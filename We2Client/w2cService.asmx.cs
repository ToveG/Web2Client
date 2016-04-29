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
        public void setUserId(string id)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;

            command.CommandText = "INSERT INTO ClientIdentification (user_id)" + "VALUES(@id_)";
            command.Parameters.AddWithValue("@id_", id);
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
        }



        [WebMethod]
        public bool getValue(string id)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            
            var retur_value = "";
           var appId = id + "&";
            var cmd = new SqlCommand("select user_id from ClientIdentification where user_id = @ID ; ", sqlConnection) { CommandType = CommandType.Text };
            // cmd.Parameters["@ID"].Value = id;
            cmd.Parameters.AddWithValue("@ID", id);

            sqlConnection.Open();
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    retur_value = rdr["user_id"].ToString();
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

