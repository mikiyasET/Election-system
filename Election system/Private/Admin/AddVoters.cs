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
    public partial class AddVoters : UserControl
    {
        string imgLoc = "";
        public AddVoters()
        {
            InitializeComponent();
            Station station = new Station();
            station_box.DataSource = station.getStations();
            station_box.DisplayMember = "station";
            station_box.ValueMember = "id";
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

        private void firstName_TextChanged(object sender, EventArgs e) {

        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }
        private void AddVoter_Click(object sender, EventArgs e)
        {
            
            bool error = false;
            bool isnull = false;
            firstName_box.BorderColor = firstName_box.Text == "" ? Color.Red : Color.Black;
            middleName_box.BorderColor = middleName_box.Text == "" ? Color.Red : Color.Black;
            lastName_box.BorderColor = lastName_box.Text == "" ? Color.Red : Color.Black;
            phoneNo_box.BorderColor = phoneNo_box.Text == "" ? Color.Red : Color.Black;
            password_box.BorderColor = password_box.Text == "" ? Color.Red : Color.Black;
            conformPassword_box.BorderColor = conformPassword_box.Text == "" ? Color.Red : Color.Black;
            IDNo_box.BorderColor = IDNo_box.Text == "" ? Color.Red : Color.Black;

            isnull = isnull || (firstName_box.Text == "" ? true : false);
            isnull = isnull || (middleName_box.Text == "" ? true : false);
            isnull = isnull || (lastName_box.Text == "" ? true : false);
            isnull = isnull || (phoneNo_box.Text == "" ? true : false);
            isnull = isnull || (password_box.Text == "" ? true : false);
            isnull = isnull || (conformPassword_box.Text == "" ? true : false);
            isnull = isnull || (IDNo_box.Text == "" ? true : false);
            isnull = isnull || (station_box.SelectedIndex == null ? true : false);

            error = firstName_box.Text == "" ? true : false;
            error = error || (middleName_box.Text == "" ? true : false);
            error = error || (lastName_box.Text == "" ? true : false);
            error = error || (phoneNo_box.Text == "" ? true : false);
            error = error || (password_box.Text == "" ? true : false);
            error = error || (conformPassword_box.Text == "" ? true : false);
            error = error || (IDNo_box.Text == "" ? true : false);
            error = error || (station_box.SelectedIndex == null ? true : false);
            try
            {
                if (isnull) {
                    MessageBox.Show("There is an empty field");
                }
                if (!error)
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    Election_system.Voters voter = new Election_system.Voters();
                    DataRowView x = station_box.SelectedItem as DataRowView;
                    voter.FirstName = firstName_box.Text;
                    voter.MiddleName = middleName_box.Text;
                    voter.LastName = lastName_box.Text;
                    voter.Phone = int.Parse(phoneNo_box.Text);
                    voter.Password = password_box.Text;
                    voter.Birth = birthdate_box.Value;
                    voter.IDNo = IDNo_box.Text;
                    voter.IDImage = img;
                    voter.Station = int.Parse(x.Row["id"].ToString());
                    voter.Save();
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Phone Number must be a number");
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show("Please insert the id image");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void IDNo_box_Load(object sender, EventArgs e)
        {

        }

        private void Spacer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
