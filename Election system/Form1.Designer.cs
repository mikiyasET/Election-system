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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.position = new System.Windows.Forms.Label();
            this.region_image = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.Logo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.button3.Location = new System.Drawing.Point(0, 381);
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
            this.button2.Location = new System.Drawing.Point(0, 334);
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
            this.button1.Location = new System.Drawing.Point(0, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(385, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Vote Now";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.VoteNowBtn);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.position);
            this.panel2.Controls.Add(this.region_image);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(385, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 808);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(531, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(404, 808);
            this.panel3.TabIndex = 3;
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
            this.panel4.Size = new System.Drawing.Size(404, 614);
            this.panel4.TabIndex = 3;
            // 
            // regionName_txt
            // 
            this.regionName_txt.AutoEllipsis = true;
            this.regionName_txt.BackColor = System.Drawing.Color.Transparent;
            this.regionName_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regionName_txt.Font = new System.Drawing.Font("Rubik", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regionName_txt.ForeColor = System.Drawing.Color.Black;
            this.regionName_txt.Location = new System.Drawing.Point(63, 50);
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
            this.station_txt.Location = new System.Drawing.Point(277, 437);
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
            this.voted_txt.Location = new System.Drawing.Point(277, 387);
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
            this.voters_txt.Location = new System.Drawing.Point(277, 337);
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
            this.population_txt.Location = new System.Drawing.Point(277, 287);
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
            this.label11.Location = new System.Drawing.Point(53, 437);
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
            this.label9.Location = new System.Drawing.Point(53, 387);
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
            this.label7.Location = new System.Drawing.Point(53, 337);
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
            this.label4.Location = new System.Drawing.Point(53, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Population";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 614);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(404, 194);
            this.dataGridView1.TabIndex = 2;
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
            this.region_image.Image = global::Election_system.Properties.Resources.Ethiopia_map___white;
            this.region_image.Location = new System.Drawing.Point(0, 0);
            this.region_image.Name = "region_image";
            this.region_image.Size = new System.Drawing.Size(530, 808);
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
            this.ClientSize = new System.Drawing.Size(1320, 808);
            this.Controls.Add(this.panel2);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private Panel panel2;
        public PictureBox region_image;
        public Label position;
        private Panel panel3;
        private DataGridView dataGridView1;
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
    }
}

