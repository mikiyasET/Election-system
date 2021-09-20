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
    public partial class AddRegions : UserControl
    {
        public AddRegions()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Region region = new Region();
            region.Name = name_box.Text;
            region.Population = int.Parse(pop_box.Text);
            region.Save();
        }
    }
}
