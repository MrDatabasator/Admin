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
        private List<string> WeekDays = new List<string> { "MON", "TUE", "WEN", "THU", "FRI", "SAT", "SUN" };
        private string DestinationMode = "Local";
        private string LoopMode = string.Empty;        
        private ServerReference.tbDaemon Daemon { get; set; }
        private ServerReference.Service1Client Client { get; set; }
        public Form_AddTask(ServerReference.tbDaemon d)
        {
            InitializeComponent();
            SetupForm();            
            Daemon = d;            
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (listBox_destinations.Items.Count > 0)
            {
                ServerReference.tbTask st = new ServerReference.tbTask();
                st.DaemonId = Daemon.Id;
                st.TaskName = textBox_TaskName.Text;
                st.KornExpression = CronCreator();

                Client = new ServerReference.Service1Client();
                int i = Client.UploadTaskReference(st);

                foreach (ServerReference.tbDestination des in listBox_destinations.Items)
                {
                    des.TaskId = i;
                    Client.UploadDestination(des);
                }                   
                Client.Close();

                this.DialogResult = DialogResult.OK;
            }   
            else
            {
                MessageBox.Show("No destination could be found, please create and add your new destinations", "Error");
            }
        }
        private void SetupForm()
        {
            ClearDesConfig();

            dtpicker_Time.Format = DateTimePickerFormat.Custom;
            dtpicker_Time.CustomFormat = "HH':'mm':'ss";

            dtpicker_date.Format = DateTimePickerFormat.Custom;
            dtpicker_date.CustomFormat = "d'.'MMMM'.'yyyy";

            LoopMode = string.Empty;
            dtpicker_date.Enabled = true;
            radioButton_dailyloop.Checked = true;
            chListBox_days.Enabled = true;
            chListBox_days.CheckOnClick = true;
            foreach (string day in WeekDays)
                chListBox_days.Items.Add(day, true);
            radioButton_dailyloop.Enabled = false;
            radioButton_monthlyloop.Enabled = false;
            radioButton_weeklyloop.Enabled = false;
        }
        /*private void SetCheckedRadioButton(RadioButton button)
        {
            foreach(RadioButton Button in DesButtons)
            {
                if(Button != button)
                    Button.Checked = false;
            }            
            DesModeChanged(button.Text);
        }*/
        private void DesModeChanged(string mode)
        {
            if(mode == "FTP")
            {
                label_des.Text = "Destination Path";
                label_username.Text = "FTP Username";
                label_password.Text = "FTP Password";
                label_address.Text = "FTP Server Address";
                textBox_ftpSerAddr.Enabled = true;
                textBox_ftpUser.Enabled = true;
                textBox_ftpPass.Enabled = true;
                textBox_workingDir.Enabled = false;
                DestinationMode = "FTP";
            }
            else if(mode == "Local")
            {
                label_des.Text = "Destination Path";
                label_username.Text = "Username";
                label_password.Text = "Password";
                label_address.Text = "Server Address";
                textBox_ftpSerAddr.Enabled = false;
                textBox_ftpUser.Enabled = false;
                textBox_ftpPass.Enabled = false;
                textBox_workingDir.Enabled = false;
                DestinationMode = "Local";
            }
            else if (mode == "SSH")
            {
                label_des.Text = "Port";
                label_username.Text = "SSH Username";
                label_password.Text = "SSH Password";
                label_address.Text = "SSH Hostname";
                textBox_ftpSerAddr.Enabled = true;
                textBox_ftpUser.Enabled = true;
                textBox_ftpPass.Enabled = true;
                textBox_workingDir.Enabled = true;
                DestinationMode = "SSH";
            }
        }
        private void LoopModeChanged(string mode)
        {
            if(mode == "Daily")
            {
                dtpicker_date.Enabled = false;
                chListBox_days.Enabled = true;
            }
            else if (mode == "Monthly" || mode == "Weekly")
            {
                dtpicker_date.Enabled = true;
                chListBox_days.Enabled = false;
            }
            
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }        

        private void radioButton_Local_CheckedChanged(object sender, EventArgs e)
        {
            DesModeChanged("Local");
          
        }

        private void radioButton_FTP_CheckedChanged(object sender, EventArgs e)
        {
            DesModeChanged("FTP");         
        }

        private void radioButton_SSH_CheckedChanged(object sender, EventArgs e)
        {
            DesModeChanged("SSH");
        }

       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }       
        private string CronCreator()
        {
            string ReturnCron = string.Empty;

            if (!this.checkBox_loop.Checked)
            {
                ReturnCron = dtpicker_Time.Value.Second + " " + dtpicker_Time.Value.Minute +
                    " " + dtpicker_Time.Value.Hour + " " + dtpicker_date.Value.Day + " " +
                    dtpicker_date.Value.Month + " " + "?" + " " + dtpicker_date.Value.Year;
            }
            else
            {
                
                if (LoopMode == "Daily")
                {
                    string Days = "";
                    if (chListBox_days.CheckedItems.Count > 0)
                    {
                        foreach (string s in chListBox_days.CheckedItems)
                            Days += s + ",";
                        Days.Remove(Days.Length - 1, 1);

                        ReturnCron = dtpicker_Time.Value.Second + " " + dtpicker_Time.Value.Minute +
                            " " + dtpicker_Time.Value.Hour + " " + "?" +" " + "*" +" " + Days;
                    }
                    else
                    {
                        ReturnCron = string.Empty;                        
                    }                    
                }
                else if(LoopMode == "Weekly")
                {
                    ReturnCron = dtpicker_Time.Value.Second + " " + dtpicker_Time.Value.Minute +
                            " " + dtpicker_Time.Value.Hour + " " + dtpicker_date.Value.Day + "/7" +
                            " " + "*" + " " + "?";
                }
                else if (LoopMode == "Monthly")
                {
                    ReturnCron = dtpicker_Time.Value.Second + " " + dtpicker_Time.Value.Minute +
                            " " + dtpicker_Time.Value.Hour + " " + dtpicker_date.Value.Day +
                            " " + "*" + " " + "?";
                }
            }
            
            return ReturnCron;
        }
        private void radioButton_dailyloop_CheckedChanged(object sender, EventArgs e)
        {
            LoopModeChanged("Daily");
        }

        private void radioButton_weeklyloop_CheckedChanged(object sender, EventArgs e)
        {
            LoopModeChanged("Weekly");
        }

        private void radioButton_monthlyloop_CheckedChanged(object sender, EventArgs e)
        {
            LoopModeChanged("Monthly");
        }

        private void checkBox_loop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_loop.Checked)
            {
                dtpicker_date.Enabled = true;
                chListBox_days.Enabled = true;
                radioButton_dailyloop.Enabled = true;
                radioButton_monthlyloop.Enabled = true;
                radioButton_weeklyloop.Enabled = true;
                radioButton_dailyloop.Checked = true;
            }
            else
            {
                LoopMode = string.Empty;
                dtpicker_date.Enabled = true;
                chListBox_days.Enabled = false;
                radioButton_dailyloop.Enabled = false;
                radioButton_monthlyloop.Enabled = false;
                radioButton_weeklyloop.Enabled = false;
            }
        }
        private void ClearDesConfig()
        {
            DesModeChanged("Local");
            radioButton_Local.Checked = true;

            textBox_DestinationPath.Text = string.Empty;
            textBox_ftpPass.Text = string.Empty;
            textBox_ftpSerAddr.Text = string.Empty;
            textBox_ftpUser.Text = string.Empty;
            textBox_SourcePath.Text = string.Empty;
            textBox_workingDir.Text = string.Empty;
        }

        private void btn_ClearDesConfig_Click(object sender, EventArgs e)
        {
            ClearDesConfig();
        }

        private void btn_addDes_Click(object sender, EventArgs e)
        {            
            ServerReference.tbDestination sd = new ServerReference.tbDestination();           
            sd.NetSourcePath = this.textBox_SourcePath.Text;
            sd.NetDestinationPath = this.textBox_DestinationPath.Text;            
            sd.Type = DestinationMode;            
            sd.FullBackup = true;
            if (DestinationMode == "FTP" || DestinationMode == "SSH")
            {
                sd.FtpServerAddress = textBox_ftpSerAddr.Text;
                sd.FtpUsername = textBox_ftpUser.Text;
                sd.FtpPassword = textBox_ftpPass.Text;
                sd.WorkingDirectory = textBox_workingDir.Text;
            }           
            
            listBox_destinations.Items.Add(sd);
            ClearDesConfig();         
        }

        private void btn_removeDes_Click(object sender, EventArgs e)
        {
            if (listBox_destinations.Items.Count > 0)
                listBox_destinations.Items.RemoveAt(listBox_destinations.SelectedIndex);
        }

          
    }
}
