//Программный код класса LoginForm

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
     
        }

        private void userLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {

            label3.Visible = true;
            textBox1.Visible = true;
            label2.Visible = true;
            textBox2.Visible = true;
            button1.Visible = true;
            button2.Visible = false;
            pictureBox1.Visible = false; 
         
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con_string = @"Data Source=OWNER-ПК\SQLEXPRESS;Initial Catalog=CUSTOMER;Integrated Security=True";
            string query = "SELECT * FROM LOG WHERE  login='" + textBox1.Text.ToString() + "' AND password='" + textBox2.Text.ToString() + "' AND id_role='" + textBox3.Text.ToString() + "'";
            SqlConnection Con = new SqlConnection(con_string);
            SqlCommand Com = new SqlCommand(query, Con);

            Con.Open();
            SqlDataReader Reader;
            Reader = Com.ExecuteReader();

            if (Reader.Read())
               
                 {

                    MessageBox.Show(" Login successfully !  Admin. ");
                    Form7 f7 = new Form7();
                    f7.Show();
                    this.Hide();
                 }
                        
          
                else

                 {
                   MessageBox.Show(" UserName or Password error ! Check your login and password. ");
                  

                   textBox1.Clear();
                   textBox2.Clear();

                 }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)

        {
            label3.Visible = true;
            textBox1.Visible = true;
            label2.Visible = true;
            textBox2.Visible = true;
            button2.Visible = true;
            button1.Visible = false;
            pictureBox1.Visible = false;

            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)

        {
            
            string con_string = @"Data Source=OWNER-ПК\SQLEXPRESS;Initial Catalog=CUSTOMER;Integrated Security=True";
            string query = "SELECT * FROM LOG WHERE  login='" + textBox1.Text.ToString() + "' AND password='" + textBox2.Text.ToString() + "' AND id_role='" + textBox4.Text.ToString() + "'";
            SqlConnection Con = new SqlConnection(con_string);
            SqlCommand Com = new SqlCommand(query, Con);
            Con.Open();
            SqlDataReader Reader;
             Reader = Com.ExecuteReader();
                    
            if (Reader.Read())
                      
                {
                    MessageBox.Show(" Login successfully !  Employee. ");
                    Form10 f10 = new Form10();
                    f10.Show();
                    this.Hide();
                 
                }

                else

                {
                    MessageBox.Show(" UserName or Password error ! Check your login and password.");

                    textBox1.Clear();
                    textBox2.Clear();
                  
               }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "DataBase",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.Yes)
            {
                Application.Exit();
            }

           }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 a1 = new AboutBox1();
            a1.Show();
            this.Hide();
        }

        private void guestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guest G = new Guest();
            G.Show();
            this.Hide();
        }

       }
   }
          
           
        

