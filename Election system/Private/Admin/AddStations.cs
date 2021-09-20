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
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            DataRowView x = region_box.SelectedItem as DataRowView; 

            Station station = new Station();
            station.Name = name_box.Text;
            station.Rid = int.Parse(x.Row["rid"].ToString());
            station.Save();
        }
    }
}
