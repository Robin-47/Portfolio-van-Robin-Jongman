using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobinJongmanSD2Bluebird
{

    // Klasse voor vluchten
    public class Vluchten
    {
        public int id;
        public string flightNumber;
        public string orgin;
        public string desitnation;
        public DateTime departure;
        public DateTime arrival;
        public int aircraftId;

        
        public string passengerFirstname { get; set; }
        public string passengerLastname { get; set; }
        public string passengerCity { get; set; }
        public string passengerEmail { get; set; }
        public DateTime bookingDate { get; set; }
        public string bookingStatus { get; set; }
        public string seatNumber { get; set; }
        public string seatClass { get; set; }
        public bool seatIsWindow { get; set; }
        public bool seatIsAisle { get; set; }

        // Override van ToString() om vluchtinformatie weer te geven in de lijst
        public override string ToString()
        {
            return $"{id} {flightNumber} {orgin} {aircraftId}";
        }

        // Methode om vluchten op te halen uit de database
        public static List<Vluchten> GetFlights()
        {
            List<Vluchten> flightList = new List<Vluchten>();
            MySqlConnection con = Database.start();
            con.Open();

            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"SELECT * FROM flights;";

            MySqlDataReader reader = myCommand.ExecuteReader();

            while (reader.Read())
            {
                Vluchten flightObj = new Vluchten();
                flightObj.id = Convert.ToInt32((reader["flight_id"]));
                flightObj.flightNumber = Convert.ToString((reader["flight_number"]));
                flightObj.orgin = Convert.ToString((reader["flight_origin"]));
                flightObj.desitnation = Convert.ToString((reader["flight_destination"]));
                flightObj.departure = Convert.ToDateTime((reader["flight_departure_time"]));
                flightObj.arrival = Convert.ToDateTime((reader["flight_arrival_time"]));
                flightObj.aircraftId = Convert.ToInt32((reader["flight_aircraft_id"]));
                flightList.Add(flightObj);
            }

            con.Close();
            return flightList;
        }

        // Methode om boekingsoverzicht op te halen uit de database
        public static List<Vluchten> getBookingOverview()
        {
            List<Vluchten> bookingList = new List<Vluchten>();
            MySqlConnection con = Database.start();
            con.Open();

            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"
                SELECT 
                    p.passenger_firstname,
                    p.passenger_lastname,
                    p.passenger_city,
                    p.passenger_email,
                    b.booking_date,
                    b.booking_status,
                    s.seat_number,
                    s.seat_class,
                    s.seat_is_window,
                    s.seat_is_aisle
                FROM bookings b
                LEFT JOIN passengers p ON b.booking_passenger_id = p.passenger_id
                LEFT JOIN seats s ON b.booking_seat_id = s.seat_id;";

            MySqlDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                Vluchten f = new Vluchten();
                f.passengerFirstname = reader["passenger_firstname"].ToString();
                f.passengerLastname = reader["passenger_lastname"].ToString();
                f.passengerCity = reader["passenger_city"].ToString();
                f.passengerEmail = reader["passenger_email"].ToString();
                f.bookingDate = Convert.ToDateTime(reader["booking_date"]);
                f.bookingStatus = reader["booking_status"].ToString();
                f.seatNumber = reader["seat_number"].ToString();
                f.seatClass = reader["seat_class"].ToString();
                f.seatIsWindow = Convert.ToBoolean(reader["seat_is_window"]);
                f.seatIsAisle = Convert.ToBoolean(reader["seat_is_aisle"]);

                bookingList.Add(f);
            }

            con.Close();
            return bookingList;
        }

        // Methode om de boekingsstatussen op te halen uit de database
        public static List<Vluchten> GetStatus()
        {
            List<Vluchten> statList = new List<Vluchten>();
            MySqlConnection con = Database.start();
            con.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT DISTINCT(booking_status) FROM bookings";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Vluchten statObj = new Vluchten();
                statObj.bookingStatus = Convert.ToString(reader["booking_status"]);
                statList.Add(statObj);
            }

            con.Close();
            return statList;
        }

        // Methode om boekingen te zoeken op basis van de status
        public static List<Vluchten> zoekStatus(string Naam)
        {
            List<Vluchten> statList = new List<Vluchten>();
            MySqlConnection conn = Database.start();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            string sqlSelectAll = @"
                SELECT 
                    p.passenger_firstname,
                    p.passenger_lastname,
                    p.passenger_city,
                    p.passenger_email,
                    b.booking_date,
                    b.booking_status,
                    s.seat_number,
                    s.seat_class,
                    s.seat_is_window,
                    s.seat_is_aisle
                FROM bookings b
                LEFT JOIN passengers p ON b.booking_passenger_id = p.passenger_id
                LEFT JOIN seats s ON b.booking_seat_id = s.seat_id
                WHERE b.booking_status LIKE @zoekNaam;";

            cmd.CommandText = sqlSelectAll;
            cmd.Parameters.AddWithValue("@zoekNaam", "%" + Naam + "%");
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Vluchten f = new Vluchten();
                f.passengerFirstname = reader["passenger_firstname"].ToString();
                f.passengerLastname = reader["passenger_lastname"].ToString();
                f.passengerCity = reader["passenger_city"].ToString();
                f.passengerEmail = reader["passenger_email"].ToString();
                f.bookingDate = Convert.ToDateTime(reader["booking_date"]);
                f.bookingStatus = reader["booking_status"].ToString();
                f.seatNumber = reader["seat_number"].ToString();
                f.seatClass = reader["seat_class"].ToString();
                f.seatIsWindow = Convert.ToBoolean(reader["seat_is_window"]);
                f.seatIsAisle = Convert.ToBoolean(reader["seat_is_aisle"]);

                statList.Add(f);
            }

            conn.Close();
            return statList;
        }

        // Methode om boekingsdatums op te halen uit de database
        public static List<Vluchten> GetDatum()
        {
            List<Vluchten> dateList = new List<Vluchten>();
            MySqlConnection con = Database.start();
            con.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT DISTINCT(DATE(booking_date)) AS booking_date FROM bookings";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Vluchten dateObj = new Vluchten();
                dateObj.bookingDate = Convert.ToDateTime(reader["booking_date"]);
                dateList.Add(dateObj);
            }

            con.Close();
            return dateList;
        }

        // Methode om boekingen te zoeken op basis van de datum
        public static List<Vluchten> zoekDate(DateTime datum)
        {
            List<Vluchten> dateList = new List<Vluchten>();
            MySqlConnection conn = Database.start();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            string sqlSelectAll = @"
                SELECT 
                    p.passenger_firstname,
                    p.passenger_lastname,
                    p.passenger_city,
                    p.passenger_email,
                    b.booking_date,
                    b.booking_status,
                    s.seat_number,
                    s.seat_class,
                    s.seat_is_window,
                    s.seat_is_aisle
                FROM bookings b
                LEFT JOIN passengers p ON b.booking_passenger_id = p.passenger_id
                LEFT JOIN seats s ON b.booking_seat_id = s.seat_id
                WHERE DATE(b.booking_date) = @datum;";

            cmd.CommandText = sqlSelectAll;
            cmd.Parameters.AddWithValue("@datum", datum.Date);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Vluchten f = new Vluchten();
                f.passengerFirstname = reader["passenger_firstname"].ToString();
                f.passengerLastname = reader["passenger_lastname"].ToString();
                f.passengerCity = reader["passenger_city"].ToString();
                f.passengerEmail = reader["passenger_email"].ToString();
                f.bookingDate = Convert.ToDateTime(reader["booking_date"]);
                f.bookingStatus = reader["booking_status"].ToString();
                f.seatNumber = reader["seat_number"].ToString();
                f.seatClass = reader["seat_class"].ToString();
                f.seatIsWindow = Convert.ToBoolean(reader["seat_is_window"]);
                f.seatIsAisle = Convert.ToBoolean(reader["seat_is_aisle"]);

                dateList.Add(f);
            }

            conn.Close();
            return dateList;
        }

        // Methode om boekingen te zoeken op basis van zowel status als datum
        public static List<Vluchten> zoekStatusEnDatum(string status, DateTime datum)
        {
            List<Vluchten> list = new List<Vluchten>();
            MySqlConnection conn = Database.start();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = @"
                SELECT 
                    p.passenger_firstname,
                    p.passenger_lastname,
                    p.passenger_city,
                    p.passenger_email,
                    b.booking_date,
                    b.booking_status,
                    s.seat_number,
                    s.seat_class,
                    s.seat_is_window,
                    s.seat_is_aisle
                FROM bookings b
                LEFT JOIN passengers p ON b.booking_passenger_id = p.passenger_id
                LEFT JOIN seats s ON b.booking_seat_id = s.seat_id
                WHERE b.booking_status = @status
                AND DATE(b.booking_date) = @datum;
            ";

            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@datum", datum.Date);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Vluchten f = new Vluchten();
                f.passengerFirstname = reader["passenger_firstname"].ToString();
                f.passengerLastname = reader["passenger_lastname"].ToString();
                f.passengerCity = reader["passenger_city"].ToString();
                f.passengerEmail = reader["passenger_email"].ToString();
                f.bookingDate = Convert.ToDateTime(reader["booking_date"]);
                f.bookingStatus = reader["booking_status"].ToString();
                f.seatNumber = reader["seat_number"].ToString();
                f.seatClass = reader["seat_class"].ToString();
                f.seatIsWindow = Convert.ToBoolean(reader["seat_is_window"]);
                f.seatIsAisle = Convert.ToBoolean(reader["seat_is_aisle"]);

                list.Add(f);
            }
            conn.Close();
            return list;
        }
    }
}
