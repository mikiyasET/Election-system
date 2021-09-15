
namespace Election_system.Private.Admin
{
    partial class AddVoters
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.middleName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.phoneNo = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.id_image = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.savebtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.IDNo = new System.Windows.Forms.TextBox();
            this.Spacer = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.firstName);
            this.groupBox1.Controls.Add(this.middleName);
            this.groupBox1.Controls.Add(this.lastName);
            this.groupBox1.Controls.Add(this.phoneNo);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.confirmPassword);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 694);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voters Info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 491);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Birth Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Confirm Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Middle Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(25, 83);
            this.firstName.Multiline = true;
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(337, 27);
            this.firstName.TabIndex = 0;
            this.firstName.TextChanged += new System.EventHandler(this.firstName_TextChanged);
            // 
            // middleName
            // 
            this.middleName.Location = new System.Drawing.Point(25, 156);
            this.middleName.Multiline = true;
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(337, 27);
            this.middleName.TabIndex = 0;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(25, 230);
            this.lastName.Multiline = true;
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(337, 27);
            this.lastName.TabIndex = 0;
            // 
            // phoneNo
            // 
            this.phoneNo.Location = new System.Drawing.Point(25, 306);
            this.phoneNo.Multiline = true;
            this.phoneNo.Name = "phoneNo";
            this.phoneNo.Size = new System.Drawing.Size(337, 27);
            this.phoneNo.TabIndex = 0;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(28, 381);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(337, 27);
            this.password.TabIndex = 0;
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(25, 447);
            this.confirmPassword.Multiline = true;
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(337, 27);
            this.confirmPassword.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 517);
            this.dateTimePicker1.MaxDate = new System.DateTime(2021, 9, 15, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(337, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2021, 9, 15, 0, 0, 0, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(399, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10, 2, 20, 20);
            this.groupBox2.Size = new System.Drawing.Size(454, 694);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Id info";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.id_image);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.savebtn);
            this.panel1.Controls.Add(this.clearbtn);
            this.panel1.Controls.Add(this.IDNo);
            this.panel1.Controls.Add(this.Spacer);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 15);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(424, 659);
            this.panel1.TabIndex = 3;
            // 
            // id_image
            // 
            this.id_image.Dock = System.Windows.Forms.DockStyle.Top;
            this.id_image.Location = new System.Drawing.Point(20, 141);
            this.id_image.Name = "id_image";
            this.id_image.Size = new System.Drawing.Size(384, 74);
            this.id_image.TabIndex = 1;
            this.id_image.Text = "Image";
            this.id_image.UseVisualStyleBackColor = true;
            this.id_image.Click += new System.EventHandler(this.id_image_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 55);
            this.panel2.TabIndex = 4;
            // 
            // savebtn
            // 
            this.savebtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.savebtn.Location = new System.Drawing.Point(113, 530);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(124, 46);
            this.savebtn.TabIndex = 2;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            // 
            // clearbtn
            // 
            this.clearbtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.clearbtn.Location = new System.Drawing.Point(255, 530);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(124, 46);
            this.clearbtn.TabIndex = 2;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            // 
            // IDNo
            // 
            this.IDNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.IDNo.Location = new System.Drawing.Point(20, 59);
            this.IDNo.Multiline = true;
            this.IDNo.Name = "IDNo";
            this.IDNo.Size = new System.Drawing.Size(384, 27);
            this.IDNo.TabIndex = 0;
            // 
            // Spacer
            // 
            this.Spacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Spacer.Location = new System.Drawing.Point(20, 33);
            this.Spacer.Name = "Spacer";
            this.Spacer.Size = new System.Drawing.Size(384, 26);
            this.Spacer.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(20, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "ID Number";
            // 
            // AddVoters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddVoters";
            this.Size = new System.Drawing.Size(853, 694);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox phoneNo;
        private System.Windows.Forms.TextBox middleName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Button id_image;
        private System.Windows.Forms.TextBox IDNo;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Spacer;
        private System.Windows.Forms.Panel panel2;
    }
}
