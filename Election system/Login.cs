using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Election_system
{
    public partial class Login : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse
            );
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            loginbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, loginbtn.Width, loginbtn.Height, 30, 30));
            choose.SelectedIndex = 1;
        }
        private void userChanged(Object sender,EventArgs e)
        {
            string user = choose.SelectedItem == null ? "" : choose.SelectedItem.ToString();
            if (user == "Admin")
            {
                username_id.Text = "Username";
            }else if (user == "Voter")
            {
                username_id.Text = "ID";
            }
        }
        private void loginbtn_Click(object sender, EventArgs e)
        {
            string user = choose.SelectedItem == null ? "" : choose.SelectedItem.ToString();
            string id = idbox.Text;
            string password = passwordbox.Text;
            if (user == "Voter")
            {
                Voters v = new Voters();
                v.IDNo = id;
                v.password = password;
                v.Login();
            }else if (user == "Admin")
            {
                Admin admin = new Admin(id,password);
                admin.Login();
            }else
            {
                MessageBox.Show("Unknown user");
            }
        }
    }
}
