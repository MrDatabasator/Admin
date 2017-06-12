namespace BackupAdmin
{
    partial class Stats
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
            this.panel_border = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label_stats = new System.Windows.Forms.Label();
            this.panel_btnX = new System.Windows.Forms.Panel();
            this.label_x = new System.Windows.Forms.Label();
            this.pBox_graph = new System.Windows.Forms.PictureBox();
            this.pBox_dList = new System.Windows.Forms.PictureBox();
            this.label_backupCountText = new System.Windows.Forms.Label();
            this.label_mostbkTypeText = new System.Windows.Forms.Label();
            this.label_daemonMostBkText = new System.Windows.Forms.Label();
            this.label_graphText = new System.Windows.Forms.Label();
            this.label_daemons = new System.Windows.Forms.Label();
            this.label_totalNumOfBackups = new System.Windows.Forms.Label();
            this.label_mostBkType = new System.Windows.Forms.Label();
            this.label_daemonWithMostBk = new System.Windows.Forms.Label();
            this.panel_border.SuspendLayout();
            this.panel_btnX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_dList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_border
            // 
            this.panel_border.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel_border.Controls.Add(this.label9);
            this.panel_border.Controls.Add(this.label_stats);
            this.panel_border.Location = new System.Drawing.Point(0, 0);
            this.panel_border.Name = "panel_border";
            this.panel_border.Size = new System.Drawing.Size(358, 40);
            this.panel_border.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Swis721 Cn BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.Location = new System.Drawing.Point(218, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 14);
            this.label9.TabIndex = 4;
            this.label9.Text = "BETA";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_stats
            // 
            this.label_stats.AutoSize = true;
            this.label_stats.Font = new System.Drawing.Font("Swis721 Cn BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stats.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label_stats.Location = new System.Drawing.Point(152, 6);
            this.label_stats.Name = "label_stats";
            this.label_stats.Size = new System.Drawing.Size(76, 29);
            this.label_stats.TabIndex = 3;
            this.label_stats.Text = "STATS";
            this.label_stats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_btnX
            // 
            this.panel_btnX.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel_btnX.Controls.Add(this.label_x);
            this.panel_btnX.Location = new System.Drawing.Point(359, 0);
            this.panel_btnX.Name = "panel_btnX";
            this.panel_btnX.Size = new System.Drawing.Size(41, 40);
            this.panel_btnX.TabIndex = 1;
            this.panel_btnX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_btnX_MouseClick);
            this.panel_btnX.MouseLeave += new System.EventHandler(this.panel_btnX_MouseLeave);
            this.panel_btnX.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_btnX_MouseMove);
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_x.Location = new System.Drawing.Point(8, 8);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(25, 24);
            this.label_x.TabIndex = 2;
            this.label_x.Text = "X";
            this.label_x.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_x.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_x_MouseClick);
            this.label_x.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_x_MouseMove);
            // 
            // pBox_graph
            // 
            this.pBox_graph.Location = new System.Drawing.Point(1, 44);
            this.pBox_graph.Name = "pBox_graph";
            this.pBox_graph.Size = new System.Drawing.Size(387, 200);
            this.pBox_graph.TabIndex = 2;
            this.pBox_graph.TabStop = false;
            this.pBox_graph.Paint += new System.Windows.Forms.PaintEventHandler(this.pBox_graph_Paint);
            // 
            // pBox_dList
            // 
            this.pBox_dList.Location = new System.Drawing.Point(288, 310);
            this.pBox_dList.Name = "pBox_dList";
            this.pBox_dList.Size = new System.Drawing.Size(111, 170);
            this.pBox_dList.TabIndex = 3;
            this.pBox_dList.TabStop = false;
            this.pBox_dList.Paint += new System.Windows.Forms.PaintEventHandler(this.pBox_dList_Paint);
            // 
            // label_backupCountText
            // 
            this.label_backupCountText.AutoSize = true;
            this.label_backupCountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_backupCountText.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_backupCountText.Location = new System.Drawing.Point(12, 310);
            this.label_backupCountText.Name = "label_backupCountText";
            this.label_backupCountText.Size = new System.Drawing.Size(155, 13);
            this.label_backupCountText.TabIndex = 4;
            this.label_backupCountText.Text = "Total Number of Backups:";
            // 
            // label_mostbkTypeText
            // 
            this.label_mostbkTypeText.AutoSize = true;
            this.label_mostbkTypeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_mostbkTypeText.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_mostbkTypeText.Location = new System.Drawing.Point(12, 343);
            this.label_mostbkTypeText.Name = "label_mostbkTypeText";
            this.label_mostbkTypeText.Size = new System.Drawing.Size(127, 13);
            this.label_mostbkTypeText.TabIndex = 5;
            this.label_mostbkTypeText.Text = "Most Backuped type:";
            // 
            // label_daemonMostBkText
            // 
            this.label_daemonMostBkText.AutoSize = true;
            this.label_daemonMostBkText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_daemonMostBkText.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_daemonMostBkText.Location = new System.Drawing.Point(12, 374);
            this.label_daemonMostBkText.Name = "label_daemonMostBkText";
            this.label_daemonMostBkText.Size = new System.Drawing.Size(188, 13);
            this.label_daemonMostBkText.TabIndex = 6;
            this.label_daemonMostBkText.Text = "Daemon with the most backups:";
            // 
            // label_graphText
            // 
            this.label_graphText.AutoSize = true;
            this.label_graphText.Location = new System.Drawing.Point(202, 247);
            this.label_graphText.Name = "label_graphText";
            this.label_graphText.Size = new System.Drawing.Size(186, 13);
            this.label_graphText.TabIndex = 7;
            this.label_graphText.Text = "-Graph of Backups done in last x days";
            // 
            // label_daemons
            // 
            this.label_daemons.AutoSize = true;
            this.label_daemons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_daemons.Location = new System.Drawing.Point(290, 305);
            this.label_daemons.Name = "label_daemons";
            this.label_daemons.Size = new System.Drawing.Size(74, 16);
            this.label_daemons.TabIndex = 8;
            this.label_daemons.Text = "Daemons";
            // 
            // label_totalNumOfBackups
            // 
            this.label_totalNumOfBackups.AutoSize = true;
            this.label_totalNumOfBackups.Location = new System.Drawing.Point(173, 310);
            this.label_totalNumOfBackups.Name = "label_totalNumOfBackups";
            this.label_totalNumOfBackups.Size = new System.Drawing.Size(62, 13);
            this.label_totalNumOfBackups.TabIndex = 9;
            this.label_totalNumOfBackups.Text = "placeholder";
            // 
            // label_mostBkType
            // 
            this.label_mostBkType.AutoSize = true;
            this.label_mostBkType.Location = new System.Drawing.Point(145, 343);
            this.label_mostBkType.Name = "label_mostBkType";
            this.label_mostBkType.Size = new System.Drawing.Size(62, 13);
            this.label_mostBkType.TabIndex = 10;
            this.label_mostBkType.Text = "placeholder";
            // 
            // label_daemonWithMostBk
            // 
            this.label_daemonWithMostBk.AutoSize = true;
            this.label_daemonWithMostBk.Location = new System.Drawing.Point(206, 374);
            this.label_daemonWithMostBk.Name = "label_daemonWithMostBk";
            this.label_daemonWithMostBk.Size = new System.Drawing.Size(62, 13);
            this.label_daemonWithMostBk.TabIndex = 11;
            this.label_daemonWithMostBk.Text = "placeholder";
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(400, 482);
            this.Controls.Add(this.label_daemonWithMostBk);
            this.Controls.Add(this.label_mostBkType);
            this.Controls.Add(this.label_totalNumOfBackups);
            this.Controls.Add(this.label_daemons);
            this.Controls.Add(this.label_graphText);
            this.Controls.Add(this.label_daemonMostBkText);
            this.Controls.Add(this.label_mostbkTypeText);
            this.Controls.Add(this.label_backupCountText);
            this.Controls.Add(this.pBox_dList);
            this.Controls.Add(this.pBox_graph);
            this.Controls.Add(this.panel_btnX);
            this.Controls.Add(this.panel_border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stats";
            this.Text = "Stats";
            this.panel_border.ResumeLayout(false);
            this.panel_border.PerformLayout();
            this.panel_btnX.ResumeLayout(false);
            this.panel_btnX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_dList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_border;
        private System.Windows.Forms.Panel panel_btnX;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.Label label_stats;
        private System.Windows.Forms.PictureBox pBox_graph;
        private System.Windows.Forms.PictureBox pBox_dList;
        private System.Windows.Forms.Label label_backupCountText;
        private System.Windows.Forms.Label label_mostbkTypeText;
        private System.Windows.Forms.Label label_daemonMostBkText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_graphText;
        private System.Windows.Forms.Label label_daemons;
        private System.Windows.Forms.Label label_totalNumOfBackups;
        private System.Windows.Forms.Label label_mostBkType;
        private System.Windows.Forms.Label label_daemonWithMostBk;
    }
}