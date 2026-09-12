using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobinJongmanSD2Bluebird
{
    // Klasse voor gebruikers
    public class Users
    {
        public int Id;
        public string Firstname;
        public string Lastname;
        public string Email;
        public string Username;
        public string Password;

        // Override van ToString() om gebruikersinformatie weer te geven in de lijst
        public override string ToString()
        {
            return $"{this.Id} {this.Firstname} {this.Lastname} {this.Email}";
        }

        // Methode om een gebruiker te authenticeren en in te loggen
        public static Users getLoginGebruiker(string username, string password)
        {
            Users userobject = null;
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"SELECT * FROM users WHERE user_username = @username;";
            myCommand.Parameters.AddWithValue("@username", username);
            MySqlDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    string bestaandWachtwoord = Convert.ToString((reader["user_password"]));
                    bool isMatch = BCrypt.Net.BCrypt.EnhancedVerify(password, bestaandWachtwoord);

                    if (isMatch)
                    {

                        userobject = new Users();
                        userobject.Id = Convert.ToInt32(reader["user_id"]);
                        userobject.Firstname = Convert.ToString(reader["user_firstname"]);
                        userobject.Lastname = Convert.ToString(reader["user_lastname"]);
                        userobject.Email = Convert.ToString(reader["user_email"]);
                        userobject.Username = Convert.ToString(reader["user_username"]);
                        userobject.Password = Convert.ToString(reader["user_password"]);
                    }
                }

            }
            con.Close();
            return userobject;
        }

        // Methode om alle gebruikers op te halen uit de database
        public static List<Users> GetUsers()
        {
            List<Users> userList = new List<Users>();
            MySqlConnection con = Database.start();
            con.Open();

            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"SELECT * FROM users;";

            MySqlDataReader reader = myCommand.ExecuteReader();

            while (reader.Read())
            {
                Users userObj = new Users();
                userObj.Id = Convert.ToInt32((reader["user_id"]));
                userObj.Firstname = Convert.ToString((reader["user_firstname"]));
                userObj.Lastname = Convert.ToString((reader["user_lastname"]));
                userObj.Email = Convert.ToString((reader["user_email"]));
                userObj.Username = Convert.ToString((reader["user_username"]));
                userObj.Password = Convert.ToString((reader["user_password"]));
                userList.Add(userObj);

            }
            con.Close();
            return userList;
        }

        // Methode om een gebruiker te wijzigen, inclusief de optie om het wachtwoord te wijzigen
        public void Wijzigen(string plainPassword = null)
        {
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;

            if (!string.IsNullOrEmpty(plainPassword))
            {
                string hashed = BCrypt.Net.BCrypt.EnhancedHashPassword(plainPassword);

                myCommand.CommandText = @"UPDATE users 
                                      SET user_firstname=@firstname, 
                                          user_lastname=@lastname, 
                                          user_email=@email,
                                          user_username=@username,
                                          user_password=@password
                                      WHERE user_id=@id;";
                myCommand.Parameters.AddWithValue("@id", this.Id);
                myCommand.Parameters.AddWithValue("@firstname", this.Firstname);
                myCommand.Parameters.AddWithValue("@lastname", this.Lastname);
                myCommand.Parameters.AddWithValue("@email", this.Email);
                myCommand.Parameters.AddWithValue("@username", this.Username);
                myCommand.Parameters.AddWithValue("@password", hashed);
            }
            else
            {
                myCommand.CommandText = @"UPDATE users 
                            SET user_firstname=@firstname, 
                                user_lastname=@lastname, 
                                user_email=@email,
                                user_username=@username
                            WHERE user_id=@id;";

                myCommand.Parameters.AddWithValue("@id", this.Id);
                myCommand.Parameters.AddWithValue("@firstname", this.Firstname);
                myCommand.Parameters.AddWithValue("@lastname", this.Lastname);
                myCommand.Parameters.AddWithValue("@email", this.Email);
                myCommand.Parameters.AddWithValue("@username", this.Username);
            }

            myCommand.ExecuteNonQuery();
            myCommand.Dispose();
            con.Close();
        }

        // Methode om een gebruiker te verwijderen uit de database
        public void Verwijder()
        {
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"DELETE FROM users WHERE user_id = @id;";
            myCommand.Parameters.AddWithValue("@id", this.Id);
            myCommand.ExecuteNonQuery();
            myCommand.Dispose();
            con.Close();
        }

        // Methode om een nieuwe gebruiker toe te voegen aan de database
        public void Toevoegen(string plainPassword)
        {
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            string hashed = BCrypt.Net.BCrypt.EnhancedHashPassword(plainPassword);

            myCommand.CommandText = @"INSERT INTO users 
                              (user_firstname, user_lastname, user_email, user_username, user_password, user_admin)
                              VALUES (@firstname, @lastname, @email, @username, @password, @admin);";


            myCommand.Parameters.AddWithValue("@firstname", this.Firstname);
            myCommand.Parameters.AddWithValue("@lastname", this.Lastname);
            myCommand.Parameters.AddWithValue("@email", this.Email);
            myCommand.Parameters.AddWithValue("@username", this.Username);
            myCommand.Parameters.AddWithValue("@password", hashed);
            myCommand.Parameters.AddWithValue("@admin", 0);

            myCommand.ExecuteNonQuery();
            myCommand.Dispose();
            con.Close();
        }
    }
}
