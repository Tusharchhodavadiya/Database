using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace database_connectivity
{
    public partial class Update_data : Form
    {
        connection_class obj_con = new connection_class();
        DataTable data_table = new DataTable();
        int bit;
        public Update_data()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bit = obj_con.connect_to_db();
            bool search_bit;
            if (bit != 1)
            {
                MessageBox.Show("Error in connection");
            }
            else
            {
                obj_con.Roll_no = Convert.ToInt32(txt_search.Text);
                data_table = obj_con.search_data(false);
                if (data_table.Rows.Count == 0)
                {
                    
                    MessageBox.Show("No Data Found");
                    lbl_message.Text = data_table.Rows.Count.ToString() + "  Record found";
                    pnl_update.Enabled = false;
                }
                else
                {
                    pnl_update.Enabled = true;
                    lbl_roll_no.Text = data_table.Rows[0][0].ToString();
                    txt_name.Text = data_table.Rows[0][1].ToString();
                    if (data_table.Rows[0][2].ToString() == "female" )
                    {
                        rd_female.Checked = true;
                    }
                    else
                    {
                        rd_male.Checked = true;
                    }
                    txt_adhar_no.Text = data_table.Rows[0][4].ToString();
                    txt_year.Text = data_table.Rows[0][5].ToString();
                    txt_division.Text = data_table.Rows[0][6].ToString();
                    txt_email.Text = data_table.Rows[0][7].ToString();
                    lbl_message.Text = data_table.Rows.Count.ToString() + "  Record found";
                }

            }
            obj_con.disconnect_db();

        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            obj_con.connect_to_db();
            obj_con.Roll_no = Convert.ToInt16(lbl_roll_no.Text);
            obj_con.Name = txt_name.Text;
            string gender = "";
            if (rd_male.Checked == true)
            {
                obj_con.Gender = rd_male.Text;
            }
            else
            {
                obj_con.Gender = rd_female.Text;
            }
            obj_con.Birthdate  = monthCalendar1.SelectionRange.Start.ToString();
            obj_con.Adhar_no = Convert.ToInt64(txt_adhar_no.Text);
            obj_con.Year  = Convert.ToInt32(txt_year.Text);
            obj_con.Div= txt_division.Text;
            obj_con.Email = txt_email.Text;
            bool update = obj_con.update_data();
            if (update == true)
            {
                MessageBox.Show("Data Update successfully");
            }
            else
            {
                MessageBox.Show("Problem in Data Updation");
            }

        }
    }
}
