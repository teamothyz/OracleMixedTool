using ChromeDriverLibrary;
using OracleMixedTool.Models;
using OracleMixedTool.Services;
using SeleniumUndetectedChromeDriver;

namespace OracleMixedTool.Forms
{
    public partial class FrmMain : Form
    {
        public static FrmMain Instance { get; private set; } = null!;

        public static bool ClickCookie { get; private set; } = false;

        private int _totalThreads = 20;
        private Queue<Account> _accounts = new();
        private List<string> _proxies = new();
        private readonly CountModel _countModel = new();
        private CancellationTokenSource _cancelToken = new();
        private CancellationTokenSource _forceCancelToken = new();

        private bool _isHeadless = true;
        private bool _privateMode = false;
        private bool _disableImg = true;
        private bool _useProxy = false;
        private bool _capture = true;

        private string _proxyPrefix = string.Empty;

        private int _proxyIndex = 0;
        private static readonly object _lockRun = new();

        private readonly int _heightCount;
        private readonly int _widthCount;
        private readonly List<string> _extensionPaths = new();
        private string _lastFileName = string.Empty;

        public FrmMain()
        {
            InitializeComponent();
            ProxyComboBox.SelectedIndex = 0;

            TotalAccountTxtBox.DataBindings.Add("Text", _countModel, "Total");
            SuccessAccountTxtBox.DataBindings.Add("Text", _countModel, "Success");
            FailedAccountTxtBox.DataBindings.Add("Text", _countModel, "Failed");
            ProcessedAccountTxtBox.DataBindings.Add("Text", _countModel, "Scanned");

            _heightCount = Screen.PrimaryScreen.Bounds.Height / 500;
            _widthCount = Screen.PrimaryScreen.Bounds.Width / 375;

            NewpassTxtBox.Text = DataHandler.ReadPasswordFromFile();
            SSHKeyTxtBox.Text = DataHandler.ReadSSHFromFile();
            ActiveControl = label1;
            Instance = this;
        }

        public void SetClipboard(string content)
        {
            Invoke(() => Clipboard.SetText(content));
        }

        private async void InputFileBtn_Click(object sender, EventArgs e)
        {
            ActiveControl = label1;
            var dialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open data file"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _accounts = await Task.Run(() => DataHandler.ReadDataFile(dialog.FileName)).ConfigureAwait(false);
                _lastFileName = Path.GetFileName(dialog.FileName);
                Invoke(() =>
                {
                    StartFromUpdown.Value = 0;
                    _countModel.Total = _accounts.Count;
                    _countModel.Success = 0;
                    _countModel.Failed = 0;
                    _countModel.Scanned = 0;
                    MessageBox.Show(this, "Đọc dữ liệu xong", "Thông báo");
                });
            }
        }

