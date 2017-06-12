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
            this.btn_stats = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_daemons)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_daemons
            // 
            this.grid_daemons.AllowUserToAddRows = false;
            this.grid_daemons.AllowUserToDeleteRows = false;
            this.grid_daemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_daemons.Location = new System.Drawing.Point(0, 0);
            this.grid_daemons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grid_daemons.Name = "grid_daemons";
            this.grid_daemons.ReadOnly = true;
            this.grid_daemons.RowTemplate.Height = 24;
            this.grid_daemons.Size = new System.Drawing.Size(511, 321);
            this.grid_daemons.TabIndex = 0;
            // 
            // btn_manage
            // 
            this.btn_manage.Location = new System.Drawing.Point(444, 325);
            this.btn_manage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_manage.Name = "btn_manage";
            this.btn_manage.Size = new System.Drawing.Size(56, 24);
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
            this.chBox_LoadOffline.Location = new System.Drawing.Point(130, 332);
            this.chBox_LoadOffline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chBox_LoadOffline.Name = "chBox_LoadOffline";
            this.chBox_LoadOffline.Size = new System.Drawing.Size(15, 14);
            this.chBox_LoadOffline.TabIndex = 3;
            this.chBox_LoadOffline.UseVisualStyleBackColor = true;
            this.chBox_LoadOffline.CheckedChanged += new System.EventHandler(this.chBox_LoadOffline_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 330);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Show Offline Daemons:";
            // 
            // btn_stats
            // 
            this.btn_stats.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_stats.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_stats.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btn_stats.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btn_stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stats.Font = new System.Drawing.Font("Swis721 Cn BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_stats.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_stats.Location = new System.Drawing.Point(360, 326);
            this.btn_stats.Name = "btn_stats";
            this.btn_stats.Size = new System.Drawing.Size(79, 23);
            this.btn_stats.TabIndex = 6;
            this.btn_stats.Text = "STATS beta";
            this.btn_stats.UseVisualStyleBackColor = false;
            this.btn_stats.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_stats_MouseClick);
            // 
            // Form_Daemons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 354);
            this.Controls.Add(this.btn_stats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chBox_LoadOffline);
            this.Controls.Add(this.btn_manage);
            this.Controls.Add(this.grid_daemons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button btn_stats;
    }
}