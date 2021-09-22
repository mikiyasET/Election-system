using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Election_system
{
    public partial class Parties : UserControl
    {
        public Parties()
        {
            InitializeComponent();
            Election election = new Election();
            elections.DataSource = election.getElections();
            elections.DisplayMember = "ename";
            elections.ValueMember = "eid";
            DataRowView row = elections.SelectedItem as DataRowView;

            Vote vote = new Vote();
            vote.Eid = int.Parse(row.Row["eid"].ToString());

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

        private void Election_OnChange(object sender, EventArgs e)
        {
            DataRowView row = elections.SelectedItem as DataRowView;

            Vote vote = new Vote();
            vote.Eid = int.Parse(row.Row["eid"].ToString());

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
