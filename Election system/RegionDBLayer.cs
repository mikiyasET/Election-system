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
    class RegionDBLayer : Database
    {
        public void Insert(Region r)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(admin_con))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_AddRegion", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@rname", r.Name);
                    cmd.Parameters.AddWithValue("@population", r.Population);
                    var x = cmd.Parameters.Add("@msg", SqlDbType.VarChar, 100);
                    x.Direction = ParameterDirection.Output;
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Inserted successfully!", "Region Added", MessageBoxButtons.OK, MessageBoxIcon.None);
                    else
                        MessageBox.Show(x.Value == null ? "" : x.Value.ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Update(Region r)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(admin_con))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_EditRegion", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@rid", r.RegionID);
                    cmd.Parameters.AddWithValue("@rname", r.Name);
                    cmd.Parameters.AddWithValue("@population", r.Population);
                    var x = cmd.Parameters.Add("@msg", SqlDbType.VarChar, 100);
                    x.Direction = ParameterDirection.Output;
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Updated successfully!", "Region modified", MessageBoxButtons.OK, MessageBoxIcon.None);
                    else
                        MessageBox.Show(x.Value == null ? "" : x.Value.ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void Delete(Region r)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(admin_con))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_RemoveRegion", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@rid", r.RegionID);
                    var x = cmd.Parameters.Add("@msg", SqlDbType.VarChar, 100);
                    x.Direction = ParameterDirection.Output;
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Deleted successfully!", "Region Removed", MessageBoxButtons.OK, MessageBoxIcon.None);
                    else
                        MessageBox.Show(x.Value == null ? "" : x.Value.ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Region Details(Region region,int eid)
        {
            SqlConnection myConnection = new SqlConnection(admin_con);
            SqlCommand cmd = new SqlCommand("SP_GetDetails", myConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            myConnection.Open();

            SqlParameter custId = cmd.Parameters.Add("@rid", SqlDbType.Int);
            custId.Direction = ParameterDirection.Input;
            custId.Value = region.RegionID;

            SqlParameter eids = cmd.Parameters.Add("@eid", SqlDbType.Int);
            eids.Direction = ParameterDirection.Input;
            eids.Value = eid;

            SqlParameter msg = cmd.Parameters.Add("@msg", SqlDbType.Int);
            msg.Direction = ParameterDirection.Output;
            
            Region result = new Region();
            string message = msg.Value == null ? "" : msg.Value.ToString();
            if (message == "")
            {
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
;
                dr.Read();
                result.RegionID = int.Parse(dr["id"].ToString());
                result.Name = dr["name"].ToString();
                result.Population = int.Parse(dr["population"].ToString());
                result.Stations = int.Parse(dr["stations"].ToString());
                result.Voter = int.Parse(dr["voters"].ToString());
                result.Voted = int.Parse(dr["voted"].ToString());
            }else
            {
                MessageBox.Show(msg.Value.ToString());
            }
            return result;
        }
        public DataTable Regions()
        {
            using (SqlConnection con = new SqlConnection(admin_con))
            {
                con.Open();
                using (SqlDataAdapter cmd = new SqlDataAdapter())
                {
                    cmd.SelectCommand = new SqlCommand("SP_GETRegions", con);
                    cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                    
                    DataSet ds = new DataSet();
                    cmd.Fill(ds, "regions");
                    DataTable dt = ds.Tables["regions"];
                    return dt;
                }
            }
        }
        public Region Region(Region r)
        {
            using (SqlConnection con = new SqlConnection(admin_con))
            {
                con.Open();
                Region region = new Region();
                SqlDataAdapter cmd = new SqlDataAdapter("SP_GetRegion", con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("@msg", SqlDbType.VarChar, 100);
                param.Direction = ParameterDirection.Output;
                cmd.SelectCommand.Parameters.AddWithValue("@rname", r.Name);
                cmd.SelectCommand.Parameters.Add(param);
                int row = cmd.SelectCommand.ExecuteNonQuery();
                if (param.Value.ToString() == "")
                {
                    DataSet ds = new DataSet();
                    cmd.Fill(ds, "regions");
                    DataTable dt = ds.Tables["regions"];

                    foreach (DataRow rows in dt.Rows)
                    {
                        region.RegionID = int.Parse(rows["rid"].ToString());
                        region.Name = rows["rname"].ToString();
                        region.Population = int.Parse(rows["rpopulation"].ToString());
                        region.HasValue = true;
                    }
                }
                else
                {
                    MessageBox.Show(param.Value.ToString(), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return region;
            }
        }
        public int Size()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(admin_con))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_CountRegions", con);
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
        public int Population()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(admin_con))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_Population", con);
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
