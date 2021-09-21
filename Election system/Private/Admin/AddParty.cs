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

namespace Election_system.Private.Admin
{
    public partial class AddParty : UserControl
    {
        string imgLoc;
        public AddParty()
        {
            InitializeComponent();
            Election election = new Election();
            election_box.DataSource = election.getElections();
            election_box.DisplayMember = "ename";
            election_box.ValueMember = "eid";
        }
        private void logobtn_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files | *jpg;*.jpeg;*png;";
            DialogResult result = dialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                imgLoc = dialog.FileName.ToString();
                try
                {
                    logo_img.ImageLocation = imgLoc;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }


        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (name_box.Text != "")
                {
                    DataRowView x = election_box.SelectedItem as DataRowView;

                    byte[] img;
                    img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    Election_system.Party party = new Election_system.Party();
                    party.Name = name_box.Text;
                    party.Logo = img;
                    party.Eid = int.Parse(x.Row["eid"].ToString());
                    party.Add();
                }
                else
                {
                    MessageBox.Show("Please insert parties name", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }catch (ArgumentException ae)
            {
                MessageBox.Show("Please insert parties logo", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

    }
}
