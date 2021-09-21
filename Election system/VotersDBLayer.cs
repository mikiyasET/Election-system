using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Election_system.Private.Voters;

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
                    SqlCommand cmd = new SqlCommand("SP_AddVoters", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@firstName", v.FirstName);
                    cmd.Parameters.AddWithValue("@middleName", v.MiddleName);
                    cmd.Parameters.AddWithValue("@lastName", v.LastName);
                    cmd.Parameters.AddWithValue("@password", v.Password);
                    cmd.Parameters.AddWithValue("@birth", v.Birth);
                    cmd.Parameters.AddWithValue("@phone", v.Phone);
                    cmd.Parameters.AddWithValue("@idNo", v.IDNo);
                    cmd.Parameters.AddWithValue("@idImage", v.IDImage);
                    cmd.Parameters.AddWithValue("@sid", v.Station);
                    var x = cmd.Parameters.Add("@msg",SqlDbType.VarChar,100);
                    x.Direction = ParameterDirection.Output;
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Inserted successfully!", "Voter Added", MessageBoxButtons.OK, MessageBoxIcon.None);
                    else
                        MessageBox.Show(x.Value==null ? "" : x.Value.ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Update(Voters v)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_EditVoters", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@vid", v.Vid);
                    cmd.Parameters.AddWithValue("@firstName", v.FirstName);
                    cmd.Parameters.AddWithValue("@middleName", v.MiddleName);
                    cmd.Parameters.AddWithValue("@lastName", v.LastName);
                    cmd.Parameters.AddWithValue("@birth", v.Birth);
                    cmd.Parameters.AddWithValue("@phone", v.Phone);
                    cmd.Parameters.AddWithValue("@idNo", v.IDNo);
                    cmd.Parameters.AddWithValue("@idImage", v.IDImage);
                    cmd.Parameters.AddWithValue("@sid", v.Station);
                    var x = cmd.Parameters.Add("@msg", SqlDbType.VarChar, 100);
                    x.Direction = ParameterDirection.Output;
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Updated successfully!", "Voter modified", MessageBoxButtons.OK, MessageBoxIcon.None);
                    else
                        MessageBox.Show(x.Value == null ? "" : x.Value.ToString());
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
                    SqlCommand cmd = new SqlCommand("SP_RemoveVoters", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@vid", v.Vid);
                    var x = cmd.Parameters.Add("@msg", SqlDbType.VarChar, 100);
                    x.Direction = ParameterDirection.Output;
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Deleted successfully!", "Voter Removed", MessageBoxButtons.OK, MessageBoxIcon.None);
                    else
                        MessageBox.Show(x.Value == null ? "" : x.Value.ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void signIn(Voters v)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_Voter_Signin", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idNo", v.IDNo);
                    cmd.Parameters.AddWithValue("@password", v.Password);
                    var r = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                    r.Direction = ParameterDirection.ReturnValue;
                    int row = cmd.ExecuteNonQuery();
                    int result = r.Value == null ? 0 : int.Parse(r.Value.ToString());
                    if (result == 1)
                    {
                        VotersForm form = new VotersForm(Voter(v));
                        Login.ActiveForm.Hide();
                        form.ShowDialog();
                    }else
                    {
                        MessageBox.Show("Id or password not correct", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();


                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Voters Voter(Voters v)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                using (SqlDataAdapter cmd = new SqlDataAdapter())
                {
                    cmd.SelectCommand = new SqlCommand("SP_GetVoters", con);
                    cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                    cmd.SelectCommand.Parameters.AddWithValue("@id", v.IDNo);

                    DataSet ds = new DataSet();
                    cmd.Fill(ds, "voters");
                    DataTable dt = ds.Tables["voters"];
                    Voters voters = new Voters();
                    foreach (DataRow row in dt.Rows)
                    {
                        voters.Vid = int.Parse(row["vid"].ToString());
                        voters.FirstName = row["firstName"].ToString();
                        voters.MiddleName = row["middleName"].ToString();
                        voters.LastName = row["lastName"].ToString();
                        voters.Birth = Convert.ToDateTime(row["birth"]);
                        voters.Phone = int.Parse(row["phone"].ToString());
                        voters.FirstName = row["firstName"].ToString();
                        voters.IDNo = row["idNo"].ToString();
                        voters.IDImage = (byte []) row["idimage"];
                        voters.Station = int.Parse(row["sid"].ToString());
                    }
                    return voters;
                }
            }
        }
        
        public int Size()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_CountVoters", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    var x = cmd.Parameters.Add("@size", SqlDbType.Int);
                    x.Direction = ParameterDirection.Output;
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    bool check = x.Value == null ? false : true;
                    if (check)
                        return int.Parse(x.Value.ToString());
                    else
                        return 0;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}
