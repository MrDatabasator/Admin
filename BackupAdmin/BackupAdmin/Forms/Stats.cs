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
        private List<ServerReference.tbLog> dataLogs { get; set; }               

        private List<Color> DaemonColors = new List<Color> { Color.DeepSkyBlue, Color.Red, Color.Green, Color.Yellow, Color.Violet, Color.DarkGreen, Color.Gray };

        private List<ServerReference.tbDaemon> Daemons = new List<ServerReference.tbDaemon>();

        private int HighestCount { get; set; }
        private int BackupAxisPointGap { get; set; }

        private const int TimeAxisCount = 7;


        ServerReference.Service1Client Client { get; set; }
        public Stats()
        {
            InitializeComponent();
            GetRequiredData();
            GetGraphDaemons();
            GetStats();          
        }
        private void GetStats()
        {
            label_graphText.Text = "-Graph of Backups done in last " + TimeAxisCount + " days.";
            label_totalNumOfBackups.Text = dataLogs.Count().ToString();
            label_mostBkType.Text = GetMostBackupType();
            label_daemonWithMostBk.Text = GetDaemonWithMostBK();
        }
        private string GetDaemonWithMostBK()
        {
            ServerReference.tbDaemon Daemon = null;
            int bkCounter = 0;
            foreach(ServerReference.tbDaemon daemon in Daemons)
            {
                int daemonCounter = 0;
                foreach(ServerReference.tbLog log in dataLogs)
                {
                    if (log.DaemonId == daemon.Id)
                        daemonCounter++;
                }
                if (daemonCounter >= bkCounter)
                {
                    bkCounter = daemonCounter;
                    Daemon = daemon;
                }                    
            }
            if (Daemon == null)
                return "None";
            else
            {
                Color color;
                if (Daemons.IndexOf(Daemon) >= DaemonColors.Count)
                    color = DaemonColors[bkCounter - 1];
                else
                    color = DaemonColors[Daemons.IndexOf(Daemon)];
                label_daemonWithMostBk.ForeColor = color;
                return Daemon.DaemonName.ToString();

            }
            
        }
        private string GetMostBackupType()
        {
            int LocalCounter = 0;
            int SSHCounter = 0;
            int FTPCounter = 0;

            foreach(ServerReference.tbLog log in dataLogs)
            {
                if (log.Message.ToLower().Contains("local"))
                    LocalCounter++;
                else if (log.Message.ToLower().Contains("ssh"))
                    SSHCounter++;
                else if (log.Message.ToLower().Contains("ftp"))
                    FTPCounter++;
            }
            if (LocalCounter > SSHCounter && LocalCounter > FTPCounter)
                return "Local";
            else if (SSHCounter > LocalCounter && SSHCounter > FTPCounter)
                return "SSH";
            else if (FTPCounter > SSHCounter && FTPCounter > LocalCounter)
                return "FTP";
            return "None";
        }
        private void GetGraphDaemons()
        {
            List<int> dIndexes = new List<int>();
            Client = new ServerReference.Service1Client();
            foreach (ServerReference.tbLog log in dataLogs)
            {
                ServerReference.tbDaemon daemon = Client.GetDaemonById(log.DaemonId);                
                if (!dIndexes.Contains(daemon.Id))
                {
                    Daemons.Add(daemon);
                    dIndexes.Add(daemon.Id);
                }               
            }
            Client.Close();
        }        
        private void DrawListOfDaemons(Graphics g)
        {
            int lHeight = 15;
            Color color;
            for (int i = 0; i < Daemons.Count; i++)
            {                
                if(i >= DaemonColors.Count)
                    color = DaemonColors[DaemonColors.Count - 1];
                else
                    color= DaemonColors[i];
                g.DrawEllipse(new Pen(color, 2), 5, lHeight, 8, 8);
                g.FillEllipse(new SolidBrush(color), 5, lHeight, 8, 8);
                g.DrawString(Daemons[i].DaemonName, SystemFonts.DefaultFont, Brushes.Black, 15, lHeight);
                lHeight += 20;
            }
        }
        private void DrawListOfDaemons(Graphics g, int count)
        {
            int lHeight = 15;
            Color color;
            for (int i = 0; i < count || i < Daemons.Count; i++)
            {
                if (i >= DaemonColors.Count)
                    color = DaemonColors[DaemonColors.Count - 1];
                else
                    color = DaemonColors[i];
                g.DrawEllipse(new Pen(color, 2), 5, lHeight, 8, 8);
                g.FillEllipse(new SolidBrush(color), 5, lHeight, 8, 8);
                g.DrawString(Daemons[i].DaemonName, SystemFonts.DefaultFont, Brushes.Black, 15, lHeight);
                lHeight += 20;
            }
        }
        private int GetDeamonBackupCountByDay(int day)
        {
            int result = 0;
            foreach(ServerReference.tbLog log in dataLogs)
            {
                if (log.Time.Date == DateTime.Today.Date.AddDays(day - TimeAxisCount +1))
                    result++;
            }
            return result;
        }
        private void DrawDaemonBackupGraph(Graphics g)
        {
            for (int i = 0; i < TimeAxisCount; i++)
            {
                g.DrawLine(new Pen(DaemonColors[i], 5), 17 + ((pBox_graph.Width -25) / TimeAxisCount) * (i + 1), pBox_graph.Height - 17, 17 + ((pBox_graph.Width - 25) / TimeAxisCount) * (i + 1), (pBox_graph.Height - 17) - BackupAxisPointGap * GetDeamonBackupCountByDay(i));
            }
                
         
        }
        private void GetRequiredData()
        {
            Client = new ServerReference.Service1Client();
            dataLogs = Client.GetAllStatsLogs().ToList();
            Client.Close();
            List<ServerReference.tbLog> ToDelete = new List<ServerReference.tbLog>();
            foreach(ServerReference.tbLog item in dataLogs)
            {
                if(item.Time.Date < DateTime.Today.Date.AddDays(-TimeAxisCount))
                {
                    ToDelete.Add(item);
                }
            }
            foreach(ServerReference.tbLog log in ToDelete)
            {
                dataLogs.Remove(log);
            }
            HighestCount = GetHighestCount();
            BackupAxisPointGap = (pBox_graph.Height - 25) / HighestCount;
        }
        private int GetHighestCount()
        {
            int result = 0;
            for(int i = 0; i < TimeAxisCount; i++)
            {
                int a = GetDeamonBackupCountByDay(i);
                if (result <= a)
                    result = a;
            }
            return result;              
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

        private void pBox_graph_Paint(object sender, PaintEventArgs e)
        {            
            DrawGraphAxies(e.Graphics);
            DrawGraphCheckpoints(e.Graphics);
            DrawDaemonBackupGraph(e.Graphics);
        }

        private void pBox_dList_Paint(object sender, PaintEventArgs e)
        {
            DrawListOfDaemons(e.Graphics);
        }              
        
        private void DrawGraphAxies(Graphics g)
        {
            g.DrawLine(Pens.Black, 15, 10, 15, pBox_graph.Height - 10);
            g.DrawLine(Pens.Black, 10, pBox_graph.Height - 15, pBox_graph.Width - 10, pBox_graph.Height - 15);
        }
        private void DrawGraphCheckpoints(Graphics g)
        {//backup axis
            for(int i = 0; i <= HighestCount; i++)
            {
                g.DrawEllipse(Pens.Black, 15 - 2, (pBox_graph.Height - 15 - 2)-BackupAxisPointGap * i, 3, 3);
                g.FillEllipse(Brushes.Black, 15 - 2, (pBox_graph.Height - 15 - 2) - BackupAxisPointGap * i, 3, 3);
                if (i == 0)
                {
                    g.DrawString(i.ToString(), SystemFonts.DefaultFont, Brushes.Black, 5, pBox_graph.Height - 15);
                }
                else
                {
                    g.DrawString(i.ToString(), SystemFonts.DefaultFont, Brushes.Black, 3, (pBox_graph.Height - 20) - BackupAxisPointGap*i);
                }

            }
            //time axis
            for(int i = 0; i <= TimeAxisCount;i++ )
            {
                if (i == 0) { }
                else
                {
                    g.DrawEllipse(Pens.Black, 15 + ((pBox_graph.Width - 25) / TimeAxisCount) * i, (pBox_graph.Height - 17), 3, 3);
                    g.FillEllipse(Brushes.Black, 15 + ((pBox_graph.Width - 25) / TimeAxisCount) * i, (pBox_graph.Height - 17), 3, 3);
                    g.DrawString(DateTime.Today.AddDays(-(TimeAxisCount - i)).Day + "." + DateTime.Today.AddDays(-(TimeAxisCount - i)).Month, SystemFonts.DefaultFont, Brushes.Black, 5 + ((pBox_graph.Width - 25) / TimeAxisCount ) * i, (pBox_graph.Height - 13));
                }
            }
        }
        
    }
}
