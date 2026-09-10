<?php
class Order
{
    // Eigenschappen van de bestelling.
    public string $id;
    public string $customerId;
    public string $date;
    public string $paid;

    // Haalt alle bestellingen op en retourneert een lijst van de Order-objecten.
    public static function haalAlleBestellingenOp()
    {
        $conn = Database::start();

        $query = "SELECT * FROM orders"; // Haalt alle bestellingen op uit de database.
        $result = $conn->query($query);

        $orders = [];

        // Zet elke rij om in een Order-object.
        if ($result->num_rows > 0) {
            while ($row = $result->fetch_assoc()) {
                $order = new Order();
                $order->id = $row["order_id"];
                $order->customerId = $row["order_customer_id"];
                $order->date = $row["order_date"];
                $order->paid = $row["order_paid"];
                $orders[] = $order;
            }
        }

        $conn->close();
        return $orders;
    }

    // Zoekt een bestelling op basis van de order_id en retourneert een Order-object.
    public static function vindBestellingId($orderId)
    {
        $conn = Database::start();

        $query = "SELECT * FROM orders WHERE order_id = '$orderId'"; // Zoekt een specifieke bestelling op basis van de order_id.
        $result = $conn->query($query);

        // Zet de gevonden rij om in een Order-object.
        if ($result->num_rows > 0) {
            $row = $result->fetch_assoc();
            $order = new Order();
            $order->id = $row["order_id"];
            $order->customerId = $row["order_customer_id"];
            $order->date = $row["order_date"];
            $order->paid = $row["order_paid"];
            return $order;
        }

        $conn->close();
        return null;
    }
}