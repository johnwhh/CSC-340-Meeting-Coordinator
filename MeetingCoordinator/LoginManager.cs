using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace MeetingCoordinator
{
    public class LoginManager
    {
        private const string connStr = "";
        public User GetUser(string username)
        {
            User user = null;
            DataTable table = new DataTable();
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                string statement = "SELECT * FROM ajjusers WHERE username=@username LIMIT 1;";
                MySqlCommand cmd = new MySqlCommand(statement, conn);
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(table);
                myAdapter.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            foreach (DataRow row in table.Rows)
            {
                string fullName = row["fullName"].ToString();
                User.Rank rank = (User.Rank)(int)row["rank"];
                user = new User(fullName, username, rank);
            }
            table.Dispose();
            return user;
        }
    }
}
