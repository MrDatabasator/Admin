﻿namespace BackupAdmin
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
            this.grid_daemons = new System.Windows.Forms.DataGridView();
            this.btn_manage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_daemons)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_daemons
            // 
            this.grid_daemons.AllowUserToAddRows = false;
            this.grid_daemons.AllowUserToDeleteRows = false;
            this.grid_daemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_daemons.Location = new System.Drawing.Point(0, 0);
            this.grid_daemons.Margin = new System.Windows.Forms.Padding(2);
            this.grid_daemons.Name = "grid_daemons";
            this.grid_daemons.ReadOnly = true;
            this.grid_daemons.RowTemplate.Height = 24;
            this.grid_daemons.Size = new System.Drawing.Size(511, 321);
            this.grid_daemons.TabIndex = 0;
            // 
            // btn_manage
            // 
            this.btn_manage.Location = new System.Drawing.Point(444, 325);
            this.btn_manage.Margin = new System.Windows.Forms.Padding(2);
            this.btn_manage.Name = "btn_manage";
            this.btn_manage.Size = new System.Drawing.Size(56, 24);
            this.btn_manage.TabIndex = 1;
            this.btn_manage.Text = "Manage";
            this.btn_manage.UseVisualStyleBackColor = true;
            this.btn_manage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_manage_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Daemons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_manage);
            this.Controls.Add(this.grid_daemons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Daemons";
            this.Text = "Daemons";
            ((System.ComponentModel.ISupportInitialize)(this.grid_daemons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_daemons;
        private System.Windows.Forms.Button btn_manage;
        private System.Windows.Forms.Button button1;
    }
}