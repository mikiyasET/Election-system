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
    public partial class ViewElection : UserControl
    {
        public ViewElection()
        {
            InitializeComponent();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Election el = new Election();
                el.Name = search_box.Text;
                Election election = el.GetElection();
                if (election.HasValue)
                {
                    name.Text = election.Name;
                    start.Text = election.Starting.ToString("MMM, dd yyyy");
                    end.Text = election.Ending.ToString("MMM, dd yyyy");
                }
                else
                {
                    name.Text = "- - -";
                    start.Text = "- - -";
                    end.Text = "- - -";
                }
            }
            catch
            {
                name.Text = "- - -";
                start.Text = "- - -";
                end.Text = "- - -";
            }

        }
    }
}
