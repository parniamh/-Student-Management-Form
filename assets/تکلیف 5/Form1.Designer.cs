namespace تکلیف_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Fnametxt = new TextBox();
            Lnametxt = new TextBox();
            IDtxt = new TextBox();
            Avetxt = new TextBox();
            SaveBtn = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ShowBtn = new Button();
            AveTotalBtn = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(6, 4);
            label1.Name = "label1";
            label1.Size = new Size(257, 45);
            label1.TabIndex = 0;
            label1.Text = "STUDENT form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(14, 43);
            label2.Name = "label2";
            label2.Size = new Size(238, 21);
            label2.TabIndex = 1;
            label2.Text = "please enter your information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.PeachPuff;
            label3.Location = new Point(37, 76);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "First name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.PeachPuff;
            label4.Location = new Point(38, 105);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Last name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.PeachPuff;
            label5.Location = new Point(34, 134);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 4;
            label5.Text = "ID number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.PeachPuff;
            label6.Location = new Point(59, 163);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 5;
            label6.Text = "Grade";
            // 
            // Fnametxt
            // 
            Fnametxt.BackColor = Color.PeachPuff;
            Fnametxt.Location = new Point(106, 72);
            Fnametxt.Name = "Fnametxt";
            Fnametxt.Size = new Size(162, 23);
            Fnametxt.TabIndex = 6;
            // 
            // Lnametxt
            // 
            Lnametxt.BackColor = Color.PeachPuff;
            Lnametxt.Location = new Point(106, 101);
            Lnametxt.Name = "Lnametxt";
            Lnametxt.Size = new Size(162, 23);
            Lnametxt.TabIndex = 7;
            // 
            // IDtxt
            // 
            IDtxt.BackColor = Color.PeachPuff;
            IDtxt.Location = new Point(106, 130);
            IDtxt.Name = "IDtxt";
            IDtxt.Size = new Size(162, 23);
            IDtxt.TabIndex = 8;
            // 
            // Avetxt
            // 
            Avetxt.BackColor = Color.PeachPuff;
            Avetxt.Location = new Point(106, 159);
            Avetxt.Name = "Avetxt";
            Avetxt.Size = new Size(163, 23);
            Avetxt.TabIndex = 9;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.Tomato;
            SaveBtn.FlatStyle = FlatStyle.Popup;
            SaveBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBtn.ForeColor = Color.Maroon;
            SaveBtn.Location = new Point(68, 190);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(167, 23);
            SaveBtn.TabIndex = 11;
            SaveBtn.Text = "save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);

            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.DodgerBlue;
            label7.Location = new Point(-13, 216);
            label7.Name = "label7";
            label7.Size = new Size(332, 15);
            label7.TabIndex = 12;
            label7.Text = "_________________________________________________________________";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DodgerBlue;
            label8.Location = new Point(6, 248);
            label8.Name = "label8";
            label8.Size = new Size(243, 25);
            label8.TabIndex = 13;
            label8.Text = "This section is for teachers";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(383, 218);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 14;
            // 
            // ShowBtn
            // 
            ShowBtn.BackColor = Color.Tomato;
            ShowBtn.FlatStyle = FlatStyle.Popup;
            ShowBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ShowBtn.ForeColor = Color.Maroon;
            ShowBtn.Location = new Point(29, 290);
            ShowBtn.Name = "ShowBtn";
            ShowBtn.Size = new Size(143, 23);
            ShowBtn.TabIndex = 15;
            ShowBtn.Text = "view students list";
            ShowBtn.UseVisualStyleBackColor = false;
            ShowBtn.Click += ShowBtn_Click;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // AveTotalBtn
            // 
            AveTotalBtn.BackColor = Color.Tomato;
            AveTotalBtn.FlatStyle = FlatStyle.Popup;
            AveTotalBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AveTotalBtn.ForeColor = Color.Maroon;
            AveTotalBtn.Location = new Point(178, 290);
            AveTotalBtn.Name = "AveTotalBtn";
            AveTotalBtn.Size = new Size(99, 23);
            AveTotalBtn.TabIndex = 16;
            AveTotalBtn.Text = "class average";
            AveTotalBtn.UseVisualStyleBackColor = false;
            AveTotalBtn.Click += AveTotalBtn_Click;
            this.AveTotalBtn.Click += new System.EventHandler(this.AveTotalBtn_Click);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._4892710;
            pictureBox1.Location = new Point(250, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._8065351;
            pictureBox2.Location = new Point(250, 239);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(307, 324);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(AveTotalBtn);
            Controls.Add(ShowBtn);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(SaveBtn);
            Controls.Add(Avetxt);
            Controls.Add(IDtxt);
            Controls.Add(Lnametxt);
            Controls.Add(Fnametxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox Fnametxt;
        private TextBox Lnametxt;
        private TextBox IDtxt;
        private TextBox Avetxt;
        private Button SaveBtn;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button ShowBtn;
        private Button AveTotalBtn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}