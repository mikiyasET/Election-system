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
    class PartyDBLayer : Database
    {

        public void Insert(Party party)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(admin_con))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_AddParty", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pname", party.Name);
                    cmd.Parameters.AddWithValue("@logo", party.Logo);
                    cmd.Parameters.AddWithValue("@eid", party.Eid);
                    var x = cmd.Parameters.Add("@msg", SqlDbType.VarChar, 100);
                    x.Direction = ParameterDirection.Output;
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Inserted successfully!", "Party Added", MessageBoxButtons.OK, MessageBoxIcon.None);
                    else
                        MessageBox.Show(x.Value == null ? "" : x.Value.ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Internal Error - Party", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Edit(Party party)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(admin_con))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_EditParty", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pid", party.Pid);
                    cmd.Parameters.AddWithValue("@pname", party.Name);
                    cmd.Parameters.AddWithValue("@logo", party.Logo);
                    cmd.Parameters.AddWithValue("@eid", party.Eid);
                    var x = cmd.Parameters.Add("@msg", SqlDbType.VarChar, 100);
                    x.Direction = ParameterDirection.Output;
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Updated successfully!", "Party modified", MessageBoxButtons.OK, MessageBoxIcon.None);
                    else
                        MessageBox.Show(x.Value == null ? "" : x.Value.ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Delete(Party party)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(admin_con))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_RemoveParty", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pid", party.Pid);
                    var x = cmd.Parameters.Add("@msg", SqlDbType.VarChar, 100);
                    x.Direction = ParameterDirection.Output;
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Deleted successfully!", "Party Removed", MessageBoxButtons.OK, MessageBoxIcon.None);
                    else
                        MessageBox.Show(x.Value == null ? "" : x.Value.ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Internal Error - Party", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Party MyParty(Party p) {
            using (SqlConnection con = new SqlConnection(viewer_con))
            {
                con.Open();
                Party party = new Party();
                SqlDataAdapter cmd = new SqlDataAdapter("SP_GetParty",con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("@msg", SqlDbType.VarChar,100);
                param.Direction = ParameterDirection.Output;
                cmd.SelectCommand.Parameters.AddWithValue("@pname", p.Name);
                cmd.SelectCommand.Parameters.Add(param);
                int row = cmd.SelectCommand.ExecuteNonQuery();
                if (param.Value.ToString() == "")
                {
                    DataSet ds = new DataSet();
                    cmd.Fill(ds, "parties");
                    DataTable dt = ds.Tables["parties"];

                    foreach (DataRow rows in dt.Rows)
                    {
                        party.Pid = int.Parse(rows["pid"].ToString());
                        party.Name = rows["pname"].ToString();
                        party.Logo = (byte[])rows["logo"];
                        party.Eid = int.Parse(rows["eid"].ToString());
                        party.HasValue = true;
                    }
                }
                else
                {
                    MessageBox.Show(param.Value.ToString(), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return party;
            }
        }
        public DataTable Parties()
        {
            using (SqlConnection con = new SqlConnection(viewer_con))
            {
                con.Open();
                using (SqlDataAdapter cmd = new SqlDataAdapter())
                {
                    cmd.SelectCommand = new SqlCommand("SP_GetParties", con);
                    cmd.SelectCommand.CommandType = CommandType.StoredProcedure;

                    DataSet ds = new DataSet();
                    cmd.Fill(ds, "parties");
                    DataTable dt = ds.Tables["parties"];
                    return dt;
                }
            }
        }
        public DataTable PartiesByEID(Party p)
        {
            using (SqlConnection con = new SqlConnection(viewer_con))
            {
                con.Open();
                using (SqlDataAdapter cmd = new SqlDataAdapter())
                {
                    cmd.SelectCommand = new SqlCommand("SP_GetPartiesByEID", con);
                    cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                    SqlParameter param = new SqlParameter("@msg", SqlDbType.VarChar, 100);
                    param.Direction = ParameterDirection.Output;
                    cmd.SelectCommand.Parameters.AddWithValue("@eid", p.Eid);
                    cmd.SelectCommand.Parameters.Add(param);

                    DataSet ds = new DataSet();
                    cmd.Fill(ds, "parties");
                    DataTable dt = ds.Tables["parties"];
                    return dt;
                }
            }
        }
        public int Size()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(viewer_con))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_CountParties", con);
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
                MessageBox.Show(e.Message, "Internal Error - Party", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

    }
}
