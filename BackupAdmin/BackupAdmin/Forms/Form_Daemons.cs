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
        public Form_Daemons()
        {
            InitializeComponent();
            DaemonDataModel _model = new DaemonDataModel();
            grid_daemons.DataSource = _model;
            //grid_daemons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            //grid_daemons.AutoResizeColumns();
        }
    }
}
