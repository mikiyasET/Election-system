using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Election_system.Private.Voters
{
    public partial class Profile : UserControl
    {
        public Profile(Election_system.Voters v)
        {
            InitializeComponent();
            id_box.Text = v.IDNo.ToString();
            firstName_box.Text = v.FirstName;
            middleName_box.Text = v.MiddleName;
            lastName_box.Text = v.LastName;
            phone_box.Text = v.Phone.ToString();
            birth_box.Text = v.Birth.ToString("MMM, dd yyyy");
            station_box.Text = v.Station.ToString();
        }

        private void id_box_Click(object sender, EventArgs e)
        {

        }
    }
}
