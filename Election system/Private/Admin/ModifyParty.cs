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
    public partial class ModifyParty : UserControl
    {
        string imgLoc = "";
        byte[] img2 = null;
        int pid;
        public ModifyParty()
        {
            InitializeComponent();
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
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img;
                if (imgLoc != null)
                {
                    img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                }
                else
                {
                    img = img2;
                }
                Election_system.Party party= new Election_system.Party();
                party.Pid = pid;
                party.Name = name_box.Text; 
                party.Logo = img;
                party.HasValue = true;
                party.Update();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Phone number must be a number", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            Election_system.Party party = new Election_system.Party();
            party.Pid = pid;
            party.Remove();
        }


        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Election_system.Party party = new Election_system.Party();
                party.Name = search_box.Text;
                Election_system.Party party1 = party.getParty();
                if (party1.HasValue)
                {
                    pid = party1.Pid;
                    name_box.Text = party1.Name;
                    MemoryStream ms = new MemoryStream(party1.Logo);
                    logo_img.Image = Image.FromStream(ms);
                    img2 = party1.Logo;
                    imgLoc = logo_img.ImageLocation;

                    name_box.Enabled = true;
                    updatebtn.Enabled = true;
                    removebtn.Enabled = true;
                    logobtn.Enabled = true;
                }else
                {
                    logo_img.Image = Election_system.Properties.Resources.addpic;
                    name_box.Text = "";
                    name_box.Enabled = false;
                    updatebtn.Enabled = false;
                    removebtn.Enabled = false;
                    logobtn.Enabled = false;
                }
            } catch (ArgumentNullException ex)
            {
                logo_img.Image = Election_system.Properties.Resources.addpic;
                name_box.Text = "";
                name_box.Enabled = false;
                updatebtn.Enabled = false;
                removebtn.Enabled = false;
                logobtn.Enabled = false;
            } catch (Exception ex)
            {
                logo_img.Image = Election_system.Properties.Resources.addpic;
                name_box.Text = "";
                name_box.Enabled = false;
                updatebtn.Enabled = false;
                removebtn.Enabled = false;
                logobtn.Enabled = false;
            }
        }
    }
}
