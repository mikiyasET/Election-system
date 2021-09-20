using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election_system
{
    class Voters
    {
        private int vid;
        private string firstName;
        private string middleName;
        private string lastName;
        private string password;
        private int phone;
        private DateTime birth;
        private string idNo;
        private byte[] idImage;
        private int station;

        public int Vid
        {
            get { return vid; }
            set { vid = value; }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string MiddleName
        {
            get
            {
                return middleName;
            }
            set
            {
                middleName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public int Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }
        public DateTime Birth
        {
            get
            {
                return birth;
            }
            set
            {
                birth = value;
            }
        }
        public string IDNo
        {
            get
            {
                return idNo;
            }
            set
            {
                idNo = value;
            }
        }
        public byte[] IDImage
        {
            get
            {
                return idImage;
            }
            set
            {
                idImage = value;
            }
        }
        public int Station
        {
            get
            {
                return station;
            }
            set
            {
                station = value;
            }
        }

        public Voters()
        {

        }
        public Voters(string firstName, string middleName, string lastName, int phone, DateTime birth, string IDNo, byte[] IDImage,int station)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.phone = phone;
            this.birth = birth;
            this.IDNo = IDNo;
            this.IDImage = IDImage;
            this.station = station;
        }

        public void Save()
        {
            VotersDBLayer votersDB = new VotersDBLayer();
            votersDB.Insert(this);
        }
        public void Update()
        {
            VotersDBLayer votersDB = new VotersDBLayer();
            votersDB.Update(this);
        }
        public void Remove()
        {
            VotersDBLayer votersDB = new VotersDBLayer();
            votersDB.Delete(this);
        }
        public void Login()
        {
            VotersDBLayer votersDB = new VotersDBLayer();
            votersDB.signIn(this);
        }
        public Voters getVoter()
        {
            VotersDBLayer votersDB = new VotersDBLayer();
            return votersDB.Voter(this);
        }
        public int Size()
        {
            VotersDBLayer votersDB = new VotersDBLayer();
            return votersDB.Size();
        }
    }
}
