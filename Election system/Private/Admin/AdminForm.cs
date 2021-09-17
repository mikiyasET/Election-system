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
        public AdminForm()
        {
            InitializeComponent();
            Dashboard form = new Dashboard();
            form.Dock = DockStyle.Fill;
            body.Controls.Clear();
            body.Controls.Add(form);
        }

        bool votebtnexp = false;
        bool partybtnexp = false;
        bool stationbtnexp = false;
        bool regionbtnexp = false;

        private void CollapseAll()
        {
            voter_con.Height = 60;
            party_con.Height = 60;
            station_con.Height = 60;
            region_con.Height = 60;
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
            CollapseAll();
            if (!regionbtnexp)
            {
                regionbtnexp = true;
                region_con.Height = 180;
            }else
            {
                regionbtnexp = false;
            }
            Console.WriteLine("Regionss");

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

        private void logout_btn_Click(object sender, EventArgs e)
        {
            CollapseAll();

        }

        private void body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidenav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void region_con_Paint(object sender, PaintEventArgs e)
        {

        }

        private void region_txt_con_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void station_con_Paint(object sender, PaintEventArgs e)
        {

        }

        private void station_txt_con_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void party_con_Paint(object sender, PaintEventArgs e)
        {

        }

        private void party_txt_con_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void voter_con_Paint(object sender, PaintEventArgs e)
        {

        }

        private void voter_txt_con_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home_con_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home_txt_con_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Spacer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
