using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election_system
{
    class Election
    {
        private int eid;
        private string name;
        private DateTime starting;
        private DateTime ending;
        private bool hasValue;
        public int Eid { 
            get { return eid; }
            set { eid = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime Starting {
            get { return starting; }
            set { starting = value; }
        }
        public DateTime Ending {
            get { return ending; }
            set { ending = value; }
        }
        public bool HasValue
        {
            set { hasValue = value; }
            get { return hasValue; }
        }

        public void Save()
        {
            ElectionDBLayer electionDB = new ElectionDBLayer();
            electionDB.Insert(this);
        }
        public void Update()
        {
            ElectionDBLayer electionDB = new ElectionDBLayer();
            electionDB.Update(this);
        }
        public void Remove()
        {
            ElectionDBLayer electionDB = new ElectionDBLayer();
            electionDB.Delete(this);
        }
        public Election getElection()
        {
            ElectionDBLayer electionDB = new ElectionDBLayer();
            return electionDB.Election(this);
        }
        public DataTable getElections()
        {
            ElectionDBLayer electionDB = new ElectionDBLayer();
            return electionDB.Elections();
        }
    }
}
