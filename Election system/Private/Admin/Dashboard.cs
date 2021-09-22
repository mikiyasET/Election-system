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
    public partial class Dashboard : UserControl
    {
        Election_system.Voters voters = new Election_system.Voters();
        Party party = new Party();
        Station station = new Station();
        Region region = new Region();

        public Dashboard()
        {
            InitializeComponent();
            voters_no.Text = String.Format("{0:n0}", voters.Size());
            parties_no.Text = String.Format("{0:n0}", party.Size());
            stations_no.Text = String.Format("{0:n0}", station.Size());
            regions_no.Text = String.Format("{0:n0}", region.Size());
            population_no.Text = String.Format("{0:n0}", region.Populations());
        }

        private void livefeed_Tick(object sender, EventArgs e)
        {
            voters_no.Text = String.Format("{0:n0}", voters.Size()); // 100,000
            parties_no.Text = String.Format("{0:n0}", party.Size());
            stations_no.Text = String.Format("{0:n0}", station.Size());
            regions_no.Text = String.Format("{0:n0}", region.Size());
            population_no.Text = String.Format("{0:n0}", region.Populations());
        }
    }
}
