﻿namespace BackupAdmin
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
            this.radioButton_FTP = new System.Windows.Forms.RadioButton();
            this.radioButton_SSH = new System.Windows.Forms.RadioButton();
            this.radioButton_Local = new System.Windows.Forms.RadioButton();
            this.groupBox_desType = new System.Windows.Forms.GroupBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox_TaskConfig.SuspendLayout();
            this.groupBox_DesConfig.SuspendLayout();
            this.groupBox_desType.SuspendLayout();
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
            this.textBox_DestinationPath.Location = new System.Drawing.Point(101, 179);
            this.textBox_DestinationPath.Name = "textBox_DestinationPath";
            this.textBox_DestinationPath.Size = new System.Drawing.Size(260, 20);
            this.textBox_DestinationPath.TabIndex = 1;
            // 
            // textBox_SourcePath
            // 
            this.textBox_SourcePath.Location = new System.Drawing.Point(101, 153);
            this.textBox_SourcePath.Name = "textBox_SourcePath";
            this.textBox_SourcePath.Size = new System.Drawing.Size(260, 20);
            this.textBox_SourcePath.TabIndex = 0;
            // 
            // groupBox_TaskConfig
            // 
            this.groupBox_TaskConfig.Controls.Add(this.label_taskname);
            this.groupBox_TaskConfig.Controls.Add(this.textBox_TaskName);
            this.groupBox_TaskConfig.Location = new System.Drawing.Point(12, 12);
            this.groupBox_TaskConfig.Name = "groupBox_TaskConfig";
            this.groupBox_TaskConfig.Size = new System.Drawing.Size(374, 110);
            this.groupBox_TaskConfig.TabIndex = 1;
            this.groupBox_TaskConfig.TabStop = false;
            this.groupBox_TaskConfig.Text = "Task Configuration";
            // 
            // label_taskname
            // 
            this.label_taskname.AutoSize = true;
            this.label_taskname.Location = new System.Drawing.Point(17, 31);
            this.label_taskname.Name = "label_taskname";
            this.label_taskname.Size = new System.Drawing.Size(62, 13);
            this.label_taskname.TabIndex = 5;
            this.label_taskname.Text = "Task Name";
            this.label_taskname.Click += new System.EventHandler(this.label_taskname_Click);
            // 
            // textBox_TaskName
            // 
            this.textBox_TaskName.Location = new System.Drawing.Point(108, 28);
            this.textBox_TaskName.Name = "textBox_TaskName";
            this.textBox_TaskName.Size = new System.Drawing.Size(260, 20);
            this.textBox_TaskName.TabIndex = 4;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(312, 339);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(231, 339);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // groupBox_DesConfig
            // 
            this.groupBox_DesConfig.Controls.Add(this.textBox3);
            this.groupBox_DesConfig.Controls.Add(this.label1);
            this.groupBox_DesConfig.Controls.Add(this.textBox2);
            this.groupBox_DesConfig.Controls.Add(this.textBox1);
            this.groupBox_DesConfig.Controls.Add(this.label_password);
            this.groupBox_DesConfig.Controls.Add(this.label_username);
            this.groupBox_DesConfig.Controls.Add(this.groupBox_desType);
            this.groupBox_DesConfig.Controls.Add(this.label_source);
            this.groupBox_DesConfig.Controls.Add(this.label_des);
            this.groupBox_DesConfig.Controls.Add(this.textBox_SourcePath);
            this.groupBox_DesConfig.Controls.Add(this.textBox_DestinationPath);
            this.groupBox_DesConfig.Location = new System.Drawing.Point(12, 128);
            this.groupBox_DesConfig.Name = "groupBox_DesConfig";
            this.groupBox_DesConfig.Size = new System.Drawing.Size(375, 205);
            this.groupBox_DesConfig.TabIndex = 4;
            this.groupBox_DesConfig.TabStop = false;
            this.groupBox_DesConfig.Text = "Destination Configuration";
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
            // 
            // radioButton_SSH
            // 
            this.radioButton_SSH.AutoSize = true;
            this.radioButton_SSH.Enabled = false;
            this.radioButton_SSH.Location = new System.Drawing.Point(272, 19);
            this.radioButton_SSH.Name = "radioButton_SSH";
            this.radioButton_SSH.Size = new System.Drawing.Size(47, 17);
            this.radioButton_SSH.TabIndex = 5;
            this.radioButton_SSH.TabStop = true;
            this.radioButton_SSH.Text = "SSH";
            this.radioButton_SSH.UseVisualStyleBackColor = true;
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
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(6, 104);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(78, 13);
            this.label_username.TabIndex = 8;
            this.label_username.Text = "FTP Username";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(260, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "FTP Server Address";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(114, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(248, 20);
            this.textBox3.TabIndex = 13;
            // 
            // Form_AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 368);
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_username;
    }
}