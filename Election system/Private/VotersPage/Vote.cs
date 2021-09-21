using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Election_system.Private.Voters
{
    public partial class Vote : UserControl
    {
        int partyID, electionID, voterID;
        public Vote(Election_system.Voters voters)
        {
            InitializeComponent();
            Election_system.Vote vote = new Election_system.Vote();
            vote.Vid = voters.Vid;
            votebtn.BackColor = Color.Gray;
            if (vote.checkEligibility())
            {
                Station s = new Station();
                s.Sid = voters.Station;
                voterID = voters.Vid;
                Party party = new Party();
                party.Eid = s.getStationByID().Eid;
                DataTable dt = party.PartiesByEID();
                foreach (DataRow row in dt.Rows)
                {
                    addParties(int.Parse(row["pid"].ToString()), row["pname"].ToString(), row["logo"] as byte[], int.Parse(row["eid"].ToString()));
                }
            }else
            {
                votebtn.Text = "Voted";
                MessageBox.Show("You can not vote twice", "Already Voted", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addParties(int pid,string name,byte[] logo,int eid)
        {
            MemoryStream ms = new MemoryStream(logo);
            Label partyName = new Label();
            PictureBox partyLogo = new PictureBox();
            Panel party_con = new Panel();

            partyName.AutoSize = false;
            partyName.Dock = System.Windows.Forms.DockStyle.Top;
            partyName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            partyName.ForeColor = System.Drawing.Color.Black;
            partyName.Location = new System.Drawing.Point(30, 209);
            partyName.Name = "partyName";
            partyName.Size = new System.Drawing.Size(138, 40);
            partyName.TabIndex = 1;
            partyName.Text = name;
            partyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            partyName.Click += new EventHandler((sender, e) => VoteMe(pid, name,eid));

            partyLogo.Dock = System.Windows.Forms.DockStyle.Top;
            partyLogo.Image = Image.FromStream(ms);
            partyLogo.Location = new System.Drawing.Point(0, 0);
            partyLogo.Name = "partyLogo";
            partyLogo.Size = new System.Drawing.Size(200, 169);
            partyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            partyLogo.TabIndex = 0;
            partyLogo.TabStop = false;
            partyLogo.Click += new EventHandler((sender, e) => VoteMe(pid, name, eid));

            party_con.BackColor = Color.WhiteSmoke;
            party_con.Controls.Add(partyName);
            party_con.Controls.Add(partyLogo);
            party_con.Location = new System.Drawing.Point(83, 13);
            party_con.Name = "party_con";
            party_con.Size = new System.Drawing.Size(200, 288);
            party_con.TabIndex = 0;
            party_con.Click += new EventHandler((sender, e) => VoteMe(pid,name, eid));

            allParties.Controls.Add(party_con);
        }

        private void VoteMe(int pid,string name,int eid)
        {
            votebtn.BackColor = Color.Red;
            votebtn.Enabled = true;
            partyID = pid;
            electionID = eid;
            votebtn.Text = "Vote for " + name;
        }

        private void votebtn_Click(object sender, EventArgs e)
        {
            if (partyID != 0 && electionID != 0 && voterID != 0) {
                Election_system.Vote vote = new Election_system.Vote();
                vote.Pid = partyID;
                vote.Eid = electionID;
                vote.Vid = voterID;
                vote.VoteNow();
            }
            else {
                MessageBox.Show("No enough information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
