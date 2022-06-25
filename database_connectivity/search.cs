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
    public partial class search : Form
    {
        
        connection_class obj_con = new connection_class();
        DataTable data_table = new DataTable();
        int bit;
        public search()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
           /* bit = obj_con.connect_to_db();
            bool search_bit;
            if (bit != 1)
            {
                MessageBox.Show("Error in connection");
            }
            else
            {
                if (rd_name.Checked == true)
                {
                    search_bit = true;
                    obj_con.Name = txt_search.Text;
                    data_table = obj_con.search_data(search_bit);
                }
                else if (rd_no.Checked == true)
                {
                    search_bit = false ;
                    obj_con.Roll_no = Convert.ToInt32(txt_search.Text);
                    data_table=obj_con.search_data(search_bit);
                    
                }
                if (data_table.Rows.Count == 0)
                {
                    lbl_message.Text = "No Data found";
                    lbl_message.Text = data_table.Rows.Count.ToString() + "  Record found";
                    
                }
                else
                {
                    grd_std_data.Enabled = true;
                    this.grd_std_data.DataSource = null;
                    this.grd_std_data.Rows.Clear();
                    this.grd_std_data.DataSource = this.grd_std_data;
                    grd_std_data.DataSource = data_table;
                    lbl_message.Text = data_table.Rows.Count.ToString() + "  Record found";
                }
               
            }
            obj_con.disconnect_db();*/
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
                bit = obj_con.connect_to_db();
                bool search_bit;
                if (bit != 1)
                {
                    MessageBox.Show("Error in connection");
                }
                else
                {
                    if (rd_name.Checked == true)
                    {
                        search_bit = true;
                        obj_con.Name = txt_search.Text;
                        data_table = obj_con.search_data(search_bit);
                    }
                    else if (rd_no.Checked == true)
                    {
                        search_bit = false;
                        if (txt_search.Text == "")
                        {
                            MessageBox.Show("Please Enter Roll Number");
                        }
                        else
                        {
                            obj_con.Roll_no = Convert.ToInt32(txt_search.Text);
                            data_table = obj_con.search_data(search_bit);
                        }
                    }
                    if (data_table.Rows.Count == 0)
                    {
                        lbl_message.Text = "No Data found";
                        lbl_message.Text = data_table.Rows.Count.ToString() + "  Record found";

                    }
                    else
                    {
                        grd_std_data.Enabled = true;
                        this.grd_std_data.DataSource = null;
                        this.grd_std_data.Rows.Clear();
                        this.grd_std_data.DataSource = this.grd_std_data;
                        grd_std_data.DataSource = data_table;
                        lbl_message.Text = data_table.Rows.Count.ToString() + "  Record found";
                    }
                }
                obj_con.disconnect_db();
            }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rd_no.Checked == true)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
            }
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {

        }
        
    }
}
