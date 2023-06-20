namespace OracleMixedTool.Forms
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            TotalAccountTxtBox = new Krypton.Toolkit.KryptonTextBox();
            SuccessAccountTxtBox = new Krypton.Toolkit.KryptonTextBox();
            FailedAccountTxtBox = new Krypton.Toolkit.KryptonTextBox();
            ProcessedAccountTxtBox = new Krypton.Toolkit.KryptonTextBox();
            TotalProxyTxtBox = new Krypton.Toolkit.KryptonTextBox();
            ExtensionTxtBox = new Krypton.Toolkit.KryptonTextBox();
            StatusTxtBox = new Krypton.Toolkit.KryptonTextBox();
            TimeoutUpdown = new Krypton.Toolkit.KryptonNumericUpDown();
            DelayChangePassUpdown = new Krypton.Toolkit.KryptonNumericUpDown();
            DelayDeleteUpdown = new Krypton.Toolkit.KryptonNumericUpDown();
            DelayRebootUpdown = new Krypton.Toolkit.KryptonNumericUpDown();
            DelayCreateUpdown = new Krypton.Toolkit.KryptonNumericUpDown();
            StartFromUpdown = new Krypton.Toolkit.KryptonNumericUpDown();
            InputFileBtn = new Krypton.Toolkit.KryptonButton();
            InputProxyBtn = new Krypton.Toolkit.KryptonButton();
            LoadExtensionsBtn = new Krypton.Toolkit.KryptonButton();
            ClearExtensionsBtn = new Krypton.Toolkit.KryptonButton();
            AddExtensionBtn = new Krypton.Toolkit.KryptonButton();
            ForceStopBtn = new Krypton.Toolkit.KryptonButton();
            StopBtn = new Krypton.Toolkit.KryptonButton();
            StartBtn = new Krypton.Toolkit.KryptonButton();
            HeadlessCheckBox = new Krypton.Toolkit.KryptonCheckBox();
            TopmostCheckBox = new Krypton.Toolkit.KryptonCheckBox();
            PrivateModeCheckBox = new Krypton.Toolkit.KryptonCheckBox();
            DisableImgCheckBox = new Krypton.Toolkit.KryptonCheckBox();
            label6 = new Label();
            ThreadNumberUpdown = new Krypton.Toolkit.KryptonNumericUpDown();
            label15 = new Label();
            SSHKeyTxtBox = new Krypton.Toolkit.KryptonTextBox();
            label16 = new Label();
            NewpassTxtBox = new Krypton.Toolkit.KryptonTextBox();
            ProxyComboBox = new Krypton.Toolkit.KryptonComboBox();
            CaptureInstanceCheckBox = new Krypton.Toolkit.KryptonCheckBox();
            ((System.ComponentModel.ISupportInitialize)ProxyComboBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Tổng số tài khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 1;
            label2.Text = "Thành công:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(12, 94);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Thất bại:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(12, 135);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Đã xử lý:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(12, 176);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 4;
            label5.Text = "Số lượng Proxy:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(224, 224, 224);
            label7.Location = new Point(12, 218);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 6;
            label7.Text = "Time out:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(224, 224, 224);
            label8.Location = new Point(12, 256);
            label8.Name = "label8";
            label8.Size = new Size(111, 15);
            label8.TabIndex = 7;
            label8.Text = "Delay Change Pass:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(224, 224, 224);
            label9.Location = new Point(12, 296);
            label9.Name = "label9";
            label9.Size = new Size(105, 15);
            label9.TabIndex = 8;
            label9.Text = "Delay sau khi xóa:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(224, 224, 224);
            label10.Location = new Point(12, 335);
            label10.Name = "label10";
            label10.Size = new Size(126, 15);
            label10.TabIndex = 9;
            label10.Text = "Delay sau khi Reboot:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(224, 224, 224);
            label11.Location = new Point(12, 373);
            label11.Name = "label11";
            label11.Size = new Size(103, 15);
            label11.TabIndex = 10;
            label11.Text = "Delay sau khi tạo:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(224, 224, 224);
            label12.Location = new Point(12, 413);
            label12.Name = "label12";
            label12.Size = new Size(69, 15);
            label12.TabIndex = 11;
            label12.Text = "Bắt đầu từ:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(224, 224, 224);
            label13.Location = new Point(12, 451);
            label13.Name = "label13";
            label13.Size = new Size(64, 15);
            label13.TabIndex = 12;
            label13.Text = "Extension:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(224, 224, 224);
            label14.Location = new Point(12, 492);
            label14.Name = "label14";
            label14.Size = new Size(65, 15);
            label14.TabIndex = 13;
            label14.Text = "Trạng thái:";
            // 
            // TotalAccountTxtBox
            // 
            TotalAccountTxtBox.Location = new Point(149, 10);
            TotalAccountTxtBox.Name = "TotalAccountTxtBox";
            TotalAccountTxtBox.ReadOnly = true;
            TotalAccountTxtBox.Size = new Size(134, 23);
            TotalAccountTxtBox.StateCommon.Back.Color1 = Color.DodgerBlue;
            TotalAccountTxtBox.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TotalAccountTxtBox.TabIndex = 14;
            TotalAccountTxtBox.Text = "0";
            TotalAccountTxtBox.TextAlign = HorizontalAlignment.Center;
            // 
            // SuccessAccountTxtBox
            // 
            SuccessAccountTxtBox.Location = new Point(149, 48);
            SuccessAccountTxtBox.Name = "SuccessAccountTxtBox";
            SuccessAccountTxtBox.ReadOnly = true;
            SuccessAccountTxtBox.Size = new Size(134, 23);
            SuccessAccountTxtBox.StateCommon.Back.Color1 = Color.Green;
            SuccessAccountTxtBox.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SuccessAccountTxtBox.TabIndex = 15;
            SuccessAccountTxtBox.Text = "0";
            SuccessAccountTxtBox.TextAlign = HorizontalAlignment.Center;
            // 
            // FailedAccountTxtBox
            // 
            FailedAccountTxtBox.Location = new Point(149, 86);
            FailedAccountTxtBox.Name = "FailedAccountTxtBox";
            FailedAccountTxtBox.ReadOnly = true;
            FailedAccountTxtBox.Size = new Size(134, 23);
            FailedAccountTxtBox.StateCommon.Back.Color1 = Color.Maroon;
            FailedAccountTxtBox.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FailedAccountTxtBox.TabIndex = 16;
            FailedAccountTxtBox.Text = "0";
            FailedAccountTxtBox.TextAlign = HorizontalAlignment.Center;
            // 
            // ProcessedAccountTxtBox
            // 
            ProcessedAccountTxtBox.Location = new Point(149, 127);
            ProcessedAccountTxtBox.Name = "ProcessedAccountTxtBox";
            ProcessedAccountTxtBox.ReadOnly = true;
            ProcessedAccountTxtBox.Size = new Size(134, 23);
            ProcessedAccountTxtBox.StateCommon.Back.Color1 = Color.DodgerBlue;
            ProcessedAccountTxtBox.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ProcessedAccountTxtBox.TabIndex = 17;
            ProcessedAccountTxtBox.Text = "0";
            ProcessedAccountTxtBox.TextAlign = HorizontalAlignment.Center;
            // 
            // TotalProxyTxtBox
            // 
            TotalProxyTxtBox.Location = new Point(149, 168);
            TotalProxyTxtBox.Name = "TotalProxyTxtBox";
            TotalProxyTxtBox.ReadOnly = true;
            TotalProxyTxtBox.Size = new Size(134, 23);
            TotalProxyTxtBox.StateCommon.Back.Color1 = Color.DodgerBlue;
            TotalProxyTxtBox.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TotalProxyTxtBox.TabIndex = 18;
            TotalProxyTxtBox.Text = "0";
            TotalProxyTxtBox.TextAlign = HorizontalAlignment.Center;
            // 
            // ExtensionTxtBox
            // 
            ExtensionTxtBox.Location = new Point(149, 443);
            ExtensionTxtBox.Name = "ExtensionTxtBox";
            ExtensionTxtBox.ReadOnly = true;
            ExtensionTxtBox.Size = new Size(134, 23);
            ExtensionTxtBox.StateCommon.Back.Color1 = Color.DodgerBlue;
            ExtensionTxtBox.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ExtensionTxtBox.TabIndex = 19;
            ExtensionTxtBox.Text = "0";
            ExtensionTxtBox.TextAlign = HorizontalAlignment.Center;
            // 
            // StatusTxtBox
            // 
            StatusTxtBox.Location = new Point(149, 484);
            StatusTxtBox.Name = "StatusTxtBox";
            StatusTxtBox.ReadOnly = true;
            StatusTxtBox.Size = new Size(134, 23);
            StatusTxtBox.StateCommon.Back.Color1 = Color.FromArgb(0, 192, 192);
            StatusTxtBox.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            StatusTxtBox.TabIndex = 20;
            StatusTxtBox.Text = "Chưa bắt đầu";
            StatusTxtBox.TextAlign = HorizontalAlignment.Center;
            // 
            // TimeoutUpdown
            // 
            TimeoutUpdown.Location = new Point(149, 211);
            TimeoutUpdown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            TimeoutUpdown.Name = "TimeoutUpdown";
            TimeoutUpdown.Size = new Size(134, 22);
            TimeoutUpdown.StateCommon.Back.Color1 = Color.FromArgb(255, 128, 0);
            TimeoutUpdown.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TimeoutUpdown.TabIndex = 21;
            TimeoutUpdown.Value = new decimal(new int[] { 30, 0, 0, 0 });
            TimeoutUpdown.ValueChanged += TimeoutUpdown_ValueChanged;
            // 
            // DelayChangePassUpdown
            // 
            DelayChangePassUpdown.Location = new Point(149, 249);
            DelayChangePassUpdown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            DelayChangePassUpdown.Name = "DelayChangePassUpdown";
            DelayChangePassUpdown.Size = new Size(134, 22);
            DelayChangePassUpdown.StateCommon.Back.Color1 = Color.FromArgb(255, 128, 0);
            DelayChangePassUpdown.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DelayChangePassUpdown.TabIndex = 22;
            DelayChangePassUpdown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            DelayChangePassUpdown.ValueChanged += DelayChangePassUpdown_ValueChanged;
            // 
            // DelayDeleteUpdown
            // 
            DelayDeleteUpdown.Location = new Point(149, 289);
            DelayDeleteUpdown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            DelayDeleteUpdown.Name = "DelayDeleteUpdown";
            DelayDeleteUpdown.Size = new Size(134, 22);
            DelayDeleteUpdown.StateCommon.Back.Color1 = Color.FromArgb(255, 128, 0);
            DelayDeleteUpdown.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DelayDeleteUpdown.TabIndex = 23;
            DelayDeleteUpdown.Value = new decimal(new int[] { 60, 0, 0, 0 });
            DelayDeleteUpdown.ValueChanged += DelayDeleteUpdown_ValueChanged;
            // 
            // DelayRebootUpdown
            // 
            DelayRebootUpdown.Location = new Point(149, 328);
            DelayRebootUpdown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            DelayRebootUpdown.Name = "DelayRebootUpdown";
            DelayRebootUpdown.Size = new Size(134, 22);
            DelayRebootUpdown.StateCommon.Back.Color1 = Color.FromArgb(255, 128, 0);
            DelayRebootUpdown.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DelayRebootUpdown.TabIndex = 24;
            DelayRebootUpdown.Value = new decimal(new int[] { 60, 0, 0, 0 });
            DelayRebootUpdown.ValueChanged += DelayRebootUpdown_ValueChanged;
            // 
            // DelayCreateUpdown
            // 
            DelayCreateUpdown.Location = new Point(149, 366);
            DelayCreateUpdown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            DelayCreateUpdown.Name = "DelayCreateUpdown";
            DelayCreateUpdown.Size = new Size(134, 22);
            DelayCreateUpdown.StateCommon.Back.Color1 = Color.FromArgb(255, 128, 0);
            DelayCreateUpdown.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DelayCreateUpdown.TabIndex = 25;
            DelayCreateUpdown.Value = new decimal(new int[] { 60, 0, 0, 0 });
            DelayCreateUpdown.ValueChanged += DelayCreateUpdown_ValueChanged;
            // 
            // StartFromUpdown
            // 
            StartFromUpdown.Location = new Point(149, 406);
            StartFromUpdown.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            StartFromUpdown.Name = "StartFromUpdown";
            StartFromUpdown.Size = new Size(134, 22);
            StartFromUpdown.StateCommon.Back.Color1 = Color.FromArgb(255, 128, 0);
            StartFromUpdown.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            StartFromUpdown.TabIndex = 26;
            // 
            // InputFileBtn
            // 
            InputFileBtn.CornerRoundingRadius = -1F;
            InputFileBtn.Location = new Point(308, 8);
            InputFileBtn.Name = "InputFileBtn";
            InputFileBtn.Size = new Size(122, 25);
            InputFileBtn.StateCommon.Back.Color1 = Color.FromArgb(0, 0, 64);
            InputFileBtn.StateCommon.Back.Color2 = Color.FromArgb(0, 0, 64);
            InputFileBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            InputFileBtn.StateCommon.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            InputFileBtn.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            InputFileBtn.TabIndex = 27;
            InputFileBtn.Values.Text = "File dữ liệu";
            InputFileBtn.Click += InputFileBtn_Click;
            // 
            // InputProxyBtn
            // 
            InputProxyBtn.CornerRoundingRadius = -1F;
            InputProxyBtn.Location = new Point(308, 46);
            InputProxyBtn.Name = "InputProxyBtn";
            InputProxyBtn.Size = new Size(122, 25);
            InputProxyBtn.StateCommon.Back.Color1 = Color.FromArgb(0, 0, 64);
            InputProxyBtn.StateCommon.Back.Color2 = Color.FromArgb(0, 0, 64);
            InputProxyBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            InputProxyBtn.StateCommon.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            InputProxyBtn.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            InputProxyBtn.TabIndex = 28;
            InputProxyBtn.Values.Text = "File Proxy";
            InputProxyBtn.Click += InputProxyBtn_Click;
            // 
            // LoadExtensionsBtn
            // 
            LoadExtensionsBtn.CornerRoundingRadius = -1F;
            LoadExtensionsBtn.Location = new Point(308, 482);
            LoadExtensionsBtn.Name = "LoadExtensionsBtn";
            LoadExtensionsBtn.Size = new Size(122, 25);
            LoadExtensionsBtn.StateCommon.Back.Color1 = Color.FromArgb(0, 0, 64);
            LoadExtensionsBtn.StateCommon.Back.Color2 = Color.FromArgb(0, 0, 64);
            LoadExtensionsBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            LoadExtensionsBtn.StateCommon.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            LoadExtensionsBtn.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LoadExtensionsBtn.TabIndex = 29;
            LoadExtensionsBtn.Values.Text = "Load Extensions";
            LoadExtensionsBtn.Click += LoadExtensionsBtn_Click;
            // 
            // ClearExtensionsBtn
            // 
            ClearExtensionsBtn.CornerRoundingRadius = -1F;
            ClearExtensionsBtn.Location = new Point(308, 519);
            ClearExtensionsBtn.Name = "ClearExtensionsBtn";
            ClearExtensionsBtn.Size = new Size(122, 25);
            ClearExtensionsBtn.StateCommon.Back.Color1 = Color.FromArgb(80, 64, 0);
            ClearExtensionsBtn.StateCommon.Back.Color2 = Color.FromArgb(80, 64, 0);
            ClearExtensionsBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            ClearExtensionsBtn.StateCommon.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            ClearExtensionsBtn.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ClearExtensionsBtn.TabIndex = 30;
            ClearExtensionsBtn.Values.Text = "Clear Extension";
            ClearExtensionsBtn.Click += ClearExtensionsBtn_Click;
            // 
            // AddExtensionBtn
            // 
            AddExtensionBtn.CornerRoundingRadius = -1F;
            AddExtensionBtn.Location = new Point(308, 441);
            AddExtensionBtn.Name = "AddExtensionBtn";
            AddExtensionBtn.Size = new Size(122, 25);
            AddExtensionBtn.StateCommon.Back.Color1 = Color.FromArgb(0, 0, 64);
            AddExtensionBtn.StateCommon.Back.Color2 = Color.FromArgb(0, 0, 64);
            AddExtensionBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            AddExtensionBtn.StateCommon.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            AddExtensionBtn.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddExtensionBtn.TabIndex = 31;
            AddExtensionBtn.Values.Text = "Thêm Extension";
            AddExtensionBtn.Click += AddExtensionBtn_Click;
            // 
            // ForceStopBtn
            // 
            ForceStopBtn.CornerRoundingRadius = -1F;
            ForceStopBtn.Location = new Point(308, 403);
            ForceStopBtn.Name = "ForceStopBtn";
            ForceStopBtn.Size = new Size(122, 25);
            ForceStopBtn.StateCommon.Back.Color1 = Color.FromArgb(64, 0, 0);
            ForceStopBtn.StateCommon.Back.Color2 = Color.FromArgb(64, 0, 0);
            ForceStopBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            ForceStopBtn.StateCommon.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            ForceStopBtn.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForceStopBtn.TabIndex = 32;
            ForceStopBtn.Values.Text = "Dừng ngay";
            ForceStopBtn.Click += ForceStopBtn_Click;
            // 
            // StopBtn
            // 
            StopBtn.CornerRoundingRadius = -1F;
            StopBtn.Enabled = false;
            StopBtn.Location = new Point(308, 363);
            StopBtn.Name = "StopBtn";
            StopBtn.Size = new Size(122, 25);
            StopBtn.StateCommon.Back.Color1 = Color.FromArgb(150, 50, 0);
            StopBtn.StateCommon.Back.Color2 = Color.FromArgb(150, 50, 0);
            StopBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            StopBtn.StateCommon.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            StopBtn.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            StopBtn.TabIndex = 33;
            StopBtn.Values.Text = "Dừng lại";
            StopBtn.Click += StopBtn_Click;
            // 
            // StartBtn
            // 
            StartBtn.CornerRoundingRadius = -1F;
            StartBtn.Location = new Point(308, 325);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(122, 25);
            StartBtn.StateCommon.Back.Color1 = Color.FromArgb(0, 64, 0);
            StartBtn.StateCommon.Back.Color2 = Color.FromArgb(0, 64, 0);
            StartBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            StartBtn.StateCommon.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            StartBtn.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            StartBtn.TabIndex = 34;
            StartBtn.Values.Text = "Bắt đầu";
            StartBtn.Click += StartBtn_Click;
            // 
            // HeadlessCheckBox
            // 
            HeadlessCheckBox.Checked = true;
            HeadlessCheckBox.CheckState = CheckState.Checked;
            HeadlessCheckBox.Location = new Point(309, 115);
            HeadlessCheckBox.Name = "HeadlessCheckBox";
            HeadlessCheckBox.Size = new Size(89, 20);
            HeadlessCheckBox.StateCommon.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            HeadlessCheckBox.StateCommon.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            HeadlessCheckBox.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            HeadlessCheckBox.TabIndex = 35;
            HeadlessCheckBox.Values.Text = "Ẩn Chrome";
            HeadlessCheckBox.CheckedChanged += HeadlessCheckBox_CheckedChanged;
            // 
            // TopmostCheckBox
            // 
            TopmostCheckBox.Checked = true;
            TopmostCheckBox.CheckState = CheckState.Checked;
            TopmostCheckBox.Location = new Point(309, 150);
            TopmostCheckBox.Name = "TopmostCheckBox";
            TopmostCheckBox.Size = new Size(79, 20);
            TopmostCheckBox.StateCommon.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            TopmostCheckBox.StateCommon.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            TopmostCheckBox.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TopmostCheckBox.TabIndex = 36;
            TopmostCheckBox.Values.Text = "Top Most";
            TopmostCheckBox.CheckedChanged += TopmostCheckBox_CheckedChanged;
            // 
            // PrivateModeCheckBox
            // 
            PrivateModeCheckBox.Location = new Point(309, 183);
            PrivateModeCheckBox.Name = "PrivateModeCheckBox";
            PrivateModeCheckBox.Size = new Size(72, 20);
            PrivateModeCheckBox.StateCommon.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            PrivateModeCheckBox.StateCommon.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            PrivateModeCheckBox.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PrivateModeCheckBox.TabIndex = 37;
            PrivateModeCheckBox.Values.Text = "Ẩn danh";
            PrivateModeCheckBox.CheckedChanged += PrivateModeCheckBox_CheckedChanged;
            // 
            // DisableImgCheckBox
            // 
            DisableImgCheckBox.Checked = true;
            DisableImgCheckBox.CheckState = CheckState.Checked;
            DisableImgCheckBox.Location = new Point(308, 217);
            DisableImgCheckBox.Name = "DisableImgCheckBox";
            DisableImgCheckBox.Size = new Size(106, 20);
            DisableImgCheckBox.StateCommon.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            DisableImgCheckBox.StateCommon.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            DisableImgCheckBox.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DisableImgCheckBox.TabIndex = 38;
            DisableImgCheckBox.Values.Text = "Disable Image";
            DisableImgCheckBox.CheckedChanged += DisableImgCheckBox_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(308, 86);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 39;
            label6.Text = "Luồng:";
            // 
            // ThreadNumberUpdown
            // 
            ThreadNumberUpdown.Location = new Point(358, 79);
            ThreadNumberUpdown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            ThreadNumberUpdown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ThreadNumberUpdown.Name = "ThreadNumberUpdown";
            ThreadNumberUpdown.Size = new Size(72, 22);
            ThreadNumberUpdown.StateCommon.Back.Color1 = Color.FromArgb(255, 128, 0);
            ThreadNumberUpdown.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ThreadNumberUpdown.TabIndex = 40;
            ThreadNumberUpdown.Value = new decimal(new int[] { 20, 0, 0, 0 });
            ThreadNumberUpdown.ValueChanged += ThreadNumberUpdown_ValueChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(224, 224, 224);
            label15.Location = new Point(12, 566);
            label15.Name = "label15";
            label15.Size = new Size(33, 15);
            label15.TabIndex = 41;
            label15.Text = "SSH:";
            // 
            // SSHKeyTxtBox
            // 
            SSHKeyTxtBox.Location = new Point(83, 558);
            SSHKeyTxtBox.Name = "SSHKeyTxtBox";
            SSHKeyTxtBox.Size = new Size(347, 23);
            SSHKeyTxtBox.StateCommon.Back.Color1 = Color.Yellow;
            SSHKeyTxtBox.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SSHKeyTxtBox.TabIndex = 42;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(224, 224, 224);
            label16.Location = new Point(12, 529);
            label16.Name = "label16";
            label16.Size = new Size(62, 15);
            label16.TabIndex = 43;
            label16.Text = "New pass:";
            // 
            // NewpassTxtBox
            // 
            NewpassTxtBox.Location = new Point(149, 521);
            NewpassTxtBox.Name = "NewpassTxtBox";
            NewpassTxtBox.Size = new Size(134, 23);
            NewpassTxtBox.StateCommon.Back.Color1 = Color.Yellow;
            NewpassTxtBox.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NewpassTxtBox.TabIndex = 44;
            // 
            // ProxyComboBox
            // 
            ProxyComboBox.CornerRoundingRadius = -1F;
            ProxyComboBox.DropDownWidth = 121;
            ProxyComboBox.IntegralHeight = false;
            ProxyComboBox.Items.AddRange(new object[] { "Proxyless", "HTTP", "Socks5" });
            ProxyComboBox.Location = new Point(309, 290);
            ProxyComboBox.Name = "ProxyComboBox";
            ProxyComboBox.RightToLeft = RightToLeft.No;
            ProxyComboBox.Size = new Size(121, 21);
            ProxyComboBox.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(192, 64, 0);
            ProxyComboBox.StateCommon.ComboBox.Content.Color1 = Color.Black;
            ProxyComboBox.StateCommon.ComboBox.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ProxyComboBox.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            ProxyComboBox.StateCommon.Item.Back.Color1 = Color.FromArgb(192, 64, 0);
            ProxyComboBox.StateCommon.Item.Back.Color2 = Color.FromArgb(192, 64, 0);
            ProxyComboBox.StateCommon.Item.Content.ShortText.Color1 = Color.Black;
            ProxyComboBox.StateCommon.Item.Content.ShortText.Color2 = Color.Black;
            ProxyComboBox.StateCommon.Item.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ProxyComboBox.TabIndex = 45;
            ProxyComboBox.Text = "Proxy Type";
            ProxyComboBox.SelectedIndexChanged += ProxyComboBox_SelectedIndexChanged;
            // 
            // CaptureInstanceCheckBox
            // 
            CaptureInstanceCheckBox.Checked = true;
            CaptureInstanceCheckBox.CheckState = CheckState.Checked;
            CaptureInstanceCheckBox.Location = new Point(308, 251);
            CaptureInstanceCheckBox.Name = "CaptureInstanceCheckBox";
            CaptureInstanceCheckBox.Size = new Size(127, 20);
            CaptureInstanceCheckBox.StateCommon.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            CaptureInstanceCheckBox.StateCommon.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            CaptureInstanceCheckBox.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CaptureInstanceCheckBox.TabIndex = 46;
            CaptureInstanceCheckBox.Values.Text = "Capture Instances";
            CaptureInstanceCheckBox.CheckedChanged += CaptureInstanceCheckBox_CheckedChanged;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(452, 593);
            Controls.Add(CaptureInstanceCheckBox);
            Controls.Add(ProxyComboBox);
            Controls.Add(NewpassTxtBox);
            Controls.Add(label16);
            Controls.Add(SSHKeyTxtBox);
            Controls.Add(label15);
            Controls.Add(ThreadNumberUpdown);
            Controls.Add(label6);
            Controls.Add(DisableImgCheckBox);
            Controls.Add(PrivateModeCheckBox);
            Controls.Add(TopmostCheckBox);
            Controls.Add(HeadlessCheckBox);
            Controls.Add(StartBtn);
            Controls.Add(StopBtn);
            Controls.Add(ForceStopBtn);
            Controls.Add(AddExtensionBtn);
            Controls.Add(ClearExtensionsBtn);
            Controls.Add(LoadExtensionsBtn);
            Controls.Add(InputProxyBtn);
            Controls.Add(InputFileBtn);
            Controls.Add(StartFromUpdown);
            Controls.Add(DelayCreateUpdown);
            Controls.Add(DelayRebootUpdown);
            Controls.Add(DelayDeleteUpdown);
            Controls.Add(DelayChangePassUpdown);
            Controls.Add(TimeoutUpdown);
            Controls.Add(StatusTxtBox);
            Controls.Add(ExtensionTxtBox);
            Controls.Add(TotalProxyTxtBox);
            Controls.Add(ProcessedAccountTxtBox);
            Controls.Add(FailedAccountTxtBox);
            Controls.Add(SuccessAccountTxtBox);
            Controls.Add(TotalAccountTxtBox);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(468, 632);
            MinimumSize = new Size(468, 632);
            Name = "FrmMain";
            Text = "Oracel Mixed Tool - Telegram: @lukaxsx";
            ((System.ComponentModel.ISupportInitialize)ProxyComboBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Krypton.Toolkit.KryptonTextBox TotalAccountTxtBox;
        private Krypton.Toolkit.KryptonTextBox SuccessAccountTxtBox;
        private Krypton.Toolkit.KryptonTextBox FailedAccountTxtBox;
        private Krypton.Toolkit.KryptonTextBox ProcessedAccountTxtBox;
        private Krypton.Toolkit.KryptonTextBox TotalProxyTxtBox;
        private Krypton.Toolkit.KryptonTextBox ExtensionTxtBox;
        private Krypton.Toolkit.KryptonTextBox StatusTxtBox;
        private Krypton.Toolkit.KryptonNumericUpDown TimeoutUpdown;
        private Krypton.Toolkit.KryptonNumericUpDown DelayChangePassUpdown;
        private Krypton.Toolkit.KryptonNumericUpDown DelayDeleteUpdown;
        private Krypton.Toolkit.KryptonNumericUpDown DelayRebootUpdown;
        private Krypton.Toolkit.KryptonNumericUpDown DelayCreateUpdown;
        private Krypton.Toolkit.KryptonNumericUpDown StartFromUpdown;
        private Krypton.Toolkit.KryptonButton InputFileBtn;
        private Krypton.Toolkit.KryptonButton InputProxyBtn;
        private Krypton.Toolkit.KryptonButton LoadExtensionsBtn;
        private Krypton.Toolkit.KryptonButton ClearExtensionsBtn;
        private Krypton.Toolkit.KryptonButton AddExtensionBtn;
        private Krypton.Toolkit.KryptonButton ForceStopBtn;
        private Krypton.Toolkit.KryptonButton StopBtn;
        private Krypton.Toolkit.KryptonButton StartBtn;
        private Krypton.Toolkit.KryptonCheckBox HeadlessCheckBox;
        private Krypton.Toolkit.KryptonCheckBox TopmostCheckBox;
        private Krypton.Toolkit.KryptonCheckBox PrivateModeCheckBox;
        private Krypton.Toolkit.KryptonCheckBox DisableImgCheckBox;
        private Label label6;
        private Krypton.Toolkit.KryptonNumericUpDown ThreadNumberUpdown;
        private Label label15;
        private Krypton.Toolkit.KryptonTextBox SSHKeyTxtBox;
        private Label label16;
        private Krypton.Toolkit.KryptonTextBox NewpassTxtBox;
        private Krypton.Toolkit.KryptonComboBox ProxyComboBox;
        private Krypton.Toolkit.KryptonCheckBox CaptureInstanceCheckBox;
    }
}