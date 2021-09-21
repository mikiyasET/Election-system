using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Election_system.Private.Admin;

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
                    SqlCommand cmd = new SqlCommand("SP_Admin_Signin", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", admin.username);
                    cmd.Parameters.AddWithValue("@password", admin.password);
                    int row = cmd.ExecuteNonQuery();
                    int result = cmd.ExecuteScalar() == null ? 0 : (int)cmd.ExecuteScalar();
                    if (result == 1)
                    {
                        AdminForm form = new AdminForm(admin);
                        Login.ActiveForm.Hide();
                        form.ShowDialog();
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
        public bool Exist(Admin admin)
        {
            try {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_Admin_exist", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", admin.username);
                    var r = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                    r.Direction = ParameterDirection.ReturnValue;
                    int row = cmd.ExecuteNonQuery();
                    int result = r.Value == null ? 0 : int.Parse(r.Value.ToString());
                    con.Close();
                    if (result == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            } catch (Exception e){
                MessageBox.Show(e.Message, "Internal Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }finally
            {

            }
        }
    }
}
