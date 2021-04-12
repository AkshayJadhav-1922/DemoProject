using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            lblLabel.Text = "User " + cfMessage.Name + " Says " + cfMessage.Message;

            //added code to store name and message to our local db table Message
            var connectionString = ConfigurationManager.ConnectionStrings["messageDB"].ConnectionString;
            var InsertStatement = "INSERT into Message (Name, Message) values (@Name, @Message)";
            using(var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (var sqlCommand = new SqlCommand(InsertStatement, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("Name", cfMessage.Name);
                    sqlCommand.Parameters.AddWithValue("Message", cfMessage.Message);
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}