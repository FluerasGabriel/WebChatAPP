using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Testing123.Controllers
{
    public class MySQL
    {
        private string account = "server=localhost; username=root; password=; database=netflix";
        public void Execute(string query)
        {
            MySqlConnection con = new MySqlConnection(account);
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            
          
        }
       
    }
}
 

    
