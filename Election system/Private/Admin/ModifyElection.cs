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
    public partial class ModifyElection : UserControl
    {
        int eid;
        public ModifyElection()
        {
            InitializeComponent();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                Election election = new Election();
                election.Eid = eid;
                election.Name = name.Text;
                election.Starting = start.Value;
                election.Ending = end.Value;
                election.Update();
            }
            catch
            {
                name.Text = "";
                start.Text = "";
                end.Text = "";
                name.Enabled = false;
                start.Enabled = false;
                end.Enabled = false;
                updatebtn.Enabled = false;
                removebtn.Enabled = false;
            }
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            Election election = new Election();
            election.Eid = eid;
            election.Remove();
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
                    eid = election.Eid;
                    name.Text = election.Name;
                    start.Value = election.Starting;
                    end.Value = election.Ending;
                    name.Enabled = true;
                    start.Enabled = true;
                    end.Enabled = true;
                    updatebtn.Enabled = true;
                    removebtn.Enabled = true;
                }
                else
                {
                    name.Text = "";
                    start.Text = "";
                    end.Text = "";
                    name.Enabled = false;
                    start.Enabled = false;
                    end.Enabled = false;
                    updatebtn.Enabled = false;
                    removebtn.Enabled = false;
                }
            }
            catch
            {
                name.Text = "";
                start.Text = "";
                end.Text = "";
                name.Enabled = false;
                start.Enabled = false;
                end.Enabled = false;
                updatebtn.Enabled = false;
                removebtn.Enabled = false;
            }
        }
    }
}
