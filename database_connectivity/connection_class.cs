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
    class connection_class
    {
        
        OleDbConnection conn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader reader;
        DataTable dt = new DataTable();
       
        private string name;
        private string gender;
        private string birthdate;
        private long  adhar_no;
        private int year;
        private string div;
        private string email;
        private int  roll_no;

        public int Roll_no
        {
            get
            {
                return roll_no;
            }
            set
            {
                roll_no = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public string Birthdate
        {
            get
            {
                return birthdate;
            }
            set
            {
                birthdate = value;
            }
        }
        public long Adhar_no
        {
            get
            {
                return adhar_no;
            }
            set
            {
                adhar_no = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public string Div
        {
            get
            {
                return div;
            }
            set
            {
                div = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }


        public int connect_to_db()
        {
            try
            {
                string connection_str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\KRUPALI_BUSA\Second_Year\Database\Final_db.mdb";
                conn.ConnectionString = connection_str;
                conn.Open();
            }
            catch (Exception ex)
            {
                return 0;
            }
            return 1;
        }
        public void insert_data()
        {
            cmd.Connection = conn;
            string qry = "insert into student_data (std_name , std_gender , std_birth_date ,std_adhar_no , std_year , std_div , std_email ) values ('"+name+"', '"+gender+"' , '"+birthdate+"' , '"+ adhar_no +"' , "+year+" , '"+div+"' , '"+email+"'  ) ";
            cmd.CommandText = qry;
            cmd.ExecuteNonQuery();
        }
        public void disconnect_db()
        {
            conn.Close();
        }

        public DataTable search_data(bool search_bit)
        {
            string qry = ""; 
            cmd.Connection = conn;
            if (search_bit)
            {
                 qry = "select * from student_data where std_name like '"+name+"%' ";
            }
            else 
            {
                 qry = "select * from student_data where RollNo = "+roll_no+" ";    
            }
            
            cmd.CommandText = qry; 
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            if (dt.Rows.Count != 0)
            {
                dt.Rows.Clear();
                da.Fill(dt);
            }
            else
            {
                da.Fill(dt);
            }
            
            return dt;
        }
        public bool update_data()
        {
            cmd.Connection = conn;
            
            string qry = "update student_data set std_name = '" + Name + "' , std_gender = '" + Gender + "' , std_birth_date= '" + Birthdate + "' , std_adhar_no = " + Adhar_no + " , std_year=" + Year + "  ,std_div = '" + Div + "'  , std_email='" + Email + "'  where RollNo = "+Roll_no+"";
            cmd.CommandText = qry;
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            
        }
        public DataTable select()
        {
            string qry = "";
            cmd.Connection = conn;
            qry = "select * from student_data";
            cmd.CommandText = qry;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            if (dt.Rows.Count != 0)
            {
                dt.Rows.Clear();
                da.Fill(dt);
            }
            else
            {
                da.Fill(dt);
            }

            return dt;

        }

        public bool delete_data()
        {
            cmd.Connection = conn;

            string qry = "delete  from  student_data where RollNo = " + Roll_no + " ";
            cmd.CommandText = qry;
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
    }
}
