
using System;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public class MyLibrary
    {
        private string connectionString;

        public MyLibrary(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool ConnectToDatabase()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine("Message: " + message);
        }
    }
}
