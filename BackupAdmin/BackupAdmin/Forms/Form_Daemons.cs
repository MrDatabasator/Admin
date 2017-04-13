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
    public partial class Form_Daemons : Form
    {
        DaemonDataModel _model = new DaemonDataModel();
        public Form_Daemons()

        {
            InitializeComponent();
            
            grid_daemons.DataSource = _model;
            //grid_daemons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            //grid_daemons.AutoResizeColumns();
            Test();
        }
        public void Test()
        {
            ServerReference.Service1Client Client = new ServerReference.Service1Client();
            Daemon test = new Daemon(1, "nejvíc top daemon", "PCdoma", "127.0.0.1");
            
            //Client.GetDaemon(((object)test) as ServerReference.Daemon);
            _model.ShowData(new List<Daemon>() { ((object)Client.GetDaemon(((object)test) as ServerReference.Daemon)) as Daemon });
        }
    }
}
