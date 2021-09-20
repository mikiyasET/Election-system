using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election_system
{
    class Station
    {
        private int sid;
        private string name;
        private int rid;
        private bool hasValue = false;
        public int Sid
        {
            set { sid = value; }
            get { return sid; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Rid
        {
            set { rid = value; }
            get { return rid; }
        }
        public bool HasValue
        {
            set { hasValue = value; }
            get { return hasValue; }
        }

        public DataTable getStations()
        {
            StationDBLayer stationDB = new StationDBLayer();
            return stationDB.stations();
        }
          public Station getStation()
        {
            StationDBLayer stationDB = new StationDBLayer();
            return stationDB.Station(this);
        }
        public void Save()
        {
            StationDBLayer stationDB = new StationDBLayer();
            stationDB.Insert(this);
        }
        public void Update()
        {
            StationDBLayer stationDB = new StationDBLayer();
            stationDB.Update(this);
        }
        public void Remove()
        {
            StationDBLayer stationDB = new StationDBLayer();
            stationDB.Delete(this);
        }
        public int Size()
        {
            StationDBLayer stationDB = new StationDBLayer();
            return stationDB.Size();
        }
    }
}
