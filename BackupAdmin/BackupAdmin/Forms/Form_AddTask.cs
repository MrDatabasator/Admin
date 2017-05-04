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
        public Form_AddTask()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            ServerReference.tbTask st = new ServerReference.tbTask();
            ServerReference.tbDestination sd = new ServerReference.tbDestination();
            st.TaskName = this.textBox_TaskName.Text;
            sd.NetSourcePath = this.textBox_SourcePath.Text;
            sd.NetDestinationPath = this.textBox_DestinationPath.Text;            
        }
    }
}
