using System;
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
            _model.ShowData(Client.GetDeamonTask(Daemon.Id).ToList());
        }
    }
}
