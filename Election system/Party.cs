using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election_system
{
    class Party
    {
        private int pid;
        private string name;
        private byte[] logo;
        private bool hasValue = false;


        public int Pid
        {
            get { return pid; }
            set { pid = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public byte[] Logo
        {
            get { return logo; }
            set { logo = value; }
        }
        public bool HasValue
        {
            get { return hasValue; }
            set { hasValue = value; }
        }

        public void Add()
        {
            PartyDBLayer partyDB = new PartyDBLayer();
            partyDB.Insert(this);
        }
        public void Update()
        {
            PartyDBLayer partyDB = new PartyDBLayer();
            partyDB.Edit(this);
        }
        public void Remove()
        {
            PartyDBLayer partyDB = new PartyDBLayer();
            partyDB.Delete(this);
        }
        public DataTable Parties()
        {
            PartyDBLayer partyDB = new PartyDBLayer();
            return partyDB.Parties();
        }
        public Party getParty()
        {
            PartyDBLayer partyDB = new PartyDBLayer();
            return partyDB.MyParty(this);
        }
        public int Size()
        {
            PartyDBLayer partyDB = new PartyDBLayer();
            return partyDB.Size();
        }
    }
}
