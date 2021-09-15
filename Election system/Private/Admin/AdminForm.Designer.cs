﻿
namespace Election_system.Private.Admin
{
    partial class AdminForm
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
            this.sidenav = new System.Windows.Forms.Panel();
            this.region_con = new System.Windows.Forms.Panel();
            this.region_txt_con = new System.Windows.Forms.Panel();
            this.region_txt = new System.Windows.Forms.Label();
            this.region_icon = new System.Windows.Forms.PictureBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.viewregion_btn = new System.Windows.Forms.Button();
            this.modifyregion_btn = new System.Windows.Forms.Button();
            this.addregion_btn = new System.Windows.Forms.Button();
            this.station_con = new System.Windows.Forms.Panel();
            this.station_txt_con = new System.Windows.Forms.Panel();
            this.station_txt = new System.Windows.Forms.Label();
            this.station_icon = new System.Windows.Forms.PictureBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.viewstation_btn = new System.Windows.Forms.Button();
            this.modifystation_btn = new System.Windows.Forms.Button();
            this.addstation_btn = new System.Windows.Forms.Button();
            this.cand_con = new System.Windows.Forms.Panel();
            this.cand_txt_con = new System.Windows.Forms.Panel();
            this.cand_txt = new System.Windows.Forms.Label();
            this.cand_icon = new System.Windows.Forms.PictureBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.viewcand_btn = new System.Windows.Forms.Button();
            this.modifycand_btn = new System.Windows.Forms.Button();
            this.addcand_btn = new System.Windows.Forms.Button();
            this.voter_con = new System.Windows.Forms.Panel();
            this.voter_txt_con = new System.Windows.Forms.Panel();
            this.voter_txt = new System.Windows.Forms.Label();
            this.voter_icon = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.viewVoters_btn = new System.Windows.Forms.Button();
            this.modifyVoters_btn = new System.Windows.Forms.Button();
            this.addVoters_btn = new System.Windows.Forms.Button();
            this.home_con = new System.Windows.Forms.Panel();
            this.home_txt_con = new System.Windows.Forms.Panel();
            this.home_txt = new System.Windows.Forms.Label();
            this.home_icon = new System.Windows.Forms.PictureBox();
            this.Spacer = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.body = new System.Windows.Forms.Panel();
            this.sidenav.SuspendLayout();
            this.region_con.SuspendLayout();
            this.region_txt_con.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.region_icon)).BeginInit();
            this.panel17.SuspendLayout();
            this.station_con.SuspendLayout();
            this.station_txt_con.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.station_icon)).BeginInit();
            this.panel14.SuspendLayout();
            this.cand_con.SuspendLayout();
            this.cand_txt_con.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cand_icon)).BeginInit();
            this.panel11.SuspendLayout();
            this.voter_con.SuspendLayout();
            this.voter_txt_con.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voter_icon)).BeginInit();
            this.panel8.SuspendLayout();
            this.home_con.SuspendLayout();
            this.home_txt_con.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_icon)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidenav
            // 
            this.sidenav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.sidenav.Controls.Add(this.region_con);
            this.sidenav.Controls.Add(this.station_con);
            this.sidenav.Controls.Add(this.cand_con);
            this.sidenav.Controls.Add(this.voter_con);
            this.sidenav.Controls.Add(this.home_con);
            this.sidenav.Controls.Add(this.Spacer);
            this.sidenav.Controls.Add(this.panel3);
            this.sidenav.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidenav.Location = new System.Drawing.Point(0, 0);
            this.sidenav.Name = "sidenav";
            this.sidenav.Size = new System.Drawing.Size(385, 800);
            this.sidenav.TabIndex = 0;
            // 
            // region_con
            // 
            this.region_con.Controls.Add(this.region_txt_con);
            this.region_con.Controls.Add(this.region_icon);
            this.region_con.Controls.Add(this.panel17);
            this.region_con.Cursor = System.Windows.Forms.Cursors.Hand;
            this.region_con.Dock = System.Windows.Forms.DockStyle.Top;
            this.region_con.Location = new System.Drawing.Point(0, 566);
            this.region_con.Name = "region_con";
            this.region_con.Padding = new System.Windows.Forms.Padding(25, 5, 5, 0);
            this.region_con.Size = new System.Drawing.Size(385, 60);
            this.region_con.TabIndex = 1;
            this.region_con.Click += new System.EventHandler(this.RegionbtnClick);
            // 
            // region_txt_con
            // 
            this.region_txt_con.Controls.Add(this.region_txt);
            this.region_txt_con.Location = new System.Drawing.Point(125, 5);
            this.region_txt_con.Name = "region_txt_con";
            this.region_txt_con.Size = new System.Drawing.Size(255, 52);
            this.region_txt_con.TabIndex = 0;
            this.region_txt_con.Click += new System.EventHandler(this.RegionbtnClick);
            // 
            // region_txt
            // 
            this.region_txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.region_txt.AutoSize = true;
            this.region_txt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.region_txt.ForeColor = System.Drawing.Color.White;
            this.region_txt.Location = new System.Drawing.Point(40, 15);
            this.region_txt.Name = "region_txt";
            this.region_txt.Size = new System.Drawing.Size(81, 22);
            this.region_txt.TabIndex = 1;
            this.region_txt.Text = "Regions";
            this.region_txt.Click += new System.EventHandler(this.RegionbtnClick);
            // 
            // region_icon
            // 
            this.region_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.region_icon.Image = global::Election_system.Properties.Resources.ethiopia;
            this.region_icon.Location = new System.Drawing.Point(25, 5);
            this.region_icon.Name = "region_icon";
            this.region_icon.Size = new System.Drawing.Size(100, 52);
            this.region_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.region_icon.TabIndex = 0;
            this.region_icon.TabStop = false;
            this.region_icon.Click += new System.EventHandler(this.RegionbtnClick);
            // 
            // panel17
            // 
            this.panel17.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel17.Controls.Add(this.viewregion_btn);
            this.panel17.Controls.Add(this.modifyregion_btn);
            this.panel17.Controls.Add(this.addregion_btn);
            this.panel17.Location = new System.Drawing.Point(24, 62);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(355, 129);
            this.panel17.TabIndex = 0;
            // 
            // viewregion_btn
            // 
            this.viewregion_btn.FlatAppearance.BorderSize = 0;
            this.viewregion_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewregion_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewregion_btn.ForeColor = System.Drawing.Color.White;
            this.viewregion_btn.Location = new System.Drawing.Point(136, 86);
            this.viewregion_btn.Name = "viewregion_btn";
            this.viewregion_btn.Size = new System.Drawing.Size(206, 34);
            this.viewregion_btn.TabIndex = 0;
            this.viewregion_btn.Text = "View Regions";
            this.viewregion_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewregion_btn.UseVisualStyleBackColor = true;
            this.viewregion_btn.Click += new System.EventHandler(this.viewregion_btn_Click);
            // 
            // modifyregion_btn
            // 
            this.modifyregion_btn.FlatAppearance.BorderSize = 0;
            this.modifyregion_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyregion_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyregion_btn.ForeColor = System.Drawing.Color.White;
            this.modifyregion_btn.Location = new System.Drawing.Point(136, 43);
            this.modifyregion_btn.Name = "modifyregion_btn";
            this.modifyregion_btn.Size = new System.Drawing.Size(206, 34);
            this.modifyregion_btn.TabIndex = 0;
            this.modifyregion_btn.Text = "Modify Regions";
            this.modifyregion_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modifyregion_btn.UseVisualStyleBackColor = true;
            this.modifyregion_btn.Click += new System.EventHandler(this.modifyregion_btn_Click);
            // 
            // addregion_btn
            // 
            this.addregion_btn.FlatAppearance.BorderSize = 0;
            this.addregion_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addregion_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addregion_btn.ForeColor = System.Drawing.Color.White;
            this.addregion_btn.Location = new System.Drawing.Point(136, 3);
            this.addregion_btn.Name = "addregion_btn";
            this.addregion_btn.Size = new System.Drawing.Size(206, 34);
            this.addregion_btn.TabIndex = 0;
            this.addregion_btn.Text = "Add Regions";
            this.addregion_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addregion_btn.UseVisualStyleBackColor = true;
            this.addregion_btn.Click += new System.EventHandler(this.addregion_btn_Click);
            // 
            // station_con
            // 
            this.station_con.Controls.Add(this.station_txt_con);
            this.station_con.Controls.Add(this.station_icon);
            this.station_con.Controls.Add(this.panel14);
            this.station_con.Cursor = System.Windows.Forms.Cursors.Hand;
            this.station_con.Dock = System.Windows.Forms.DockStyle.Top;
            this.station_con.Location = new System.Drawing.Point(0, 506);
            this.station_con.Name = "station_con";
            this.station_con.Padding = new System.Windows.Forms.Padding(25, 5, 5, 0);
            this.station_con.Size = new System.Drawing.Size(385, 60);
            this.station_con.TabIndex = 1;
            this.station_con.Click += new System.EventHandler(this.StationbtnClick);
            // 
            // station_txt_con
            // 
            this.station_txt_con.Controls.Add(this.station_txt);
            this.station_txt_con.Location = new System.Drawing.Point(125, 5);
            this.station_txt_con.Name = "station_txt_con";
            this.station_txt_con.Size = new System.Drawing.Size(255, 52);
            this.station_txt_con.TabIndex = 0;
            this.station_txt_con.Click += new System.EventHandler(this.StationbtnClick);
            // 
            // station_txt
            // 
            this.station_txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.station_txt.AutoSize = true;
            this.station_txt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.station_txt.ForeColor = System.Drawing.Color.White;
            this.station_txt.Location = new System.Drawing.Point(40, 15);
            this.station_txt.Name = "station_txt";
            this.station_txt.Size = new System.Drawing.Size(68, 22);
            this.station_txt.TabIndex = 1;
            this.station_txt.Text = "Station";
            this.station_txt.Click += new System.EventHandler(this.StationbtnClick);
            // 
            // station_icon
            // 
            this.station_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.station_icon.Image = global::Election_system.Properties.Resources.work_from_home;
            this.station_icon.Location = new System.Drawing.Point(25, 5);
            this.station_icon.Name = "station_icon";
            this.station_icon.Size = new System.Drawing.Size(100, 52);
            this.station_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.station_icon.TabIndex = 0;
            this.station_icon.TabStop = false;
            this.station_icon.Click += new System.EventHandler(this.StationbtnClick);
            // 
            // panel14
            // 
            this.panel14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel14.Controls.Add(this.viewstation_btn);
            this.panel14.Controls.Add(this.modifystation_btn);
            this.panel14.Controls.Add(this.addstation_btn);
            this.panel14.Location = new System.Drawing.Point(24, 56);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(355, 121);
            this.panel14.TabIndex = 0;
            // 
            // viewstation_btn
            // 
            this.viewstation_btn.FlatAppearance.BorderSize = 0;
            this.viewstation_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewstation_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewstation_btn.ForeColor = System.Drawing.Color.White;
            this.viewstation_btn.Location = new System.Drawing.Point(136, 83);
            this.viewstation_btn.Name = "viewstation_btn";
            this.viewstation_btn.Size = new System.Drawing.Size(206, 34);
            this.viewstation_btn.TabIndex = 0;
            this.viewstation_btn.Text = "View Stations";
            this.viewstation_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewstation_btn.UseVisualStyleBackColor = true;
            this.viewstation_btn.Click += new System.EventHandler(this.viewstation_btn_Click);
            // 
            // modifystation_btn
            // 
            this.modifystation_btn.FlatAppearance.BorderSize = 0;
            this.modifystation_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifystation_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifystation_btn.ForeColor = System.Drawing.Color.White;
            this.modifystation_btn.Location = new System.Drawing.Point(136, 43);
            this.modifystation_btn.Name = "modifystation_btn";
            this.modifystation_btn.Size = new System.Drawing.Size(206, 34);
            this.modifystation_btn.TabIndex = 0;
            this.modifystation_btn.Text = "Modify Stations";
            this.modifystation_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modifystation_btn.UseVisualStyleBackColor = true;
            this.modifystation_btn.Click += new System.EventHandler(this.modifystation_btn_Click);
            // 
            // addstation_btn
            // 
            this.addstation_btn.FlatAppearance.BorderSize = 0;
            this.addstation_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addstation_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addstation_btn.ForeColor = System.Drawing.Color.White;
            this.addstation_btn.Location = new System.Drawing.Point(136, 3);
            this.addstation_btn.Name = "addstation_btn";
            this.addstation_btn.Size = new System.Drawing.Size(206, 34);
            this.addstation_btn.TabIndex = 0;
            this.addstation_btn.Text = "Add Stations";
            this.addstation_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addstation_btn.UseVisualStyleBackColor = true;
            this.addstation_btn.Click += new System.EventHandler(this.addstation_btn_Click);
            // 
            // cand_con
            // 
            this.cand_con.Controls.Add(this.cand_txt_con);
            this.cand_con.Controls.Add(this.cand_icon);
            this.cand_con.Controls.Add(this.panel11);
            this.cand_con.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cand_con.Dock = System.Windows.Forms.DockStyle.Top;
            this.cand_con.Location = new System.Drawing.Point(0, 446);
            this.cand_con.Name = "cand_con";
            this.cand_con.Padding = new System.Windows.Forms.Padding(25, 5, 5, 0);
            this.cand_con.Size = new System.Drawing.Size(385, 60);
            this.cand_con.TabIndex = 1;
            this.cand_con.Click += new System.EventHandler(this.CandbtnClick);
            // 
            // cand_txt_con
            // 
            this.cand_txt_con.Controls.Add(this.cand_txt);
            this.cand_txt_con.Location = new System.Drawing.Point(125, 5);
            this.cand_txt_con.Name = "cand_txt_con";
            this.cand_txt_con.Size = new System.Drawing.Size(255, 52);
            this.cand_txt_con.TabIndex = 0;
            this.cand_txt_con.Click += new System.EventHandler(this.CandbtnClick);
            // 
            // cand_txt
            // 
            this.cand_txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cand_txt.AutoSize = true;
            this.cand_txt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cand_txt.ForeColor = System.Drawing.Color.White;
            this.cand_txt.Location = new System.Drawing.Point(40, 15);
            this.cand_txt.Name = "cand_txt";
            this.cand_txt.Size = new System.Drawing.Size(96, 22);
            this.cand_txt.TabIndex = 1;
            this.cand_txt.Text = "Candidate";
            this.cand_txt.Click += new System.EventHandler(this.CandbtnClick);
            // 
            // cand_icon
            // 
            this.cand_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cand_icon.Image = global::Election_system.Properties.Resources.candidate;
            this.cand_icon.Location = new System.Drawing.Point(25, 5);
            this.cand_icon.Name = "cand_icon";
            this.cand_icon.Size = new System.Drawing.Size(100, 52);
            this.cand_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cand_icon.TabIndex = 0;
            this.cand_icon.TabStop = false;
            this.cand_icon.Click += new System.EventHandler(this.CandbtnClick);
            // 
            // panel11
            // 
            this.panel11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel11.Controls.Add(this.viewcand_btn);
            this.panel11.Controls.Add(this.modifycand_btn);
            this.panel11.Controls.Add(this.addcand_btn);
            this.panel11.Location = new System.Drawing.Point(24, 57);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(355, 124);
            this.panel11.TabIndex = 0;
            // 
            // viewcand_btn
            // 
            this.viewcand_btn.FlatAppearance.BorderSize = 0;
            this.viewcand_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewcand_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewcand_btn.ForeColor = System.Drawing.Color.White;
            this.viewcand_btn.Location = new System.Drawing.Point(136, 83);
            this.viewcand_btn.Name = "viewcand_btn";
            this.viewcand_btn.Size = new System.Drawing.Size(206, 34);
            this.viewcand_btn.TabIndex = 0;
            this.viewcand_btn.Text = "View Candidates";
            this.viewcand_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewcand_btn.UseVisualStyleBackColor = true;
            this.viewcand_btn.Click += new System.EventHandler(this.viewcand_btn_Click);
            // 
            // modifycand_btn
            // 
            this.modifycand_btn.FlatAppearance.BorderSize = 0;
            this.modifycand_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifycand_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifycand_btn.ForeColor = System.Drawing.Color.White;
            this.modifycand_btn.Location = new System.Drawing.Point(136, 43);
            this.modifycand_btn.Name = "modifycand_btn";
            this.modifycand_btn.Size = new System.Drawing.Size(206, 34);
            this.modifycand_btn.TabIndex = 0;
            this.modifycand_btn.Text = "Modify Candidate";
            this.modifycand_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modifycand_btn.UseVisualStyleBackColor = true;
            this.modifycand_btn.Click += new System.EventHandler(this.modifycand_btn_Click);
            // 
            // addcand_btn
            // 
            this.addcand_btn.FlatAppearance.BorderSize = 0;
            this.addcand_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addcand_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcand_btn.ForeColor = System.Drawing.Color.White;
            this.addcand_btn.Location = new System.Drawing.Point(136, 3);
            this.addcand_btn.Name = "addcand_btn";
            this.addcand_btn.Size = new System.Drawing.Size(206, 34);
            this.addcand_btn.TabIndex = 0;
            this.addcand_btn.Text = "Add Candidate";
            this.addcand_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addcand_btn.UseVisualStyleBackColor = true;
            this.addcand_btn.Click += new System.EventHandler(this.addcand_btn_Click);
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
            this.voter_con.Click += new System.EventHandler(this.VoterbtnClick);
            // 
            // voter_txt_con
            // 
            this.voter_txt_con.Controls.Add(this.voter_txt);
            this.voter_txt_con.Location = new System.Drawing.Point(125, 5);
            this.voter_txt_con.Name = "voter_txt_con";
            this.voter_txt_con.Size = new System.Drawing.Size(255, 52);
            this.voter_txt_con.TabIndex = 0;
            this.voter_txt_con.Click += new System.EventHandler(this.VoterbtnClick);
            // 
            // voter_txt
            // 
            this.voter_txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.voter_txt.AutoSize = true;
            this.voter_txt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voter_txt.ForeColor = System.Drawing.Color.White;
            this.voter_txt.Location = new System.Drawing.Point(40, 15);
            this.voter_txt.Name = "voter_txt";
            this.voter_txt.Size = new System.Drawing.Size(55, 22);
            this.voter_txt.TabIndex = 1;
            this.voter_txt.Text = "Voter";
            this.voter_txt.Click += new System.EventHandler(this.VoterbtnClick);
            // 
            // voter_icon
            // 
            this.voter_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.voter_icon.Image = global::Election_system.Properties.Resources.vote;
            this.voter_icon.Location = new System.Drawing.Point(25, 5);
            this.voter_icon.Name = "voter_icon";
            this.voter_icon.Size = new System.Drawing.Size(100, 52);
            this.voter_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.voter_icon.TabIndex = 0;
            this.voter_icon.TabStop = false;
            this.voter_icon.Click += new System.EventHandler(this.VoterbtnClick);
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
            this.viewVoters_btn.Click += new System.EventHandler(this.viewVoters_btn_Click);
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
            this.modifyVoters_btn.Click += new System.EventHandler(this.modifyVoters_btn_Click);
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
            this.addVoters_btn.Click += new System.EventHandler(this.addVoters_btn_Click);
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
            this.home_con.Click += new System.EventHandler(this.HomebtnClick);
            // 
            // home_txt_con
            // 
            this.home_txt_con.Controls.Add(this.home_txt);
            this.home_txt_con.Location = new System.Drawing.Point(125, 5);
            this.home_txt_con.Name = "home_txt_con";
            this.home_txt_con.Size = new System.Drawing.Size(255, 52);
            this.home_txt_con.TabIndex = 0;
            this.home_txt_con.Click += new System.EventHandler(this.HomebtnClick);
            // 
            // home_txt
            // 
            this.home_txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.home_txt.AutoSize = true;
            this.home_txt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_txt.ForeColor = System.Drawing.Color.White;
            this.home_txt.Location = new System.Drawing.Point(40, 15);
            this.home_txt.Name = "home_txt";
            this.home_txt.Size = new System.Drawing.Size(61, 22);
            this.home_txt.TabIndex = 1;
            this.home_txt.Text = "Home";
            this.home_txt.Click += new System.EventHandler(this.HomebtnClick);
            // 
            // home_icon
            // 
            this.home_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.home_icon.Image = global::Election_system.Properties.Resources.home__2_;
            this.home_icon.Location = new System.Drawing.Point(25, 5);
            this.home_icon.Name = "home_icon";
            this.home_icon.Size = new System.Drawing.Size(100, 52);
            this.home_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.home_icon.TabIndex = 0;
            this.home_icon.TabStop = false;
            this.home_icon.Click += new System.EventHandler(this.HomebtnClick);
            // 
            // Spacer
            // 
            this.Spacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Spacer.Location = new System.Drawing.Point(0, 287);
            this.Spacer.Name = "Spacer";
            this.Spacer.Size = new System.Drawing.Size(385, 39);
            this.Spacer.TabIndex = 0;
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
            // body
            // 
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Location = new System.Drawing.Point(385, 0);
            this.body.Name = "body";
            this.body.Padding = new System.Windows.Forms.Padding(50);
            this.body.Size = new System.Drawing.Size(1115, 800);
            this.body.TabIndex = 1;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.body);
            this.Controls.Add(this.sidenav);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.sidenav.ResumeLayout(false);
            this.region_con.ResumeLayout(false);
            this.region_txt_con.ResumeLayout(false);
            this.region_txt_con.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.region_icon)).EndInit();
            this.panel17.ResumeLayout(false);
            this.station_con.ResumeLayout(false);
            this.station_txt_con.ResumeLayout(false);
            this.station_txt_con.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.station_icon)).EndInit();
            this.panel14.ResumeLayout(false);
            this.cand_con.ResumeLayout(false);
            this.cand_txt_con.ResumeLayout(false);
            this.cand_txt_con.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cand_icon)).EndInit();
            this.panel11.ResumeLayout(false);
            this.voter_con.ResumeLayout(false);
            this.voter_txt_con.ResumeLayout(false);
            this.voter_txt_con.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voter_icon)).EndInit();
            this.panel8.ResumeLayout(false);
            this.home_con.ResumeLayout(false);
            this.home_txt_con.ResumeLayout(false);
            this.home_txt_con.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_icon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidenav;
        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel home_con;
        private System.Windows.Forms.Label home_txt;
        private System.Windows.Forms.PictureBox home_icon;
        private System.Windows.Forms.Panel Spacer;
        private System.Windows.Forms.Panel home_txt_con;
        private System.Windows.Forms.Panel region_con;
        private System.Windows.Forms.Panel region_txt_con;
        private System.Windows.Forms.Label region_txt;
        private System.Windows.Forms.PictureBox region_icon;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button modifyregion_btn;
        private System.Windows.Forms.Button addregion_btn;
        private System.Windows.Forms.Panel station_con;
        private System.Windows.Forms.Panel station_txt_con;
        private System.Windows.Forms.Label station_txt;
        private System.Windows.Forms.PictureBox station_icon;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button modifystation_btn;
        private System.Windows.Forms.Button addstation_btn;
        private System.Windows.Forms.Panel cand_con;
        private System.Windows.Forms.Panel cand_txt_con;
        private System.Windows.Forms.Label cand_txt;
        private System.Windows.Forms.PictureBox cand_icon;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button viewcand_btn;
        private System.Windows.Forms.Button modifycand_btn;
        private System.Windows.Forms.Button addcand_btn;
        private System.Windows.Forms.Panel voter_con;
        private System.Windows.Forms.Panel voter_txt_con;
        private System.Windows.Forms.Label voter_txt;
        private System.Windows.Forms.PictureBox voter_icon;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button viewVoters_btn;
        private System.Windows.Forms.Button modifyVoters_btn;
        private System.Windows.Forms.Button addVoters_btn;
        private System.Windows.Forms.Button viewregion_btn;
        private System.Windows.Forms.Button viewstation_btn;
    }
}