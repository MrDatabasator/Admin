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
        private int DestinationsTempRow;
        private int DestinationsTempCell;

        private int TimeTick = 0;
        private const int GridRefresh = 3;
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
            RefreshDestinations();
        }
        private void RefreshDestinations()
        {
            if (grid_tasks.CurrentCell != null)
            {
                /*if (grid_destinations.CurrentCell != null)
                {
                    DestinationsTempRow = grid_destinations.CurrentCell.RowIndex;
                    DestinationsTempCell = grid_destinations.CurrentCell.ColumnIndex;
                }*/
                int TempHScrollPos = grid_destinations.HorizontalScrollingOffset;

                _desmodel.ShowData(Client.FindDestinationByTaskId(_model.GetTask(grid_tasks.CurrentRow.Index).Id).ToList());

               /* if(grid_destinations.CurrentCell != null)
                    grid_destinations.CurrentCell = grid_destinations.Rows[DestinationsTempRow].Cells[DestinationsTempCell];*/
                grid_destinations.HorizontalScrollingOffset = TempHScrollPos;
            }
        }
        private void RefreshTasks()
        {
            if (grid_tasks.CurrentCell != null)
            {
                int tempRow = grid_tasks.CurrentCell.RowIndex;
                int TempCell = grid_tasks.CurrentCell.ColumnIndex;
                int TempHScrollPos = grid_tasks.HorizontalScrollingOffset;


                _model.ShowData(Client.GetDeamonTask(Daemon.Id).ToList());

                grid_tasks.CurrentCell = grid_tasks.Rows[tempRow].Cells[TempCell];
                grid_tasks.HorizontalScrollingOffset = TempHScrollPos;
            }
        }

        private void btn_des_remove_Click(object sender, EventArgs e)
        {           

            if (grid_destinations.CurrentCell != null)
            { }
            // kod odstraneni nefunguje :(
               // Client.DeleteDestination(_desmodel.GetDestination(grid_destinations.CurrentRow.Index));
        }

        private void btn_task_remove_Click(object sender, EventArgs e)
        {
            if (grid_tasks.CurrentCell != null)
            { }
            // kod odstraneni nefunguje :(
            //ServerReference.tbTask task = _model.GetTask(grid_tasks.CurrentRow.Index);
            //Client.AutoDeleteTask(task);
        }

        private void tmr_refresh_Tick(object sender, EventArgs e)
        {
            TimeTick++;
            if(TimeTick >= GridRefresh)
            {
                RefreshTasks();
                RefreshDestinations();
                TimeTick = 0;
            }


        }
    }
}
