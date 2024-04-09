using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace skills_international
{
    public partial class Student_Registration___Skills_International : Form
    {
     
        

        //string connectionstring = @"Data Source = DESKTOP - GC6F9E5; Integrated Security = True; Encrypt=False";

        // connection 

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GC6F9E5;Integrated Security=True;Encrypt=False");
        public Student_Registration___Skills_International()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            // clear input values

            comboBox1.Text="";
            textBox1.Text="";
            textBox2.Text = "";
           
            richTextBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text ="";
            textBox5.Text="";
            textBox6.Text="";
            textBox7.Text="";
            textBox8.Text="";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // connection open for delete operations

            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Registration Where @regNo==int.Parse(comboBox1.Text)");
            cmd.ExecuteNonQuery();   //executing query
            con.Close();
            deletepage dt1 = new deletepage();
            dt1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // connetion open for update query
            con.Open();
            SqlCommand cmd = new SqlCommand("update Registration set @firstName=textBox1.text,@lastname=textBox2.Text, @address=richTextBox1.Text ,@email=textBox3.Text,@mobilePhone=Int32.Parse(textBox4.Text),@homePhone=Int32.Parse(textBox5.Text),@parentName=textBox6.Text,@nic=textBox7.Text,@contactNo=Int32.Parse(textBox8.Text)");
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("data updated successfully");


        }
        private void button1_Click(object sender, EventArgs e)
        {
            string gend = "Female";


           

                        int regno=int.Parse(comboBox1.Text);
                        string fname=textBox1.Text;
                        string lname=textBox2.Text;
                        string dat=dateTimePicker1.Text;
                        string addr=richTextBox1.Text;
                        string email=textBox3.Text;
                        int mobile=Int32.Parse(textBox4.Text);
                        int home=Int32.Parse(textBox5.Text);
                        string paren=textBox6.Text;
                        string nic=textBox7.Text;
                        int contact=Int32.Parse(textBox8.Text);
            

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Registration Values('" + int.Parse(comboBox1.Text) + "','" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + gend + "','" + richTextBox1.Text + "','" + textBox3.Text + "','" + int.Parse(textBox4.Text) + "','" + int.Parse(textBox5.Text) + "','" + textBox6.Text + "','" + textBox7.Text + "','" + int.Parse(textBox8.Text) + "'),",con);
            cmd.ExecuteNonQuery();

            
            MessageBox.Show("record aded successfully");
            con.Close();
            MessageBox.Show("data inserted successfully");

            /*/
             cmd.Parameters.AddWithValue("@regNo",regno);
             cmd.Parameters.AddWithValue("@firstName",fname);
             cmd.Parameters.AddWithValue("@lastName", lname);
             cmd.Parameters.AddWithValue("@dateofBirth",dat);
             cmd.Parameters.AddWithValue("gender", gend);
             cmd.Parameters.AddWithValue("@address", addr);
             cmd.Parameters.AddWithValue("@email", email);
             cmd.Parameters.AddWithValue("@mobilePhone",mobile);
             cmd.Parameters.AddWithValue("@homePhone", home);
             cmd.Parameters.AddWithValue("@parentName",paren);
             cmd.Parameters.AddWithValue("@nic", nic);
           cmd.Parameters.AddWithValue("@ContactNo", contact);
            /*/







        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            // exit function
            Exit ex = new Exit();
            ex.Show();
            
            
            
            

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //logouut
            Form1 f1 = new Form1();
            f1.Show();
            MessageBox.Show("logout successfully");
            this.Hide();
        }

        private void Student_Registration___Skills_International_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
