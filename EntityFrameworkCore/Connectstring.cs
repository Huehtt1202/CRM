using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore
{
    class Myclass
    {
        static void Mymethod(string[] args)
        {
            string connStr = "server=127.0.0.1;user=root;database=crm;password=Hoangtthue0220@;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            string sql = "SELECT this FROM that";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    /* iterate once per row */
                }
            }
        }
    }
    //public class Connectstring
    //{
    //    MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
    //    conn_string.Server = "127.0.0.1";
    //    conn_string.UserID = "root";
    //    conn_string.Password = "Hoangtthue0220@";
    //    conn_string.Database = "crm";

    //    MySqlConnection MyCon = new MySqlConnection(conn_string.ToString());


    //    try
    //    {
    //    MyCon.Open();
    //    MessageBox.Show("Open");
    //    MyCon.Close();
    //    MessageBox.Show("Close");
    //    }
    //    catch(Exception ex)
    //    {
    //    MessageBox.Show(ex.Message);
    //    }
    //}
}
