
namespace Election_system.Private.Admin
{
    partial class AddParty
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
            this.addbtn = new System.Windows.Forms.Button();
            this.name_box = new System.Windows.Forms.TextBox();
            this.population_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logobtn = new System.Windows.Forms.Button();
            this.logo_img = new System.Windows.Forms.PictureBox();
            this.election_label = new System.Windows.Forms.Label();
            this.election_box = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).BeginInit();
            this.SuspendLayout();
            // 
            // addbtn
            // 
            this.addbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addbtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(55, 547);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(600, 48);
            this.addbtn.TabIndex = 9;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // name_box
            // 
            this.name_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name_box.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_box.Location = new System.Drawing.Point(383, 206);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(272, 30);
            this.name_box.TabIndex = 8;
            // 
            // population_label
            // 
            this.population_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.population_label.AutoSize = true;
            this.population_label.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.population_label.Location = new System.Drawing.Point(67, 308);
            this.population_label.Name = "population_label";
            this.population_label.Size = new System.Drawing.Size(57, 24);
            this.population_label.TabIndex = 5;
            this.population_label.Text = "Logo";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 212);
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
            this.label1.Location = new System.Drawing.Point(236, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add Party";
            // 
            // logobtn
            // 
            this.logobtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logobtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logobtn.Location = new System.Drawing.Point(383, 494);
            this.logobtn.Name = "logobtn";
            this.logobtn.Size = new System.Drawing.Size(272, 31);
            this.logobtn.TabIndex = 9;
            this.logobtn.Text = "choose image ...";
            this.logobtn.UseVisualStyleBackColor = true;
            this.logobtn.Click += new System.EventHandler(this.logobtn_Click);
            // 
            // logo_img
            // 
            this.logo_img.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo_img.BackColor = System.Drawing.Color.Transparent;
            this.logo_img.Image = global::Election_system.Properties.Resources.addpic;
            this.logo_img.Location = new System.Drawing.Point(383, 308);
            this.logo_img.Name = "logo_img";
            this.logo_img.Size = new System.Drawing.Size(272, 180);
            this.logo_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_img.TabIndex = 10;
            this.logo_img.TabStop = false;
            // 
            // election_label
            // 
            this.election_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.election_label.AutoSize = true;
            this.election_label.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.election_label.Location = new System.Drawing.Point(67, 262);
            this.election_label.Name = "election_label";
            this.election_label.Size = new System.Drawing.Size(85, 24);
            this.election_label.TabIndex = 5;
            this.election_label.Text = "Election";
            // 
            // election_box
            // 
            this.election_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.election_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.election_box.FormattingEnabled = true;
            this.election_box.Location = new System.Drawing.Point(383, 253);
            this.election_box.Name = "election_box";
            this.election_box.Size = new System.Drawing.Size(272, 33);
            this.election_box.TabIndex = 11;
            // 
            // AddParty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.election_box);
            this.Controls.Add(this.logo_img);
            this.Controls.Add(this.logobtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.election_label);
            this.Controls.Add(this.population_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddParty";
            this.Size = new System.Drawing.Size(707, 638);
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label population_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logobtn;
        private System.Windows.Forms.PictureBox logo_img;
        private System.Windows.Forms.Label election_label;
        private System.Windows.Forms.ComboBox election_box;
    }
}
