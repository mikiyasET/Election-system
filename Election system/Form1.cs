using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Election_system
{
    public partial class MainPage : Form
    {
        string regionName;
        public MainPage()
        {
            try
            {
                InitializeComponent();
                Election election = new Election();
                elections.DataSource = election.getElections();
                elections.DisplayMember = "ename";
                elections.ValueMember = "eid";
                DataRowView row = elections.SelectedItem as DataRowView;
                
                Vote vote = new Vote();
                vote.Eid = row == null ? 0 : int.Parse(row.Row["eid"].ToString());

                DataTable dtable = vote.PartiesByEID();
                dtable = dtable.DefaultView.ToTable();
                dtable.Columns.Add("Rank", typeof(Int32)).SetOrdinal(0);
                int srNo = 1;
                foreach (DataRow rows in dtable.Rows)
                {
                    rows["Rank"] = srNo++;
                }
                leadboard_table.DataSource = dtable;
                DataGridViewColumn column = leadboard_table.Columns[2];
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                ((DataGridViewImageColumn)leadboard_table.Columns[2]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                
            }
           
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Point point = region_image.PointToClient(Cursor.Position);
            int x = point.X;
            int y = point.Y;
            Console.WriteLine("x: {0}\ny: {1}", x, y);

            // rule:-  Rule(x1,x2,y1,y1)
            // rule:-       30,88,10,20
            if (Rule(123, 244, 216, 255) || Rule(216, 244, 210, 291))
            {
                // Tigray
                ShowRegion("Tigray");
            }
            else if (Rule(46, 133, 305, 405))
            {
                // Benishangul
                ShowRegion("Benishangul");

            }
            else if (Rule(88, 242, 259, 370) || Rule(88, 130, 277, 308) || Rule(222, 250, 371, 414) || Rule(224, 253, 232, 370))
            {
                // Amahara
                ShowRegion("Amahara");
            }
            else if (Rule(307, 327, 381, 389))
            {
                // DireDawa
                ShowRegion("DireDawa");

            }
            else if (Rule(316, 325, 393, 400))
            {
                // Harari
                ShowRegion("Harari");
            }
            else if (Rule(76, 178, 463, 565))
            {
                // SNNPR
                ShowRegion("SNNPR");

            }
            else if (Rule(228, 276, 403, 533) || Rule(277, 313, 389, 497) || Rule(255, 277, 392, 414) || Rule(312, 348, 381, 435) || Rule(291, 323, 462, 495) || Rule(228, 242, 535, 572))
            {
                // Oromia
                ShowRegion("Oromia");
            }
            else if (Rule(228, 518, 340, 600))
            {
                // Somali
                ShowRegion("Somali");

            }
            else if (Rule(245, 329, 219, 410) || Rule(278, 329, 260, 340))
            {
                // Afar
                ShowRegion("Afar");
            }
            else if (Rule(10, 79, 417, 502))
            {
                // Gambela
                ShowRegion("Gambela");
            }

            else if (Rule(202, 209, 403, 411))
            {
                // AddisAbaba
                ShowRegion("AddisAbaba");
            }

            else if (Rule(183, 217, 470, 515))
            {
                // Sidama
                ShowRegion("Sidama");
            }

            else if (Rule(48, 344, 361, 596))
            {
                // Oromia
                ShowRegion("Oromia");

            }
        }
        private void pictureBox1_Hover(object sender, EventArgs e)
        {
         /*   
            Point point = region_image.PointToClient(Cursor.Position);
            int x = point.X;
            int y = point.Y;

            // rule:-  Rule(x1,x2,y1,y1)
            // rule:-       30,88,10,20
            if (Rule(123, 244, 216, 255) || Rule(216, 244, 210, 291))
            {
                // Tigray
                Console.WriteLine("Tigray X: " + x + "         Y:" + y + "\n");
            }
            else if (Rule(46, 133, 305, 405))
            {
                // Benshal gulgumz
                Console.WriteLine("Benishan Gulgumz X: " + x + "         Y:" + y + "\n");

            }
            else if (Rule(88, 242, 259, 370) || Rule(88, 130, 277, 308) || Rule(222, 250, 371, 414) || Rule(224, 253, 232, 370))
            {
                // Amahara
                Console.WriteLine("Amhara X: " + x + "         Y:" + y + "\n");
            }
            else if (Rule(307, 327, 381, 389))
            {
                // dire dawa
                Console.WriteLine("Dire Dawa X: " + x + "         Y:" + y + "\n");

            }
            else if (Rule(316, 325, 393, 400))
            {
                // hareri
                Console.WriteLine("Hareri X: " + x + "         Y:" + y + "\n");

            }
            else if (Rule(76, 178, 463, 565))
            {
                // SNNP
                Console.WriteLine("SNNP X: " + x + "         Y:" + y + "\n");

            }
            else if (Rule(228, 276, 403, 533) || Rule(277, 313, 389, 497) || Rule(255, 277, 392, 414) || Rule(312, 348, 381, 435) || Rule(291, 323, 462, 495) || Rule(228, 242, 535, 572))
            {
                // Oromiya
                Console.WriteLine("Oromiya X: " + x + "         Y:" + y + "\n");
            }
            else if (Rule(228, 518, 340, 600))
            {
                // somali
                Console.WriteLine("Somali X: " + x + "         Y:" + y + "\n");

            }
            else if (Rule(245, 329, 219, 410) || Rule(278, 329, 260, 340))
            {
                // Afar
                Console.WriteLine("Afar X: " + x + "         Y:" + y + "\n");
            }
            else if (Rule(10, 79, 417, 502))
            {
                // Gambela
                Console.WriteLine("Gambela X: " + x + "         Y:" + y + "\n");

            }

            else if (Rule(202, 209, 403, 411))
            {
                // addis ababa
                Console.WriteLine("Addis Ababa X: " + x + "         Y:" + y + "\n");
            }

            else if (Rule(183, 217, 470, 515))
            {
                // sidama
                Console.WriteLine("Sidama X: " + x + "         Y:" + y + "\n");
            }

            else if (Rule(48, 344, 361, 596))
            {
                // oromiya
                Console.WriteLine("Oromiya X: " + x + "         Y:" + y + "\n");

            }


            else
            {
                Console.WriteLine("Unkown Region    X: " + x + "         Y:" + y + "\n");
            }
            */
        }
        private bool Rule(int x1, int x2, int y1, int y2)
        {
            Point point = region_image.PointToClient(Cursor.Position);
            int x = point.X;
            int y = point.Y;
            if (x >= x1 && x <= x2 && (y >= y1 && y <= y2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void ShowRegion(string region) 
        {
            try
            {
                DataRowView row = elections.SelectedItem as DataRowView;
                switch (region)
                {
                    case "AddisAbaba":
                        Region region1 = new Region();
                        region1.RegionID = 1;
                        ChangeDetails(region1.getDetails(int.Parse(row.Row["eid"].ToString())));
                        this.region_image.Image = global::Election_system.Properties.Resources.AddisAbaba;
                        regionName = "AddisAbaba";
                        break;
                    case "Afar":
                        Region region2 = new Region();
                        region2.RegionID = 2;
                        ChangeDetails(region2.getDetails(int.Parse(row.Row["eid"].ToString())));
                        this.region_image.Image = global::Election_system.Properties.Resources.Afar;
                        regionName = "Afar";
                        break;
                    case "Amahara":
                        Region region3 = new Region();
                        region3.RegionID = 3;
                        ChangeDetails(region3.getDetails(int.Parse(row.Row["eid"].ToString())));
                        this.region_image.Image = global::Election_system.Properties.Resources.Amhara;
                        regionName = "Amahara";
                        break;
                    case "Benishangul":
                        Region region4 = new Region();
                        region4.RegionID = 4;
                        ChangeDetails(region4.getDetails(int.Parse(row.Row["eid"].ToString())));
                        this.region_image.Image = global::Election_system.Properties.Resources.Benishangul_Gumuz;
                        regionName = "Benishangul";
                        break;
                    case "DireDawa":
                        Region region5 = new Region();
                        region5.RegionID = 5;
                        ChangeDetails(region5.getDetails(int.Parse(row.Row["eid"].ToString())));
                        this.region_image.Image = global::Election_system.Properties.Resources.DireDawa;
                        regionName = "DireDawa";
                        break;
                    case "Gambela":
                        Region region6 = new Region();
                        region6.RegionID = 6;
                        ChangeDetails(region6.getDetails(int.Parse(row.Row["eid"].ToString())));
                        this.region_image.Image = global::Election_system.Properties.Resources.Gambela;
                        regionName = "Gambela";
                        break;
                    case "Harari":
                        Region region7 = new Region();
                        region7.RegionID = 7;
                        ChangeDetails(region7.getDetails(int.Parse(row.Row["eid"].ToString())));
                        this.region_image.Image = global::Election_system.Properties.Resources.Harari;
                        regionName = "Harari";
                        break;
                    case "Oromia":
                        Region region8 = new Region();
                        region8.RegionID = 8;
                        ChangeDetails(region8.getDetails(int.Parse(row.Row["eid"].ToString())));
                        this.region_image.Image = global::Election_system.Properties.Resources.Oromia;
                        regionName = "Oromia";
                        break;
                    case "Sidama":
                        Region region9 = new Region();
                        region9.RegionID = 9;
                        ChangeDetails(region9.getDetails(int.Parse(row.Row["eid"].ToString())));
                        this.region_image.Image = global::Election_system.Properties.Resources.sidama;
                        regionName = "Sidama";
                        break;
                    case "Somali":
                        Region region10 = new Region();
                        region10.RegionID = 10;
                        ChangeDetails(region10.getDetails(int.Parse(row.Row["eid"].ToString())));
                        this.region_image.Image = global::Election_system.Properties.Resources.somali;
                        regionName = "Somali";
                        break;
                    case "SNNPR":
                        Region region11 = new Region();
                        region11.RegionID = 11;
                        ChangeDetails(region11.getDetails(int.Parse(row.Row["eid"].ToString())));
                        this.region_image.Image = global::Election_system.Properties.Resources.SNNP;
                        regionName = "SNNPR";
                        break;
                    case "Tigray":
                        Region region12 = new Region();
                        region12.RegionID = 12;
                        ChangeDetails(region12.getDetails(int.Parse(row.Row["eid"].ToString())));
                        this.region_image.Image = global::Election_system.Properties.Resources.Tigray;
                        regionName = "Tigray";
                        break;
                    default:
                        this.region_image.Image = global::Election_system.Properties.Resources.Ethiopia_map___white;
                        Console.WriteLine("Error: " + region);
                        break;
                }
            }catch (Exception e)
            {
                MessageBox.Show("No election selected");
            }
        }
        private void ChangeDetails(Region region)
        {
            string regionfix = region.RegionID == 1 || region.RegionID == 5 ? "" : " Region";
            regionName_txt.Text = region.Name + regionfix;
            population_txt.Text = String.Format("{0:n0}", region.Population);
            voters_txt.Text = String.Format("{0:n0}", region.Voter) == "0" ? "- - -" : String.Format("{0:n0}", region.Voter);
            voted_txt.Text = String.Format("{0:n0}", region.Voted) == "0" ? "- - -" : String.Format("{0:n0}", region.Voted);
            station_txt.Text = String.Format("{0:n0}", region.Stations) == "0" ? "- - -" : String.Format("{0:n0}", region.Stations);

        }
        private void VoteNowBtn(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            //this.Close();
        }
        private void Election_OnChange(object sender, EventArgs e)
        {
            DataRowView row = elections.SelectedItem as DataRowView;

            ShowRegion(regionName);
            Vote vote = new Vote();
            vote.Eid = int.Parse(row.Row["eid"].ToString());
            DataTable dtable = vote.PartiesByEID();
            dtable = dtable.DefaultView.ToTable();
            dtable.Columns.Add("Rank", typeof(Int32)).SetOrdinal(0);
            int srNo = 1;
            foreach (DataRow rows in dtable.Rows)
            {
                rows["Rank"] = srNo++;
            }
            leadboard_table.DataSource = dtable;
            DataGridViewColumn column = leadboard_table.Columns[2];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ((DataGridViewImageColumn)leadboard_table.Columns[2]).ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void parties_btn_Click(object sender, EventArgs e)
        {
            body.Controls.Clear();
            Parties p = new Parties();
            p.Dock = DockStyle.Fill;
            body.Controls.Add(p);
        }

        private void leadboardbtn_Click(object sender, EventArgs e)
        {
            body.Controls.Clear();
            body.Controls.Add(rightbar);
            body.Controls.Add(ethiopia);
        }

        private void leadboard_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
