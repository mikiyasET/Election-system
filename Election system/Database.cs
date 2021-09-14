using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election_system
{
    abstract class Database
    {
        protected string constr = "server=UNKNOWN\\SQLEXPRESS;database=Election;uid=lab;pwd=123";
    }
}
