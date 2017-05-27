using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BackupAdmin
{
    class TaskDataModel : IListSource
    {
        private BindingList<ServerReference.tbTask> _data = new BindingList<ServerReference.tbTask>();

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

        public ServerReference.tbTask GetTask(int index)
        {
            return this._data[index];
        }

        public void ShowData(List<ServerReference.tbTask> Task)
        {
            this._data.Clear();
            foreach (ServerReference.tbTask task in Task)
            {
                this._data.Add(task);
            }
        }
        public void UpdateDaemon(int index, ServerReference.tbTask t)
        {
            this._data[index] = t;
        }
        public void RemoveTask(ServerReference.tbTask t)
        {
            this._data.Remove(t);
        }
    }
}
