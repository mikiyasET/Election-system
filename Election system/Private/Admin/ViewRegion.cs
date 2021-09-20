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
    public partial class ViewRegion : UserControl
    {
        public ViewRegion()
        {
            InitializeComponent();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Region r = new Region();
                r.Name = search_box.Text;
                Region region = r.getRegion();
                if (region.HasValue)
                {
                    name.Text = region.Name;
                    population.Text = String.Format("{0:n0}", region.Population);
                }
                else
                {
                    name.Text = "- - -";
                    population.Text = "- - -";
                }
            }
            catch
            {
                name.Text = "- - -";
                population.Text = "- - -";
            }
        }
    }
}
