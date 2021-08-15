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
            if (Rule(123, 244, 216, 255) || Rule(216,244,210,291))
            {
                // Tigray
                Console.WriteLine("Tigray X: " + x + "         Y:" + y + "\n");
            }
            else if (Rule( 88,242,259,370) || Rule(88,130,277,308))
            {
                // Amahara
                Console.WriteLine("Amhara X: " + x + "         Y:" + y + "\n");
            }else if (Rule(307,327,381,389))
            {
                // dire dawa
                Console.WriteLine("Dire Dawa X: " + x + "         Y:" + y + "\n");

            }
            else if (Rule(316,325,393,400))
            {
                // hareri
                Console.WriteLine("Hareri X: " + x + "         Y:" + y + "\n");

            }
            else if (Rule(228,518,318,600))
            {
                // somali
                Console.WriteLine("Somali X: " + x + "         Y:" + y + "\n");

            }
            else if (Rule(245,329,219,410) || Rule(278,329,260,340))
            {
                // Afar
                Console.WriteLine("Afar X: " + x + "         Y:" + y + "\n");
            }
            else if (false)
            {
                // Benshal gulgumz
            }
            
           
            else if (false)
            {
                // sidama
            }
            else if (false)
            {
                // oromiya
            }
            else if (false)
            {
                // addis ababa
            }
            else if (false)
            {
                // SNNP
            }
            else if (false)
            {
                // Gambela
            }
            
            else
            {
                Console.WriteLine("Unkown Region    X: " + x + "         Y:" + y + "\n");
            }
        }

        private bool Rule(int x1, int x2 , int y1 ,int y2)
        {
            Point point = pictureBox1.PointToClient(Cursor.Position);
            int x = point.X;
            int y = point.Y;
            if (x >= x1 && x <= x2 && (y >= y1 && y <= y2))
            {
                return true;
            }else
            {
                return false;
            }
        }

        
    }
}
