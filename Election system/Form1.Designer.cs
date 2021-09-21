using System;
using System.Drawing;
using System.Windows.Forms;
namespace Election_system
{
    partial class MainPage
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
        ///  
        public bool max = false;
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.elections = new System.Windows.Forms.ComboBox();
            this.Logo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ethiopia = new System.Windows.Forms.Panel();
            this.rightbar = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.regionName_txt = new System.Windows.Forms.Label();
            this.station_txt = new System.Windows.Forms.Label();
            this.voted_txt = new System.Windows.Forms.Label();
            this.voters_txt = new System.Windows.Forms.Label();
            this.population_txt = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.leadboard_table = new System.Windows.Forms.DataGridView();
            this.position = new System.Windows.Forms.Label();
            this.region_image = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.Logo.SuspendLayout();
            this.ethiopia.SuspendLayout();
            this.rightbar.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leadboard_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.region_image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.elections);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 808);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(197)))), ((int)(((byte)(194)))));
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 761);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(385, 47);
            this.button4.TabIndex = 4;
            this.button4.Text = "Report";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 409);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(385, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "LeaderBoard";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(385, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Parties";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(385, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Vote Now";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.VoteNowBtn);
            // 
            // elections
            // 
            this.elections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.elections.Dock = System.Windows.Forms.DockStyle.Top;
            this.elections.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold);
            this.elections.ForeColor = System.Drawing.Color.White;
            this.elections.FormattingEnabled = true;
            this.elections.Location = new System.Drawing.Point(0, 287);
            this.elections.MaxDropDownItems = 100;
            this.elections.Name = "elections";
            this.elections.Size = new System.Drawing.Size(385, 28);
            this.elections.TabIndex = 5;
            this.elections.SelectedIndexChanged += new System.EventHandler(this.Election_OnChange);
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = global::Election_system.Properties.Resources.logo;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Controls.Add(this.label2);
            this.Logo.Controls.Add(this.label1);
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(385, 287);
            this.Logo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "NATIONAL ELECTION BOARD OF ETHIOPIA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nyala", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "የኢትዮጵያ ብሔራዊ ምርጫ ቦርድ";
            // 
            // ethiopia
            // 
            this.ethiopia.Controls.Add(this.position);
            this.ethiopia.Controls.Add(this.region_image);
            this.ethiopia.Location = new System.Drawing.Point(385, 0);
            this.ethiopia.Name = "ethiopia";
            this.ethiopia.Size = new System.Drawing.Size(526, 808);
            this.ethiopia.TabIndex = 1;
            // 
            // rightbar
            // 
            this.rightbar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rightbar.Controls.Add(this.panel4);
            this.rightbar.Controls.Add(this.leadboard_table);
            this.rightbar.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightbar.Location = new System.Drawing.Point(908, 0);
            this.rightbar.Name = "rightbar";
            this.rightbar.Size = new System.Drawing.Size(728, 808);
            this.rightbar.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.regionName_txt);
            this.panel4.Controls.Add(this.station_txt);
            this.panel4.Controls.Add(this.voted_txt);
            this.panel4.Controls.Add(this.voters_txt);
            this.panel4.Controls.Add(this.population_txt);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(60);
            this.panel4.Size = new System.Drawing.Size(728, 472);
            this.panel4.TabIndex = 3;
            // 
            // regionName_txt
            // 
            this.regionName_txt.AutoEllipsis = true;
            this.regionName_txt.BackColor = System.Drawing.Color.Transparent;
            this.regionName_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regionName_txt.Font = new System.Drawing.Font("Rubik", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regionName_txt.ForeColor = System.Drawing.Color.Black;
            this.regionName_txt.Location = new System.Drawing.Point(240, 18);
            this.regionName_txt.MaximumSize = new System.Drawing.Size(300, 200);
            this.regionName_txt.Name = "regionName_txt";
            this.regionName_txt.Size = new System.Drawing.Size(284, 200);
            this.regionName_txt.TabIndex = 2;
            this.regionName_txt.Text = "- - -";
            this.regionName_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.regionName_txt.UseMnemonic = false;
            // 
            // station_txt
            // 
            this.station_txt.AutoSize = true;
            this.station_txt.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.station_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.station_txt.Location = new System.Drawing.Point(454, 405);
            this.station_txt.Name = "station_txt";
            this.station_txt.Size = new System.Drawing.Size(41, 20);
            this.station_txt.TabIndex = 2;
            this.station_txt.Text = "- - -";
            // 
            // voted_txt
            // 
            this.voted_txt.AutoSize = true;
            this.voted_txt.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voted_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.voted_txt.Location = new System.Drawing.Point(454, 355);
            this.voted_txt.Name = "voted_txt";
            this.voted_txt.Size = new System.Drawing.Size(41, 20);
            this.voted_txt.TabIndex = 3;
            this.voted_txt.Text = "- - -";
            // 
            // voters_txt
            // 
            this.voters_txt.AutoSize = true;
            this.voters_txt.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voters_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.voters_txt.Location = new System.Drawing.Point(454, 305);
            this.voters_txt.Name = "voters_txt";
            this.voters_txt.Size = new System.Drawing.Size(41, 20);
            this.voters_txt.TabIndex = 4;
            this.voters_txt.Text = "- - -";
            // 
            // population_txt
            // 
            this.population_txt.AutoSize = true;
            this.population_txt.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.population_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.population_txt.Location = new System.Drawing.Point(454, 255);
            this.population_txt.Name = "population_txt";
            this.population_txt.Size = new System.Drawing.Size(41, 20);
            this.population_txt.TabIndex = 5;
            this.population_txt.Text = "- - -";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(230, 405);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Stations";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(230, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Voted (Currently)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(230, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Voters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(230, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Population";
            // 
            // leadboard_table
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.leadboard_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.leadboard_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.leadboard_table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.leadboard_table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.leadboard_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.leadboard_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.leadboard_table.DefaultCellStyle = dataGridViewCellStyle3;
            this.leadboard_table.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.leadboard_table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.leadboard_table.Location = new System.Drawing.Point(0, 472);
            this.leadboard_table.Name = "leadboard_table";
            this.leadboard_table.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.leadboard_table.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.leadboard_table.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.leadboard_table.RowTemplate.Height = 60;
            this.leadboard_table.Size = new System.Drawing.Size(728, 336);
            this.leadboard_table.TabIndex = 2;
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.ForeColor = System.Drawing.Color.Black;
            this.position.Location = new System.Drawing.Point(43, 708);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(0, 13);
            this.position.TabIndex = 1;
            // 
            // region_image
            // 
            this.region_image.BackColor = System.Drawing.Color.White;
            this.region_image.Dock = System.Windows.Forms.DockStyle.Left;
            this.region_image.Image = global::Election_system.Properties.Resources.Ethiopia_map___white;
            this.region_image.Location = new System.Drawing.Point(0, 0);
            this.region_image.Name = "region_image";
            this.region_image.Size = new System.Drawing.Size(525, 808);
            this.region_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.region_image.TabIndex = 0;
            this.region_image.TabStop = false;
            this.region_image.Click += new System.EventHandler(this.pictureBox1_Click);
            this.region_image.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_Hover);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1636, 808);
            this.Controls.Add(this.rightbar);
            this.Controls.Add(this.ethiopia);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.ForeColor = System.Drawing.Color.White;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Election system";
            this.TransparencyKey = System.Drawing.Color.Purple;
            this.panel1.ResumeLayout(false);
            this.Logo.ResumeLayout(false);
            this.Logo.PerformLayout();
            this.ethiopia.ResumeLayout(false);
            this.ethiopia.PerformLayout();
            this.rightbar.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leadboard_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.region_image)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private Panel panel1;
        private Panel Logo;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Panel ethiopia;
        public PictureBox region_image;
        public Label position;
        private Panel rightbar;
        private DataGridView leadboard_table;
        private Panel panel4;
        private Label regionName_txt;
        private Label station_txt;
        private Label voted_txt;
        private Label voters_txt;
        private Label population_txt;
        private Label label11;
        private Label label9;
        private Label label7;
        private Label label4;
        private ComboBox elections;
    }
}

