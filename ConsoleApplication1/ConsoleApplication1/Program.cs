using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connstr = "server=localhost;user=root;database=sys;port=3306;password=rajagiri";
            string sql = "select *from mytable";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connectiong to mysql");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.read()) {
                    Console.WriteLine(rdr[0].ToString() + "\t" + rdr[1].ToString());
                }
                rdr.Close();
            }catch(Exception e) { Console.WriteLine(e); }
            conn.Close();
            Console.WriteLine("connection closed.press any key");
            Console.Read();
        }
    }
}