        private async void InputProxyBtn_Click(object sender, EventArgs e)
        {
            ActiveControl = label1;
            var dialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open proxy file"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _proxies = await Task.Run(() => DataHandler.ReadProxyFile(dialog.FileName));
                Invoke(() =>
                {
                    TotalProxyTxtBox.Text = _proxies.Count.ToString();
                    MessageBox.Show(this, "Đọc danh sách proxy xong", "Thông báo");
                });
            }
        }

        private async void StartBtn_Click(object sender, EventArgs e)
        {
            ActiveControl = label1;
            if (_accounts.Count == 0)
            {
                MessageBox.Show(this, "Vui lòng nhập dữ liệu", "Cảnh báo");
                return;
            }
            if (_useProxy && _proxies.Count == 0)
            {
                MessageBox.Show(this, "Vui lòng nhập proxy", "Cảnh báo");
                return;
            }
            if (string.IsNullOrWhiteSpace(NewpassTxtBox.Text) || string.IsNullOrWhiteSpace(SSHKeyTxtBox.Text))
            {
                MessageBox.Show(this, "Vui lòng nhập pass và SSH", "Cảnh báo");
                return;
            }
            EnableBtn(true);
            var needDeleted = (int)StartFromUpdown.Value;
            try
            {
                Invoke(() =>
                {
                    StatusTxtBox.StateCommon.Back.Color1 = Color.FromArgb(0, 192, 0);
                    StatusTxtBox.Text = "Đang chạy";
                    MessageBox.Show(this, "Chương trình bắt đầu", "Thông báo");
                });
                await Task.Run(() =>
                {
                    DataHandler.SaveSSHToFile(SSHKeyTxtBox.Text);
                    DataHandler.SavePasswordToFile(NewpassTxtBox.Text);
                });
                _proxyIndex = 0;
                var tasks = new List<Task>();
                _cancelToken = new();
                _forceCancelToken = new();
                var totalThread = _accounts.Count > _totalThreads ? _totalThreads : _accounts.Count;

                var forceToken = _forceCancelToken.Token;
                await Task.Run(() =>
                {
                    for (var i = 0; i < needDeleted; i++) { _ = _accounts.Dequeue(); }
                    Invoke(() => _countModel.Scanned += needDeleted);
                });

                while (_accounts.Count > 0)
                {
                    if (_cancelToken.IsCancellationRequested) break;
                    for (var i = 0; i < totalThread; i++)
                    {
                        if (_cancelToken.IsCancellationRequested) break;
                        var token = _cancelToken.Token;
                        var index = i;
                        var task = Task.Run(async () => await RunThread(index, token), forceToken);
                        tasks.Add(task);
                    }
                    await Task.WhenAll(tasks);
                    tasks.Clear();
                    ChromeDriverInstance.ForceKillAll();
                }
                await Task.WhenAll(tasks);
            }
            catch (Exception ex)
            {
                DataHandler.WriteLog("[StartBtn_Click]", ex);
            }
            finally
            {
                await Task.Run(() => DataHandler.WriteLastInfo(_countModel.Scanned, _lastFileName));
                Invoke(() =>
                {
                    StartFromUpdown.Value = 0;
                    StatusTxtBox.StateCommon.Back.Color1 = Color.FromArgb(192, 0, 0);
                    StatusTxtBox.Text = "Đã dừng";
                    MessageBox.Show(this, "Chương trình đã dừng lại", "Thông báo");
                });
                EnableBtn(false);
            }
        }

        private async Task RunThread(int index, CancellationToken token)
        {
            index %= (_widthCount * _heightCount + 1);
            var positionX = (index % _widthCount) * 375;
            var positionY = (index / _widthCount) * 500;

            var proxy = string.Empty;
            Account? account = null;
            var completed = true;
            UndetectedChromeDriver? driver = null;

            try
            {
                while (true)
                {
                    if (token.IsCancellationRequested) return;

                    lock (_lockRun)
                    {
                        if (completed)
                        {
                            if (_accounts.Count > 0)
                            {
                                account = _accounts.Dequeue();
                                if (_useProxy)
                                {
                                    if (_proxyIndex >= _proxies.Count) _proxyIndex = 0;
                                    proxy = _proxyPrefix + _proxies[_proxyIndex];
                                    _proxyIndex++;
                                }
                                completed = false;
                            }
                            else return;
                        }
                    }
                    if (account == null) return;
                    account.NewPassword = NewpassTxtBox.Text;
                    var driverInfo = await Task.Run(() => ChromeDriverInstance.GetInstance(positionX: positionX,
                        positionY: positionY, isMaximize: true,
                        proxy: proxy, isHeadless: _isHeadless, extensionPaths: _extensionPaths,
                        disableImg: _disableImg, privateMode: _privateMode, token: token), token);

                    driver = driverInfo.Item1;
                    if (driver == null)
                    {
                        DataHandler.WriteLog("[RunThread]", new Exception("can't create chrome driver"));
                        await Task.Delay(3000, token).ConfigureAwait(false);
                        continue;
                    }
                    await HandleAccount(account, driver, driverInfo.Item2, token);
                    completed = true;

                    await ChromeDriverInstance.Close(driver, driverInfo.Item2).ConfigureAwait(false);
                    return;
                }
            }
            catch (Exception ex)
            {
                DataHandler.WriteLog("[RunThread]", ex);
                if (completed == false && account != null)
                {
                    DataHandler.WriteFailedData(account, _lastFileName, "failed caused by cancel");
                    HandleFailed();
                }
            }
        }

        private async Task HandleAccount(Account account, UndetectedChromeDriver driver, string userDir, CancellationToken token)
        {
            try
            {
                var checkTenantRs = await WebDriverService.EnterTenant(driver, account, token);
                if (!checkTenantRs.Item1)
                {
                    HandleFailed();
                    DataHandler.WriteFailedData(account, _lastFileName, checkTenantRs.Item2);
                    return;
                }

                var loginRs = await WebDriverService.Login(driver, account, token);
                if (loginRs.Item2 == "pwdmustchange")
                {
                    var mustChangeRs = await WebDriverService.ChangePasswordMustChange(driver, account, token);
                    if (!mustChangeRs.Item1)
                    {
                        HandleFailed();
                        DataHandler.WriteFailedData(account, _lastFileName, mustChangeRs.Item2);
                        return;
                    }
                }
                if (loginRs.Item2 == "pwdmustchange" || ChangePassCheckBox.Checked)
                {
                    var changePassRs = await WebDriverService.ChangePassword(driver, loginRs.Item3, account, token);
                    if (!changePassRs.Item1)
                    {
                        HandleFailed();
                        DataHandler.WriteFailedData(account, _lastFileName, changePassRs.Item2);
                        return;
                    }
                }
                if (!loginRs.Item1)
                {
                    HandleFailed();
                    DataHandler.WriteFailedData(account, _lastFileName, loginRs.Item2);
                    return;
                }

                await WebDriverService.DeleteRebootAndCreate(driver, account, SSHKeyTxtBox.Text, token);
                if (_capture)
                {
                    await WebDriverService.CaptureInstance(driver, account, token);
                }
                if (account.Errors.Count == 0)
                {
                    HandleSuccess();
                    DataHandler.WriteSuccessData(account, _lastFileName);
                }
                else
                {
                    HandleFailed();
                    DataHandler.WriteFailedData(account, _lastFileName, checkTenantRs.Item2);
                }
            }
            catch (Exception ex)
            {

                DataHandler.WriteLog("[HandleAccount]", ex);
                DataHandler.WriteFailedData(account, _lastFileName, ex.Message);
            }
            finally { await ChromeDriverInstance.Close(driver, userDir); }
        }

        private void HandleSuccess()
        {
            lock (_countModel)
            {
                Invoke(() =>
                {
                    _countModel.Success++;
                    _countModel.Scanned++;
                });
            }
        }

        private void HandleFailed()
        {
            lock (_countModel)
            {
                Invoke(() =>
                {
                    _countModel.Failed++;
                    _countModel.Scanned++;
                });
            }
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            ActiveControl = label1;
            _cancelToken.Cancel();
        }

        private void ForceStopBtn_Click(object sender, EventArgs e)
        {
            ActiveControl = label1;
            _forceCancelToken.Cancel();
            StopBtn_Click(sender, e);
            ChromeDriverInstance.ForceKillAll();
        }

        private void AddExtensionBtn_Click(object sender, EventArgs e)
        {
            ActiveControl = label1;
            using var folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                _extensionPaths.Clear();
                _extensionPaths.AddRange(Directory.GetDirectories(folderBrowserDialog.SelectedPath));
                Invoke(() => ExtensionTxtBox.Text = _extensionPaths.Count.ToString());
            }
        }

        private void LoadExtensionsBtn_Click(object sender, EventArgs e)
        {
            ActiveControl = label1;
            _extensionPaths.Clear();
            var basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "extensions");
            if (Directory.Exists(basePath)) _extensionPaths.AddRange(Directory.GetDirectories(basePath));
            else Directory.CreateDirectory(basePath);
            Invoke(() => ExtensionTxtBox.Text = _extensionPaths.Count.ToString());
        }

        private void ClearExtensionsBtn_Click(object sender, EventArgs e)
        {
            ActiveControl = label1;
            _extensionPaths.Clear();
            Invoke(() => ExtensionTxtBox.Text = _extensionPaths.Count.ToString());
        }

        private void TimeoutUpdown_ValueChanged(object sender, EventArgs e)
        {
            ActiveControl = label1;
            WebDriverService.DefaultTimeout = (int)TimeoutUpdown.Value;
        }

        private void DelayChangePassUpdown_ValueChanged(object sender, EventArgs e)
        {
            ActiveControl = label1;
            WebDriverService.DefaultWaitChangePass = (int)DelayChangePassUpdown.Value;
        }

        private void DelayDeleteUpdown_ValueChanged(object sender, EventArgs e)
        {
            ActiveControl = label1;
            WebDriverService.DefaultWaitDelete = (int)DelayDeleteUpdown.Value;
        }

        private void DelayRebootUpdown_ValueChanged(object sender, EventArgs e)
        {
            ActiveControl = label1;
            WebDriverService.DefaultWaitReboot = (int)DelayRebootUpdown.Value;
        }

        private void DelayCreateUpdown_ValueChanged(object sender, EventArgs e)
        {
            ActiveControl = label1;
            WebDriverService.DefaultWaitCreateNew = (int)DelayCreateUpdown.Value;
        }

        private void TopmostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ActiveControl = label1;
            TopMost = TopmostCheckBox.Checked;
        }

        private void ThreadNumberUpdown_ValueChanged(object sender, EventArgs e)
        {
            _totalThreads = (int)ThreadNumberUpdown.Value;
        }

        private void ProxyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActiveControl = label1;
            switch (ProxyComboBox.SelectedIndex)
            {
                case 0:
                    _useProxy = false;
                    _proxyPrefix = string.Empty;
                    break;
                case 1:
                    _useProxy = true;
                    _proxyPrefix = "http://";
                    break;
                case 2:
                    _useProxy = true;
                    _proxyPrefix = "socks5://";
                    break;
                default:
                    _useProxy = false;
                    _proxyPrefix = string.Empty;
                    break;
            }
        }

        private void HeadlessCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ActiveControl = label1;
            _isHeadless = HeadlessCheckBox.Checked;
        }

        private void PrivateModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ActiveControl = label1;
            _privateMode = PrivateModeCheckBox.Checked;
        }

        private void DisableImgCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ActiveControl = label1;
            _disableImg = DisableImgCheckBox.Checked;
        }

        private void EnableBtn(bool isRun)
        {
            Invoke(() =>
            {
                InputFileBtn.Enabled = !isRun;
                InputProxyBtn.Enabled = !isRun;
                ThreadNumberUpdown.Enabled = !isRun;
                HeadlessCheckBox.Enabled = !isRun;
                PrivateModeCheckBox.Enabled = !isRun;
                DisableImgCheckBox.Enabled = !isRun;
                ProxyComboBox.Enabled = !isRun;
                StartBtn.Enabled = !isRun;
                AddExtensionBtn.Enabled = !isRun;
                LoadExtensionsBtn.Enabled = !isRun;
                ClearExtensionsBtn.Enabled = !isRun;

                TimeoutUpdown.Enabled = !isRun;
                DelayChangePassUpdown.Enabled = !isRun;
                DelayDeleteUpdown.Enabled = !isRun;
                DelayRebootUpdown.Enabled = !isRun;
                DelayCreateUpdown.Enabled = !isRun;
                StartFromUpdown.Enabled = !isRun;

                ClickCookieCheckBox.Enabled = !isRun;
                ChangePassCheckBox.Enabled = !isRun;

                NewpassTxtBox.ReadOnly = isRun;
                SSHKeyTxtBox.ReadOnly = isRun;
                StopBtn.Enabled = isRun;
            });
        }

        private void CaptureInstanceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _capture = CaptureInstanceCheckBox.Checked;
        }

        private void ClickCookieCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ClickCookie = ClickCookieCheckBox.Checked;
        }
    }
}
