namespace Thread_Inspection
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.Administrator = new System.Windows.Forms.Button();
            this.textBox1_result = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Partcount = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.total_count = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.total_failcount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.total_passcount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.hole_failcount = new System.Windows.Forms.Label();
            this.hole_passcount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.thread_fail_count = new System.Windows.Forms.Label();
            this.thread_pass_count = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.Partcount.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.password_textbox);
            this.groupBox1.Controls.Add(this.Administrator);
            this.groupBox1.Controls.Add(this.textBox1_result);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(111, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 207);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOGIN DETAILS";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(230, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 38);
            this.button1.TabIndex = 60;
            this.button1.Text = "CAN&CEL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 22);
            this.label5.TabIndex = 59;
            this.label5.Text = "PASSWORD";
            // 
            // password_textbox
            // 
            this.password_textbox.BackColor = System.Drawing.SystemColors.Window;
            this.password_textbox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textbox.Location = new System.Drawing.Point(157, 88);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(232, 32);
            this.password_textbox.TabIndex = 58;
            // 
            // Administrator
            // 
            this.Administrator.BackColor = System.Drawing.Color.Maroon;
            this.Administrator.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Administrator.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Administrator.Location = new System.Drawing.Point(71, 152);
            this.Administrator.Name = "Administrator";
            this.Administrator.Size = new System.Drawing.Size(120, 38);
            this.Administrator.TabIndex = 57;
            this.Administrator.Text = "LOG&IN";
            this.Administrator.UseVisualStyleBackColor = false;
            this.Administrator.Click += new System.EventHandler(this.Administrator_Click);
            // 
            // textBox1_result
            // 
            this.textBox1_result.Location = new System.Drawing.Point(157, 39);
            this.textBox1_result.Name = "textBox1_result";
            this.textBox1_result.Size = new System.Drawing.Size(232, 32);
            this.textBox1_result.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "USER NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, -129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 73);
            this.label1.TabIndex = 60;
            this.label1.Text = "RESULT  WINDOW";
            // 
            // Partcount
            // 
            this.Partcount.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Partcount.Controls.Add(this.button3);
            this.Partcount.Controls.Add(this.groupBox2);
            this.Partcount.Controls.Add(this.label11);
            this.Partcount.Controls.Add(this.hole_failcount);
            this.Partcount.Controls.Add(this.hole_passcount);
            this.Partcount.Controls.Add(this.label7);
            this.Partcount.Controls.Add(this.button2);
            this.Partcount.Controls.Add(this.label8);
            this.Partcount.Controls.Add(this.thread_fail_count);
            this.Partcount.Controls.Add(this.thread_pass_count);
            this.Partcount.Controls.Add(this.label2);
            this.Partcount.Controls.Add(this.label3);
            this.Partcount.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Partcount.Location = new System.Drawing.Point(29, 340);
            this.Partcount.Name = "Partcount";
            this.Partcount.Size = new System.Drawing.Size(651, 347);
            this.Partcount.TabIndex = 59;
            this.Partcount.TabStop = false;
            this.Partcount.Text = "Part count Result";
            this.Partcount.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(500, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 38);
            this.button3.TabIndex = 63;
            this.button3.Text = "RESET";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.total_count);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.total_failcount);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.total_passcount);
            this.groupBox2.Location = new System.Drawing.Point(156, 143);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(316, 146);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            // 
            // total_count
            // 
            this.total_count.AutoSize = true;
            this.total_count.BackColor = System.Drawing.SystemColors.MenuBar;
            this.total_count.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_count.Location = new System.Drawing.Point(239, 110);
            this.total_count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.total_count.Name = "total_count";
            this.total_count.Size = new System.Drawing.Size(43, 33);
            this.total_count.TabIndex = 64;
            this.total_count.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 26);
            this.label9.TabIndex = 63;
            this.label9.Text = "TOTAL COUNT    :";
            // 
            // total_failcount
            // 
            this.total_failcount.AutoSize = true;
            this.total_failcount.BackColor = System.Drawing.SystemColors.MenuBar;
            this.total_failcount.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_failcount.Location = new System.Drawing.Point(239, 63);
            this.total_failcount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.total_failcount.Name = "total_failcount";
            this.total_failcount.Size = new System.Drawing.Size(43, 33);
            this.total_failcount.TabIndex = 62;
            this.total_failcount.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 33);
            this.label4.TabIndex = 38;
            this.label4.Text = "Total Passcount  :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(217, 34);
            this.label12.TabIndex = 61;
            this.label12.Text = "Total Failcount  :";
            // 
            // total_passcount
            // 
            this.total_passcount.AutoSize = true;
            this.total_passcount.BackColor = System.Drawing.SystemColors.MenuBar;
            this.total_passcount.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_passcount.Location = new System.Drawing.Point(239, 15);
            this.total_passcount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.total_passcount.Name = "total_passcount";
            this.total_passcount.Size = new System.Drawing.Size(43, 33);
            this.total_passcount.TabIndex = 40;
            this.total_passcount.Text = "00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(352, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(212, 33);
            this.label11.TabIndex = 60;
            this.label11.Text = "Hole Failcount   :";
            // 
            // hole_failcount
            // 
            this.hole_failcount.AutoSize = true;
            this.hole_failcount.BackColor = System.Drawing.SystemColors.MenuBar;
            this.hole_failcount.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hole_failcount.Location = new System.Drawing.Point(569, 93);
            this.hole_failcount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hole_failcount.Name = "hole_failcount";
            this.hole_failcount.Size = new System.Drawing.Size(43, 33);
            this.hole_failcount.TabIndex = 59;
            this.hole_failcount.Text = "00";
            // 
            // hole_passcount
            // 
            this.hole_passcount.AutoSize = true;
            this.hole_passcount.BackColor = System.Drawing.SystemColors.MenuBar;
            this.hole_passcount.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hole_passcount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hole_passcount.Location = new System.Drawing.Point(569, 49);
            this.hole_passcount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hole_passcount.Name = "hole_passcount";
            this.hole_passcount.Size = new System.Drawing.Size(43, 33);
            this.hole_passcount.TabIndex = 58;
            this.hole_passcount.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(353, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 33);
            this.label7.TabIndex = 57;
            this.label7.Text = "Hole Passcount  :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(291, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 38);
            this.button2.TabIndex = 56;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(249, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 27);
            this.label8.TabIndex = 41;
            // 
            // thread_fail_count
            // 
            this.thread_fail_count.AutoSize = true;
            this.thread_fail_count.BackColor = System.Drawing.SystemColors.MenuBar;
            this.thread_fail_count.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thread_fail_count.Location = new System.Drawing.Point(248, 93);
            this.thread_fail_count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.thread_fail_count.Name = "thread_fail_count";
            this.thread_fail_count.Size = new System.Drawing.Size(43, 33);
            this.thread_fail_count.TabIndex = 39;
            this.thread_fail_count.Text = "00";
            // 
            // thread_pass_count
            // 
            this.thread_pass_count.AutoSize = true;
            this.thread_pass_count.BackColor = System.Drawing.SystemColors.MenuBar;
            this.thread_pass_count.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thread_pass_count.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.thread_pass_count.Location = new System.Drawing.Point(248, 45);
            this.thread_pass_count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.thread_pass_count.Name = "thread_pass_count";
            this.thread_pass_count.Size = new System.Drawing.Size(43, 33);
            this.thread_pass_count.TabIndex = 6;
            this.thread_pass_count.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 33);
            this.label2.TabIndex = 36;
            this.label2.Text = "Thread Passcount  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 33);
            this.label3.TabIndex = 37;
            this.label3.Text = "Thread Failcount   :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(39, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(613, 73);
            this.label10.TabIndex = 62;
            this.label10.Text = "RESULT  WINDOW";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 603);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Partcount);
            this.Location = new System.Drawing.Point(650, 10);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Partcount.ResumeLayout(false);
            this.Partcount.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Button Administrator;
        private System.Windows.Forms.TextBox textBox1_result;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Partcount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label total_count;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label total_failcount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label total_passcount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label hole_failcount;
        private System.Windows.Forms.Label hole_passcount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label thread_fail_count;
        private System.Windows.Forms.Label thread_pass_count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
    }
}