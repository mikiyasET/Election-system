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
        public VotersForm()
        {
            InitializeComponent();
        }

        private void Profilebtn_Click(object sender, EventArgs e)
        {
            Profile form = new Profile();
            form.Dock = DockStyle.Fill;
            body.Controls.Clear();
            body.Controls.Add(form);
        }
        private void Votebtn_Click(object sender, EventArgs e)
        {
            Vote form = new Vote();
            form.Dock = DockStyle.Fill;
            body.Controls.Clear();
            body.Controls.Add(form);
        }
        private void Logout_Click(object sender,EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();

        }
    }
}
