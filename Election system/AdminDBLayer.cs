using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Election_system
{
    class AdminDBLayer : Database
    {
        public void signIn(Admin admin)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Admin_Signin", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", admin.username);
                    cmd.Parameters.AddWithValue("@password", admin.password);
                    int row = cmd.ExecuteNonQuery();
                    int result = cmd.ExecuteScalar() == null ? 0 : (int)cmd.ExecuteScalar();
                    if (result == 1)
                    {
                        MessageBox.Show("Successfull");
                    }
                    else
                    {
                        MessageBox.Show("Username or password not correct", "Login error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
