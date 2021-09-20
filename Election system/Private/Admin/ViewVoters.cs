using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Election_system.Private.Admin
{
    public partial class ViewVoters : UserControl
    {
        public ViewVoters()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = false;
                Election_system.Voters vdata = new Election_system.Voters();
                vdata.IDNo = search_box.Text;
                Election_system.Voters voter = vdata.getVoter();
                check = voter.FirstName == null ? false : true;
                firstName_txt.Text = check ? voter.FirstName : "---";
                middleName_txt.Text = check ? voter.MiddleName : "---";
                lastName_txt.Text = check ? voter.LastName : "---";
                phone_txt.Text = check ? voter.Phone.ToString() : "---";
                birth_txt.Text = check ? voter.Birth.ToString("MMM, dd yyyy") : "---";
                station_txt.Text = check ? voter.Station.ToString() : "---";
                idno_txt.Text = check ? voter.IDNo : "---";
                MemoryStream ms = new MemoryStream(voter.IDImage);
                idcard_image.Image = Image.FromStream(ms);
            }catch (ArgumentException ex)
            {
                idcard_image.Image = Election_system.Properties.Resources.id_card;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
