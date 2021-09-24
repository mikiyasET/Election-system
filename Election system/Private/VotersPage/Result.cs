using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Election_system.Private.VotersPage
{
    public partial class Result : UserControl
    {
        int eid;
        public Result(Election_system.Voters v)
        {
            InitializeComponent();

            Vote vote = new Vote();
            Station x = new Station();
            x.Sid = v.Station;
            eid = x.getStationByID().Eid;
            vote.Eid = eid;

            DataTable dtable = vote.PartiesByEID();
            dtable = dtable.DefaultView.ToTable();
            dtable.Columns.Add("Rank", typeof(Int32)).SetOrdinal(0);
            int srNo = 1;
            foreach (DataRow rows in dtable.Rows)
            {
                rows["Rank"] = srNo++;
            }
            leadboard_table.DataSource = dtable;
            DataGridViewColumn column = leadboard_table.Columns[2];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            leadboard_table.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            leadboard_table.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ((DataGridViewImageColumn)leadboard_table.Columns[2]).ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        
    }
}
