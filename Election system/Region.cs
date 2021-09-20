using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election_system
{
    class Region
    {
        private int regionID;
        private string name;
        private int population;
        private int stations;
        private int voter;
        private int voted;
        private bool hasValue;

        public int RegionID
        {
            get { return regionID; }
            set { regionID = value; }
        }
        public string Name
        {
            get
            {
                return name;
            }set
            {
                name = value;
            }
        }
        public int Population
        {
            get
            {
                return population;
            }
            set
            {
                population = value;
            }
        }
        public int Stations
        {
            get
            {
                return stations;
            }
            set
            {
                stations = value;
            }
        }
        public int Voter
        {
            get
            {
                return voter;
            }
            set
            {
                voter = value;
            }
        }
        public int Voted
        {
            get
            {
                return voted;
            }
            set
            {
                voted = value;
            }
        }
        public bool HasValue
        {
            set { hasValue = value; }
            get { return hasValue; }
        }

        public Region getDetails()
        {
            RegionDBLayer regionDB = new RegionDBLayer();
            return regionDB.Details(this);
        }
        public Region getRegion()
        {
            RegionDBLayer regionDB = new RegionDBLayer();
            return regionDB.Region(this);
        }
        public DataTable getRegions()
        {
            RegionDBLayer regionDB = new RegionDBLayer();
            return regionDB.Regions();
        }

        public void Save()
        {
            RegionDBLayer regionDB = new RegionDBLayer();
            regionDB.Insert(this);
        }
        public void Update()
        {
            RegionDBLayer regionDB = new RegionDBLayer();
            regionDB.Update(this);
        }
        public void Remove()
        {
            RegionDBLayer regionDB = new RegionDBLayer();
            regionDB.Delete(this);
        }
        public int Size()
        {
            RegionDBLayer regionDB = new RegionDBLayer();
            return regionDB.Size();
        }
        public int Populations()
        {
            RegionDBLayer regionDB = new RegionDBLayer();
            return regionDB.Population();
        }
    }
}
