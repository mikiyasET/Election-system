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
    public partial class AdminForm : Form
    {
        private string username;
        /*public AdminForm()
        {
           InitializeComponent();
            Dashboard form = new Dashboard();
            form.Dock = DockStyle.Fill;
            body.Controls.Clear();
            body.Controls.Add(form);

        }*/

        public AdminForm(Election_system.Admin admin)
        {
            username = admin.username;
            if (checkIfAdminExist(admin.username))
            {
                InitializeComponent();
                Dashboard form = new Dashboard();
                form.Dock = DockStyle.Fill;
                body.Controls.Clear();
                body.Controls.Add(form);
            }else
            {
                this.Hide();
                this.Close();
                MessageBox.Show("You are not an admin", "Security", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool checkIfAdminExist(string username)
        {
            Election_system.Admin admin = new Election_system.Admin();
            admin.username = username;
            return admin.CheckUsername();
        }
        bool votebtnexp = false;
        bool partybtnexp = false;
        bool stationbtnexp = false;
        bool regionbtnexp = false;
        bool electionbtnexp = false;

        private void CollapseAll()
        {
            checkIfAdminExist(username);
            voter_con.Height = 60;
            party_con.Height = 60;
            station_con.Height = 60;
            region_con.Height = 60;
            election_con.Height = 60;

        }

        private void HomebtnClick(object sender, EventArgs e)
        {
            Dashboard form = new Dashboard();
            form.Dock = DockStyle.Fill;
            body.Controls.Clear();
            body.Controls.Add(form);
            CollapseAll();
            Console.WriteLine("Home");
        }
        private void VoterbtnClick(object sender, EventArgs e)
        {
            partybtnexp = false;
            stationbtnexp = false;
            regionbtnexp = false;
            electionbtnexp = false;
            CollapseAll();
            if (!votebtnexp)
            {
                votebtnexp = true;
                voter_con.Height = 180;
            }else
            {
                votebtnexp = false;
            }
            Console.WriteLine("Voter");
        }
        private void PartybtnClick(object sender, EventArgs e)
        {
            votebtnexp = false;
            stationbtnexp = false;
            regionbtnexp = false;
            electionbtnexp = false;

            CollapseAll();
            if (!partybtnexp)
            {
                partybtnexp = true;
                party_con.Height = 180;
            }else
            {
                partybtnexp = false;
            }
            Console.WriteLine("Candidate");
        }
        private void StationbtnClick(object sender, EventArgs e)
        {
            votebtnexp = false;
            partybtnexp = false;
            regionbtnexp = false;
            electionbtnexp = false;

            CollapseAll();
            if (!stationbtnexp)
            {
                stationbtnexp = true;
                station_con.Height = 180;
            }else
            {
                stationbtnexp = false;
            }
            Console.WriteLine("Station");
        }
        private void RegionbtnClick(object sender, EventArgs e)
        {
            votebtnexp = false;
            partybtnexp = false;
            stationbtnexp = false;
            electionbtnexp = false;

            CollapseAll();
            if (!regionbtnexp)
            {
                regionbtnexp = true;
                region_con.Height = 180;
            }else
            {
                regionbtnexp = false;
            }
            Console.WriteLine("Region");

        }
        private void ElectionbtnClick(object sender, EventArgs e)
        {
            votebtnexp = false;
            partybtnexp = false;
            stationbtnexp = false;
            regionbtnexp = false;

            CollapseAll();
            if (!electionbtnexp)
            {
                electionbtnexp = true;
                election_con.Height = 180;
            }
            else
            {
                electionbtnexp = false;
            }
            Console.WriteLine("Election");

        }

        private void addVoters_btn_Click(object sender, EventArgs e)
        {
            AddVoters form = new AddVoters();
            form.Dock = DockStyle.Fill;
            body.Controls.Clear();
            body.Controls.Add(form);
        }

        private void modifyVoters_btn_Click(object sender, EventArgs e)
        {
            ModifyVoters form = new ModifyVoters();
            form.Dock = DockStyle.Fill;
            body.Controls.Clear();
            body.Controls.Add(form);
        }

        private void viewVoters_btn_Click(object sender, EventArgs e)
        {
            ViewVoters form = new ViewVoters();
            form.Dock = DockStyle.Fill;
            body.Controls.Clear();
            body.Controls.Add(form);
        }

        private void addparty_btn_Click(object sender, EventArgs e)
        {
            AddParty form = new AddParty();
            form.Dock = DockStyle.Fill;
            body.Controls.Clear();
            body.Controls.Add(form);
        }

        private void modifyparty_btn_Click(object sender, EventArgs e)
        {
            ModifyParty form = new ModifyParty();
            form.Dock = DockStyle.Fill;
            body.Controls.Clear();
            body.Controls.Add(form);
        }

        private void viewparty_btn_Click(object sender, EventArgs e)
        {
            ViewParty form = new ViewParty();
            form.Dock = DockStyle.Fill;
            body.Controls.Clear();
            body.Controls.Add(form);
        }

        private void addstation_btn_Click(object sender, EventArgs e)
        {
            AddStations form = new AddStations();
            form.Dock = DockStyle.Fill;
            body.Controls.Clear();
            body.Controls.Add(form);
        }

        private void modifystation_btn_Click(object sender, EventArgs e)
        {
            ModifyStations form = new ModifyStations();
            form.Dock = DockStyle.Fill;
            body.Controls.Clear();
            body.Controls.Add(form);
        }

        private void viewstation_btn_Click(object sender, EventArgs e)
        {
            ViewStations form = new ViewStations();
            form.Dock = DockStyle.Fill;
            body.Controls.Clear();
            body.Controls.Add(form);
        }

        private void addregion_btn_Click(object sender, EventArgs e)
        {
            AddRegions form = new AddRegions();
            form.Dock = DockStyle.Fill;
            body.Controls.Clear();
            body.Controls.Add(form);
        }

        private void modifyregion_btn_Click(object sender, EventArgs e)
        {
            ModifyRegions form = new ModifyRegions();
            form.Dock = DockStyle.Fill;
            body.Controls.Clear();
            body.Controls.Add(form);
        }

        private void viewregion_btn_Click(object sender, EventArgs e)
        {
            ViewRegion form = new ViewRegion();
            form.Dock = DockStyle.Fill;
            body.Controls.Clear();
            body.Controls.Add(form);
        }

        private void addelection_btn_Click(object sender, EventArgs e)
        {
            AddElection form = new AddElection();
            form.Dock = DockStyle.Fill;
            body.Controls.Clear();
            body.Controls.Add(form);
        }

        private void modifyelection_btn_Click(object sender, EventArgs e)
        {
            ModifyElection form = new ModifyElection();
            form.Dock = DockStyle.Fill;
            body.Controls.Clear();
            body.Controls.Add(form);
        }

        private void viewelection_btn_Click(object sender, EventArgs e)
        {
            ViewElection form = new ViewElection();
            form.Dock = DockStyle.Fill;
            body.Controls.Clear();
            body.Controls.Add(form);
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();

        }


    }
}
