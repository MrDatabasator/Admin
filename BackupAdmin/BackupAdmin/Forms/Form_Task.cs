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
        public Form_Task(ServerReference.Service1Client c,ServerReference.tbDaemon d)
        {
            Daemon = d;
            Client = c;
            InitializeComponent();
            this.grid_tasks.DataSource = _model;
            this.grid_destinations.DataSource = _desmodel;
            SetComponents();
        }

        private ServerReference.tbDaemon Daemon { get; set; }
        private ServerReference.tbDestination Dest { get; set; }
        private ServerReference.tbTask Task { get; set; }
        private ServerReference.Service1Client Client { get; set; }

        private TaskDataModel _model = new TaskDataModel();
        private DestinationDataModel _desmodel = new DestinationDataModel();

        
        public void SetComponents()
        {
            _model.ShowData(Client.GetDeamonTask(Daemon.Id).ToList());                            
        }

        private void btn_addTask_Click(object sender, EventArgs e)
        {
            Form_AddTask Add = new Form_AddTask(Client,Daemon);
            if (Add.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void grid_tasks_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _desmodel.ShowData(Client.FindDestinationByTaskId(_model.GetTask(grid_tasks.CurrentRow.Index).Id).ToList());
        }
    }
}
