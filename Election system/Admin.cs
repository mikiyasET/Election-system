using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election_system
{
    public class Admin
    {
        public string username;
        public string password;

        public Admin () { }
        public Admin(string username,string password)
        {
            this.username = username;
            this.password = password;
        }
        public void Login()
        {
            AdminDBLayer adminDB = new AdminDBLayer();
            adminDB.signIn(this);
        }
        public bool CheckUsername()
        {
            AdminDBLayer adminDB = new AdminDBLayer();
            return adminDB.Exist(this);
        }
    }
}
