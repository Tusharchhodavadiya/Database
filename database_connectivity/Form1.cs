using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace database_connectivity
{
    public partial class Form1 : Form
    {
        connection_class obj_con = new connection_class();
        int bit;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bit = obj_con.connect_to_db();
            if (bit != 1)
            {
                MessageBox.Show("Error in connection");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

           if (txt_name.Text == "")
            {
                MessageBox.Show("Please write your name");
            }
            else if (txt_adhar_no.Text == "")
            {
                MessageBox.Show("Please write your adhar number");
            }
            else if (txt_year.Text == "")
            {
                MessageBox.Show("Please write your year");
            }
            else if (txt_division.Text == "")
            {
                MessageBox.Show("Please write your division");
            }
            else if (txt_email.Text == "")
            {
                MessageBox.Show("Please write your email");
            }
            else
            {
                obj_con.Name = txt_name.Text;
                if(rd_female.Checked == true)
                {
                    obj_con.Gender = rd_female.Text;
                }
                else if (rd_male.Checked == true)
                {
                    obj_con.Gender = rd_male.Text;
                }
                obj_con.Birthdate = monthCalendar1.SelectionRange.Start.ToString();
                obj_con.Adhar_no = Convert.ToInt64(txt_adhar_no.Text);
                obj_con.Year = Convert.ToInt32(txt_year.Text);
                obj_con.Div = txt_division.Text;
                obj_con.Email = txt_email.Text;
                try
                {
                    obj_con.insert_data();
                    obj_con.disconnect_db();
                    MessageBox.Show("Data Inserted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
    }
}
