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
    public partial class ModifyStations : UserControl
    {
        int sid;
        public ModifyStations()
        {
            InitializeComponent();
            Region region = new Region();

            region_box.DataSource = region.getRegions();
            region_box.DisplayMember = "rname";
            region_box.ValueMember = "rid";
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Station x = new Station();
                x.Name = search_box.Text;
                Station station = x.getStation();
                if (station.HasValue)
                {
                    sid = station.Sid;
                    name_box.Text = station.Name;
                    region_box.SelectedValue = station.Rid;
                    region_box.Enabled = true;
                    name_box.Enabled = true;
                    updatebtn.Enabled = true;
                    removebtn.Enabled = true;

                }
                else
                {
                    name_box.Text = "";
                    region_box.Enabled = false;
                    name_box.Enabled = false;
                    updatebtn.Enabled = false;
                    removebtn.Enabled = false;
                }
            }catch
            {
                name_box.Text = "";
                region_box.Enabled = false;
                name_box.Enabled = false;
                updatebtn.Enabled = false;
                removebtn.Enabled = false;

            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            DataRowView x = region_box.SelectedItem as DataRowView;
            Station station = new Station();
            station.Sid = sid;
            station.Name = name_box.Text;
            station.Rid = int.Parse(x.Row["rid"].ToString());
            station.HasValue = true;
            station.Update();
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            Station station = new Station();
            station.Sid = sid;
            station.Remove();
        }
    }
}
