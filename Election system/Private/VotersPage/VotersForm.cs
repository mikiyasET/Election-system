using Election_system.Private.VotersPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Election_system.Private.Voters
{
    public partial class VotersForm : Form
    {
        Election_system.Voters voters;
        public VotersForm(Election_system.Voters v)
        {
            InitializeComponent();
            voters = v;
        }

        private void Profilebtn_Click(object sender, EventArgs e)
        {
            Profile form = new Profile(voters);
            form.Dock = DockStyle.Fill;
            body.Controls.Clear();
            body.Controls.Add(form);
        }
        private void Votebtn_Click(object sender, EventArgs e)
        {
            Vote form = new Vote(voters);
            form.Dock = DockStyle.Fill;
            body.Controls.Clear();
            body.Controls.Add(form);
        }
        private void Resultbtn_Click(object sender, EventArgs e)
        {
            Result form = new Result(voters);
            form.Dock = DockStyle.Fill;
            body.Controls.Clear();
            body.Controls.Add(form);
        }
        private void Logout_Click(object sender,EventArgs e)
        {
            Logout();
        }
        private void Logout()
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
    }
}
