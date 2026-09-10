<?php
class Orderline
{
    // Eigenschappen van de orderregel.
    public string $id;
    public string $orderId;
    public string $productId;
    public string $quantity;

    // Haalt alle orderregels van een order op en retourneert een lijst van Orderline-objecten.
    public static function findOrderId($orderId)
    {
        $conn = Database::start();

        $query = "SELECT * FROM order_lines WHERE order_line_order_id = '$orderId'"; // SQL-query om orderregels op te halen voor een specifieke bestelling.
        $result = $conn->query($query);

        $orderlines = [];

        // Zet elke rij om in een Orderline-object.
        if ($result->num_rows > 0) {
            while ($row = $result->fetch_assoc()) {
                $orderline = new Orderline();
                $orderline->id = $row["order_line_id"];
                $orderline->orderId = $row["order_line_order_id"];
                $orderline->productId = $row["order_line_product_id"];
                $orderline->quantity = $row["order_line_quantity"];
                $orderlines[] = $orderline;
            }
        }

        $conn->close();
        return $orderlines;
    }
}