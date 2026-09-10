<?php
include "Classes/database.php";
include "Classes/order.php";

// Haalt alle bestellingen op uit de database en slaat deze op in een array
$orders = Order::haalAlleBestellingenOp();
?>

<!doctype html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Bestellingen Overzicht</title>
    <link rel="icon" type="CSS/x-icon" href="CSS/order.png">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.10.5/font/bootstrap-icons.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.6/dist/css/bootstrap.min.css" rel="stylesheet">
    <link href="css/style.css" rel="stylesheet">
</head>

<body>
    <div class="container-fluid">
        <div class="row" id="titel">
            <div class="col text-center">
                <h1><strong>Administratie</strong></h1>
            </div>
        </div>
        <div class="row">
            <nav class="navbar navbar-expand-lg" id="kleurNav">
                <div class="container-fluid">
                    <div class="collapse navbar-collapse" id="navbarNav">
                        <ul class="navbar-nav mx-auto">
                            <li class="nav-item">
                                <a class="nav-link" href="home.php">Home</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="index.php">Klanten</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="products.php">Producten</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" id="active" href="orders.php">Bestellingen</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
        </div>
        <div class="row mt-4"></div>
        <div class="row">
            <div class="col">
                <table id="tabel" border="1" class="table table-striped">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Klant ID</th>
                            <th>Datum</th>
                            <th>Betaald</th>
                            <th>Factuur</th>
                        </tr>
                    </thead>
                    <tbody>
                        <?php foreach ($orders as $order): ?>
                            <tr>
                                <!-- Toont de gegevens van de bestelling -->
                                <td><?= $order->id ?></td>
                                <td><?= $order->customerId ?></td>
                                <td><?= $order->date ?></td>
                                <td><?= $order->paid == 1 ? "Ja" : "Nee" ?></td>
                                <td>
                                    <a href="invoice.php?id=<?= $order->id; ?>">
                                        <i class="bi bi-file-earmark-text"></i>
                                    </a>
                                </td>
                            </tr>
                        <?php endforeach; ?>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.6/dist/js/bootstrap.bundle.min.js"></script>
</body>

</html>