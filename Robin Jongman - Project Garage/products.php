<?php
include "Classes/database.php";
include "Classes/product.php";

$producten = Product::findAll(); // Haalt alle producten op uit de database en slaat deze op in een array
?>
<!doctype html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Producten Overzicht</title>
    <link rel="icon" type="CSS/x-icon" href="CSS/product.png">
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
                                <a class="nav-link" id="active" href="products.php">Producten</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="orders.php">Bestellingen</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
        </div>
        <div class="row mt-4">
            <div class="col text-center">
                <?php if (isset($_GET["message"])): ?>
                    <strong><?= htmlspecialchars($_GET["message"]) ?></strong>
                <?php endif; ?>

                <?php if (isset($_GET["error"])): ?>
                    <strong><?= htmlspecialchars($_GET["error"]) ?></strong>
                <?php endif; ?>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <table id="tabel" border="1" class="table table-striped">
                    <thead>
                        <tr>
                            <th>Naam product</th>
                            <th>Categorie</th>
                            <th>Prijs</th>
                            <th>Stock</th>
                            <th>
                                Acties
                                <a href="productAdd.php" class="btn btn-dark btn-sm ms-2" id="knop">Toevoegen</a>
                            </th>
                        </tr>
                    </thead>
                    <tbody>
                        <!-- Loopt door alle producten en toont hun gegevens in de tabel -->
                        <?php foreach ($producten as $product): ?>
                            <tr>
                                <td><?= $product->name ?></td>
                                <td><?= $product->category ?></td>
                                <td><?= $product->price ?></td>
                                <td><?= $product->instock ?></td>
                                <td>
                                    <!-- Links naar de bewerk- en verwijderpagina's voor elk product -->
                                    <a href="productEdit.php?id=<?= $product->id; ?>" class="btn btn-dark btn-sm" id="knop">Aanpassen</a>
                                    <a href="productDelete.php?id=<?= $product->id; ?>" class="btn btn-dark btn-sm" id="knop"
                                        onclick="return confirm('Weet je zeker dat je dit product wilt verwijderen?')">Verwijderen</a>
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