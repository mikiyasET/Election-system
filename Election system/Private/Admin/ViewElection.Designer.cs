
namespace Election_system.Private.Admin
{
    partial class ViewElection
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchbtn = new System.Windows.Forms.Button();
            this.search_box = new System.Windows.Forms.TextBox();
            this.spacer1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.searchpanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.Label();
            this.searchpanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchbtn
            // 
            this.searchbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchbtn.Location = new System.Drawing.Point(670, 47);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(169, 30);
            this.searchbtn.TabIndex = 1;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // search_box
            // 
            this.search_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box.Location = new System.Drawing.Point(20, 47);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(639, 30);
            this.search_box.TabIndex = 0;
            // 
            // spacer1
            // 
            this.spacer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacer1.Location = new System.Drawing.Point(20, 33);
            this.spacer1.Name = "spacer1";
            this.spacer1.Size = new System.Drawing.Size(819, 14);
            this.spacer1.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(20, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Name";
            // 
            // searchpanel
            // 
            this.searchpanel.Controls.Add(this.searchbtn);
            this.searchpanel.Controls.Add(this.search_box);
            this.searchpanel.Controls.Add(this.spacer1);
            this.searchpanel.Controls.Add(this.label9);
            this.searchpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchpanel.Location = new System.Drawing.Point(0, 0);
            this.searchpanel.Name = "searchpanel";
            this.searchpanel.Padding = new System.Windows.Forms.Padding(20);
            this.searchpanel.Size = new System.Drawing.Size(859, 97);
            this.searchpanel.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.name);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(35);
            this.panel3.Size = new System.Drawing.Size(400, 105);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.start);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 114);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(35);
            this.panel4.Size = new System.Drawing.Size(400, 105);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.end);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 225);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(35);
            this.panel5.Size = new System.Drawing.Size(400, 105);
            this.panel5.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F);
            this.label4.Location = new System.Drawing.Point(0, 216);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(327, 108);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ending Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F);
            this.label3.Location = new System.Drawing.Point(0, 108);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(327, 108);
            this.label3.TabIndex = 0;
            this.label3.Text = "Starting Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(327, 108);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(327, 97);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(532, 505);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 505);
            this.panel2.TabIndex = 10;
            // 
            // name
            // 
            this.name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name.Font = new System.Drawing.Font("Arial", 15.75F);
            this.name.Location = new System.Drawing.Point(35, 35);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(330, 35);
            this.name.TabIndex = 0;
            this.name.Text = "- - -";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // start
            // 
            this.start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.start.Font = new System.Drawing.Font("Arial", 15.75F);
            this.start.Location = new System.Drawing.Point(35, 35);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(330, 35);
            this.start.TabIndex = 0;
            this.start.Text = "- - -";
            this.start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // end
            // 
            this.end.Dock = System.Windows.Forms.DockStyle.Fill;
            this.end.Font = new System.Drawing.Font("Arial", 15.75F);
            this.end.Location = new System.Drawing.Point(35, 35);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(330, 35);
            this.end.TabIndex = 0;
            this.end.Text = "- - -";
            this.end.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewElection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.searchpanel);
            this.Name = "ViewElection";
            this.Size = new System.Drawing.Size(859, 602);
            this.searchpanel.ResumeLayout(false);
            this.searchpanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Panel spacer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel searchpanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label end;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
    }
}
