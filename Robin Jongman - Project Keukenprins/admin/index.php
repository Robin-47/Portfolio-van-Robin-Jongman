<?php
include "../classes/gebruiker.php";
include "../classes/sessie.php";
include "../classes/database.php";

$error = "";

// Checkt ingevulde gegevens van de gebruiker
if (isset($_POST['username'])) {
    $username = $_POST['username'];
    $password = $_POST['password'];

    // Probeert gebruiker te vinden op basis van ingevoerde gegevens
    $gebruiker = Gebruiker::vindGebruiker($username, $password);

    if ($gebruiker) {
        // Unieke sessiesleutel aanmaken
        $key = md5(uniqid(rand(), true));

        // Nieuwe sessie aanmaken
        $sessie = new Sessie();
        $sessie->sessionUserId = $gebruiker->userId;
        $sessie->sessionKey = $key;
        $sessie->sessionStart = date("Y-m-d H:i:s");
        $sessie->sessionEnd = date("Y-m-d H:i:s", strtotime("+1 month"));
        $sessie->insert();

        // Cookie voor sessie instellen met geldigheid van 1 maand
        setcookie("keukenprins-session", $key, strtotime("+1 month"), "/");

        header("location: admin.php"); // Stuurt ingelogde gebruiker naar admin.php
        exit();
    } else
        // Foutmelding bij onjuiste inloggegevens
        $error = "Probeer Opnieuw of Betaal op onze Website voor Toegang.";
}
?>

<!DOCTYPE html>
<html lang="nl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login</title>
    <link rel="stylesheet" href="jquery-te-1.4.0.min.js">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <link rel="stylesheet" href="../css/admin.css">
</head>
<body id="body" class="d-flex justify-content-center align-items-center vh-100" > <!-- Centreert de inhoud van de pagina zowel horizontaal als verticaal, zodat de card in het midden komt te staan en geeft de achtergrond een lichtgrijze kleur -->
<div class="container">
    <div class="card login-card shadow">
        <div class="card-body">
            <?php
            echo '<h2 class="text-center">Login®</h2>';

            // Toont een foutmelding als de gegevens niet kloppen
            if ($error != null) {
                echo '<div class="alert alert-danger text-center">' . $error . '</div>';
            }
            ?>
            <form action="index.php" method="post">
                <div class="form-group">
                    <label for="username">Naam</label>
                    <input type="text" class="form-control" id="username" name="username" required>
                </div>
                <div class="form-group">
                    <label for="password">Wachtwoord</label>
                    <input type="password" class="form-control" id="password" name="password" required>
                </div>
                <button type="submit" class="btn btn-dark btn-block">Start</button>
            </form>
        </div>
    </div>
</body>
</html>
