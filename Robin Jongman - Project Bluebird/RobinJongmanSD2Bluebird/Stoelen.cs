using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobinJongmanSD2Bluebird
{
    // Klasse voor stoelen
    class Stoelen
    {
        public int seatId;
        public int aircraftId;
        public string seatNumber;
        public string seatClass;
        public int window;
        public int aisle;

        // Override van ToString() om stoelen weer te geven
        public override string ToString()
        {
            return $"{seatId} {seatNumber}";
        }

        // Methode om beschikbare stoelen per vlucht weer te geven
        public static List<Stoelen> GetAvailableSeatsByFlight_SQL(int flightId)
        {
            List<Stoelen> vrijeStoelen = new List<Stoelen>();
            MySqlConnection con = Database.start();
            con.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = @"
                SELECT s.seat_id, s.seat_number
                FROM aircrafts a
                INNER JOIN seats s ON s.seat_aircraft_id = a.aircraft_id
                INNER JOIN flights f ON a.aircraft_id = f.flight_aircraft_id
                WHERE f.flight_id = @flightId
                    AND s.seat_id NOT IN (
                        SELECT b.booking_seat_id 
                        FROM bookings b
                        WHERE b.booking_flight_id = @flightId
                            AND b.booking_status IN ('pending', 'confirmed')
                            )";

            cmd.Parameters.AddWithValue("@flightId", flightId);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Stoelen seat = new Stoelen();
                seat.seatId = Convert.ToInt32(reader["seat_id"]);
                seat.seatNumber = Convert.ToString(reader["seat_number"]);
                vrijeStoelen.Add(seat);
            }

            con.Close();
            return vrijeStoelen;
        }

    }
}
