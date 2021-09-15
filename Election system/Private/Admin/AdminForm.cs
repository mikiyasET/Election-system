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
        }

        bool votebtnexp = false;
        bool candbtnexp = false;
        bool stationbtnexp = false;
        bool regionbtnexp = false;

        private void CollapseAll()
        {
            voter_con.Height = 60;
            cand_con.Height = 60;
            station_con.Height = 60;
            region_con.Height = 60;
        }

        private void HomebtnClick(object sender, EventArgs e)
        {
            CollapseAll();
            Console.WriteLine("Home");
        }
        private void VoterbtnClick(object sender, EventArgs e)
        {
            candbtnexp = false;
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
        private void CandbtnClick(object sender, EventArgs e)
        {
            votebtnexp = false;
            stationbtnexp = false;
            regionbtnexp = false;
            CollapseAll();
            if (!candbtnexp)
            {
                candbtnexp = true;
                cand_con.Height = 180;
            }else
            {
                candbtnexp = false;
            }
            Console.WriteLine("Candidate");
        }
        private void StationbtnClick(object sender, EventArgs e)
        {
            votebtnexp = false;
            candbtnexp = false;
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
            candbtnexp = false;
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
            AddVoters add = new AddVoters();
            add.Dock = DockStyle.Fill;
            body.Controls.Clear();
            body.Controls.Add(add);
        }

        private void modifyVoters_btn_Click(object sender, EventArgs e)
        {

        }

        private void viewVoters_btn_Click(object sender, EventArgs e)
        {

        }

        private void addcand_btn_Click(object sender, EventArgs e)
        {

        }

        private void modifycand_btn_Click(object sender, EventArgs e)
        {

        }

        private void viewcand_btn_Click(object sender, EventArgs e)
        {

        }

        private void addstation_btn_Click(object sender, EventArgs e)
        {

        }

        private void modifystation_btn_Click(object sender, EventArgs e)
        {

        }

        private void viewstation_btn_Click(object sender, EventArgs e)
        {

        }

        private void addregion_btn_Click(object sender, EventArgs e)
        {

        }

        private void modifyregion_btn_Click(object sender, EventArgs e)
        {

        }

        private void viewregion_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
