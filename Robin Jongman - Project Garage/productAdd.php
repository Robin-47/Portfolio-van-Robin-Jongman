<?php
include "Classes/database.php";

// Controleert of de product naam is verzonden via het formulier
if (isset($_POST["productNaam"])) {

    include "Classes/product.php";

    // Maakt een nieuw Product object aan
    $product = new Product();

    // Vult de eigenschappen van het product met data uit het formulier
    $product->name = $_POST["productNaam"];
    $product->category = $_POST["productCategory"];
    $product->price = $_POST["productPrijs"];
    $product->instock = $_POST["productVoorraad"];

    // Voegt het product toe aan de database
    $product->insert();

    // Redirect naar products.php met een succesbericht om te bevestigen dat het product is toegevoegd
    header("Location: products.php?message=Product is toegevoegd");
    exit();
}
?>

<!doctype html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Product toevoegen</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.6/dist/css/bootstrap.min.css" rel="stylesheet">
    <link href="css/style.css" rel="stylesheet">
</head>

<body>
    <div class="center-form-container">
        <div class="center-form-box">
            <form method="post" class="text-start">
                <div class="mb-3">
                    <label for="productNaam" class="form-label">Naam</label>
                    <input type="text" class="form-control" id="productNaam" name="productNaam" placeholder="Naam" required>
                </div>
                <div class="mb-3">
                    <label for="productCategory" class="form-label">Category</label>
                    <input type="text" class="form-control" id="productCategory" name="productCategory" placeholder="Category" required>
                </div>
                <div class="mb-3">
                    <label for="productPrijs" class="form-label">Prijs</label>
                    <input type="text" class="form-control" id="productPrijs" name="productPrijs" placeholder="Prijs" required>
                </div>
                <div class="mb-3">
                    <label for="productVoorraad" class="form-label">Voorraad</label>
                    <input type="text" class="form-control" id="productVoorraad" name="productVoorraad" placeholder="Voorraad" required>
                </div>
                <input id="knopSend" type="submit" class="btn btn-dark w-100" value="Verzenden">
            </form>
        </div>
    </div>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.6/dist/js/bootstrap.bundle.min.js"></script>
</body>

</html>