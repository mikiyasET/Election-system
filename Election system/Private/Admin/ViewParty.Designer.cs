
namespace Election_system.Private.Admin
{
    partial class ViewParty
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo_img = new System.Windows.Forms.PictureBox();
            this.partyName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.search_box = new System.Windows.Forms.TextBox();
            this.spacer1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 609);
            this.panel1.TabIndex = 10;
            // 
            // logo_img
            // 
            this.logo_img.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo_img.BackColor = System.Drawing.Color.Transparent;
            this.logo_img.Image = global::Election_system.Properties.Resources.picture;
            this.logo_img.Location = new System.Drawing.Point(286, 9);
            this.logo_img.Name = "logo_img";
            this.logo_img.Size = new System.Drawing.Size(271, 200);
            this.logo_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_img.TabIndex = 15;
            this.logo_img.TabStop = false;
            // 
            // partyName
            // 
            this.partyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partyName.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partyName.Location = new System.Drawing.Point(0, 0);
            this.partyName.Name = "partyName";
            this.partyName.Size = new System.Drawing.Size(859, 127);
            this.partyName.TabIndex = 10;
            this.partyName.Text = "- - -";
            this.partyName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Party Details";
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
            // panel3
            // 
            this.panel3.Controls.Add(this.searchbtn);
            this.panel3.Controls.Add(this.search_box);
            this.panel3.Controls.Add(this.spacer1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20);
            this.panel3.Size = new System.Drawing.Size(859, 97);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 100);
            this.panel2.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.logo_img);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(859, 215);
            this.panel4.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.partyName);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 315);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(859, 127);
            this.panel5.TabIndex = 16;
            // 
            // ViewParty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "ViewParty";
            this.Size = new System.Drawing.Size(859, 706);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Panel spacer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox logo_img;
        private System.Windows.Forms.Label partyName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
    }
}
