using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace loginformusingcsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=Dev-PC;Initial Catalog=testlogin;Integrated Security=True");
            SqlDataAdapter sda =new SqlDataAdapter("select count(*) from login where Username = '"+textBox1.Text+"' and Password='"+textBox2.Text+"' and Email='"+textBox3.Text+"' and ID='"+textBox4.Text+"'",conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Main mm = new Main();
                mm.Show();
            }
            else
            { 
                MessageBox.Show("please enter correct username , password , Email and ID", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
