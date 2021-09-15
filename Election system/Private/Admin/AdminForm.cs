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

            votebtnexp = false;
            candbtnexp = false;
            stationbtnexp = false;
            regionbtnexp = false;
        }

        private void HomebtnClick(object sender, EventArgs e)
        {
            CollapseAll();
            Console.WriteLine("Home");
        }
        private void VoterbtnClick(object sender, EventArgs e)
        {
            CollapseAll();
            if (!votebtnexp)
            {
                votebtnexp = true;
                voter_con.Height = 180;
            }
            Console.WriteLine("Voter");
        }
        private void CandbtnClick(object sender, EventArgs e)
        {
            CollapseAll();
            if (!candbtnexp)
            {
                candbtnexp = true;
                cand_con.Height = 180;
            }
            Console.WriteLine("Candidate");
        }
        private void StationbtnClick(object sender, EventArgs e)
        {
            CollapseAll();
            if (!stationbtnexp)
            {
                stationbtnexp = true;
                station_con.Height = 180;
            }
            Console.WriteLine("Station");
        }
        private void RegionbtnClick(object sender, EventArgs e)
        {
            CollapseAll();
            if (!regionbtnexp)
            {
                regionbtnexp = true;
                region_con.Height = 180;
            }
            Console.WriteLine("Regionss");
        }
    }
}
