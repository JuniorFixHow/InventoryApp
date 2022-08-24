namespace InventoryApp
{
    partial class Form9
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.odQuant = new System.Windows.Forms.TextBox();
            this.odProd = new System.Windows.Forms.TextBox();
            this.oId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.errorLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.button3.Location = new System.Drawing.Point(218, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 45);
            this.button3.TabIndex = 50;
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
            this.button2.Location = new System.Drawing.Point(60, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 45);
            this.button2.TabIndex = 49;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // odQuant
            // 
            this.odQuant.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.odQuant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.odQuant.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.odQuant.ForeColor = System.Drawing.SystemColors.WindowText;
            this.odQuant.Location = new System.Drawing.Point(61, 220);
            this.odQuant.Multiline = true;
            this.odQuant.Name = "odQuant";
            this.odQuant.Size = new System.Drawing.Size(127, 26);
            this.odQuant.TabIndex = 46;
            // 
            // odProd
            // 
            this.odProd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.odProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.odProd.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.odProd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.odProd.Location = new System.Drawing.Point(59, 156);
            this.odProd.Multiline = true;
            this.odProd.Name = "odProd";
            this.odProd.Size = new System.Drawing.Size(222, 26);
            this.odProd.TabIndex = 47;
            // 
            // oId
            // 
            this.oId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.oId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oId.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.oId.Location = new System.Drawing.Point(59, 85);
            this.oId.Multiline = true;
            this.oId.Name = "oId";
            this.oId.Size = new System.Drawing.Size(129, 26);
            this.oId.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label7.Location = new System.Drawing.Point(55, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 43;
            this.label7.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label9.Location = new System.Drawing.Point(53, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 25);
            this.label9.TabIndex = 44;
            this.label9.Text = "Product";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.label3.Location = new System.Drawing.Point(53, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Order ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(453, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(416, 515);
            this.dataGridView1.TabIndex = 51;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(80)))), ((int)(((byte)(61)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(756, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 33);
            this.button4.TabIndex = 52;
            this.button4.Text = "Print";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // errorLbl
            // 
            this.errorLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorLbl.AutoSize = true;
            this.errorLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.errorLbl.Location = new System.Drawing.Point(57, 260);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(47, 23);
            this.errorLbl.TabIndex = 43;
            this.errorLbl.Text = "error";
            this.errorLbl.Visible = false;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(3)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(905, 612);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.odQuant);
            this.Controls.Add(this.odProd);
            this.Controls.Add(this.oId);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form9";
            this.Text = "Form9";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button3;
        private Button button2;
        private TextBox odQuant;
        private TextBox odProd;
        private TextBox oId;
        private Label label7;
        private Label label9;
        private Label label3;
        private DataGridView dataGridView1;
        private Button button4;
        private Label errorLbl;
    }
}