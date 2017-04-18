using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BackupAdmin
{
    class DaemonDataModel : IListSource
    {
        private BindingList<ServerReference.Daemon> _data = new BindingList<ServerReference.Daemon>();

        public bool ContainsListCollection
        {
            get
            {
                return true;
            }
        }
        public bool IsEmpty()
        {
            if (_data.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public IList GetList()
        {
            return this._data;
        }

        public ServerReference.Daemon GetDaemon(int index)
        {
            return this._data[index];
        }

        public void ShowData(List<ServerReference.Daemon> Daemon)
        {
            this._data.Clear();
            foreach (ServerReference.Daemon daemon in Daemon)
            {
                this._data.Add(daemon);
            }
        }
        public void UpdateDaemon(int index, ServerReference.Daemon d)
        {
            this._data[index] = d;
        }
    }
}
