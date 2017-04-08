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
            this.grid_daemons = new System.Windows.Forms.DataGridView();
            this.btn_manage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_daemons)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_daemons
            // 
            this.grid_daemons.AllowUserToAddRows = false;
            this.grid_daemons.AllowUserToDeleteRows = false;
            this.grid_daemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_daemons.Location = new System.Drawing.Point(0, 0);
            this.grid_daemons.Name = "grid_daemons";
            this.grid_daemons.ReadOnly = true;
            this.grid_daemons.RowTemplate.Height = 24;
            this.grid_daemons.Size = new System.Drawing.Size(394, 395);
            this.grid_daemons.TabIndex = 0;
            // 
            // btn_manage
            // 
            this.btn_manage.Location = new System.Drawing.Point(308, 401);
            this.btn_manage.Name = "btn_manage";
            this.btn_manage.Size = new System.Drawing.Size(75, 29);
            this.btn_manage.TabIndex = 1;
            this.btn_manage.Text = "Manage";
            this.btn_manage.UseVisualStyleBackColor = true;
            // 
            // Form_Daemons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 436);
            this.Controls.Add(this.btn_manage);
            this.Controls.Add(this.grid_daemons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
    }
}