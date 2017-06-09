namespace BackupAdmin
{
    partial class Form_AddTask
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
            this.label_des = new System.Windows.Forms.Label();
            this.label_source = new System.Windows.Forms.Label();
            this.textBox_DestinationPath = new System.Windows.Forms.TextBox();
            this.textBox_SourcePath = new System.Windows.Forms.TextBox();
            this.groupBox_TaskConfig = new System.Windows.Forms.GroupBox();
            this.label_taskname = new System.Windows.Forms.Label();
            this.textBox_TaskName = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.groupBox_DesConfig = new System.Windows.Forms.GroupBox();
            this.btn_addDes = new System.Windows.Forms.Button();
            this.textBox_ftpSerAddr = new System.Windows.Forms.TextBox();
            this.label_address = new System.Windows.Forms.Label();
            this.textBox_ftpPass = new System.Windows.Forms.TextBox();
            this.textBox_ftpUser = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.groupBox_desType = new System.Windows.Forms.GroupBox();
            this.radioButton_Local = new System.Windows.Forms.RadioButton();
            this.radioButton_SSH = new System.Windows.Forms.RadioButton();
            this.radioButton_FTP = new System.Windows.Forms.RadioButton();
            this.groupBox_timetable = new System.Windows.Forms.GroupBox();
            this.checkBox_monthloop = new System.Windows.Forms.CheckBox();
            this.label_monthloop = new System.Windows.Forms.Label();
            this.checkBox_weekloop = new System.Windows.Forms.CheckBox();
            this.label_weekloop = new System.Windows.Forms.Label();
            this.dtpicker_date = new System.Windows.Forms.DateTimePicker();
            this.label_date = new System.Windows.Forms.Label();
            this.checkBox_dayloop = new System.Windows.Forms.CheckBox();
            this.chListBox_days = new System.Windows.Forms.CheckedListBox();
            this.label_days = new System.Windows.Forms.Label();
            this.label_dayloop = new System.Windows.Forms.Label();
            this.dtpicker_Time = new System.Windows.Forms.DateTimePicker();
            this.label_time = new System.Windows.Forms.Label();
            this.label_workingdir = new System.Windows.Forms.Label();
            this.textBox_workingDir = new System.Windows.Forms.TextBox();
            this.groupBox_TaskConfig.SuspendLayout();
            this.groupBox_DesConfig.SuspendLayout();
            this.groupBox_desType.SuspendLayout();
            this.groupBox_timetable.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_des
            // 
            this.label_des.AutoSize = true;
            this.label_des.Location = new System.Drawing.Point(6, 182);
            this.label_des.Name = "label_des";
            this.label_des.Size = new System.Drawing.Size(85, 13);
            this.label_des.TabIndex = 3;
            this.label_des.Text = "Destination Path";
            // 
            // label_source
            // 
            this.label_source.AutoSize = true;
            this.label_source.Location = new System.Drawing.Point(6, 156);
            this.label_source.Name = "label_source";
            this.label_source.Size = new System.Drawing.Size(66, 13);
            this.label_source.TabIndex = 2;
            this.label_source.Text = "Source Path";
            // 
            // textBox_DestinationPath
            // 
            this.textBox_DestinationPath.Location = new System.Drawing.Point(129, 179);
            this.textBox_DestinationPath.Name = "textBox_DestinationPath";
            this.textBox_DestinationPath.Size = new System.Drawing.Size(233, 20);
            this.textBox_DestinationPath.TabIndex = 1;
            // 
            // textBox_SourcePath
            // 
            this.textBox_SourcePath.Location = new System.Drawing.Point(129, 153);
            this.textBox_SourcePath.Name = "textBox_SourcePath";
            this.textBox_SourcePath.Size = new System.Drawing.Size(232, 20);
            this.textBox_SourcePath.TabIndex = 0;
            // 
            // groupBox_TaskConfig
            // 
            this.groupBox_TaskConfig.Controls.Add(this.label_taskname);
            this.groupBox_TaskConfig.Controls.Add(this.textBox_TaskName);
            this.groupBox_TaskConfig.Location = new System.Drawing.Point(12, 12);
            this.groupBox_TaskConfig.Name = "groupBox_TaskConfig";
            this.groupBox_TaskConfig.Size = new System.Drawing.Size(374, 59);
            this.groupBox_TaskConfig.TabIndex = 1;
            this.groupBox_TaskConfig.TabStop = false;
            this.groupBox_TaskConfig.Text = "Task Configuration";
            // 
            // label_taskname
            // 
            this.label_taskname.AutoSize = true;
            this.label_taskname.Location = new System.Drawing.Point(6, 31);
            this.label_taskname.Name = "label_taskname";
            this.label_taskname.Size = new System.Drawing.Size(62, 13);
            this.label_taskname.TabIndex = 5;
            this.label_taskname.Text = "Task Name";
            // 
            // textBox_TaskName
            // 
            this.textBox_TaskName.Location = new System.Drawing.Point(74, 28);
            this.textBox_TaskName.Name = "textBox_TaskName";
            this.textBox_TaskName.Size = new System.Drawing.Size(294, 20);
            this.textBox_TaskName.TabIndex = 4;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(312, 603);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(231, 603);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // groupBox_DesConfig
            // 
            this.groupBox_DesConfig.Controls.Add(this.label_workingdir);
            this.groupBox_DesConfig.Controls.Add(this.textBox_workingDir);
            this.groupBox_DesConfig.Controls.Add(this.btn_addDes);
            this.groupBox_DesConfig.Controls.Add(this.textBox_ftpSerAddr);
            this.groupBox_DesConfig.Controls.Add(this.label_address);
            this.groupBox_DesConfig.Controls.Add(this.textBox_ftpPass);
            this.groupBox_DesConfig.Controls.Add(this.textBox_ftpUser);
            this.groupBox_DesConfig.Controls.Add(this.label_password);
            this.groupBox_DesConfig.Controls.Add(this.label_username);
            this.groupBox_DesConfig.Controls.Add(this.groupBox_desType);
            this.groupBox_DesConfig.Controls.Add(this.label_source);
            this.groupBox_DesConfig.Controls.Add(this.label_des);
            this.groupBox_DesConfig.Controls.Add(this.textBox_SourcePath);
            this.groupBox_DesConfig.Controls.Add(this.textBox_DestinationPath);
            this.groupBox_DesConfig.Location = new System.Drawing.Point(12, 282);
            this.groupBox_DesConfig.Name = "groupBox_DesConfig";
            this.groupBox_DesConfig.Size = new System.Drawing.Size(375, 258);
            this.groupBox_DesConfig.TabIndex = 4;
            this.groupBox_DesConfig.TabStop = false;
            this.groupBox_DesConfig.Text = "Destination Configuration";
            // 
            // btn_addDes
            // 
            this.btn_addDes.Location = new System.Drawing.Point(219, 229);
            this.btn_addDes.Name = "btn_addDes";
            this.btn_addDes.Size = new System.Drawing.Size(143, 23);
            this.btn_addDes.TabIndex = 6;
            this.btn_addDes.Text = "Add Destination";
            this.btn_addDes.UseVisualStyleBackColor = true;
            // 
            // textBox_ftpSerAddr
            // 
            this.textBox_ftpSerAddr.Location = new System.Drawing.Point(129, 75);
            this.textBox_ftpSerAddr.Name = "textBox_ftpSerAddr";
            this.textBox_ftpSerAddr.Size = new System.Drawing.Size(233, 20);
            this.textBox_ftpSerAddr.TabIndex = 13;
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(6, 78);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(102, 13);
            this.label_address.TabIndex = 12;
            this.label_address.Text = "FTP Server Address";
            // 
            // textBox_ftpPass
            // 
            this.textBox_ftpPass.Location = new System.Drawing.Point(129, 127);
            this.textBox_ftpPass.Name = "textBox_ftpPass";
            this.textBox_ftpPass.Size = new System.Drawing.Size(232, 20);
            this.textBox_ftpPass.TabIndex = 11;
            // 
            // textBox_ftpUser
            // 
            this.textBox_ftpUser.Location = new System.Drawing.Point(129, 101);
            this.textBox_ftpUser.Name = "textBox_ftpUser";
            this.textBox_ftpUser.Size = new System.Drawing.Size(232, 20);
            this.textBox_ftpUser.TabIndex = 10;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(6, 130);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(76, 13);
            this.label_password.TabIndex = 9;
            this.label_password.Text = "FTP Password";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(6, 104);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(78, 13);
            this.label_username.TabIndex = 8;
            this.label_username.Text = "FTP Username";
            // 
            // groupBox_desType
            // 
            this.groupBox_desType.Controls.Add(this.radioButton_Local);
            this.groupBox_desType.Controls.Add(this.radioButton_SSH);
            this.groupBox_desType.Controls.Add(this.radioButton_FTP);
            this.groupBox_desType.Location = new System.Drawing.Point(6, 19);
            this.groupBox_desType.Name = "groupBox_desType";
            this.groupBox_desType.Size = new System.Drawing.Size(362, 44);
            this.groupBox_desType.TabIndex = 7;
            this.groupBox_desType.TabStop = false;
            this.groupBox_desType.Text = "Destination Type";
            // 
            // radioButton_Local
            // 
            this.radioButton_Local.AutoSize = true;
            this.radioButton_Local.Location = new System.Drawing.Point(14, 19);
            this.radioButton_Local.Name = "radioButton_Local";
            this.radioButton_Local.Size = new System.Drawing.Size(51, 17);
            this.radioButton_Local.TabIndex = 6;
            this.radioButton_Local.TabStop = true;
            this.radioButton_Local.Text = "Local";
            this.radioButton_Local.UseVisualStyleBackColor = true;
            this.radioButton_Local.CheckedChanged += new System.EventHandler(this.radioButton_Local_CheckedChanged);
            // 
            // radioButton_SSH
            // 
            this.radioButton_SSH.AutoSize = true;
            this.radioButton_SSH.Location = new System.Drawing.Point(272, 19);
            this.radioButton_SSH.Name = "radioButton_SSH";
            this.radioButton_SSH.Size = new System.Drawing.Size(47, 17);
            this.radioButton_SSH.TabIndex = 5;
            this.radioButton_SSH.TabStop = true;
            this.radioButton_SSH.Text = "SSH";
            this.radioButton_SSH.UseVisualStyleBackColor = true;
            this.radioButton_SSH.CheckedChanged += new System.EventHandler(this.radioButton_SSH_CheckedChanged);
            // 
            // radioButton_FTP
            // 
            this.radioButton_FTP.AutoSize = true;
            this.radioButton_FTP.Location = new System.Drawing.Point(146, 19);
            this.radioButton_FTP.Name = "radioButton_FTP";
            this.radioButton_FTP.Size = new System.Drawing.Size(45, 17);
            this.radioButton_FTP.TabIndex = 4;
            this.radioButton_FTP.TabStop = true;
            this.radioButton_FTP.Text = "FTP";
            this.radioButton_FTP.UseVisualStyleBackColor = true;
            this.radioButton_FTP.CheckedChanged += new System.EventHandler(this.radioButton_FTP_CheckedChanged);
            // 
            // groupBox_timetable
            // 
            this.groupBox_timetable.Controls.Add(this.checkBox_monthloop);
            this.groupBox_timetable.Controls.Add(this.label_monthloop);
            this.groupBox_timetable.Controls.Add(this.checkBox_weekloop);
            this.groupBox_timetable.Controls.Add(this.label_weekloop);
            this.groupBox_timetable.Controls.Add(this.dtpicker_date);
            this.groupBox_timetable.Controls.Add(this.label_date);
            this.groupBox_timetable.Controls.Add(this.checkBox_dayloop);
            this.groupBox_timetable.Controls.Add(this.chListBox_days);
            this.groupBox_timetable.Controls.Add(this.label_days);
            this.groupBox_timetable.Controls.Add(this.label_dayloop);
            this.groupBox_timetable.Controls.Add(this.dtpicker_Time);
            this.groupBox_timetable.Controls.Add(this.label_time);
            this.groupBox_timetable.Location = new System.Drawing.Point(12, 77);
            this.groupBox_timetable.Name = "groupBox_timetable";
            this.groupBox_timetable.Size = new System.Drawing.Size(374, 199);
            this.groupBox_timetable.TabIndex = 5;
            this.groupBox_timetable.TabStop = false;
            this.groupBox_timetable.Text = "Time Table";
            // 
            // checkBox_monthloop
            // 
            this.checkBox_monthloop.AutoSize = true;
            this.checkBox_monthloop.Location = new System.Drawing.Point(310, 54);
            this.checkBox_monthloop.Name = "checkBox_monthloop";
            this.checkBox_monthloop.Size = new System.Drawing.Size(15, 14);
            this.checkBox_monthloop.TabIndex = 16;
            this.checkBox_monthloop.UseVisualStyleBackColor = true;
            this.checkBox_monthloop.CheckedChanged += new System.EventHandler(this.checkBox_monthloop_CheckedChanged);
            // 
            // label_monthloop
            // 
            this.label_monthloop.AutoSize = true;
            this.label_monthloop.Location = new System.Drawing.Point(230, 54);
            this.label_monthloop.Name = "label_monthloop";
            this.label_monthloop.Size = new System.Drawing.Size(74, 13);
            this.label_monthloop.TabIndex = 15;
            this.label_monthloop.Text = "Monthly Loop ";
            // 
            // checkBox_weekloop
            // 
            this.checkBox_weekloop.AutoSize = true;
            this.checkBox_weekloop.Location = new System.Drawing.Point(190, 54);
            this.checkBox_weekloop.Name = "checkBox_weekloop";
            this.checkBox_weekloop.Size = new System.Drawing.Size(15, 14);
            this.checkBox_weekloop.TabIndex = 14;
            this.checkBox_weekloop.UseVisualStyleBackColor = true;
            this.checkBox_weekloop.CheckedChanged += new System.EventHandler(this.checkBox_weekloop_CheckedChanged);
            // 
            // label_weekloop
            // 
            this.label_weekloop.AutoSize = true;
            this.label_weekloop.Location = new System.Drawing.Point(111, 54);
            this.label_weekloop.Name = "label_weekloop";
            this.label_weekloop.Size = new System.Drawing.Size(73, 13);
            this.label_weekloop.TabIndex = 13;
            this.label_weekloop.Text = "Weekly Loop ";
            // 
            // dtpicker_date
            // 
            this.dtpicker_date.Location = new System.Drawing.Point(43, 25);
            this.dtpicker_date.Name = "dtpicker_date";
            this.dtpicker_date.Size = new System.Drawing.Size(140, 20);
            this.dtpicker_date.TabIndex = 11;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(7, 31);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(30, 13);
            this.label_date.TabIndex = 12;
            this.label_date.Text = "Date";
            // 
            // checkBox_dayloop
            // 
            this.checkBox_dayloop.AutoSize = true;
            this.checkBox_dayloop.Location = new System.Drawing.Point(74, 53);
            this.checkBox_dayloop.Name = "checkBox_dayloop";
            this.checkBox_dayloop.Size = new System.Drawing.Size(15, 14);
            this.checkBox_dayloop.TabIndex = 10;
            this.checkBox_dayloop.UseVisualStyleBackColor = true;
            this.checkBox_dayloop.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chListBox_days
            // 
            this.chListBox_days.Enabled = false;
            this.chListBox_days.FormattingEnabled = true;
            this.chListBox_days.Items.AddRange(new object[] {
            "MON",
            "TUE",
            "THU",
            "WED",
            "FRY",
            "SAT",
            "SUN"});
            this.chListBox_days.Location = new System.Drawing.Point(43, 80);
            this.chListBox_days.Name = "chListBox_days";
            this.chListBox_days.Size = new System.Drawing.Size(282, 109);
            this.chListBox_days.TabIndex = 9;
            // 
            // label_days
            // 
            this.label_days.AutoSize = true;
            this.label_days.Location = new System.Drawing.Point(6, 80);
            this.label_days.Name = "label_days";
            this.label_days.Size = new System.Drawing.Size(31, 13);
            this.label_days.TabIndex = 8;
            this.label_days.Text = "Days";
            // 
            // label_dayloop
            // 
            this.label_dayloop.AutoSize = true;
            this.label_dayloop.Location = new System.Drawing.Point(3, 53);
            this.label_dayloop.Name = "label_dayloop";
            this.label_dayloop.Size = new System.Drawing.Size(63, 13);
            this.label_dayloop.TabIndex = 7;
            this.label_dayloop.Text = " Daily Loop ";
            // 
            // dtpicker_Time
            // 
            this.dtpicker_Time.Location = new System.Drawing.Point(225, 24);
            this.dtpicker_Time.Name = "dtpicker_Time";
            this.dtpicker_Time.Size = new System.Drawing.Size(100, 20);
            this.dtpicker_Time.TabIndex = 6;
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(189, 31);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(30, 13);
            this.label_time.TabIndex = 6;
            this.label_time.Text = "Time";
            this.label_time.Click += new System.EventHandler(this.label_time_Click);
            // 
            // label_workingdir
            // 
            this.label_workingdir.AutoSize = true;
            this.label_workingdir.Location = new System.Drawing.Point(6, 206);
            this.label_workingdir.Name = "label_workingdir";
            this.label_workingdir.Size = new System.Drawing.Size(117, 13);
            this.label_workingdir.TabIndex = 15;
            this.label_workingdir.Text = "SSH Working Directory";
            // 
            // textBox_workingDir
            // 
            this.textBox_workingDir.Location = new System.Drawing.Point(129, 203);
            this.textBox_workingDir.Name = "textBox_workingDir";
            this.textBox_workingDir.Size = new System.Drawing.Size(232, 20);
            this.textBox_workingDir.TabIndex = 14;
            // 
            // Form_AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 638);
            this.Controls.Add(this.groupBox_timetable);
            this.Controls.Add(this.groupBox_DesConfig);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.groupBox_TaskConfig);
            this.Name = "Form_AddTask";
            this.Text = "Task Creator";
            this.groupBox_TaskConfig.ResumeLayout(false);
            this.groupBox_TaskConfig.PerformLayout();
            this.groupBox_DesConfig.ResumeLayout(false);
            this.groupBox_DesConfig.PerformLayout();
            this.groupBox_desType.ResumeLayout(false);
            this.groupBox_desType.PerformLayout();
            this.groupBox_timetable.ResumeLayout(false);
            this.groupBox_timetable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_des;
        private System.Windows.Forms.Label label_source;
        private System.Windows.Forms.TextBox textBox_DestinationPath;
        private System.Windows.Forms.TextBox textBox_SourcePath;
        private System.Windows.Forms.GroupBox groupBox_TaskConfig;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label_taskname;
        private System.Windows.Forms.TextBox textBox_TaskName;
        private System.Windows.Forms.GroupBox groupBox_DesConfig;
        private System.Windows.Forms.GroupBox groupBox_desType;
        private System.Windows.Forms.RadioButton radioButton_Local;
        private System.Windows.Forms.RadioButton radioButton_SSH;
        private System.Windows.Forms.RadioButton radioButton_FTP;
        private System.Windows.Forms.TextBox textBox_ftpSerAddr;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.TextBox textBox_ftpPass;
        private System.Windows.Forms.TextBox textBox_ftpUser;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.GroupBox groupBox_timetable;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.CheckedListBox chListBox_days;
        private System.Windows.Forms.Label label_days;
        private System.Windows.Forms.Label label_dayloop;
        private System.Windows.Forms.DateTimePicker dtpicker_Time;
        private System.Windows.Forms.CheckBox checkBox_dayloop;
        private System.Windows.Forms.Button btn_addDes;
        private System.Windows.Forms.DateTimePicker dtpicker_date;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.CheckBox checkBox_weekloop;
        private System.Windows.Forms.Label label_weekloop;
        private System.Windows.Forms.CheckBox checkBox_monthloop;
        private System.Windows.Forms.Label label_monthloop;
        private System.Windows.Forms.Label label_workingdir;
        private System.Windows.Forms.TextBox textBox_workingDir;
    }
}