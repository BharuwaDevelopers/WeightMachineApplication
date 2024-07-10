using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace login
{
    class db_Connection
    {
        public static string connection_string()
        {
          
                string con_string = System.IO.File.ReadAllText(@"C:\db_connect.txt");
                Console.WriteLine(con_string);
                //  String db_string = "Data Source=OVERWATCH-PC;Initial Catalog=weight_bridge;Integrated Security=True";
                String db_string = con_string;
                return db_string;
            
                

        }
    }
}
