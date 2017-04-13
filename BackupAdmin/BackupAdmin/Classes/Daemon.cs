using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupAdmin
{
    public class Daemon
    {
        public Daemon(int id, string daemonname, string pcname, string ipaddress)
        {
            Id = id;
            DaemonName = daemonname;
            PcName = pcname;
            IPAddress = ipaddress;
        }
        [Browsable(false)]
        public int Id { get; set; }
        [DisplayName("Daemon Name")]
        public string DaemonName { get; set; }
        [DisplayName("PC Name")]
        public string PcName { get; set; }
        [DisplayName("IP Address")]
        public string IPAddress { get; set; }
        [Browsable(false)]
        public DateTime LastActive { get; set; }
    }
}
