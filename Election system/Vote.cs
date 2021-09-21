using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election_system
{
    class Vote
    {
        private int vid, eid, pid;
        public int Vid
        {
            set { vid = value; }
            get { return vid; }
        }
        public int Eid
        {
            set { eid = value; }
            get { return eid; }
        }
        public int Pid
        {
            set { pid = value; }
            get { return pid; }
        }
        public void VoteNow()
        {
            VoteDBLayer voteDB = new VoteDBLayer();
            voteDB.Insert(this);
        }
        public bool checkEligibility()
        {
            VoteDBLayer voteDB = new VoteDBLayer();
            return voteDB.Check(this);
        }
        public DataTable PartiesByEID()
        {
            VoteDBLayer voteDB = new VoteDBLayer();
            return voteDB.PartiesLead(this);
        }
    }
}
