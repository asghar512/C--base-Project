using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    class Librarian
    {
        
        SqlCommand cmd = null;
        public string createLibrarian(string name, string cno, string uname, string pw)
        {
            Connection con = new Connection();
            try
            {
                cmd = new SqlCommand("INSERT into tbl_librarian VALUES('" + name + "','" + cno + "','" + uname + "','" + pw + "')", con.Connect());
                cmd.ExecuteNonQuery();
                con.Close();
                return "Account created successfully";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public DataTable getLibrarians(string name)
        {
            string mystr;
            if (name == "")
            {
                mystr = "SELECT * FROM tbl_Librarian";
            }
            else
            {
                mystr = "SELECT * FROM tbl_Librarian WHERE L_FullName like '%" + name + "%'";
            }
            Connection con = new Connection();
            DataTable dt = new DataTable();
            try
            {

                cmd = new SqlCommand(mystr, con.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }
            return dt;

        }

        public string deleteLibrarian(string lid)
        {
            Connection con = new Connection();
            try
            {
                cmd = new SqlCommand("Delete From tbl_Librarian Where L_ID = " + lid + "", con.Connect());
                cmd.ExecuteNonQuery();
                con.Close();
                return "Account deleted successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public string updateLibrarian(string id,string name, string cno, string pw)
        {
            Connection con = new Connection();
            try
            {
                cmd = new SqlCommand("UPDATE tbl_Librarian SET l_FullName = '" + name + "',l_ContactNo = '" + cno + "',l_password = '" + pw + "' WHERE l_ID = " + id + "", con.Connect());
                cmd.ExecuteNonQuery();
                con.Close();
                return "Account Updated Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
