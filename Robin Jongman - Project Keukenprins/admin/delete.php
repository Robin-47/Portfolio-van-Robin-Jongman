<?php
include_once "../classes/database.php";
include_once "../classes/blog.php";

$id = $_GET["id"]; // Haalt id uit de URL

$blog = Blog::findId($id); // Zoekt blog op id

if ($blog == null) {
    header("Location: admin.php?error=blog+niet+gevonden"); // Foutmelding als blog niet wordt gevonden
    exit;
}

$blog->delete(); // Verwijder de blog

header("Location: admin.php?msg=verwijderd"); // Stuurt gebruiker terug naar admin.php na het verwijderen van de blog
exit;
?>
