namespace Thread_Inspection
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.HEADING_LBL = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.load_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.log_btn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.yml_path = new System.Windows.Forms.TextBox();
            this.test_btn = new System.Windows.Forms.Button();
            this.img_path = new System.Windows.Forms.TextBox();
            this.browse_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.frame_conut = new System.Windows.Forms.Button();
            this.camstatus = new System.Windows.Forms.Label();
            this.plcstatus = new System.Windows.Forms.Label();
            this.time_lbl = new System.Windows.Forms.Label();
            this.date_lbl = new System.Windows.Forms.Label();
            this.datetime = new System.Windows.Forms.Timer(this.components);
            this.stop_btn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.imagegrabtimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hole_result = new System.Windows.Forms.Button();
            this.Thread_result = new System.Windows.Forms.Button();
            this.Final_result = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.img_disp = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.offtimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_disp)).BeginInit();
            this.SuspendLayout();
            // 
            // HEADING_LBL
            // 
            this.HEADING_LBL.AutoSize = true;
            this.HEADING_LBL.BackColor = System.Drawing.Color.Azure;
            this.HEADING_LBL.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HEADING_LBL.Location = new System.Drawing.Point(-3, 9);
            this.HEADING_LBL.Name = "HEADING_LBL";
            this.HEADING_LBL.Size = new System.Drawing.Size(1092, 94);
            this.HEADING_LBL.TabIndex = 4;
            this.HEADING_LBL.Text = "THREAD INSPECTION SYSTEM";
            this.HEADING_LBL.Click += new System.EventHandler(this.HEADING_LBL_Click);
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.start_btn.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.Location = new System.Drawing.Point(1228, 352);
            this.start_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(179, 73);
            this.start_btn.TabIndex = 6;
            this.start_btn.Text = "START";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.EnabledChanged += new System.EventHandler(this.start_btn_EnabledChanged);
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.load_btn);
            this.groupBox1.Controls.Add(this.save_btn);
            this.groupBox1.Controls.Add(this.log_btn);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.yml_path);
            this.groupBox1.Controls.Add(this.test_btn);
            this.groupBox1.Controls.Add(this.img_path);
            this.groupBox1.Controls.Add(this.browse_btn);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1005, 181);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(805, 153);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Box";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(364, 114);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 28);
            this.textBox2.TabIndex = 58;
            this.textBox2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(656, 113);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 28);
            this.textBox1.TabIndex = 50;
            this.textBox1.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(40, 114);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 30);
            this.button3.TabIndex = 49;
            this.button3.Text = "Rect";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // load_btn
            // 
            this.load_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_btn.Location = new System.Drawing.Point(491, 79);
            this.load_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(89, 30);
            this.load_btn.TabIndex = 10;
            this.load_btn.Text = "Load";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(368, 82);
            this.save_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(89, 30);
            this.save_btn.TabIndex = 9;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // log_btn
            // 
            this.log_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_btn.Location = new System.Drawing.Point(621, 78);
            this.log_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.log_btn.Name = "log_btn";
            this.log_btn.Size = new System.Drawing.Size(168, 30);
            this.log_btn.TabIndex = 8;
            this.log_btn.Text = "Log Images";
            this.log_btn.UseVisualStyleBackColor = true;
            this.log_btn.Click += new System.EventHandler(this.log_btn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(199, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 27);
            this.label10.TabIndex = 48;
            this.label10.Text = "Elapsing Time:";
            this.label10.Visible = false;
            // 
            // yml_path
            // 
            this.yml_path.Location = new System.Drawing.Point(368, 39);
            this.yml_path.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yml_path.Multiline = true;
            this.yml_path.Name = "yml_path";
            this.yml_path.Size = new System.Drawing.Size(420, 24);
            this.yml_path.TabIndex = 7;
            this.yml_path.Text = "Yml Path";
            this.yml_path.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // test_btn
            // 
            this.test_btn.BackColor = System.Drawing.SystemColors.Control;
            this.test_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test_btn.Location = new System.Drawing.Point(204, 82);
            this.test_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.test_btn.Name = "test_btn";
            this.test_btn.Size = new System.Drawing.Size(129, 30);
            this.test_btn.TabIndex = 5;
            this.test_btn.Text = "Test";
            this.test_btn.UseVisualStyleBackColor = false;
            this.test_btn.Click += new System.EventHandler(this.test_btn_Click);
            // 
            // img_path
            // 
            this.img_path.Location = new System.Drawing.Point(5, 39);
            this.img_path.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.img_path.Multiline = true;
            this.img_path.Name = "img_path";
            this.img_path.Size = new System.Drawing.Size(335, 24);
            this.img_path.TabIndex = 2;
            this.img_path.Text = "Browsed image path";
            this.img_path.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.img_path.TextChanged += new System.EventHandler(this.img_path_TextChanged);
            // 
            // browse_btn
            // 
            this.browse_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse_btn.Location = new System.Drawing.Point(23, 80);
            this.browse_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(139, 30);
            this.browse_btn.TabIndex = 0;
            this.browse_btn.Text = "Browse";
            this.browse_btn.UseVisualStyleBackColor = true;
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 790);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Number of images captured";
            // 
            // frame_conut
            // 
            this.frame_conut.BackColor = System.Drawing.Color.White;
            this.frame_conut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frame_conut.Location = new System.Drawing.Point(885, 785);
            this.frame_conut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frame_conut.Name = "frame_conut";
            this.frame_conut.Size = new System.Drawing.Size(93, 30);
            this.frame_conut.TabIndex = 4;
            this.frame_conut.Text = "Frame count";
            this.frame_conut.UseVisualStyleBackColor = false;
            this.frame_conut.Click += new System.EventHandler(this.button1_Click);
            // 
            // camstatus
            // 
            this.camstatus.AutoSize = true;
            this.camstatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camstatus.Location = new System.Drawing.Point(15, 788);
            this.camstatus.Name = "camstatus";
            this.camstatus.Size = new System.Drawing.Size(163, 26);
            this.camstatus.TabIndex = 4;
            this.camstatus.Text = "Camera Status";
            this.camstatus.Click += new System.EventHandler(this.label4_Click);
            // 
            // plcstatus
            // 
            this.plcstatus.AutoSize = true;
            this.plcstatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plcstatus.Location = new System.Drawing.Point(295, 788);
            this.plcstatus.Name = "plcstatus";
            this.plcstatus.Size = new System.Drawing.Size(129, 26);
            this.plcstatus.TabIndex = 5;
            this.plcstatus.Text = "PLC Status";
            this.plcstatus.Click += new System.EventHandler(this.label5_Click);
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_lbl.Location = new System.Drawing.Point(1672, 793);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(75, 26);
            this.time_lbl.TabIndex = 33;
            this.time_lbl.Text = "TIME";
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lbl.Location = new System.Drawing.Point(1503, 791);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(75, 26);
            this.date_lbl.TabIndex = 34;
            this.date_lbl.Text = "DATE";
            // 
            // datetime
            // 
            this.datetime.Tick += new System.EventHandler(this.datetime_Tick);
            // 
            // stop_btn
            // 
            this.stop_btn.BackColor = System.Drawing.Color.Red;
            this.stop_btn.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_btn.Location = new System.Drawing.Point(1475, 352);
            this.stop_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(179, 73);
            this.stop_btn.TabIndex = 35;
            this.stop_btn.Text = "STOP";
            this.stop_btn.UseVisualStyleBackColor = false;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // imagegrabtimer
            // 
            this.imagegrabtimer.Interval = 50;
            this.imagegrabtimer.Tick += new System.EventHandler(this.imagegrabtimer_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hole_result);
            this.groupBox2.Controls.Add(this.Thread_result);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1011, 622);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(396, 145);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Individual Inspection Results";
            // 
            // hole_result
            // 
            this.hole_result.BackColor = System.Drawing.Color.OliveDrab;
            this.hole_result.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hole_result.Location = new System.Drawing.Point(44, 86);
            this.hole_result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hole_result.Name = "hole_result";
            this.hole_result.Size = new System.Drawing.Size(333, 52);
            this.hole_result.TabIndex = 45;
            this.hole_result.Text = "HOLE RESULT";
            this.hole_result.UseVisualStyleBackColor = false;
            // 
            // Thread_result
            // 
            this.Thread_result.BackColor = System.Drawing.Color.OliveDrab;
            this.Thread_result.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thread_result.Location = new System.Drawing.Point(45, 31);
            this.Thread_result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Thread_result.Name = "Thread_result";
            this.Thread_result.Size = new System.Drawing.Size(333, 52);
            this.Thread_result.TabIndex = 44;
            this.Thread_result.Text = "THREAD RESULT";
            this.Thread_result.UseVisualStyleBackColor = false;
            // 
            // Final_result
            // 
            this.Final_result.BackColor = System.Drawing.Color.OliveDrab;
            this.Final_result.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Final_result.Location = new System.Drawing.Point(1496, 639);
            this.Final_result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Final_result.Name = "Final_result";
            this.Final_result.Size = new System.Drawing.Size(269, 121);
            this.Final_result.TabIndex = 0;
            this.Final_result.Text = "Final Result";
            this.Final_result.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Lavender;
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(1005, 463);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(805, 121);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(144, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(456, 57);
            this.button1.TabIndex = 49;
            this.button1.Text = "Samples Count";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(497, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 51;
            this.label3.Text = "To Adjust Values";
            this.label3.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(485, 31);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(313, 57);
            this.button2.TabIndex = 44;
            this.button2.Text = "Train Values";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 26);
            this.label2.TabIndex = 50;
            this.label2.Text = "To Check Count";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Thread_Inspection.Properties.Resources.rebot;
            this.pictureBox1.Location = new System.Drawing.Point(1147, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(663, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // img_disp
            // 
            this.img_disp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.img_disp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.img_disp.Location = new System.Drawing.Point(20, 103);
            this.img_disp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.img_disp.Name = "img_disp";
            this.img_disp.Size = new System.Drawing.Size(957, 665);
            this.img_disp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_disp.TabIndex = 5;
            this.img_disp.TabStop = false;
            this.img_disp.Click += new System.EventHandler(this.img_disp_Click);
            this.img_disp.Paint += new System.Windows.Forms.PaintEventHandler(this.img_disp_Paint);
            this.img_disp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.img_disp_MouseDown);
            this.img_disp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.img_disp_MouseMove);
            this.img_disp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.img_disp_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1069, 352);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 33);
            this.button5.TabIndex = 54;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1011, 352);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 33);
            this.button6.TabIndex = 55;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1128, 352);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(51, 33);
            this.button7.TabIndex = 56;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1067, 396);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 28);
            this.button8.TabIndex = 57;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            // 
            // offtimer
            // 
            this.offtimer.Interval = 2000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1827, 809);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.frame_conut);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.Final_result);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.plcstatus);
            this.Controls.Add(this.date_lbl);
            this.Controls.Add(this.camstatus);
            this.Controls.Add(this.time_lbl);
            this.Controls.Add(this.img_disp);
            this.Controls.Add(this.HEADING_LBL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thread_Inspection";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_disp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label HEADING_LBL;
        private System.Windows.Forms.PictureBox img_disp;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button frame_conut;
        private System.Windows.Forms.TextBox img_path;
        private System.Windows.Forms.Button browse_btn;
        private System.Windows.Forms.Label camstatus;
        private System.Windows.Forms.Label plcstatus;
        private System.Windows.Forms.Button test_btn;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.Timer datetime;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox yml_path;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button log_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer imagegrabtimer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Final_result;
        private System.Windows.Forms.Button hole_result;
        private System.Windows.Forms.Button Thread_result;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer offtimer;
        // private System.Windows.Forms.Label image_count;
    }
}

