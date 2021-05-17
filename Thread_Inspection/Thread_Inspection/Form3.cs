using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thread_Inspection
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public static int value1 = 0;
        public static int value2 = 0;
        public static int value3 = 0;
        public static int value4 = 0;
        public static int thread_value = 0;
        public static bool start = false, close = false,start5=false,start1=false,start2=false,start3=false,start4=false;
        private void Administrator_Click(object sender, EventArgs e)
        {
           
            if (password_textbox.Text == "")
            {
                MessageBox.Show("Please enter Password");

            }
            else if (textBox1_user.Text == "lucastvs" && password_textbox.Text == "985052")

            
            {
                MessageBox.Show("Login Successful!");
               
                this.Width = 781;
                this.Height = 659;
                label1.Width = this.Width;
                label1.Height = this.Height;

                groupBox4.Visible = true;
               
            }
            else
            {
                MessageBox.Show("Wrong Password", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            password_textbox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            close = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            close = true;
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void numeric_hole_first_ValueChanged(object sender, EventArgs e)
        {
            value1 = (int)numeric_hole_first.Value;
            start1 = true;
            start = true;
        }

        private void numeric_hole_second_ValueChanged(object sender, EventArgs e)
        {
            value2 = (int)numeric_hole_second.Value;
            start2 = true;
            start = true;
        }

        private void numeric_hole_fthird_ValueChanged(object sender, EventArgs e)
        {
            value3 = (int)numeric_hole_fthird.Value;
            start3 = true;
            start = true;
        }

        private void numeric_hole_fourth_ValueChanged(object sender, EventArgs e)
        {
            value4 = (int)numeric_hole_fourth.Value;
            start4 = true;
            start = true;
        }

        private void numeric_thread_ValueChanged(object sender, EventArgs e)
        {
            thread_value = (int)numeric_thread.Value;
            start5 = true;
            start = true;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            value1 = (int)numeric_hole_first.Value;
            value2 = (int)numeric_hole_second.Value;
            value3 = (int)numeric_hole_fthird.Value;
            value4 = (int)numeric_hole_fourth.Value;
            thread_value= (int)numeric_thread.Value;
            close = true;
        }
    }
}
