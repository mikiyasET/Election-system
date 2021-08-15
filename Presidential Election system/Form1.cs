using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Presidential_Election_system
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /* Point point = pictureBox1.PointToClient(Cursor.Position);

             int x = point.X;
             int y = point.Y;
             Console.WriteLine("X: " + point.X + "         Y:" + point.Y + "\n");*/
        }
        private void pictureBox1_Hover(object sender, EventArgs e)
        {
            Point point = pictureBox1.PointToClient(Cursor.Position);
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
        }

        private bool Rule(int x1, int x2, int y1, int y2)
        {
            Point point = pictureBox1.PointToClient(Cursor.Position);
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
            switch (region)
            {
                case "Addis Ababa":
                    Console.WriteLine("Addis Ababa");
                    break;
                case "Afar":
                    Console.WriteLine("Afar");
                    break;
                case "Amahara":
                    Console.WriteLine("Amahara");
                    break;
                case "Benishangul":
                    Console.WriteLine("Benishangul");
                    break;
                case "DireDawa":
                    Console.WriteLine("DireDawa");
                    break;
                case "Gambela":
                    Console.WriteLine("Gambela");
                    break;
                case "Harari":
                    Console.WriteLine("Harari");
                    break;
                case "Oromia":
                    Console.WriteLine("Oromia");
                    break;
                case "Sidama":
                    Console.WriteLine("Sidama");
                    break;
                case "Somali":
                    Console.WriteLine("Somali");
                    break;
                case "SNNPR":
                    Console.WriteLine("SNNPR");
                    break;
                case "Tigray":
                    Console.WriteLine("Tigray");
                    break;

            }
        }

    }
}
