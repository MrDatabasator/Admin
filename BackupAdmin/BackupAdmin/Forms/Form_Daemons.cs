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
            Client = new ServerReference.Service1Client();
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
            ServerReference.tbDaemon test = new ServerReference.tbDaemon();
            test.DaemonName = "Daemon1";
            test.PcName = "pc1";
            test.IpAddress = "127.0.0.1";           
            
            //_model.ShowData(new List<ServerReference.tbDaemon>() { Client.GetDaemon(test) });
        }
        public void SendStringTest()
        {            
            //Client.UploadString("Foo Bar");
            Client.UpdateDaemonLastActive(8);
        }
        public void LoadAllDaemons()
        {            
            _model.ShowData(Client.GetAllDaemons().ToList());
        }

        private void btn_manage_MouseClick(object sender, MouseEventArgs e)
        {
            /*try
            {*/
                Form_Configure fConfig = new Form_Configure(_model.GetDaemon(grid_daemons.CurrentRow.Index));
                if (fConfig.ShowDialog() == DialogResult.OK)
                {

                }
            /*}
            catch(Exception ex)
            {

            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _model.ShowData(Client.GetAllDaemons().ToList());
        }
    }
}
