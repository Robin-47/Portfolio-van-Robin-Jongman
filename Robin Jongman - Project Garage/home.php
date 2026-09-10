<!doctype html>
<html lang="nl">

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Home</title>
    <link rel="icon" type="CSS/x-icon" href="CSS/home.png">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.6/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-4Q6Gf2aSP4eDXB8Miphtr37CMZZQ5oXLH2yaXMJ2w8e2ZtHTl7GptT4jmndRuHDT" crossorigin="anonymous">
    <link href="css/style.css" rel="stylesheet">
</head>

<body>
    <div class="container-fluid">
        <div class="row" id="titel">
            <div class="col text-center">
                <h1><strong>Administratie</strong></h1>
            </div>
        </div>

        <!-- Navigatiebalk -->
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
                                <a class="nav-link" href="orders.php">Bestellingen</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
        </div>

        <!-- Welkomstbericht en afbeeldingen -->
        <div class="row mt-5 mb-4">
            <div class="col text-center">
                <h2>Welkom bij het Beheer Systeem</h2>
                <p>Kies in de navigatiebalk hierboven om klanten, producten of bestellingen te bekijken, aanpassen of verwijderen. <strong>Let op</strong> bij het aanpassen van producten, <strong>Dit heeft gevolgen op de database!</strong>
                </p>
            </div>
        </div>
        <div class="row justify-content-center">
            <div class="col-md-4 col-4 mb-3">
                <img src="CSS/peripherials.jpg" alt="Peripherals" class="img-fluid">
            </div>
            <div class="col-md-4 col-4 mb-3">
                <img src="CSS/coffee.webp" alt="Voorbeeld 2" class="img-fluid">
            </div>
            <div class="col-md-4 col-4 mb-3">
                <img src="CSS/gadgets.webp" alt="Voorbeeld 3" class="img-fluid">
            </div>
            <div class="col-md-4 col-4 mb-3">
                <img src="CSS/tv.webp" alt="Voorbeeld 2" class="img-fluid">
            </div>
            <div class="col-md-4 col-4 mb-3">
                <img src="CSS/pc.jpg" alt="Voorbeeld 2" class="img-fluid">
            </div>
            <div class="col-md-4 col-4 mb-3">
                <img src="CSS/printer.png" alt="Voorbeeld 2" class="img-fluid">
            </div>
        </div>
    </div>
</div>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.6/dist/js/bootstrap.bundle.min.js" integrity="sha384-j1CDi7MgGQ12Z7Qab0qlWQ/Qqz24Gc6BM0thvEMVjHnfYGF0rmFCozFSxQBxwHKO" crossorigin="anonymous"></script>
</body>

</html>
