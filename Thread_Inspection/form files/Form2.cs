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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Administrator_Click(object sender, EventArgs e)
        {
           
            if (password_textbox.Text == "")
            {
                MessageBox.Show("Please enter Password");

            }
            

            else if (textBox1_result.Text == "lucastvs" && password_textbox.Text == "1234")
            {
                MessageBox.Show("Login Successful!");
                Partcount.Visible = true;
               
                this.Width = 781;
                this.Height = 735;
                label1.Width = this.Width;
                label1.Height = this.Height;

               
            }
           
            else
            {
                MessageBox.Show("Wrong Password", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            password_textbox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            thread_pass_count.Text = Form1.Thread_Passcount.ToString();
            thread_fail_count.Text = Form1.Thread_Failcount.ToString();
            hole_passcount.Text = Form1.Hole_Passcount.ToString();
            hole_failcount.Text = Form1.Hole_Failcount.ToString();
            total_passcount.Text = Form1.Total_passcount.ToString();
            total_failcount.Text = Form1.Total_failcount.ToString();
            total_count.Text = Form1.total_count.ToString();
        }
    }
}
