<?php
// Zorgt ervoor dat de benodigde klassen worden geladen
include "Classes/database.php";
include "Classes/customer.php";

// Haalt alle klanten op uit de database en slaat deze op in een array
$klanten = Customer::haalAlleKlantenOp();
?>

<!doctype html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Klanten Overzicht</title>
    <link rel="icon" type="CSS/x-icon" href="CSS/mens.png">
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
                                <a class="nav-link" id="active" href="index.php">Klanten</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="products.php">Producten</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="orders.php">Bestellingen</a>
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
                            <th>Voornaam</th>
                            <th>Achternaam</th>
                            <th>Adres</th>
                            <th>Postcode</th>
                            <th>Woonplaats</th>
                            <th>E-mail</th>
                        </tr>
                    </thead>
                    <tbody>
                        <?php foreach ($klanten as $klant): ?> <!-- Loopt door alle klanten en toont hun gegevens in de tabel -->
                            <tr>
                                <td><?= $klant->firstname ?></td>
                                <td><?= $klant->lastname ?></td>
                                <td><?= $klant->address ?></td>
                                <td><?= $klant->zipcode ?></td>
                                <td><?= $klant->city ?></td>
                                <td><?= $klant->email ?></td>
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