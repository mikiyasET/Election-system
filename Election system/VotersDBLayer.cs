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
    class VotersDBLayer : Database
    {
        public void Insert(Voters v)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("AddVoters", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@firstName", v.firstName);
                    cmd.Parameters.AddWithValue("@middleName", v.middleName);
                    cmd.Parameters.AddWithValue("@lastName", v.lastName);
                    cmd.Parameters.AddWithValue("@password", v.password);
                    cmd.Parameters.AddWithValue("@birth", v.birth);
                    cmd.Parameters.AddWithValue("@phone", v.phone);
                    cmd.Parameters.AddWithValue("@idNo", v.IDNo);
                    cmd.Parameters.AddWithValue("@idImage", v.IDImage);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Save successfully!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Update(Voters v)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sqlUpdateUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@firstName", v.firstName);
                    cmd.Parameters.AddWithValue("@middleName", v.middleName);
                    cmd.Parameters.AddWithValue("@lastName", v.lastName);
                    cmd.Parameters.AddWithValue("@password", v.password);
                    cmd.Parameters.AddWithValue("@birth", v.birth);
                    cmd.Parameters.AddWithValue("@phone", v.phone);
                    cmd.Parameters.AddWithValue("@idNo", v.IDNo);
                    cmd.Parameters.AddWithValue("@idImage", v.IDImage);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Updated successfully!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Delete(Voters v)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sqlDeleteUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", v.IDNo);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Deleted successfully!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void signIn(Voters v)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Voter_Signin", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idNo", v.IDNo);
                    cmd.Parameters.AddWithValue("@password", v.password);
                    // cmd.Parameters.Add("@x", SqlDbType.Int,100).Direction = ParameterDirection.Output;
                    int row = cmd.ExecuteNonQuery();
                    // string result = Convert.ToString(cmd.Parameters["@x"].Value);
                    int result = cmd.ExecuteScalar() == null ? 0 : (int) cmd.ExecuteScalar();
                    if (result == 1)
                    {
                        MessageBox.Show("Successfull");
                    }else
                    {
                        MessageBox.Show("Id or password not correct", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
