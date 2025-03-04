﻿namespace BackupAdmin
{
    partial class Form_Task
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
            this.grid_tasks = new System.Windows.Forms.DataGridView();
            this.grid_destinations = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_des_remove = new System.Windows.Forms.Button();
            this.btn_addTask = new System.Windows.Forms.Button();
            this.groupBox_tasks = new System.Windows.Forms.GroupBox();
            this.btn_task_remove = new System.Windows.Forms.Button();
            this.groupBox_destinations = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tmr_refresh = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grid_tasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_destinations)).BeginInit();
            this.groupBox_tasks.SuspendLayout();
            this.groupBox_destinations.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_tasks
            // 
            this.grid_tasks.AllowUserToAddRows = false;
            this.grid_tasks.AllowUserToDeleteRows = false;
            this.grid_tasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_tasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_tasks.Location = new System.Drawing.Point(4, 17);
            this.grid_tasks.Margin = new System.Windows.Forms.Padding(2);
            this.grid_tasks.Name = "grid_tasks";
            this.grid_tasks.ReadOnly = true;
            this.grid_tasks.RowTemplate.Height = 24;
            this.grid_tasks.Size = new System.Drawing.Size(342, 203);
            this.grid_tasks.TabIndex = 0;
            this.grid_tasks.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_tasks_CellMouseClick);
            // 
            // grid_destinations
            // 
            this.grid_destinations.AllowUserToAddRows = false;
            this.grid_destinations.AllowUserToDeleteRows = false;
            this.grid_destinations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_destinations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_destinations.Location = new System.Drawing.Point(4, 17);
            this.grid_destinations.Margin = new System.Windows.Forms.Padding(2);
            this.grid_destinations.Name = "grid_destinations";
            this.grid_destinations.ReadOnly = true;
            this.grid_destinations.RowTemplate.Height = 24;
            this.grid_destinations.Size = new System.Drawing.Size(342, 203);
            this.grid_destinations.TabIndex = 4;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Location = new System.Drawing.Point(295, 500);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(60, 24);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_save_MouseClick);
            // 
            // btn_des_remove
            // 
            this.btn_des_remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_des_remove.Location = new System.Drawing.Point(166, 500);
            this.btn_des_remove.Margin = new System.Windows.Forms.Padding(2);
            this.btn_des_remove.Name = "btn_des_remove";
            this.btn_des_remove.Size = new System.Drawing.Size(60, 24);
            this.btn_des_remove.TabIndex = 6;
            this.btn_des_remove.Text = "Remove";
            this.btn_des_remove.UseVisualStyleBackColor = true;
            this.btn_des_remove.Click += new System.EventHandler(this.btn_des_remove_Click);
            // 
            // btn_addTask
            // 
            this.btn_addTask.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_addTask.Location = new System.Drawing.Point(286, 225);
            this.btn_addTask.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addTask.Name = "btn_addTask";
            this.btn_addTask.Size = new System.Drawing.Size(60, 24);
            this.btn_addTask.TabIndex = 7;
            this.btn_addTask.Text = "Add Task";
            this.btn_addTask.UseVisualStyleBackColor = true;
            this.btn_addTask.Click += new System.EventHandler(this.btn_addTask_Click);
            // 
            // groupBox_tasks
            // 
            this.groupBox_tasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_tasks.Controls.Add(this.btn_task_remove);
            this.groupBox_tasks.Controls.Add(this.btn_addTask);
            this.groupBox_tasks.Controls.Add(this.grid_tasks);
            this.groupBox_tasks.Location = new System.Drawing.Point(2, 10);
            this.groupBox_tasks.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_tasks.Name = "groupBox_tasks";
            this.groupBox_tasks.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_tasks.Size = new System.Drawing.Size(351, 256);
            this.groupBox_tasks.TabIndex = 8;
            this.groupBox_tasks.TabStop = false;
            this.groupBox_tasks.Text = "Tasks";
            // 
            // btn_task_remove
            // 
            this.btn_task_remove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_task_remove.Location = new System.Drawing.Point(222, 225);
            this.btn_task_remove.Margin = new System.Windows.Forms.Padding(2);
            this.btn_task_remove.Name = "btn_task_remove";
            this.btn_task_remove.Size = new System.Drawing.Size(60, 24);
            this.btn_task_remove.TabIndex = 11;
            this.btn_task_remove.Text = "Remove";
            this.btn_task_remove.UseVisualStyleBackColor = true;
            this.btn_task_remove.Click += new System.EventHandler(this.btn_task_remove_Click);
            // 
            // groupBox_destinations
            // 
            this.groupBox_destinations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_destinations.Controls.Add(this.grid_destinations);
            this.groupBox_destinations.Location = new System.Drawing.Point(4, 271);
            this.groupBox_destinations.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_destinations.Name = "groupBox_destinations";
            this.groupBox_destinations.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_destinations.Size = new System.Drawing.Size(351, 225);
            this.groupBox_destinations.TabIndex = 9;
            this.groupBox_destinations.TabStop = false;
            this.groupBox_destinations.Text = "Destinations";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.Location = new System.Drawing.Point(230, 500);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(60, 24);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // tmr_refresh
            // 
            this.tmr_refresh.Enabled = true;
            this.tmr_refresh.Interval = 1000;
            this.tmr_refresh.Tick += new System.EventHandler(this.tmr_refresh_Tick);
            // 
            // Form_Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 529);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.groupBox_destinations);
            this.Controls.Add(this.groupBox_tasks);
            this.Controls.Add(this.btn_des_remove);
            this.Controls.Add(this.btn_save);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(676, 757);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(213, 563);
            this.Name = "Form_Task";
            this.Text = "Tasks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Task_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grid_tasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_destinations)).EndInit();
            this.groupBox_tasks.ResumeLayout(false);
            this.groupBox_destinations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_tasks;
        private System.Windows.Forms.DataGridView grid_destinations;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_des_remove;
        private System.Windows.Forms.Button btn_addTask;
        private System.Windows.Forms.GroupBox groupBox_tasks;
        private System.Windows.Forms.GroupBox groupBox_destinations;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_task_remove;
        private System.Windows.Forms.Timer tmr_refresh;
    }
}