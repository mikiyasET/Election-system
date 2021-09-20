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

    class StationDBLayer : Database
    {
        public void Insert(Station s)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_AddStation", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sname", s.Name);
                    cmd.Parameters.AddWithValue("@rid", s.Rid);
                    var x = cmd.Parameters.Add("@msg", SqlDbType.VarChar, 100);
                    x.Direction = ParameterDirection.Output;
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Inserted successfully!", "Station Added", MessageBoxButtons.OK, MessageBoxIcon.None);
                    else
                        MessageBox.Show(x.Value == null ? "" : x.Value.ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Update(Station s)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_EditStation", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sid", s.Sid);
                    cmd.Parameters.AddWithValue("@sname", s.Name);
                    cmd.Parameters.AddWithValue("@rid", s.Rid);
                    var x = cmd.Parameters.Add("@msg", SqlDbType.VarChar, 100);
                    x.Direction = ParameterDirection.Output;
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Updated successfully!", "Station modified", MessageBoxButtons.OK, MessageBoxIcon.None);
                    else
                        MessageBox.Show(x.Value == null ? "" : x.Value.ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Delete(Station s)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_RemoveStation", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sid", s.Sid);
                    var x = cmd.Parameters.Add("@msg", SqlDbType.VarChar, 100);
                    x.Direction = ParameterDirection.Output;
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                        MessageBox.Show("Deleted successfully!", "Station Removed", MessageBoxButtons.OK, MessageBoxIcon.None);
                    else
                        MessageBox.Show(x.Value == null ? "" : x.Value.ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable stations()
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                using (SqlDataAdapter cmd = new SqlDataAdapter())
                {
                    cmd.SelectCommand = new SqlCommand("SP_GetStations", con);
                    cmd.SelectCommand.CommandType = CommandType.StoredProcedure;

                    DataSet ds = new DataSet();
                    cmd.Fill(ds, "station");
                    DataTable dt = ds.Tables["station"];
                    return dt;
                }
            }
        }
        public Station Station(Station s)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                Station station = new Station();
                SqlDataAdapter cmd = new SqlDataAdapter("SP_GetStation", con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("@msg", SqlDbType.VarChar, 100);
                param.Direction = ParameterDirection.Output;
                cmd.SelectCommand.Parameters.AddWithValue("@sname", s.Name);
                cmd.SelectCommand.Parameters.Add(param);
                int row = cmd.SelectCommand.ExecuteNonQuery();
                if (param.Value.ToString() == "")
                {
                    DataSet ds = new DataSet();
                    cmd.Fill(ds, "station");
                    DataTable dt = ds.Tables["station"];

                    foreach (DataRow rows in dt.Rows)
                    {
                        station.Sid = int.Parse(rows["sid"].ToString());
                        station.Name = rows["sname"].ToString();
                        station.Rid = int.Parse(rows["rid"].ToString());
                        station.HasValue = true;
                    }
                }
                else
                {
                    MessageBox.Show(param.Value.ToString(), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return station;
            }
        }
        public int Size()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_CountStations", con);
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
