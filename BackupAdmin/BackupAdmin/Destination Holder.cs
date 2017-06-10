using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupAdmin
{
    public class Destination_Holder
    {
        public ServerReference.tbDestination Destination { get; set; }

        public string desToString { get; set; }

        public Destination_Holder(ServerReference.tbDestination des, string message)
        {
            Destination = des;
            message = desToString;
        }
        public override string ToString()
        {
            return desToString;

        }
    }
}
