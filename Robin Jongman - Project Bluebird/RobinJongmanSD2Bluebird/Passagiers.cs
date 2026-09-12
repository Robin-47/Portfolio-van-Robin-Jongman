using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobinJongmanSD2Bluebird
{
    // Klasse voor passagiers
    class Passagiers
    {
        public int id;
        public string firstname;
        public string lastname;
        public string address;
        public string zipCode;
        public string city;
        public string email;
        public string passportNumber;

        // Override van ToString() om passagiers weer te geven
        public override string ToString()
        {
            return $"{firstname} {lastname} {address} {zipCode} {city}";
        }
        public string PassengerDisplay => $"{id} {firstname} {lastname}";

        // Methode om passagiers op te halen uit de database
        public static List<Passagiers> GetPassagiers()
        {
            List<Passagiers> passengersList = new List<Passagiers>();
            MySqlConnection con = Database.start();
            con.Open();

            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"SELECT * FROM passengers;";

            MySqlDataReader reader = myCommand.ExecuteReader();

            while (reader.Read())
            {
                Passagiers passengersObj = new Passagiers();
                passengersObj.id = Convert.ToInt32((reader["passenger_id"]));
                passengersObj.firstname = Convert.ToString((reader["passenger_firstname"]));
                passengersObj.lastname = Convert.ToString((reader["passenger_lastname"]));
                passengersObj.address = Convert.ToString((reader["passenger_address"]));
                passengersObj.zipCode = Convert.ToString((reader["passenger_zipcode"]));
                passengersObj.city = Convert.ToString((reader["passenger_city"]));
                passengersObj.email = Convert.ToString((reader["passenger_email"]));
                passengersObj.passportNumber = Convert.ToString((reader["passenger_passportnumber"]));
                passengersList.Add(passengersObj);
            }

            con.Close();
            return passengersList;
        }

        // Methode om een passagier te verwijderen uit de database
        public void Verwijderen()
        {
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"DELETE FROM passengers WHERE passenger_id = @id;";
            myCommand.Parameters.AddWithValue("@id", this.id);
            myCommand.ExecuteNonQuery();
            myCommand.Dispose();
            con.Close();
        }

        // Methode om een passagier te wijzigen in de database
        public void Wijzigen()
        {
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"UPDATE passengers
                              SET passenger_firstname = @firstname,
                                  passenger_lastname = @lastname,
                                  passenger_address = @address,
                                  passenger_zipcode = @zipcode,
                                  passenger_city = @city,
                                  passenger_email = @email,
                                  passenger_passportnumber = @passport
                              WHERE passenger_id = @id;";
            myCommand.Parameters.AddWithValue("@firstname", this.firstname);
            myCommand.Parameters.AddWithValue("@lastname", this.lastname);
            myCommand.Parameters.AddWithValue("@address", this.address);
            myCommand.Parameters.AddWithValue("@zipcode", this.zipCode);
            myCommand.Parameters.AddWithValue("@city", this.city);
            myCommand.Parameters.AddWithValue("@email", this.email);
            myCommand.Parameters.AddWithValue("@passport", this.passportNumber);
            myCommand.Parameters.AddWithValue("@id", this.id);

            myCommand.ExecuteNonQuery();
            myCommand.Dispose();
            con.Close();
        }

        // Methode om een passagier toe te voegen aan de database
        public void toevoegen()
        {
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();

            myCommand.Connection = con;
            myCommand.CommandText = @"INSERT INTO passengers 
                              (passenger_firstname, passenger_lastname, passenger_address, passenger_zipcode, passenger_city, passenger_email, passenger_passportnumber)
                              VALUES (@firstname, @lastname, @address, @zipcode, @city, @email, @passport);";

            myCommand.Parameters.AddWithValue("@firstname", this.firstname);
            myCommand.Parameters.AddWithValue("@lastname", this.lastname);
            myCommand.Parameters.AddWithValue("@address", this.address);
            myCommand.Parameters.AddWithValue("@zipcode", this.zipCode);
            myCommand.Parameters.AddWithValue("@city", this.city);
            myCommand.Parameters.AddWithValue("@email", this.email);
            myCommand.Parameters.AddWithValue("@passport", this.passportNumber);

            myCommand.ExecuteNonQuery();
            myCommand.Dispose();
            con.Close();
        }
    }
}
