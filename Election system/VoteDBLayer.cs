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
    class VoteDBLayer : Database
    {
        public void Insert (Vote v)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(voter_con))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_VOTE", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@vid", v.Vid);
                    cmd.Parameters.AddWithValue("@eid", v.Eid);
                    cmd.Parameters.AddWithValue("@pid", v.Pid);
                    var x = cmd.Parameters.Add("@msg", SqlDbType.VarChar, 100);
                    x.Direction = ParameterDirection.Output;
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Voted!", "Voted", MessageBoxButtons.OK, MessageBoxIcon.None);
                    else
                        MessageBox.Show(x.Value == null ? "" : x.Value.ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool Check (Vote v)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(viewer_con))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_CheckVoter", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@vid", v.Vid);
                    var r = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                    r.Direction = ParameterDirection.ReturnValue;
                    int row = cmd.ExecuteNonQuery();
                    int result = r.Value == null ? 0 : int.Parse(r.Value.ToString());
                    if (result == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    con.Close();


                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public DataTable PartiesLead(Vote v)
        {
            using (SqlConnection con = new SqlConnection(viewer_con))
            {
                con.Open();
                using (SqlDataAdapter cmd = new SqlDataAdapter())
                {
                    cmd.SelectCommand = new SqlCommand("SP_LeadBoard", con);
                    cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                    SqlParameter param = new SqlParameter("@msg", SqlDbType.VarChar, 100);
                    param.Direction = ParameterDirection.Output;
                    cmd.SelectCommand.Parameters.AddWithValue("@eid", v.Eid);
                    cmd.SelectCommand.Parameters.Add(param);

                    DataSet ds = new DataSet();
                    cmd.Fill(ds, "parties");
                    DataTable dt = ds.Tables["parties"];
                    return dt;
                }
            }
        }
    }
}
