﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupAdmin
{
    public partial class Form_Configure : Form
    {
        private TaskDataModel _model = new TaskDataModel();

        private const int GridRefresh = 10;
        private int TimeTick = 0;
        private ServerReference.tbDaemon Daemon { get; set; }
        private ServerReference.Service1Client Client = new ServerReference.Service1Client();

        public Form_Configure()
        {
            InitializeComponent();
            grid_tasks.DataSource = _model;
        }
        public Form_Configure(ServerReference.tbDaemon daemon)
        {
            InitializeComponent();
            grid_tasks.DataSource = _model;
            Daemon = daemon;
            SetComponents();
        }
        public void SetComponents()
        {
            textBox_daemonName.Text = Daemon.DaemonName;
            textBox_sRefreshRate.Text = Daemon.RefreshRate.ToString();
            ShowAllTasks();
        }

        private void ShowAllTasks()
        {
            _model.ShowData(Client.GetDeamonTask(Daemon.Id).ToList());
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Daemon.RefreshRate = Convert.ToInt32(this.textBox_sRefreshRate.Text);
            Daemon.DaemonName = this.textBox_daemonName.Text;
            this.DialogResult = DialogResult.OK;
            Client.UpdateDeamonReference(Daemon.Id, Daemon);
            Client.Close();
        }

        private void btn_viewTasks_Click(object sender, EventArgs e)
        {
            Form_Task Add = new Form_Task(Client,Daemon);
            if (Add.ShowDialog() == DialogResult.OK)
            {
                ShowAllTasks();
            }
        }

        private void tmr_taskRefresh_Tick(object sender, EventArgs e)
        {
            TimeTick++;
            if (TimeTick >= GridRefresh)
            {
                try
                {
                    int tempRow = grid_tasks.CurrentCell.RowIndex;
                    int TempCell = grid_tasks.CurrentCell.ColumnIndex;
                    int TempHScrollPos = grid_tasks.HorizontalScrollingOffset;
                    ShowAllTasks();
                    grid_tasks.CurrentCell = grid_tasks.Rows[tempRow].Cells[TempCell];
                    grid_tasks.HorizontalScrollingOffset = TempHScrollPos;
                }
                catch (Exception ex)
                {
                    ShowAllTasks();
                }
                TimeTick = 0;
            }
        }

    }
}
