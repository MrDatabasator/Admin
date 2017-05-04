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
    public partial class Form_Task : Form
    {
        private ServerReference.tbDaemon Daemon { get; set; }
        private ServerReference.tbDestination Dest { get; set; }
        private ServerReference.tbTask Task { get; set; }
        private ServerReference.Service1Client Client = new ServerReference.Service1Client();

        private TaskDataModel _model = new TaskDataModel();
        private DestinationDataModel _desmodel = new DestinationDataModel();

        
        public Form_Task()
        {
            InitializeComponent();
            this.grid_tasks.DataSource = _model;
            this.grid_destinations.DataSource = _desmodel;
            SetComponents();
        }
        public void SetComponents()
        {
           // _model.ShowData(Client.GetDeamonTask(Daemon.Id).ToList());
           // _desmodel.ShowData(Client.FindDestinationByTaskId(Task.Id).ToList());                   
        }

        private void btn_addTask_Click(object sender, EventArgs e)
        {
            Form_AddTask Add = new Form_AddTask();
            if (Add.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
