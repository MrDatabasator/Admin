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
    public partial class Stats : Form
    {
        private string[,] FinalData { get; set; }






        public Stats()
        {
            InitializeComponent();
        }


#region control
        private void panel_btnX_MouseMove(object sender, MouseEventArgs e)
        {
            panel_btnX.BackColor = Color.OrangeRed;
        }

        private void panel_btnX_MouseLeave(object sender, EventArgs e)
        {
            panel_btnX.BackColor = System.Drawing.SystemColors.ScrollBar;
        }

        private void label_x_MouseMove(object sender, MouseEventArgs e)
        {
            panel_btnX.BackColor = Color.OrangeRed;
        }

        private void label_x_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void panel_btnX_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        #endregion

       
    }
}
