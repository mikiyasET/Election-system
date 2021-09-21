using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Election_system.Private.Admin
{
    public partial class ViewStations : UserControl
    {
        public ViewStations()
        {
            InitializeComponent();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Station s = new Station();
                s.Name = search_box.Text;
                Station station = s.getStation();
                if (station.HasValue)
                {
                    name_box.Text = station.Name;
                    region_box.Text = station.Rid.ToString();
                    election_box.Text = station.Eid.ToString();
                }
                else
                {
                    name_box.Text = "- - -";
                    region_box.Text = "- - -";
                    election_box.Text = "- - -";
                }
            }
            catch
            {
                name_box.Text = "- - -";
                region_box.Text = "- - -";
                election_box.Text = "- - -";

            }
        }
    }
}
