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
    public partial class ModifyRegions : UserControl
    {
        int rid;
        public ModifyRegions()
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
                    rid = region.RegionID;
                    name_box.Text = region.Name;
                    pop_box.Text = region.Population.ToString();

                    name_box.Enabled = true;
                    pop_box.Enabled = true;
                    updatebtn.Enabled = true;
                    removebtn.Enabled = true;
                }
                else
                {
                    name_box.Enabled = false;
                    pop_box.Enabled = false;
                    updatebtn.Enabled = false;
                    removebtn.Enabled = false;
                }
            }
            catch
            {
                name_box.Enabled = false;
                pop_box.Enabled = false;
                updatebtn.Enabled = false;
                removebtn.Enabled = false;
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            Region region = new Region();
            region.RegionID = rid;
            region.Name = name_box.Text;
            region.Population = int.Parse(pop_box.Text);
            region.Update();
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            Region region = new Region();
            region.RegionID = rid;
            region.Remove();
        }
    }
}
