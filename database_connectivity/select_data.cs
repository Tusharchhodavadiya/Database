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
    public partial class select_data : Form
    {
        connection_class obj_con = new connection_class();
        DataTable data_table = new DataTable();
        public select_data()
        {
            InitializeComponent();
        }

        private void select_data_Load(object sender, EventArgs e)
        {
           
        }

        private void grd_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            
            obj_con.connect_to_db();
            data_table = obj_con.select();
            if (data_table.Rows.Count == 0)
            {
                MessageBox.Show("No data Found");
            }
            else
            {
                grd_data.DataSource = data_table;
            }
            obj_con.disconnect_db();
        }

        private void grd_data_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            lbl_roll_no.Text = grd_data.CurrentRow.Cells[0].Value.ToString();
            lbl_name.Text = grd_data.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.grd_data.DataSource = null;
            this.grd_data.Rows.Clear();
            obj_con.connect_to_db();
            obj_con.Roll_no = Convert.ToInt16(lbl_roll_no.Text);
            bool delete = obj_con.delete_data();
            obj_con.disconnect_db();
            if (delete == true)
            {
                MessageBox.Show("Data Delete Successfully");
                obj_con.connect_to_db();
                data_table = obj_con.select();
                if (data_table.Rows.Count == 0)
                {
                    MessageBox.Show("No data Found");
                }
                else
                {
                    grd_data.DataSource = data_table;
                }
                obj_con.disconnect_db();
            }
            else
            {
                MessageBox.Show("Problem in deletind Data");  
            }

        }
    }
}
