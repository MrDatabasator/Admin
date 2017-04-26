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
            this.textBox_daemonName = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_sRefreshRate = new System.Windows.Forms.Label();
            this.textBox_sRefreshRate = new System.Windows.Forms.TextBox();
            this.grid_tasks = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(380, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daemon";
            // 
            // textBox_daemonName
            // 
            this.textBox_daemonName.Location = new System.Drawing.Point(97, 22);
            this.textBox_daemonName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_daemonName.Name = "textBox_daemonName";
            this.textBox_daemonName.Size = new System.Drawing.Size(167, 20);
            this.textBox_daemonName.TabIndex = 1;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(13, 24);
            this.label_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(81, 13);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Daemon Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.grid_tasks);
            this.groupBox2.Location = new System.Drawing.Point(9, 115);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(380, 266);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tasks";
            // 
            // label_sRefreshRate
            // 
            this.label_sRefreshRate.AutoSize = true;
            this.label_sRefreshRate.Location = new System.Drawing.Point(13, 52);
            this.label_sRefreshRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_sRefreshRate.Name = "label_sRefreshRate";
            this.label_sRefreshRate.Size = new System.Drawing.Size(147, 13);
            this.label_sRefreshRate.TabIndex = 2;
            this.label_sRefreshRate.Text = "Server Refresh rate (minutes):";
            // 
            // textBox_sRefreshRate
            // 
            this.textBox_sRefreshRate.Location = new System.Drawing.Point(164, 49);
            this.textBox_sRefreshRate.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_sRefreshRate.Name = "textBox_sRefreshRate";
            this.textBox_sRefreshRate.Size = new System.Drawing.Size(100, 20);
            this.textBox_sRefreshRate.TabIndex = 3;
            // 
            // grid_tasks
            // 
            this.grid_tasks.AllowUserToAddRows = false;
            this.grid_tasks.AllowUserToDeleteRows = false;
            this.grid_tasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_tasks.Location = new System.Drawing.Point(5, 18);
            this.grid_tasks.Name = "grid_tasks";
            this.grid_tasks.ReadOnly = true;
            this.grid_tasks.Size = new System.Drawing.Size(370, 213);
            this.grid_tasks.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(219, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(312, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form_Configure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 418);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}