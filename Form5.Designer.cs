namespace InventoryApp
{
    partial class Form5
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.utype = new System.Windows.Forms.ComboBox();
            this.uid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.upass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.uemail = new System.Windows.Forms.TextBox();
            this.uphone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.uaddress = new System.Windows.Forms.TextBox();
            this.errorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(24)))), ((int)(((byte)(149)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(526, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 45);
            this.button1.TabIndex = 43;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(24)))), ((int)(((byte)(144)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(365, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 45);
            this.button3.TabIndex = 42;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(141)))), ((int)(((byte)(149)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(207, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 45);
            this.button2.TabIndex = 40;
            this.button2.Text = "Post";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // utype
            // 
            this.utype.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.utype.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.utype.ForeColor = System.Drawing.SystemColors.WindowText;
            this.utype.FormattingEnabled = true;
            this.utype.Items.AddRange(new object[] {
            "Management",
            "Attendant"});
            this.utype.Location = new System.Drawing.Point(480, 297);
            this.utype.Name = "utype";
            this.utype.Size = new System.Drawing.Size(222, 31);
            this.utype.TabIndex = 39;
            // 
            // uid
            // 
            this.uid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uid.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uid.ForeColor = System.Drawing.SystemColors.WindowText;
            this.uid.Location = new System.Drawing.Point(205, 84);
            this.uid.Multiline = true;
            this.uid.Name = "uid";
            this.uid.Size = new System.Drawing.Size(145, 26);
            this.uid.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label4.Location = new System.Drawing.Point(476, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "User Type";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label3.Location = new System.Drawing.Point(199, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Username";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label1.Location = new System.Drawing.Point(198, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "User ID";
            // 
            // uname
            // 
            this.uname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uname.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.uname.Location = new System.Drawing.Point(205, 162);
            this.uname.Multiline = true;
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(222, 26);
            this.uname.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label2.Location = new System.Drawing.Point(474, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Password";
            // 
            // upass
            // 
            this.upass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.upass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.upass.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.upass.ForeColor = System.Drawing.SystemColors.WindowText;
            this.upass.Location = new System.Drawing.Point(480, 162);
            this.upass.Multiline = true;
            this.upass.Name = "upass";
            this.upass.Size = new System.Drawing.Size(222, 26);
            this.upass.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label9.Location = new System.Drawing.Point(199, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label10.Location = new System.Drawing.Point(474, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "Phone";
            // 
            // uemail
            // 
            this.uemail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uemail.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uemail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.uemail.Location = new System.Drawing.Point(205, 233);
            this.uemail.Multiline = true;
            this.uemail.Name = "uemail";
            this.uemail.Size = new System.Drawing.Size(222, 26);
            this.uemail.TabIndex = 33;
            // 
            // uphone
            // 
            this.uphone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uphone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uphone.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uphone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.uphone.Location = new System.Drawing.Point(480, 233);
            this.uphone.Multiline = true;
            this.uphone.Name = "uphone";
            this.uphone.Size = new System.Drawing.Size(222, 26);
            this.uphone.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label7.Location = new System.Drawing.Point(201, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Address";
            // 
            // uaddress
            // 
            this.uaddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uaddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uaddress.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uaddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.uaddress.Location = new System.Drawing.Point(207, 297);
            this.uaddress.Multiline = true;
            this.uaddress.Name = "uaddress";
            this.uaddress.Size = new System.Drawing.Size(222, 26);
            this.uaddress.TabIndex = 33;
            // 
            // errorLbl
            // 
            this.errorLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorLbl.AutoSize = true;
            this.errorLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.errorLbl.Location = new System.Drawing.Point(474, 77);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(90, 25);
            this.errorLbl.TabIndex = 26;
            this.errorLbl.Text = "Password";
            this.errorLbl.Visible = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(3)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(905, 612);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.utype);
            this.Controls.Add(this.uphone);
            this.Controls.Add(this.upass);
            this.Controls.Add(this.uaddress);
            this.Controls.Add(this.uemail);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.uid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private Button button3;
        private Button button2;
        private ComboBox utype;
        private TextBox uid;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox uname;
        private Label label2;
        private TextBox upass;
        private Label label9;
        private Label label10;
        private TextBox uemail;
        private TextBox uphone;
        private Label label7;
        private TextBox uaddress;
        private Label errorLbl;
    }
}