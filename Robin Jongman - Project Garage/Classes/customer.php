<?php
class Customer
{
    // Eigenschappen van de klant.
    public string $id;
    public string $firstname;
    public string $lastname;
    public string $address;
    public string $zipcode;
    public string $city;
    public string $email;

    // Haalt alle klanten op uit de database en retourneert een lijst van de Customer-objecten.
    public static function haalAlleKlantenOp()
    {
        $conn = Database::start();

        $query = "SELECT * FROM customers";
        $result = $conn->query($query);

        $klanten = [];

        // Zet elke rij om in een Customer-object.
        if ($result->num_rows > 0) {
            while ($row = $result->fetch_assoc()) {
                $klant = new Customer();
                $klant->id = $row["customer_id"];
                $klant->firstname = $row["customer_firstname"];
                $klant->lastname = $row["customer_lastname"];
                $klant->address = $row["customer_address"];
                $klant->zipcode = $row["customer_zipcode"];
                $klant->city = $row["customer_city"];
                $klant->email = $row["customer_email"];
                $klanten[] = $klant;
            }
        }

        $conn->close();
        return $klanten;
    }

    // Zoekt een klant op basis van de id en retourneert een Customer-object.
    public static function vindKlantId($klantId)
    {
        $conn = Database::start();

        $query = "SELECT * FROM customers WHERE customer_id = '$klantId'";
        $result = $conn->query($query);

        // Controleert of er resultaten zijn en zet de eerste rij om in een Customer-object.
        if ($result->num_rows > 0) {
            $row = $result->fetch_assoc();
            $klant = new Customer();
            $klant->id = $row["customer_id"];
            $klant->firstname = $row["customer_firstname"];
            $klant->lastname = $row["customer_lastname"];
            $klant->address = $row["customer_address"];
            $klant->zipcode = $row["customer_zipcode"];
            $klant->city = $row["customer_city"];
            $klant->email = $row["customer_email"];
            return $klant;
        }

        $conn->close();
        return null;
    }
}