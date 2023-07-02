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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TotalAccountTxtBox = new Krypton.Toolkit.KryptonTextBox();
            this.SuccessAccountTxtBox = new Krypton.Toolkit.KryptonTextBox();
            this.FailedAccountTxtBox = new Krypton.Toolkit.KryptonTextBox();
            this.ProcessedAccountTxtBox = new Krypton.Toolkit.KryptonTextBox();
            this.TotalProxyTxtBox = new Krypton.Toolkit.KryptonTextBox();
            this.ExtensionTxtBox = new Krypton.Toolkit.KryptonTextBox();
            this.StatusTxtBox = new Krypton.Toolkit.KryptonTextBox();
            this.TimeoutUpdown = new Krypton.Toolkit.KryptonNumericUpDown();
            this.DelayChangePassUpdown = new Krypton.Toolkit.KryptonNumericUpDown();
            this.DelayDeleteUpdown = new Krypton.Toolkit.KryptonNumericUpDown();
            this.DelayRebootUpdown = new Krypton.Toolkit.KryptonNumericUpDown();
            this.DelayCreateUpdown = new Krypton.Toolkit.KryptonNumericUpDown();
            this.StartFromUpdown = new Krypton.Toolkit.KryptonNumericUpDown();
            this.InputFileBtn = new Krypton.Toolkit.KryptonButton();
            this.InputProxyBtn = new Krypton.Toolkit.KryptonButton();
            this.LoadExtensionsBtn = new Krypton.Toolkit.KryptonButton();
            this.ClearExtensionsBtn = new Krypton.Toolkit.KryptonButton();
            this.AddExtensionBtn = new Krypton.Toolkit.KryptonButton();
            this.ForceStopBtn = new Krypton.Toolkit.KryptonButton();
            this.StopBtn = new Krypton.Toolkit.KryptonButton();
            this.StartBtn = new Krypton.Toolkit.KryptonButton();
            this.HeadlessCheckBox = new Krypton.Toolkit.KryptonCheckBox();
            this.TopmostCheckBox = new Krypton.Toolkit.KryptonCheckBox();
            this.PrivateModeCheckBox = new Krypton.Toolkit.KryptonCheckBox();
            this.DisableImgCheckBox = new Krypton.Toolkit.KryptonCheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ThreadNumberUpdown = new Krypton.Toolkit.KryptonNumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.SSHKeyTxtBox = new Krypton.Toolkit.KryptonTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.NewpassTxtBox = new Krypton.Toolkit.KryptonTextBox();
            this.ProxyComboBox = new Krypton.Toolkit.KryptonComboBox();
            this.CaptureInstanceCheckBox = new Krypton.Toolkit.KryptonCheckBox();
            this.ClickCookieCheckBox = new Krypton.Toolkit.KryptonCheckBox();
            this.ChangePassCheckBox = new Krypton.Toolkit.KryptonCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProxyComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng số tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thành công:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thất bại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đã xử lý:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(12, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng Proxy:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(12, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Time out:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(12, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Delay Change Pass:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(12, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Delay sau khi xóa:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(12, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Delay sau khi Reboot:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Location = new System.Drawing.Point(12, 373);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Delay sau khi tạo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label12.Location = new System.Drawing.Point(12, 413);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "Bắt đầu từ:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label13.Location = new System.Drawing.Point(12, 451);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 15);
            this.label13.TabIndex = 12;
            this.label13.Text = "Extension:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label14.Location = new System.Drawing.Point(12, 492);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 15);
            this.label14.TabIndex = 13;
            this.label14.Text = "Trạng thái:";
            // 
            // TotalAccountTxtBox
            // 
            this.TotalAccountTxtBox.Location = new System.Drawing.Point(149, 10);
            this.TotalAccountTxtBox.Name = "TotalAccountTxtBox";
            this.TotalAccountTxtBox.ReadOnly = true;
            this.TotalAccountTxtBox.Size = new System.Drawing.Size(134, 23);
            this.TotalAccountTxtBox.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.TotalAccountTxtBox.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalAccountTxtBox.TabIndex = 14;
            this.TotalAccountTxtBox.Text = "0";
            this.TotalAccountTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SuccessAccountTxtBox
            // 
            this.SuccessAccountTxtBox.Location = new System.Drawing.Point(149, 48);
            this.SuccessAccountTxtBox.Name = "SuccessAccountTxtBox";
            this.SuccessAccountTxtBox.ReadOnly = true;
            this.SuccessAccountTxtBox.Size = new System.Drawing.Size(134, 23);
            this.SuccessAccountTxtBox.StateCommon.Back.Color1 = System.Drawing.Color.Green;
            this.SuccessAccountTxtBox.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SuccessAccountTxtBox.TabIndex = 15;
            this.SuccessAccountTxtBox.Text = "0";
            this.SuccessAccountTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FailedAccountTxtBox
            // 
            this.FailedAccountTxtBox.Location = new System.Drawing.Point(149, 86);
            this.FailedAccountTxtBox.Name = "FailedAccountTxtBox";
            this.FailedAccountTxtBox.ReadOnly = true;
            this.FailedAccountTxtBox.Size = new System.Drawing.Size(134, 23);
            this.FailedAccountTxtBox.StateCommon.Back.Color1 = System.Drawing.Color.Maroon;
            this.FailedAccountTxtBox.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FailedAccountTxtBox.TabIndex = 16;
            this.FailedAccountTxtBox.Text = "0";
            this.FailedAccountTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProcessedAccountTxtBox
            // 
            this.ProcessedAccountTxtBox.Location = new System.Drawing.Point(149, 127);
            this.ProcessedAccountTxtBox.Name = "ProcessedAccountTxtBox";
            this.ProcessedAccountTxtBox.ReadOnly = true;
            this.ProcessedAccountTxtBox.Size = new System.Drawing.Size(134, 23);
            this.ProcessedAccountTxtBox.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.ProcessedAccountTxtBox.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProcessedAccountTxtBox.TabIndex = 17;
            this.ProcessedAccountTxtBox.Text = "0";
            this.ProcessedAccountTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalProxyTxtBox
            // 
            this.TotalProxyTxtBox.Location = new System.Drawing.Point(149, 168);
            this.TotalProxyTxtBox.Name = "TotalProxyTxtBox";
            this.TotalProxyTxtBox.ReadOnly = true;
            this.TotalProxyTxtBox.Size = new System.Drawing.Size(134, 23);
            this.TotalProxyTxtBox.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.TotalProxyTxtBox.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalProxyTxtBox.TabIndex = 18;
            this.TotalProxyTxtBox.Text = "0";
            this.TotalProxyTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExtensionTxtBox
            // 
            this.ExtensionTxtBox.Location = new System.Drawing.Point(149, 443);
            this.ExtensionTxtBox.Name = "ExtensionTxtBox";
            this.ExtensionTxtBox.ReadOnly = true;
            this.ExtensionTxtBox.Size = new System.Drawing.Size(134, 23);
            this.ExtensionTxtBox.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.ExtensionTxtBox.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExtensionTxtBox.TabIndex = 19;
            this.ExtensionTxtBox.Text = "0";
            this.ExtensionTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StatusTxtBox
            // 
            this.StatusTxtBox.Location = new System.Drawing.Point(149, 484);
            this.StatusTxtBox.Name = "StatusTxtBox";
            this.StatusTxtBox.ReadOnly = true;
            this.StatusTxtBox.Size = new System.Drawing.Size(134, 23);
            this.StatusTxtBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.StatusTxtBox.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StatusTxtBox.TabIndex = 20;
            this.StatusTxtBox.Text = "Chưa bắt đầu";
            this.StatusTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimeoutUpdown
            // 
            this.TimeoutUpdown.Location = new System.Drawing.Point(149, 211);
            this.TimeoutUpdown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TimeoutUpdown.Name = "TimeoutUpdown";
            this.TimeoutUpdown.Size = new System.Drawing.Size(134, 22);
            this.TimeoutUpdown.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TimeoutUpdown.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimeoutUpdown.TabIndex = 21;
            this.TimeoutUpdown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // DelayChangePassUpdown
            // 
            this.DelayChangePassUpdown.Location = new System.Drawing.Point(149, 249);
            this.DelayChangePassUpdown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DelayChangePassUpdown.Name = "DelayChangePassUpdown";
            this.DelayChangePassUpdown.Size = new System.Drawing.Size(134, 22);
            this.DelayChangePassUpdown.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DelayChangePassUpdown.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DelayChangePassUpdown.TabIndex = 22;
            this.DelayChangePassUpdown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // DelayDeleteUpdown
            // 
            this.DelayDeleteUpdown.Location = new System.Drawing.Point(149, 289);
            this.DelayDeleteUpdown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DelayDeleteUpdown.Name = "DelayDeleteUpdown";
            this.DelayDeleteUpdown.Size = new System.Drawing.Size(134, 22);
            this.DelayDeleteUpdown.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DelayDeleteUpdown.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DelayDeleteUpdown.TabIndex = 23;
            this.DelayDeleteUpdown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // DelayRebootUpdown
            // 
            this.DelayRebootUpdown.Location = new System.Drawing.Point(149, 328);
            this.DelayRebootUpdown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DelayRebootUpdown.Name = "DelayRebootUpdown";
            this.DelayRebootUpdown.Size = new System.Drawing.Size(134, 22);
            this.DelayRebootUpdown.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DelayRebootUpdown.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DelayRebootUpdown.TabIndex = 24;
            this.DelayRebootUpdown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // DelayCreateUpdown
            // 
            this.DelayCreateUpdown.Location = new System.Drawing.Point(149, 366);
            this.DelayCreateUpdown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DelayCreateUpdown.Name = "DelayCreateUpdown";
            this.DelayCreateUpdown.Size = new System.Drawing.Size(134, 22);
            this.DelayCreateUpdown.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DelayCreateUpdown.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DelayCreateUpdown.TabIndex = 25;
            this.DelayCreateUpdown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // StartFromUpdown
            // 
            this.StartFromUpdown.Location = new System.Drawing.Point(149, 406);
            this.StartFromUpdown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.StartFromUpdown.Name = "StartFromUpdown";
            this.StartFromUpdown.Size = new System.Drawing.Size(134, 22);
            this.StartFromUpdown.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.StartFromUpdown.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartFromUpdown.TabIndex = 26;
            // 
            // InputFileBtn
            // 
            this.InputFileBtn.CornerRoundingRadius = -1F;
            this.InputFileBtn.Location = new System.Drawing.Point(308, 8);
            this.InputFileBtn.Name = "InputFileBtn";
            this.InputFileBtn.Size = new System.Drawing.Size(122, 25);
            this.InputFileBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.InputFileBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.InputFileBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.InputFileBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.InputFileBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InputFileBtn.TabIndex = 27;
            this.InputFileBtn.Values.Text = "File dữ liệu";
            // 
            // InputProxyBtn
            // 
            this.InputProxyBtn.CornerRoundingRadius = -1F;
            this.InputProxyBtn.Location = new System.Drawing.Point(308, 46);
            this.InputProxyBtn.Name = "InputProxyBtn";
            this.InputProxyBtn.Size = new System.Drawing.Size(122, 25);
            this.InputProxyBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.InputProxyBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.InputProxyBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.InputProxyBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.InputProxyBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InputProxyBtn.TabIndex = 28;
            this.InputProxyBtn.Values.Text = "File Proxy";
            // 
            // LoadExtensionsBtn
            // 
            this.LoadExtensionsBtn.CornerRoundingRadius = -1F;
            this.LoadExtensionsBtn.Location = new System.Drawing.Point(308, 482);
            this.LoadExtensionsBtn.Name = "LoadExtensionsBtn";
            this.LoadExtensionsBtn.Size = new System.Drawing.Size(122, 25);
            this.LoadExtensionsBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LoadExtensionsBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LoadExtensionsBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LoadExtensionsBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LoadExtensionsBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoadExtensionsBtn.TabIndex = 29;
            this.LoadExtensionsBtn.Values.Text = "Load Extensions";
            // 
            // ClearExtensionsBtn
            // 
            this.ClearExtensionsBtn.CornerRoundingRadius = -1F;
            this.ClearExtensionsBtn.Location = new System.Drawing.Point(308, 519);
            this.ClearExtensionsBtn.Name = "ClearExtensionsBtn";
            this.ClearExtensionsBtn.Size = new System.Drawing.Size(122, 25);
            this.ClearExtensionsBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClearExtensionsBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClearExtensionsBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClearExtensionsBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClearExtensionsBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearExtensionsBtn.TabIndex = 30;
            this.ClearExtensionsBtn.Values.Text = "Clear Extension";
            // 
            // AddExtensionBtn
            // 
            this.AddExtensionBtn.CornerRoundingRadius = -1F;
            this.AddExtensionBtn.Location = new System.Drawing.Point(308, 441);
            this.AddExtensionBtn.Name = "AddExtensionBtn";
            this.AddExtensionBtn.Size = new System.Drawing.Size(122, 25);
            this.AddExtensionBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AddExtensionBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AddExtensionBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddExtensionBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddExtensionBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddExtensionBtn.TabIndex = 31;
            this.AddExtensionBtn.Values.Text = "Thêm Extension";
            // 
            // ForceStopBtn
            // 
            this.ForceStopBtn.CornerRoundingRadius = -1F;
            this.ForceStopBtn.Location = new System.Drawing.Point(308, 403);
            this.ForceStopBtn.Name = "ForceStopBtn";
            this.ForceStopBtn.Size = new System.Drawing.Size(122, 25);
            this.ForceStopBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ForceStopBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ForceStopBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ForceStopBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ForceStopBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForceStopBtn.TabIndex = 32;
            this.ForceStopBtn.Values.Text = "Dừng ngay";
            // 
            // StopBtn
            // 
            this.StopBtn.CornerRoundingRadius = -1F;
            this.StopBtn.Enabled = false;
            this.StopBtn.Location = new System.Drawing.Point(308, 363);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(122, 25);
            this.StopBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.StopBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.StopBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StopBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StopBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StopBtn.TabIndex = 33;
            this.StopBtn.Values.Text = "Dừng lại";
            // 
            // StartBtn
            // 
            this.StartBtn.CornerRoundingRadius = -1F;
            this.StartBtn.Location = new System.Drawing.Point(308, 325);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(122, 25);
            this.StartBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.StartBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.StartBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StartBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StartBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartBtn.TabIndex = 34;
            this.StartBtn.Values.Text = "Bắt đầu";
            // 
            // HeadlessCheckBox
            // 
            this.HeadlessCheckBox.Checked = true;
            this.HeadlessCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HeadlessCheckBox.Location = new System.Drawing.Point(309, 115);
            this.HeadlessCheckBox.Name = "HeadlessCheckBox";
            this.HeadlessCheckBox.Size = new System.Drawing.Size(89, 20);
            this.HeadlessCheckBox.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HeadlessCheckBox.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HeadlessCheckBox.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HeadlessCheckBox.TabIndex = 35;
            this.HeadlessCheckBox.Values.Text = "Ẩn Chrome";
            // 
            // TopmostCheckBox
            // 
            this.TopmostCheckBox.Checked = true;
            this.TopmostCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TopmostCheckBox.Location = new System.Drawing.Point(309, 150);
            this.TopmostCheckBox.Name = "TopmostCheckBox";
            this.TopmostCheckBox.Size = new System.Drawing.Size(79, 20);
            this.TopmostCheckBox.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TopmostCheckBox.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TopmostCheckBox.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TopmostCheckBox.TabIndex = 36;
            this.TopmostCheckBox.Values.Text = "Top Most";
            // 
            // PrivateModeCheckBox
            // 
            this.PrivateModeCheckBox.Location = new System.Drawing.Point(309, 183);
            this.PrivateModeCheckBox.Name = "PrivateModeCheckBox";
            this.PrivateModeCheckBox.Size = new System.Drawing.Size(72, 20);
            this.PrivateModeCheckBox.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PrivateModeCheckBox.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PrivateModeCheckBox.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrivateModeCheckBox.TabIndex = 37;
            this.PrivateModeCheckBox.Values.Text = "Ẩn danh";
            // 
            // DisableImgCheckBox
            // 
            this.DisableImgCheckBox.Checked = true;
            this.DisableImgCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisableImgCheckBox.Location = new System.Drawing.Point(308, 217);
            this.DisableImgCheckBox.Name = "DisableImgCheckBox";
            this.DisableImgCheckBox.Size = new System.Drawing.Size(106, 20);
            this.DisableImgCheckBox.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DisableImgCheckBox.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DisableImgCheckBox.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DisableImgCheckBox.TabIndex = 38;
            this.DisableImgCheckBox.Values.Text = "Disable Image";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(308, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "Luồng:";
            // 
            // ThreadNumberUpdown
            // 
            this.ThreadNumberUpdown.Location = new System.Drawing.Point(358, 79);
            this.ThreadNumberUpdown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ThreadNumberUpdown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ThreadNumberUpdown.Name = "ThreadNumberUpdown";
            this.ThreadNumberUpdown.Size = new System.Drawing.Size(72, 22);
            this.ThreadNumberUpdown.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ThreadNumberUpdown.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ThreadNumberUpdown.TabIndex = 40;
            this.ThreadNumberUpdown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label15.Location = new System.Drawing.Point(12, 566);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 15);
            this.label15.TabIndex = 41;
            this.label15.Text = "SSH:";
            // 
            // SSHKeyTxtBox
            // 
            this.SSHKeyTxtBox.Location = new System.Drawing.Point(149, 558);
            this.SSHKeyTxtBox.Name = "SSHKeyTxtBox";
            this.SSHKeyTxtBox.Size = new System.Drawing.Size(134, 23);
            this.SSHKeyTxtBox.StateCommon.Back.Color1 = System.Drawing.Color.Yellow;
            this.SSHKeyTxtBox.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SSHKeyTxtBox.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label16.Location = new System.Drawing.Point(12, 529);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 15);
            this.label16.TabIndex = 43;
            this.label16.Text = "New pass:";
            // 
            // NewpassTxtBox
            // 
            this.NewpassTxtBox.Location = new System.Drawing.Point(149, 521);
            this.NewpassTxtBox.Name = "NewpassTxtBox";
            this.NewpassTxtBox.Size = new System.Drawing.Size(134, 23);
            this.NewpassTxtBox.StateCommon.Back.Color1 = System.Drawing.Color.Yellow;
            this.NewpassTxtBox.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewpassTxtBox.TabIndex = 44;
            // 
            // ProxyComboBox
            // 
            this.ProxyComboBox.CornerRoundingRadius = -1F;
            this.ProxyComboBox.DropDownWidth = 121;
            this.ProxyComboBox.IntegralHeight = false;
            this.ProxyComboBox.Items.AddRange(new object[] {
            "Proxyless",
            "HTTP",
            "Socks5"});
            this.ProxyComboBox.Location = new System.Drawing.Point(309, 290);
            this.ProxyComboBox.Name = "ProxyComboBox";
            this.ProxyComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProxyComboBox.Size = new System.Drawing.Size(121, 21);
            this.ProxyComboBox.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ProxyComboBox.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.ProxyComboBox.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProxyComboBox.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.ProxyComboBox.StateCommon.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ProxyComboBox.StateCommon.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ProxyComboBox.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.ProxyComboBox.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.ProxyComboBox.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProxyComboBox.TabIndex = 45;
            this.ProxyComboBox.Text = "Proxy Type";
            // 
            // CaptureInstanceCheckBox
            // 
            this.CaptureInstanceCheckBox.Checked = true;
            this.CaptureInstanceCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CaptureInstanceCheckBox.Location = new System.Drawing.Point(308, 251);
            this.CaptureInstanceCheckBox.Name = "CaptureInstanceCheckBox";
            this.CaptureInstanceCheckBox.Size = new System.Drawing.Size(127, 20);
            this.CaptureInstanceCheckBox.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CaptureInstanceCheckBox.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CaptureInstanceCheckBox.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CaptureInstanceCheckBox.TabIndex = 46;
            this.CaptureInstanceCheckBox.Values.Text = "Capture Instances";
            // 
            // ClickCookieCheckBox
            // 
            this.ClickCookieCheckBox.Location = new System.Drawing.Point(308, 561);
            this.ClickCookieCheckBox.Name = "ClickCookieCheckBox";
            this.ClickCookieCheckBox.Size = new System.Drawing.Size(94, 20);
            this.ClickCookieCheckBox.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClickCookieCheckBox.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClickCookieCheckBox.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClickCookieCheckBox.TabIndex = 47;
            this.ClickCookieCheckBox.Values.Text = "Click Cookie";
            this.ClickCookieCheckBox.CheckedChanged += new System.EventHandler(this.ClickCookieCheckBox_CheckedChanged);
            // 
            // ChangePassCheckBox
            // 
            this.ChangePassCheckBox.Location = new System.Drawing.Point(308, 591);
            this.ChangePassCheckBox.Name = "ChangePassCheckBox";
            this.ChangePassCheckBox.Size = new System.Drawing.Size(96, 20);
            this.ChangePassCheckBox.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ChangePassCheckBox.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ChangePassCheckBox.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChangePassCheckBox.TabIndex = 48;
            this.ChangePassCheckBox.Values.Text = "Change Pass";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(452, 621);
            this.Controls.Add(this.ChangePassCheckBox);
            this.Controls.Add(this.ClickCookieCheckBox);
            this.Controls.Add(this.CaptureInstanceCheckBox);
            this.Controls.Add(this.ProxyComboBox);
            this.Controls.Add(this.NewpassTxtBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.SSHKeyTxtBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ThreadNumberUpdown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DisableImgCheckBox);
            this.Controls.Add(this.PrivateModeCheckBox);
            this.Controls.Add(this.TopmostCheckBox);
            this.Controls.Add(this.HeadlessCheckBox);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.ForceStopBtn);
            this.Controls.Add(this.AddExtensionBtn);
            this.Controls.Add(this.ClearExtensionsBtn);
            this.Controls.Add(this.LoadExtensionsBtn);
            this.Controls.Add(this.InputProxyBtn);
            this.Controls.Add(this.InputFileBtn);
            this.Controls.Add(this.StartFromUpdown);
            this.Controls.Add(this.DelayCreateUpdown);
            this.Controls.Add(this.DelayRebootUpdown);
            this.Controls.Add(this.DelayDeleteUpdown);
            this.Controls.Add(this.DelayChangePassUpdown);
            this.Controls.Add(this.TimeoutUpdown);
            this.Controls.Add(this.StatusTxtBox);
            this.Controls.Add(this.ExtensionTxtBox);
            this.Controls.Add(this.TotalProxyTxtBox);
            this.Controls.Add(this.ProcessedAccountTxtBox);
            this.Controls.Add(this.FailedAccountTxtBox);
            this.Controls.Add(this.SuccessAccountTxtBox);
            this.Controls.Add(this.TotalAccountTxtBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(468, 660);
            this.MinimumSize = new System.Drawing.Size(468, 660);
            this.Name = "FrmMain";
            this.Text = "Oracel Mixed Tool - Telegram: @lukaxsx";
            ((System.ComponentModel.ISupportInitialize)(this.ProxyComboBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Krypton.Toolkit.KryptonCheckBox ClickCookieCheckBox;
        private Krypton.Toolkit.KryptonCheckBox ChangePassCheckBox;
    }
}