
namespace Election_system.Private.Voters
{
    partial class VotersForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.voter_con = new System.Windows.Forms.Panel();
            this.voter_txt_con = new System.Windows.Forms.Panel();
            this.voter_txt = new System.Windows.Forms.Label();
            this.voter_icon = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.viewVoters_btn = new System.Windows.Forms.Button();
            this.modifyVoters_btn = new System.Windows.Forms.Button();
            this.addVoters_btn = new System.Windows.Forms.Button();
            this.result_txt = new System.Windows.Forms.Label();
            this.home_con = new System.Windows.Forms.Panel();
            this.home_txt_con = new System.Windows.Forms.Panel();
            this.home_txt = new System.Windows.Forms.Label();
            this.home_icon = new System.Windows.Forms.PictureBox();
            this.Spacer = new System.Windows.Forms.Panel();
            this.body = new System.Windows.Forms.Panel();
            this.result_txt_con = new System.Windows.Forms.Panel();
            this.sidenav = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.result_con = new System.Windows.Forms.Panel();
            this.result_icon = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.voter_con.SuspendLayout();
            this.voter_txt_con.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voter_icon)).BeginInit();
            this.panel8.SuspendLayout();
            this.home_con.SuspendLayout();
            this.home_txt_con.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_icon)).BeginInit();
            this.result_txt_con.SuspendLayout();
            this.sidenav.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.result_con.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.result_icon)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // voter_con
            // 
            this.voter_con.Controls.Add(this.voter_txt_con);
            this.voter_con.Controls.Add(this.voter_icon);
            this.voter_con.Controls.Add(this.panel8);
            this.voter_con.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voter_con.Dock = System.Windows.Forms.DockStyle.Top;
            this.voter_con.Location = new System.Drawing.Point(0, 386);
            this.voter_con.Name = "voter_con";
            this.voter_con.Padding = new System.Windows.Forms.Padding(25, 5, 5, 0);
            this.voter_con.Size = new System.Drawing.Size(385, 60);
            this.voter_con.TabIndex = 1;
            this.voter_con.Click += new System.EventHandler(this.Votebtn_Click);
            // 
            // voter_txt_con
            // 
            this.voter_txt_con.Controls.Add(this.voter_txt);
            this.voter_txt_con.Location = new System.Drawing.Point(125, 5);
            this.voter_txt_con.Name = "voter_txt_con";
            this.voter_txt_con.Size = new System.Drawing.Size(255, 52);
            this.voter_txt_con.TabIndex = 0;
            this.voter_txt_con.Click += new System.EventHandler(this.Votebtn_Click);
            // 
            // voter_txt
            // 
            this.voter_txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.voter_txt.AutoSize = true;
            this.voter_txt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voter_txt.ForeColor = System.Drawing.Color.White;
            this.voter_txt.Location = new System.Drawing.Point(40, 15);
            this.voter_txt.Name = "voter_txt";
            this.voter_txt.Size = new System.Drawing.Size(49, 22);
            this.voter_txt.TabIndex = 1;
            this.voter_txt.Text = "Vote";
            this.voter_txt.Click += new System.EventHandler(this.Votebtn_Click);
            // 
            // voter_icon
            // 
            this.voter_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.voter_icon.Image = global::Election_system.Properties.Resources.vote__1_;
            this.voter_icon.Location = new System.Drawing.Point(25, 5);
            this.voter_icon.Name = "voter_icon";
            this.voter_icon.Size = new System.Drawing.Size(100, 52);
            this.voter_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.voter_icon.TabIndex = 0;
            this.voter_icon.TabStop = false;
            this.voter_icon.Click += new System.EventHandler(this.Votebtn_Click);
            // 
            // panel8
            // 
            this.panel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel8.Controls.Add(this.viewVoters_btn);
            this.panel8.Controls.Add(this.modifyVoters_btn);
            this.panel8.Controls.Add(this.addVoters_btn);
            this.panel8.Location = new System.Drawing.Point(25, 59);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(355, 124);
            this.panel8.TabIndex = 0;
            // 
            // viewVoters_btn
            // 
            this.viewVoters_btn.FlatAppearance.BorderSize = 0;
            this.viewVoters_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewVoters_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewVoters_btn.ForeColor = System.Drawing.Color.White;
            this.viewVoters_btn.Location = new System.Drawing.Point(136, 83);
            this.viewVoters_btn.Name = "viewVoters_btn";
            this.viewVoters_btn.Size = new System.Drawing.Size(206, 34);
            this.viewVoters_btn.TabIndex = 0;
            this.viewVoters_btn.Text = "View Voters";
            this.viewVoters_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewVoters_btn.UseVisualStyleBackColor = true;
            // 
            // modifyVoters_btn
            // 
            this.modifyVoters_btn.FlatAppearance.BorderSize = 0;
            this.modifyVoters_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyVoters_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyVoters_btn.ForeColor = System.Drawing.Color.White;
            this.modifyVoters_btn.Location = new System.Drawing.Point(136, 43);
            this.modifyVoters_btn.Name = "modifyVoters_btn";
            this.modifyVoters_btn.Size = new System.Drawing.Size(206, 34);
            this.modifyVoters_btn.TabIndex = 0;
            this.modifyVoters_btn.Text = "Modify Voters";
            this.modifyVoters_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modifyVoters_btn.UseVisualStyleBackColor = true;
            // 
            // addVoters_btn
            // 
            this.addVoters_btn.FlatAppearance.BorderSize = 0;
            this.addVoters_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addVoters_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVoters_btn.ForeColor = System.Drawing.Color.White;
            this.addVoters_btn.Location = new System.Drawing.Point(136, 3);
            this.addVoters_btn.Name = "addVoters_btn";
            this.addVoters_btn.Size = new System.Drawing.Size(206, 34);
            this.addVoters_btn.TabIndex = 0;
            this.addVoters_btn.Text = "Add Voters";
            this.addVoters_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addVoters_btn.UseVisualStyleBackColor = true;
            // 
            // result_txt
            // 
            this.result_txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.result_txt.AutoSize = true;
            this.result_txt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_txt.ForeColor = System.Drawing.Color.White;
            this.result_txt.Location = new System.Drawing.Point(40, 15);
            this.result_txt.Name = "result_txt";
            this.result_txt.Size = new System.Drawing.Size(64, 22);
            this.result_txt.TabIndex = 1;
            this.result_txt.Text = "Result";
            this.result_txt.Click += new System.EventHandler(this.Resultbtn_Click);
            // 
            // home_con
            // 
            this.home_con.Controls.Add(this.home_txt_con);
            this.home_con.Controls.Add(this.home_icon);
            this.home_con.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_con.Dock = System.Windows.Forms.DockStyle.Top;
            this.home_con.Location = new System.Drawing.Point(0, 326);
            this.home_con.Name = "home_con";
            this.home_con.Padding = new System.Windows.Forms.Padding(25, 5, 5, 0);
            this.home_con.Size = new System.Drawing.Size(385, 60);
            this.home_con.TabIndex = 1;
            this.home_con.Click += new System.EventHandler(this.Profilebtn_Click);
            // 
            // home_txt_con
            // 
            this.home_txt_con.Controls.Add(this.home_txt);
            this.home_txt_con.Location = new System.Drawing.Point(125, 5);
            this.home_txt_con.Name = "home_txt_con";
            this.home_txt_con.Size = new System.Drawing.Size(255, 52);
            this.home_txt_con.TabIndex = 0;
            this.home_txt_con.Click += new System.EventHandler(this.Profilebtn_Click);
            // 
            // home_txt
            // 
            this.home_txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.home_txt.AutoSize = true;
            this.home_txt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_txt.ForeColor = System.Drawing.Color.White;
            this.home_txt.Location = new System.Drawing.Point(40, 15);
            this.home_txt.Name = "home_txt";
            this.home_txt.Size = new System.Drawing.Size(65, 22);
            this.home_txt.TabIndex = 1;
            this.home_txt.Text = "Profile";
            this.home_txt.Click += new System.EventHandler(this.Profilebtn_Click);
            // 
            // home_icon
            // 
            this.home_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.home_icon.Image = global::Election_system.Properties.Resources.user;
            this.home_icon.Location = new System.Drawing.Point(25, 5);
            this.home_icon.Name = "home_icon";
            this.home_icon.Size = new System.Drawing.Size(100, 52);
            this.home_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.home_icon.TabIndex = 0;
            this.home_icon.TabStop = false;
            this.home_icon.Click += new System.EventHandler(this.Profilebtn_Click);
            // 
            // Spacer
            // 
            this.Spacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Spacer.Location = new System.Drawing.Point(0, 287);
            this.Spacer.Name = "Spacer";
            this.Spacer.Size = new System.Drawing.Size(385, 39);
            this.Spacer.TabIndex = 0;
            // 
            // body
            // 
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Location = new System.Drawing.Point(385, 0);
            this.body.Name = "body";
            this.body.Padding = new System.Windows.Forms.Padding(50);
            this.body.Size = new System.Drawing.Size(907, 732);
            this.body.TabIndex = 3;
            // 
            // result_txt_con
            // 
            this.result_txt_con.Controls.Add(this.result_txt);
            this.result_txt_con.Location = new System.Drawing.Point(125, 5);
            this.result_txt_con.Name = "result_txt_con";
            this.result_txt_con.Size = new System.Drawing.Size(255, 52);
            this.result_txt_con.TabIndex = 0;
            this.result_txt_con.Click += new System.EventHandler(this.Resultbtn_Click);
            // 
            // sidenav
            // 
            this.sidenav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.sidenav.Controls.Add(this.panel1);
            this.sidenav.Controls.Add(this.result_con);
            this.sidenav.Controls.Add(this.voter_con);
            this.sidenav.Controls.Add(this.home_con);
            this.sidenav.Controls.Add(this.Spacer);
            this.sidenav.Controls.Add(this.panel3);
            this.sidenav.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidenav.Location = new System.Drawing.Point(0, 0);
            this.sidenav.Name = "sidenav";
            this.sidenav.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.sidenav.Size = new System.Drawing.Size(385, 732);
            this.sidenav.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 662);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(25, 5, 5, 0);
            this.panel1.Size = new System.Drawing.Size(385, 60);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.Logout_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(125, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 52);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.Logout_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Logout";
            this.label3.Click += new System.EventHandler(this.Logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Election_system.Properties.Resources.logout;
            this.pictureBox1.Location = new System.Drawing.Point(25, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Logout_Click);
            // 
            // result_con
            // 
            this.result_con.Controls.Add(this.result_txt_con);
            this.result_con.Controls.Add(this.result_icon);
            this.result_con.Cursor = System.Windows.Forms.Cursors.Hand;
            this.result_con.Dock = System.Windows.Forms.DockStyle.Top;
            this.result_con.Location = new System.Drawing.Point(0, 446);
            this.result_con.Name = "result_con";
            this.result_con.Padding = new System.Windows.Forms.Padding(25, 5, 5, 0);
            this.result_con.Size = new System.Drawing.Size(385, 60);
            this.result_con.TabIndex = 1;
            this.result_con.Click += new System.EventHandler(this.Resultbtn_Click);
            // 
            // result_icon
            // 
            this.result_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.result_icon.Image = global::Election_system.Properties.Resources.notepad;
            this.result_icon.Location = new System.Drawing.Point(25, 5);
            this.result_icon.Name = "result_icon";
            this.result_icon.Size = new System.Drawing.Size(100, 52);
            this.result_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.result_icon.TabIndex = 0;
            this.result_icon.TabStop = false;
            this.result_icon.Click += new System.EventHandler(this.Resultbtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Election_system.Properties.Resources.logo1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 287);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "NATIONAL ELECTION BOARD OF ETHIOPIA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nyala", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "የኢትዮጵያ ብሔራዊ ምርጫ ቦርድ";
            // 
            // VotersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 732);
            this.Controls.Add(this.body);
            this.Controls.Add(this.sidenav);
            this.Name = "VotersForm";
            this.Text = "VotersForm";
            this.voter_con.ResumeLayout(false);
            this.voter_txt_con.ResumeLayout(false);
            this.voter_txt_con.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voter_icon)).EndInit();
            this.panel8.ResumeLayout(false);
            this.home_con.ResumeLayout(false);
            this.home_txt_con.ResumeLayout(false);
            this.home_txt_con.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_icon)).EndInit();
            this.result_txt_con.ResumeLayout(false);
            this.result_txt_con.PerformLayout();
            this.sidenav.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.result_con.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.result_icon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel voter_con;
        private System.Windows.Forms.Panel voter_txt_con;
        private System.Windows.Forms.Label voter_txt;
        private System.Windows.Forms.PictureBox voter_icon;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button viewVoters_btn;
        private System.Windows.Forms.Button modifyVoters_btn;
        private System.Windows.Forms.Button addVoters_btn;
        private System.Windows.Forms.Label result_txt;
        private System.Windows.Forms.Panel home_con;
        private System.Windows.Forms.Panel home_txt_con;
        private System.Windows.Forms.Label home_txt;
        private System.Windows.Forms.PictureBox home_icon;
        private System.Windows.Forms.Panel Spacer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.Panel result_txt_con;
        private System.Windows.Forms.Panel sidenav;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel result_con;
        private System.Windows.Forms.PictureBox result_icon;
    }
}