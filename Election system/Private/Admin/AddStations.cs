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
    public partial class AddStations : UserControl
    {
        public AddStations()
        {
            InitializeComponent();
            Region region = new Region();
            
            region_box.DataSource = region.getRegions();
            region_box.DisplayMember = "rname";
            region_box.ValueMember = "rid";

            Election election = new Election();
            election_box.DataSource = election.getElections();
            election_box.DisplayMember = "ename";
            election_box.ValueMember = "eid";
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            DataRowView x = region_box.SelectedItem as DataRowView;
            DataRowView y = election_box.SelectedItem as DataRowView;

            Station station = new Station();
            station.Name = name_box.Text;
            station.Rid = int.Parse(x.Row["rid"].ToString());
            station.Eid = int.Parse(y.Row["eid"].ToString());
            station.Save();
        }

        private void election_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
