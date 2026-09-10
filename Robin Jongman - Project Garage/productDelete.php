<?php
include "Classes/database.php";
include "Classes/product.php";

// Haalt de product-ID op uit de URL doormiddel van GET
$id = $_GET["id"];

// Zoekt het product op basis van de ID
$product = Product::findId($id);

// Controleert of het product bestaat
if ($product == null) {
    header("Location: products.php?error=Product+niet+gevonden");
    exit;
}

// Verwijdert het product uit de database
$product->delete();

// Redirect naar products.php en toont een succesbericht als het product succesvol is verwijderd
header("Location: products.php?message=Product+verwijderd");
exit;
?>
