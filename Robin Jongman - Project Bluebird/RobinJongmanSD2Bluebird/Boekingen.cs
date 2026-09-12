using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobinJongmanSD2Bluebird
{
    // Klasse voor boekingenen
    class Boekingen
    {
        public int bookingId;
        public int flightId;
        public int passengerId;
        public int seatId;
        public DateTime date;
        public string status;
        public string flightNumber;
        public int aantal;
        public string seatNumber;
        public string seatClass;

        // Override van ToString() om boekingenen weer te geven
        public override string ToString()
        {
            return $"{flightNumber} – {aantal} boekingen";
        }

        // Methode om vrije stoelen weer te geven
        public string vrijeStoelen()
        {
            return $"{flightNumber} – {seatNumber} ({seatClass})";
        }

        // Methode voor het maken van een boeking
        public static void maakBoeking(int flightId, int passengerId, int seatId)
        {
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"INSERT INTO bookings 
                                        (booking_flight_id, booking_passenger_id, booking_seat_id, booking_date, booking_status)
                                        VALUES
                                        (@flightId, @passengerId, @seatId, NOW(), @status);";
            myCommand.Parameters.AddWithValue("@flightId", flightId);
            myCommand.Parameters.AddWithValue("@passengerId", passengerId);
            myCommand.Parameters.AddWithValue("@seatId", seatId);
            myCommand.Parameters.AddWithValue("@status", "confirmed");

            myCommand.ExecuteNonQuery();
            con.Close();
        }

        // Methode om boekingen per vlucht weer te geven
        public static List<Boekingen> GetBoekingenPerVlucht()
        {
            List<Boekingen> lijst = new List<Boekingen>();
            MySqlConnection con = Database.start();
            con.Open();

            MySqlCommand cmd = new MySqlCommand(@"
        SELECT f.flight_number,
               COUNT(b.booking_id) AS aantal
        FROM flights f
        LEFT JOIN bookings b ON b.booking_flight_id = f.flight_id
        GROUP BY f.flight_id, f.flight_number;", con);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Boekingen bc = new Boekingen();
                bc.flightNumber = Convert.ToString(reader["flight_number"]);
                bc.aantal = Convert.ToInt32(reader["aantal"]);
                lijst.Add(bc);
            }

            con.Close();
            return lijst;
        }

        // Methode om vrije stoelen per vlucht weer te geven
        public static List<Boekingen> GetVrijeStoelenPerVlucht()
        {
            List<Boekingen> lijst = new List<Boekingen>();
            MySqlConnection con = Database.start();
            con.Open();

            MySqlCommand cmd = new MySqlCommand(@"
                    SELECT f.flight_number, s.seat_number, s.seat_class
                        FROM flights f 
                    INNER JOIN aircrafts a ON f.flight_aircraft_id = a.aircraft_id
                    INNER JOIN seats s ON s.seat_aircraft_id = a.aircraft_id
                        WHERE s.seat_id NOT IN (SELECT b.booking_seat_id FROM bookings b WHERE b.booking_status IN ('confirmed', 'pending'))
                    ORDER BY f.flight_number, s.seat_number;", con);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Boekingen stoel = new Boekingen();
                stoel.flightNumber = Convert.ToString(reader["flight_number"]);
                stoel.seatNumber = Convert.ToString(reader["seat_number"]);
                stoel.seatClass = Convert.ToString(reader["seat_class"]);
                lijst.Add(stoel);
            }

            con.Close();
            return lijst;
        }
    }
}
