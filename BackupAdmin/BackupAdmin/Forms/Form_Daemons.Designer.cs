namespace BackupAdmin
{
    partial class Form_Daemons
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
            this.components = new System.ComponentModel.Container();
            this.grid_daemons = new System.Windows.Forms.DataGridView();
            this.btn_manage = new System.Windows.Forms.Button();
            this.tmr_refresh = new System.Windows.Forms.Timer(this.components);
            this.chBox_LoadOffline = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_daemons)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_daemons
            // 
            this.grid_daemons.AllowUserToAddRows = false;
            this.grid_daemons.AllowUserToDeleteRows = false;
            this.grid_daemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_daemons.Location = new System.Drawing.Point(0, 0);
            this.grid_daemons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid_daemons.Name = "grid_daemons";
            this.grid_daemons.ReadOnly = true;
            this.grid_daemons.RowTemplate.Height = 24;
            this.grid_daemons.Size = new System.Drawing.Size(681, 395);
            this.grid_daemons.TabIndex = 0;
            // 
            // btn_manage
            // 
            this.btn_manage.Location = new System.Drawing.Point(592, 400);
            this.btn_manage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_manage.Name = "btn_manage";
            this.btn_manage.Size = new System.Drawing.Size(75, 30);
            this.btn_manage.TabIndex = 1;
            this.btn_manage.Text = "Manage";
            this.btn_manage.UseVisualStyleBackColor = true;
            this.btn_manage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_manage_MouseClick);
            // 
            // tmr_refresh
            // 
            this.tmr_refresh.Enabled = true;
            this.tmr_refresh.Interval = 1000;
            this.tmr_refresh.Tick += new System.EventHandler(this.tmr_refresh_Tick);
            // 
            // chBox_LoadOffline
            // 
            this.chBox_LoadOffline.AutoSize = true;
            this.chBox_LoadOffline.Location = new System.Drawing.Point(173, 408);
            this.chBox_LoadOffline.Name = "chBox_LoadOffline";
            this.chBox_LoadOffline.Size = new System.Drawing.Size(18, 17);
            this.chBox_LoadOffline.TabIndex = 3;
            this.chBox_LoadOffline.UseVisualStyleBackColor = true;
            this.chBox_LoadOffline.CheckedChanged += new System.EventHandler(this.chBox_LoadOffline_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Show Offline Daemons:";
            // 
            // Form_Daemons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 436);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chBox_LoadOffline);
            this.Controls.Add(this.btn_manage);
            this.Controls.Add(this.grid_daemons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Daemons";
            this.Text = "Daemons";
            ((System.ComponentModel.ISupportInitialize)(this.grid_daemons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_daemons;
        private System.Windows.Forms.Button btn_manage;
        private System.Windows.Forms.Timer tmr_refresh;
        private System.Windows.Forms.CheckBox chBox_LoadOffline;
        private System.Windows.Forms.Label label2;
    }
}