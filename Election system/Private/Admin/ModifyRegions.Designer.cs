
namespace Election_system.Private.Admin
{
    partial class ModifyRegions
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.removebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.pop_box = new System.Windows.Forms.TextBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.population_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchbtn
            // 
            this.searchbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchbtn.Location = new System.Drawing.Point(694, 47);
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
            this.search_box.Size = new System.Drawing.Size(663, 30);
            this.search_box.TabIndex = 0;
            // 
            // spacer1
            // 
            this.spacer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacer1.Location = new System.Drawing.Point(20, 33);
            this.spacer1.Name = "spacer1";
            this.spacer1.Size = new System.Drawing.Size(843, 14);
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
            this.panel3.Size = new System.Drawing.Size(883, 97);
            this.panel3.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.removebtn);
            this.panel1.Controls.Add(this.updatebtn);
            this.panel1.Controls.Add(this.pop_box);
            this.panel1.Controls.Add(this.name_box);
            this.panel1.Controls.Add(this.population_label);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 637);
            this.panel1.TabIndex = 6;
            // 
            // removebtn
            // 
            this.removebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removebtn.Enabled = false;
            this.removebtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removebtn.Location = new System.Drawing.Point(625, 335);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(112, 48);
            this.removebtn.TabIndex = 9;
            this.removebtn.Text = "Remove";
            this.removebtn.UseVisualStyleBackColor = true;
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updatebtn.Enabled = false;
            this.updatebtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(507, 335);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(112, 48);
            this.updatebtn.TabIndex = 9;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // pop_box
            // 
            this.pop_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pop_box.Enabled = false;
            this.pop_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pop_box.Location = new System.Drawing.Point(466, 263);
            this.pop_box.Name = "pop_box";
            this.pop_box.Size = new System.Drawing.Size(272, 30);
            this.pop_box.TabIndex = 7;
            // 
            // name_box
            // 
            this.name_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name_box.Enabled = false;
            this.name_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_box.Location = new System.Drawing.Point(466, 206);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(272, 30);
            this.name_box.TabIndex = 8;
            // 
            // population_label
            // 
            this.population_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.population_label.AutoSize = true;
            this.population_label.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.population_label.Location = new System.Drawing.Point(150, 263);
            this.population_label.Name = "population_label";
            this.population_label.Size = new System.Drawing.Size(108, 24);
            this.population_label.TabIndex = 5;
            this.population_label.Text = "Population";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modify Regions";
            // 
            // ModifyRegions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "ModifyRegions";
            this.Size = new System.Drawing.Size(883, 734);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Panel spacer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox pop_box;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label population_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.Button updatebtn;
    }
}
