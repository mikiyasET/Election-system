
namespace Election_system.Private.Admin
{
    partial class ModifyParty
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo_img = new System.Windows.Forms.PictureBox();
            this.logobtn = new System.Windows.Forms.Button();
            this.name_box = new System.Windows.Forms.TextBox();
            this.population_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.removebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchbtn
            // 
            this.searchbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchbtn.Location = new System.Drawing.Point(509, 47);
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
            this.search_box.Size = new System.Drawing.Size(478, 30);
            this.search_box.TabIndex = 0;
            // 
            // spacer1
            // 
            this.spacer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacer1.Location = new System.Drawing.Point(20, 33);
            this.spacer1.Name = "spacer1";
            this.spacer1.Size = new System.Drawing.Size(658, 14);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.logo_img);
            this.panel1.Controls.Add(this.logobtn);
            this.panel1.Controls.Add(this.name_box);
            this.panel1.Controls.Add(this.population_label);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.removebtn);
            this.panel1.Controls.Add(this.updatebtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 540);
            this.panel1.TabIndex = 8;
            // 
            // logo_img
            // 
            this.logo_img.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo_img.BackColor = System.Drawing.Color.Transparent;
            this.logo_img.Image = global::Election_system.Properties.Resources.addpic;
            this.logo_img.Location = new System.Drawing.Point(371, 182);
            this.logo_img.Name = "logo_img";
            this.logo_img.Size = new System.Drawing.Size(272, 180);
            this.logo_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_img.TabIndex = 15;
            this.logo_img.TabStop = false;
            // 
            // logobtn
            // 
            this.logobtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logobtn.Enabled = false;
            this.logobtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logobtn.Location = new System.Drawing.Point(371, 368);
            this.logobtn.Name = "logobtn";
            this.logobtn.Size = new System.Drawing.Size(272, 31);
            this.logobtn.TabIndex = 14;
            this.logobtn.Text = "choose image ...";
            this.logobtn.UseVisualStyleBackColor = true;
            this.logobtn.Click += new System.EventHandler(this.logobtn_Click);
            // 
            // name_box
            // 
            this.name_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name_box.Enabled = false;
            this.name_box.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_box.Location = new System.Drawing.Point(371, 142);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(272, 30);
            this.name_box.TabIndex = 13;
            // 
            // population_label
            // 
            this.population_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.population_label.AutoSize = true;
            this.population_label.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.population_label.Location = new System.Drawing.Point(55, 182);
            this.population_label.Name = "population_label";
            this.population_label.Size = new System.Drawing.Size(57, 24);
            this.population_label.TabIndex = 11;
            this.population_label.Text = "Logo";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Modify Party";
            // 
            // removebtn
            // 
            this.removebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removebtn.Enabled = false;
            this.removebtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removebtn.Location = new System.Drawing.Point(509, 416);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(134, 48);
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
            this.updatebtn.Location = new System.Drawing.Point(371, 416);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(127, 48);
            this.updatebtn.TabIndex = 9;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
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
            this.panel3.Size = new System.Drawing.Size(698, 97);
            this.panel3.TabIndex = 7;
            // 
            // ModifyParty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "ModifyParty";
            this.Size = new System.Drawing.Size(698, 637);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Panel spacer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo_img;
        private System.Windows.Forms.Button logobtn;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label population_label;
        private System.Windows.Forms.Label label2;
    }
}
