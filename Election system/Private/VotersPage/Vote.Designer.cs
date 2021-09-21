
namespace Election_system.Private.Voters
{
    partial class Vote
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
            this.votebtn = new System.Windows.Forms.Button();
            this.allParties = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.votebtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 492);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(30);
            this.panel1.Size = new System.Drawing.Size(800, 139);
            this.panel1.TabIndex = 0;
            // 
            // votebtn
            // 
            this.votebtn.BackColor = System.Drawing.Color.Red;
            this.votebtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.votebtn.Enabled = false;
            this.votebtn.FlatAppearance.BorderSize = 0;
            this.votebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.votebtn.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.votebtn.ForeColor = System.Drawing.Color.White;
            this.votebtn.Location = new System.Drawing.Point(30, 30);
            this.votebtn.Name = "votebtn";
            this.votebtn.Size = new System.Drawing.Size(740, 79);
            this.votebtn.TabIndex = 0;
            this.votebtn.Text = "VOTE";
            this.votebtn.UseVisualStyleBackColor = false;
            this.votebtn.Click += new System.EventHandler(this.votebtn_Click);
            // 
            // allParties
            // 
            this.allParties.AutoScroll = true;
            this.allParties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allParties.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.allParties.Location = new System.Drawing.Point(0, 0);
            this.allParties.Name = "allParties";
            this.allParties.Padding = new System.Windows.Forms.Padding(80, 10, 80, 10);
            this.allParties.Size = new System.Drawing.Size(800, 492);
            this.allParties.TabIndex = 1;
            // 
            // Vote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.allParties);
            this.Controls.Add(this.panel1);
            this.Name = "Vote";
            this.Size = new System.Drawing.Size(800, 631);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button votebtn;
        private System.Windows.Forms.FlowLayoutPanel allParties;
    }
}
