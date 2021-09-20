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
    public partial class ViewParty : UserControl
    {
        public ViewParty()
        {
            InitializeComponent();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Election_system.Party party = new Election_system.Party();
                party.Name = search_box.Text;
                Election_system.Party party1 = party.getParty();
                if (party1.HasValue)
                {
                    partyName.Text = party1.Name;
                    MemoryStream ms = new MemoryStream(party1.Logo);
                    logo_img.Image = Image.FromStream(ms);
                }else
                {
                    logo_img.Image = Election_system.Properties.Resources.picture;
                    partyName.Text = "- - -";
                }
            }
            catch (Exception ex)
            {
                logo_img.Image = Election_system.Properties.Resources.picture;
                partyName.Text = "- - -";
            }
        }
    }
}
