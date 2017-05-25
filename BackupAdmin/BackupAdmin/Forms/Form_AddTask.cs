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
        private string DestinationMode = "Local";
        private List<RadioButton> DesButtons { get; set; }
        private ServerReference.tbDaemon Daemon { get; set; }
        private ServerReference.Service1Client Client { get; set; }
        public Form_AddTask(ServerReference.Service1Client c,ServerReference.tbDaemon d)
        {
            InitializeComponent();
            SetupForm();
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
            sd.Type = DestinationMode;
            st.DaemonId = Daemon.Id;
            sd.FullBackup = true;
            if(DestinationMode == "FTP")
            {
                sd.FtpServerAddress = textBox_ftpSerAddr.Text;
                sd.FtpUsername = textBox_ftpUser.Text;
                sd.FtpPassword = textBox_ftpPass.Text;
            }

            int i = Client.UploadTaskReference(st);
            sd.TaskId = i;
            Client.UploadDestination(sd);    

            this.DialogResult = DialogResult.OK;    
        }
        private void SetupForm()
        {
            DesButtons = new List<RadioButton>();
            DesButtons.Add(radioButton_FTP);
            DesButtons.Add(radioButton_Local);            
            radioButton_Local.Checked = true;
        }
        private void SetCheckedRadioButton(RadioButton button)
        {
            foreach(RadioButton Button in DesButtons)
            {
                if(Button != button)
                    Button.Checked = false;
            }            
            DesModeChanged(button.Text);
        }
        private void DesModeChanged(string mode)
        {
            if(mode == "FTP")
            {
                textBox_ftpSerAddr.Enabled = true;
                textBox_ftpUser.Enabled = true;
                textBox_ftpPass.Enabled = true;
                DestinationMode = "FTP";
            }
            else if(mode == "Local")
            {
                textBox_ftpSerAddr.Enabled = false;
                textBox_ftpUser.Enabled = false;
                textBox_ftpPass.Enabled = false;
                DestinationMode = "Local";
            }
            else
            {

            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }        

        private void radioButton_Local_CheckedChanged(object sender, EventArgs e)
        {
            SetCheckedRadioButton(radioButton_Local);
        }

        private void radioButton_FTP_CheckedChanged(object sender, EventArgs e)
        {
            SetCheckedRadioButton(radioButton_FTP);
        }
    }
}
