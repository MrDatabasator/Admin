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
        private const int GridRefresh = 3;
        private int TimeTick = 0;
        DaemonDataModel _model = new DaemonDataModel();        
        ServerReference.Service1Client Client { get; set; }

        public Form_Daemons()
        {
            Client = new ServerReference.Service1Client();
            InitializeComponent();
            
            grid_daemons.DataSource = _model;
            chBox_LoadOffline.Checked = true;
            //grid_daemons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            //grid_daemons.AutoResizeColumns();
            //SendDaemonTest();
            //SendStringTest();
            LoadDaemons();
        }

        public void LoadDaemons()
        {
            if (chBox_LoadOffline.Checked)
                _model.ShowData(Client.GetAllDaemons().ToList());
            else
                _model.ShowData(Client.GetAllDaemons()
                    .Where(x => x.LastActive >= DateTime.Now.AddMinutes(-6)).ToList());
        }

        private void btn_manage_MouseClick(object sender, MouseEventArgs e)
        {
            if (grid_daemons.CurrentRow != null)
            {
                Form_Configure fConfig = new Form_Configure(_model.GetDaemon(grid_daemons.CurrentRow.Index));
                if (fConfig.ShowDialog() == DialogResult.OK)
                {
                    LoadDaemons();
                }
            }           
        }       

        private void tmr_refresh_Tick(object sender, EventArgs e)
        {
            TimeTick++;
            if(TimeTick >= GridRefresh)
            {
                try
                {
                    int tempRow = grid_daemons.CurrentCell.RowIndex;
                    int TempCell = grid_daemons.CurrentCell.ColumnIndex;                    
                    int TempHScrollPos = grid_daemons.HorizontalScrollingOffset;
                    LoadDaemons();
                    grid_daemons.CurrentCell = grid_daemons.Rows[tempRow].Cells[TempCell];
                    grid_daemons.HorizontalScrollingOffset = TempHScrollPos;
                    
                }
                catch(Exception ex)
                {
                    LoadDaemons();
                }
                TimeTick = 0;
            }
        }

        private void chBox_LoadOffline_CheckedChanged(object sender, EventArgs e)
        {
            LoadDaemons();
        }
    }
}
