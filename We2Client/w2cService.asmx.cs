using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace We2Client
{
    /// <summary>
    /// Summary description for w2cService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class w2cService : System.Web.Services.WebService
    {
        private string ConnectionString = "server=WIN-14IEVFR7PQB\\;Database=client2webDB;Trusted_Connection=True;";

        [WebMethod]
        ////Save comment in CommentB;
        public void AddWord(string word)
        {

            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;

            sqlCommand.CommandText = "INSERT INTO  Words (word_value)" + "VALUES(@word_)";

            sqlCommand.Parameters.AddWithValue("@word_", word);
            sqlCommand.Connection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
        }

        [WebMethod]
        public bool getValue()
        {

            SqlConnection sqlConnection = new SqlConnection(ConnectionString);

            var retur_value = "";
            var cmd = new SqlCommand("select word_value from Words where word_value = 'true'; ", sqlConnection) { CommandType = CommandType.Text };
            sqlConnection.Open();
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    retur_value = rdr["word_value"].ToString();
                
               
                }
              
            }
            if (string.IsNullOrEmpty(retur_value))
            {
                return false;
            }
            else { return true; }
        }
    }
}
