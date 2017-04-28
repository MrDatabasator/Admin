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
        ServerReference.Service1Client Client { get; set; }
        public Form_Daemons()
        {
            InitializeComponent();
            
            grid_daemons.DataSource = _model;
            //grid_daemons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            //grid_daemons.AutoResizeColumns();
            //SendDaemonTest();
            //SendStringTest();
            LoadAllDaemons();
        }
        public void SendDaemonTest()
        {
            Client = new ServerReference.Service1Client();
            ServerReference.tbDaemon test = new ServerReference.tbDaemon();
            test.DaemonName = "Daemon1";
            test.PcName = "pc1";
            test.IpAddress = "127.0.0.1";

            //Client.GetDaemon(((object)test) as ServerReference.Daemon);
            
            //_model.ShowData(new List<ServerReference.tbDaemon>() { Client.GetDaemon(test) });
        }
        public void SendStringTest()
        {
            Client = new ServerReference.Service1Client();
            //Client.UploadString("Foo Bar");
            Client.UpdateDaemonLastActive(8);
        }
        public void LoadAllDaemons()
        {
            Client = new ServerReference.Service1Client();
            _model.ShowData(Client.GetAllDaemons().ToList());
        }
    }
}
