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
    public partial class ModifyVoters : UserControl
    {
        string imgLoc = "";
        byte[] img2 = null;
        int vid;
        public ModifyVoters()
        {
            InitializeComponent();
            Station station = new Station();
            station_box.DataSource = station.getStations();
            station_box.DisplayMember = "station";
            station_box.ValueMember = "id";
            firstName_box.Enabled = false;
            middleName_box.Enabled = false;
            lastName_box.Enabled = false;
            phoneNo_box.Enabled = false;
            birth_box.Enabled = false;
            station_box.Enabled = false;
            updatebtn.Enabled = false;
            removebtn.Enabled = false;
            clearbtn.Enabled = false;
            id_image.Enabled = false;
            IDNo_box.Enabled = false;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            bool check = false;
            Election_system.Voters vdata = new Election_system.Voters();
            vdata.IDNo = searchbox.Text;
            Election_system.Voters voter = vdata.getVoter();
            check = voter.FirstName == null ? false : true;
            if (check)
            {
                try
                {
                    firstName_box.Enabled = true;
                    middleName_box.Enabled = true;
                    lastName_box.Enabled = true;
                    phoneNo_box.Enabled = true;
                    birth_box.Enabled = true;
                    station_box.Enabled = true;
                    updatebtn.Enabled = true;
                    removebtn.Enabled = true;
                    clearbtn.Enabled = true;
                    IDNo_box.Enabled = true;
                    id_image.Enabled = true;

                    firstName_box.Text = voter.FirstName;
                    middleName_box.Text = voter.MiddleName;
                    lastName_box.Text = voter.LastName;
                    phoneNo_box.Text = voter.Phone.ToString();
                    IDNo_box.Text = voter.IDNo;
                    station_box.SelectedValue = voter.Station;
                    birth_box.Value = voter.Birth;
                    MemoryStream ms = new MemoryStream(voter.IDImage);
                    Idcard_image.Image = Image.FromStream(ms);
                    imgLoc = Idcard_image.ImageLocation;
                    vid = voter.Vid;
                    img2 = voter.IDImage;
                }
                catch (ArgumentException ex)
                {
                    Idcard_image.Image = Election_system.Properties.Resources.id_card;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                firstName_box.Enabled = false;
                middleName_box.Enabled = false;
                lastName_box.Enabled = false;
                phoneNo_box.Enabled = false;
                birth_box.Enabled = false;
                station_box.Enabled = false;
                updatebtn.Enabled = false;
                removebtn.Enabled = false;
                clearbtn.Enabled = false;
                IDNo_box.Enabled = false;
                id_image.Enabled = false;
            }
            
        }

        private void id_image_Click(object sender, EventArgs e)
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
                    Idcard_image.ImageLocation = imgLoc;
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
                Console.WriteLine(imgLoc);
                if (imgLoc != null)
                {
                    img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                }else
                {
                    img = img2;
                }
                    DataRowView x = station_box.SelectedItem as DataRowView;
                    Election_system.Voters voter = new Election_system.Voters();
                    voter.Vid = vid;
                    voter.FirstName = firstName_box.Text;
                    voter.MiddleName = middleName_box.Text;
                    voter.LastName = lastName_box.Text;
                    voter.Phone = int.Parse(phoneNo_box.Text);
                    voter.Station = int.Parse(x.Row["id"].ToString());
                    voter.Birth = birth_box.Value;
                    voter.IDNo = IDNo_box.Text;
                    voter.IDImage = img;
                    voter.Update();
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Phone number must be a number", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            Election_system.Voters voter = new Election_system.Voters();
            voter.Vid = vid;
            voter.Remove();
        }

        private void clear() {
            firstName_box.Text = "";
            middleName_box.Text = "";
            lastName_box.Text = "";
            phoneNo_box.Text = "";
            IDNo_box.Text = "";
            Idcard_image.Image = Election_system.Properties.Resources.id_card;
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
