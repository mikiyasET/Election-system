using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election_system
{
    class Voters
    {
        public string firstName;
        public string middleName;
        public string lastName;
        public string password;
        public int phone;
        public DateTime birth;
        public string IDNo;
        public string IDImage;
        public Voters()
        {

        }
        public Voters(string firstName,string middleName,string lastName,int phone,DateTime birth,string IDNo,string IDImage)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.phone = phone;
            this.birth = birth;
            this.IDNo = IDNo;
            this.IDImage = IDImage;
        }

        public void Save()
        {
            VotersDBLayer v = new VotersDBLayer();
            v.Insert(this);
        }
        public void Update()
        {
            VotersDBLayer v = new VotersDBLayer();
            v.Update(this);
        }
        public void Remove()
        {
            VotersDBLayer v = new VotersDBLayer();
            v.Delete(this);
        }
        public void Login()
        {
            VotersDBLayer v = new VotersDBLayer();
            v.signIn(this);
        }
    }
}
