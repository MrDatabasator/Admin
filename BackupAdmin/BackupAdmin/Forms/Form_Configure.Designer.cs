namespace BackupAdmin
{
    partial class Form_Configure
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_sRefreshRate = new System.Windows.Forms.TextBox();
            this.label_sRefreshRate = new System.Windows.Forms.Label();
            this.textBox_daemonName = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_viewTasks = new System.Windows.Forms.Button();
            this.grid_tasks = new System.Windows.Forms.DataGridView();
            this.btn_ok = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tasks)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_sRefreshRate);
            this.groupBox1.Controls.Add(this.label_sRefreshRate);
            this.groupBox1.Controls.Add(this.textBox_daemonName);
            this.groupBox1.Controls.Add(this.label_name);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(507, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daemon";
            // 
            // textBox_sRefreshRate
            // 
            this.textBox_sRefreshRate.Location = new System.Drawing.Point(218, 57);
            this.textBox_sRefreshRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_sRefreshRate.Name = "textBox_sRefreshRate";
            this.textBox_sRefreshRate.Size = new System.Drawing.Size(132, 22);
            this.textBox_sRefreshRate.TabIndex = 3;
            // 
            // label_sRefreshRate
            // 
            this.label_sRefreshRate.AutoSize = true;
            this.label_sRefreshRate.Location = new System.Drawing.Point(17, 60);
            this.label_sRefreshRate.Name = "label_sRefreshRate";
            this.label_sRefreshRate.Size = new System.Drawing.Size(200, 17);
            this.label_sRefreshRate.TabIndex = 2;
            this.label_sRefreshRate.Text = "Server Refresh rate (minutes):";
            // 
            // textBox_daemonName
            // 
            this.textBox_daemonName.Location = new System.Drawing.Point(129, 27);
            this.textBox_daemonName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_daemonName.Name = "textBox_daemonName";
            this.textBox_daemonName.Size = new System.Drawing.Size(221, 22);
            this.textBox_daemonName.TabIndex = 1;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(17, 30);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(106, 17);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Daemon Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_viewTasks);
            this.groupBox2.Controls.Add(this.grid_tasks);
            this.groupBox2.Location = new System.Drawing.Point(12, 142);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(507, 327);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tasks";
            // 
            // btn_viewTasks
            // 
            this.btn_viewTasks.Location = new System.Drawing.Point(322, 292);
            this.btn_viewTasks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_viewTasks.Name = "btn_viewTasks";
            this.btn_viewTasks.Size = new System.Drawing.Size(178, 28);
            this.btn_viewTasks.TabIndex = 2;
            this.btn_viewTasks.Text = "View Details";
            this.btn_viewTasks.UseVisualStyleBackColor = true;
            // 
            // grid_tasks
            // 
            this.grid_tasks.AllowUserToAddRows = false;
            this.grid_tasks.AllowUserToDeleteRows = false;
            this.grid_tasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_tasks.Location = new System.Drawing.Point(7, 22);
            this.grid_tasks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grid_tasks.Name = "grid_tasks";
            this.grid_tasks.ReadOnly = true;
            this.grid_tasks.Size = new System.Drawing.Size(493, 262);
            this.grid_tasks.TabIndex = 2;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(416, 475);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(100, 28);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "Save";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // Form_Configure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 514);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Configure";
            this.Text = "Configuration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_tasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_daemonName;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_sRefreshRate;
        private System.Windows.Forms.Label label_sRefreshRate;
        private System.Windows.Forms.DataGridView grid_tasks;
        private System.Windows.Forms.Button btn_viewTasks;
        private System.Windows.Forms.Button btn_ok;
    }
}