using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election_system
{
    abstract class Database
    {
        protected string viewer_con = "server=UNKNOWN\\SQLEXPRESS;database=Election;uid=viewer;pwd=views";
        protected string voter_con = "server=UNKNOWN\\SQLEXPRESS;database=Election;uid=voter;pwd=secure";
        protected string admin_con = "server=UNKNOWN\\SQLEXPRESS;database=Election;uid=eadmin;pwd=election";
    }
}
