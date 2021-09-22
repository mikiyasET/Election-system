using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Election_system
{
    class ElectionDBLayer : Database
    {
        public void Insert(Election election)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(admin_con))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_AddElection", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", election.Name);
                    cmd.Parameters.AddWithValue("@start", election.Starting);
                    cmd.Parameters.AddWithValue("@end", election.Ending);
                    var x = cmd.Parameters.Add("@msg", SqlDbType.VarChar, 100);
                    x.Direction = ParameterDirection.Output;
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Inserted successfully!", "Election Added", MessageBoxButtons.OK, MessageBoxIcon.None);
                    else
                        MessageBox.Show(x.Value == null ? "" : x.Value.ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Update(Election election)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(admin_con))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_EditElection", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@eid", election.Eid);
                    cmd.Parameters.AddWithValue("@name", election.Name);
                    cmd.Parameters.AddWithValue("@start", election.Starting);
                    cmd.Parameters.AddWithValue("@end", election.Ending);
                    var x = cmd.Parameters.Add("@msg", SqlDbType.VarChar, 100);
                    x.Direction = ParameterDirection.Output;
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Updated successfully!", "Election modified", MessageBoxButtons.OK, MessageBoxIcon.None);
                    else
                        MessageBox.Show(x.Value == null ? "" : x.Value.ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Delete(Election election)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(admin_con))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_RemoveElection", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@eid", election.Eid);
                    var x = cmd.Parameters.Add("@msg", SqlDbType.VarChar, 100);
                    x.Direction = ParameterDirection.Output;
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Deleted successfully!", "Election Removed", MessageBoxButtons.OK, MessageBoxIcon.None);
                    else
                        MessageBox.Show(x.Value == null ? "" : x.Value.ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Election Election(Election el)
        {
            using (SqlConnection con = new SqlConnection(viewer_con))
            {
                con.Open();
                Election election = new Election();
                SqlDataAdapter cmd = new SqlDataAdapter("SP_GetElection", con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("@msg", SqlDbType.VarChar, 100);
                param.Direction = ParameterDirection.Output;
                cmd.SelectCommand.Parameters.AddWithValue("@ename", el.Name);
                cmd.SelectCommand.Parameters.Add(param);
                int row = cmd.SelectCommand.ExecuteNonQuery();
                if (param.Value.ToString() == "")
                {
                    DataSet ds = new DataSet();
                    cmd.Fill(ds, "election");
                    DataTable dt = ds.Tables["election"];

                    foreach (DataRow rows in dt.Rows)
                    {
                        election.Eid = int.Parse(rows["eid"].ToString());
                        election.Name = rows["ename"].ToString();
                        election.Starting = (DateTime) rows["e_start"];
                        election.Ending = (DateTime)rows["e_end"];
                        election.HasValue = true;
                    }
                }
                else
                {
                    MessageBox.Show(param.Value.ToString(), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return election;
            }
        }
        public DataTable Elections()
        {
            using (SqlConnection con = new SqlConnection(viewer_con))
            {
                con.Open();
                using (SqlDataAdapter cmd = new SqlDataAdapter())
                {
                    cmd.SelectCommand = new SqlCommand("SP_GetElections", con);
                    cmd.SelectCommand.CommandType = CommandType.StoredProcedure;

                    DataSet ds = new DataSet();
                    cmd.Fill(ds, "election");
                    DataTable dt = ds.Tables["election"];
                    return dt;
                }
            }
        }

    }
}
