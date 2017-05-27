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
        private BindingList<ServerReference.tbDaemon> _data = new BindingList<ServerReference.tbDaemon>();

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

        public ServerReference.tbDaemon GetDaemon(int index)
        {
            return this._data[index];
        }

        public void ShowData(List<ServerReference.tbDaemon> Daemon)
        {
            this._data.Clear();
            foreach (ServerReference.tbDaemon daemon in Daemon)
            {
                this._data.Add(daemon);
            }
        }
        public void UpdateDaemon(int index, ServerReference.tbDaemon d)
        {
            this._data[index] = d;
        }
        public void RemoveDaemon(ServerReference.tbDaemon d)
        {
            this._data.Remove(d);
        }
    }
}
