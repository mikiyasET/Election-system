
namespace Election_system.Private.Admin
{
    partial class AddStations
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
            this.region_box = new System.Windows.Forms.ComboBox();
            this.election_box = new System.Windows.Forms.ComboBox();
            this.election_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addbtn
            // 
            this.addbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addbtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(178, 420);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(600, 48);
            this.addbtn.TabIndex = 15;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // name_box
            // 
            this.name_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_box.Location = new System.Drawing.Point(506, 219);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(272, 30);
            this.name_box.TabIndex = 13;
            // 
            // population_label
            // 
            this.population_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.population_label.AutoSize = true;
            this.population_label.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.population_label.Location = new System.Drawing.Point(190, 286);
            this.population_label.Name = "population_label";
            this.population_label.Size = new System.Drawing.Size(76, 24);
            this.population_label.TabIndex = 11;
            this.population_label.Text = "Region";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 219);
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
            this.label1.Location = new System.Drawing.Point(359, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add Stations";
            // 
            // region_box
            // 
            this.region_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.region_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.region_box.FormattingEnabled = true;
            this.region_box.Location = new System.Drawing.Point(506, 288);
            this.region_box.Name = "region_box";
            this.region_box.Size = new System.Drawing.Size(272, 33);
            this.region_box.TabIndex = 16;
            // 
            // election_box
            // 
            this.election_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.election_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.election_box.FormattingEnabled = true;
            this.election_box.Location = new System.Drawing.Point(506, 355);
            this.election_box.Name = "election_box";
            this.election_box.Size = new System.Drawing.Size(272, 33);
            this.election_box.TabIndex = 18;
            this.election_box.SelectedIndexChanged += new System.EventHandler(this.election_box_SelectedIndexChanged);
            // 
            // election_label
            // 
            this.election_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.election_label.AutoSize = true;
            this.election_label.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.election_label.Location = new System.Drawing.Point(190, 359);
            this.election_label.Name = "election_label";
            this.election_label.Size = new System.Drawing.Size(85, 24);
            this.election_label.TabIndex = 17;
            this.election_label.Text = "Election";
            // 
            // AddStations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.election_box);
            this.Controls.Add(this.election_label);
            this.Controls.Add(this.region_box);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.population_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddStations";
            this.Size = new System.Drawing.Size(961, 724);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label population_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox region_box;
        private System.Windows.Forms.ComboBox election_box;
        private System.Windows.Forms.Label election_label;
    }
}
