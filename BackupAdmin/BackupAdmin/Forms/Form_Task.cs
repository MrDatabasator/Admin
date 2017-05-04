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
        public Form_Task()
        {
            InitializeComponent();
        }

        private void Form_Task_Load(object sender, EventArgs e)
        {

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
