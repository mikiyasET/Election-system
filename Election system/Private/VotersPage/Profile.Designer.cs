
namespace Election_system.Private.Voters
{
    partial class Profile
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.id_box = new System.Windows.Forms.Label();
            this.fullname_con = new System.Windows.Forms.Panel();
            this.lastName_box = new System.Windows.Forms.Label();
            this.middleName_box = new System.Windows.Forms.Label();
            this.firstName_box = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.phone_box = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.station_box = new System.Windows.Forms.Label();
            this.birth_box = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.fullname_con.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.fullname_con);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.phone_box);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.station_box);
            this.panel2.Controls.Add(this.birth_box);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 612);
            this.panel2.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.id_box);
            this.panel4.Location = new System.Drawing.Point(714, 441);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(112, 48);
            this.panel4.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Id:";
            this.label7.Click += new System.EventHandler(this.id_box_Click);
            // 
            // id_box
            // 
            this.id_box.AutoSize = true;
            this.id_box.Dock = System.Windows.Forms.DockStyle.Right;
            this.id_box.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_box.Location = new System.Drawing.Point(52, 10);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(50, 24);
            this.id_box.TabIndex = 7;
            this.id_box.Text = "- - -";
            this.id_box.Click += new System.EventHandler(this.id_box_Click);
            // 
            // fullname_con
            // 
            this.fullname_con.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fullname_con.AutoSize = true;
            this.fullname_con.Controls.Add(this.lastName_box);
            this.fullname_con.Controls.Add(this.middleName_box);
            this.fullname_con.Controls.Add(this.firstName_box);
            this.fullname_con.Location = new System.Drawing.Point(479, 129);
            this.fullname_con.Name = "fullname_con";
            this.fullname_con.Padding = new System.Windows.Forms.Padding(10);
            this.fullname_con.Size = new System.Drawing.Size(383, 44);
            this.fullname_con.TabIndex = 10;
            // 
            // lastName_box
            // 
            this.lastName_box.AutoSize = true;
            this.lastName_box.Dock = System.Windows.Forms.DockStyle.Left;
            this.lastName_box.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_box.Location = new System.Drawing.Point(110, 10);
            this.lastName_box.Name = "lastName_box";
            this.lastName_box.Size = new System.Drawing.Size(50, 24);
            this.lastName_box.TabIndex = 5;
            this.lastName_box.Text = "- - -";
            // 
            // middleName_box
            // 
            this.middleName_box.AutoSize = true;
            this.middleName_box.Dock = System.Windows.Forms.DockStyle.Left;
            this.middleName_box.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleName_box.Location = new System.Drawing.Point(60, 10);
            this.middleName_box.Name = "middleName_box";
            this.middleName_box.Size = new System.Drawing.Size(50, 24);
            this.middleName_box.TabIndex = 6;
            this.middleName_box.Text = "- - -";
            // 
            // firstName_box
            // 
            this.firstName_box.AutoSize = true;
            this.firstName_box.Dock = System.Windows.Forms.DockStyle.Left;
            this.firstName_box.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_box.Location = new System.Drawing.Point(10, 10);
            this.firstName_box.Name = "firstName_box";
            this.firstName_box.Size = new System.Drawing.Size(50, 24);
            this.firstName_box.TabIndex = 7;
            this.firstName_box.Text = "- - -";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 512);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 100);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(229, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "You can not change this information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Election_system.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(32, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // phone_box
            // 
            this.phone_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phone_box.AutoSize = true;
            this.phone_box.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_box.Location = new System.Drawing.Point(489, 188);
            this.phone_box.Name = "phone_box";
            this.phone_box.Size = new System.Drawing.Size(50, 24);
            this.phone_box.TabIndex = 4;
            this.phone_box.Text = "- - -";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(357, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Station";
            this.label6.Click += new System.EventHandler(this.id_box_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(357, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Birthday";
            this.label5.Click += new System.EventHandler(this.id_box_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone";
            this.label4.Click += new System.EventHandler(this.id_box_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Full Name:";
            this.label3.Click += new System.EventHandler(this.id_box_Click);
            // 
            // station_box
            // 
            this.station_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.station_box.AutoSize = true;
            this.station_box.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.station_box.Location = new System.Drawing.Point(489, 288);
            this.station_box.Name = "station_box";
            this.station_box.Size = new System.Drawing.Size(50, 24);
            this.station_box.TabIndex = 3;
            this.station_box.Text = "- - -";
            // 
            // birth_box
            // 
            this.birth_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.birth_box.AutoSize = true;
            this.birth_box.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_box.Location = new System.Drawing.Point(489, 239);
            this.birth_box.Name = "birth_box";
            this.birth_box.Size = new System.Drawing.Size(50, 24);
            this.birth_box.TabIndex = 3;
            this.birth_box.Text = "- - -";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(875, 612);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.fullname_con.ResumeLayout(false);
            this.fullname_con.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label phone_box;
        private System.Windows.Forms.Label lastName_box;
        private System.Windows.Forms.Label middleName_box;
        private System.Windows.Forms.Label firstName_box;
        private System.Windows.Forms.Label station_box;
        private System.Windows.Forms.Label birth_box;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel fullname_con;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label id_box;
    }
}
