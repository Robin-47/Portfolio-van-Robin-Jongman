<?php
include "Classes/database.php";
include "Classes/product.php";

$id = $_GET["id"]; // Haalt de product ID op uit de URL

// Zoekt het product op basis van de ID
$product = Product::findId($id);

// Controleert of het product bestaat
if (!$product) {
    header("location: products.php?error=Product niet gevonden");
    exit;
}

// Updatet het product wanneer het formulier is verzonden
if (isset($_POST["productNaam"])) {

    $product->name = $_POST["productNaam"];
    $product->category = $_POST["productCategory"];
    $product->price = $_POST["productPrijs"];
    $product->instock = $_POST["productVoorraad"];

    $product->update(); // Werkt product bij in de database

    // Redirect naar products.php met een succesbericht om te bevestigen dat het product is bijgewerkt
    header("Location: products.php?message=Product is bijgewerkt");
    exit();
}
?>

<!doctype html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Product bewerken</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.6/dist/css/bootstrap.min.css" rel="stylesheet">
    <link href="css/style.css" rel="stylesheet">
</head>

<body>
    <div class="center-form-container">
        <div class="center-form-box">
            <form method="post" class="text-start">
                <div class="mb-3">
                    <label for="productNaam" class="form-label">Naam</label>
                    <input type="text" class="form-control" id="productNaam" name="productNaam" placeholder="Naam" value="<?= $product->name ?>" required>
                </div>
                <div class="mb-3">
                    <label for="productCategory" class="form-label">Category</label>
                    <input type="text" class="form-control" id="productCategory" name="productCategory" placeholder="Category" value="<?= $product->category ?>" required>
                </div>
                <div class="mb-3">
                    <label for="productPrijs" class="form-label">Prijs</label>
                    <input type="text" class="form-control" id="productPrijs" name="productPrijs" placeholder="Prijs" value="<?= $product->price ?>" required>
                </div>
                <div class="mb-3">
                    <label for="productVoorraad" class="form-label">Voorraad</label>
                    <input type="text" class="form-control" id="productVoorraad" name="productVoorraad" placeholder="Voorraad" value="<?= $product->instock ?>" required>
                </div>
                <input id="knopSend" type="submit" class="btn btn-dark w-100" value="Verzenden">
            </form>
        </div>
    </div>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.6/dist/js/bootstrap.bundle.min.js"></script>
</body>

</html>