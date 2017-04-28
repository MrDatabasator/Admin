using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace BackupAdmin
{
    class DestinationDataModel : IListSource
    {
        private BindingList<ServerReference.tbDestination> _data = new BindingList<ServerReference.tbDestination>();

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

        public ServerReference.tbDestination GetDestination(int index)
        {
            return this._data[index];
        }

        public void ShowData(List<ServerReference.tbDestination> Destination)
        {
            this._data.Clear();
            foreach (ServerReference.tbDestination des in Destination)
            {
                this._data.Add(des);
            }
        }
        public void UpdateDaemon(int index, ServerReference.tbDestination t)
        {
            this._data[index] = t;
        }
    }
}