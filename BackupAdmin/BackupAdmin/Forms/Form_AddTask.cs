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
    public partial class Form_AddTask : Form
    {
        private ServerReference.tbDaemon Daemon { get; set; }
        private ServerReference.Service1Client Client { get; set; }
        public Form_AddTask(ServerReference.Service1Client c,ServerReference.tbDaemon d)
        {
            InitializeComponent();
            Client = c;
            Daemon = d;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            ServerReference.tbTask st = new ServerReference.tbTask();
            ServerReference.tbDestination sd = new ServerReference.tbDestination();

            st.TaskName = this.textBox_TaskName.Text;
            sd.NetSourcePath = this.textBox_SourcePath.Text;
            sd.NetDestinationPath = this.textBox_DestinationPath.Text;
            st.KornExpression = "test";
            sd.Type = "Normal Backup";
            st.DaemonId = Daemon.Id;


            int i = Client.UploadTaskReference(st);
            sd.TaskId = i;
            Client.UploadDestination(sd);        

           
            
            this.DialogResult = DialogResult.OK;    
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
