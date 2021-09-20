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
    public partial class AddElection : UserControl
    {
        public AddElection()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Election election = new Election();
            election.Name = name.Text;
            election.Starting = start.Value;
            election.Ending = end.Value;
            election.Save();
        }
    }
}
