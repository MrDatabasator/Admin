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
        private ServerReference.tbDaemon Daemon { get; set; }

        public Form_Configure()
        {
            InitializeComponent();
        }
        public Form_Configure(ServerReference.tbDaemon daemon)
        {
            InitializeComponent();
            Daemon = daemon;
            SetComponents();
        }
        public void SetComponents()
        {
            textBox_daemonName.Text = Daemon.DaemonName;
        }
    }
}
