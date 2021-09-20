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
        int partyID;
        public Vote()
        {
            InitializeComponent();
            Party party = new Party();
            DataTable dt = party.Parties();
            foreach (DataRow row in dt.Rows)
            {
                addParties(int.Parse(row["pid"].ToString()),row["pname"].ToString(), row["logo"] as byte[]);
            }
        }

        private void addParties(int pid,string name,byte[] logo)
        {
            MemoryStream ms = new MemoryStream(logo);
            Label partyName = new Label();
            partyName.AutoSize = false;
            partyName.Dock = System.Windows.Forms.DockStyle.Top;
            partyName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            partyName.ForeColor = System.Drawing.Color.Black;
            partyName.Location = new System.Drawing.Point(30, 209);
            partyName.Name = "partyName";
            partyName.Size = new System.Drawing.Size(138, 40);
            partyName.TabIndex = 1;
            partyName.Text = name;
            partyName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            partyName.Click += new EventHandler((sender, e) => VoteMe(pid));

            PictureBox partyLogo = new PictureBox();
            partyLogo.Dock = System.Windows.Forms.DockStyle.Top;
            partyLogo.Image = Image.FromStream(ms);
            partyLogo.Location = new System.Drawing.Point(0, 0);
            partyLogo.Name = "partyLogo";
            partyLogo.Size = new System.Drawing.Size(200, 169);
            partyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            partyLogo.TabIndex = 0;
            partyLogo.TabStop = false;
            partyLogo.Click += new EventHandler((sender, e) => VoteMe(pid));

            Panel party_con = new Panel();
            party_con.BackColor = Color.WhiteSmoke;
            party_con.Controls.Add(partyName);
            party_con.Controls.Add(partyLogo);
            party_con.Location = new System.Drawing.Point(83, 13);
            party_con.Name = "party_con";
            party_con.Size = new System.Drawing.Size(200, 288);
            party_con.TabIndex = 0;
            party_con.Click += new EventHandler( (sender,e) => VoteMe(pid));

            allParties.Controls.Add(party_con);
        }

        private void VoteMe(int pid)
        {
            votebtn.Enabled = true;
            partyID = pid;
        }

        private void votebtn_Click(object sender, EventArgs e)
        {
            if (partyID != 0)
            {
                MessageBox.Show("Voted for " + partyID);
            }
        }
    }
}
