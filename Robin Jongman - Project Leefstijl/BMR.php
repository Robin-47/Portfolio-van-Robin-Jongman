<!doctype html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Home</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <link rel="stylesheet" type="text/css" href="style.css"/>
  </head>
  <body>
  <div class="container-fluid">
      <div class="row text-center" id="up">
        <div class="col">
          <h1 class="title">Test Je Leefstijl</h1>
        </div>
      </div>
    </div>

  <nav class="navbar navbar-expand-lg">
      <div class="container-fluid">
        <a class="navbar-brand" href="#"></a><img src="logo.png" alt="image" height="95" width="100"/>
        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarNav">
          <ul class="navbar-nav">
            <li class="nav-item">
              <a class="nav-link" href="Home.php">Home</a>
            </li>
            <li class="nav-item">
              <a class="nav-link" href="BMI.php">BMI</a>
            </li>
            <li class="nav-item">
              <a class="nav-link" href="BMR.php">BMR</a>
            </li>
            <li class="nav-item">
              <a class="nav-link" href="Tips.php">Tips</a>
            </li>
          </ul>
        </div>
      </div>
    </nav>

    <div class="row">
    <div class="col-6">
        <form method="POST" action="">
            <div class="mb-3">
                <label for="gewicht" class="form-label">Gewicht (KG):</label>
                <input type="number" step="1" name="gewicht" id="gewicht" class="form-control" required>
            </div>

            <div class="mb-3">
                <label for="lengte" class="form-label">Lengte (M):</label>
                <input type="number" step="0.1" name="lengte" id="lengte" class="form-control" required>
            </div>

            <div class="mb-3">
                <label for="leeftijd" class="form-label">Leeftijd (Jaren):</label>
                <input type="number" step="1" name="leeftijd" id="leeftijd" class="form-control" required>
            </div>

            <div class="mb-3">
                <label class="form-label">Geslacht:</label><br>
                <div class="form-check">
                    <input type="radio" name="geslacht" value="man" id="man" class="form-check-input" required>
                    <label class="form-check-label" for="man">Man</label>
                </div>
                <div class="form-check">
                    <input type="radio" name="geslacht" value="vrouw" id="vrouw" class="form-check-input" required>
                    <label class="form-check-label" for="vrouw">Vrouw</label>
                </div>
            </div>

            <button type="submit" class="btn btn-light"><h2>Bereken BMR</h2></button>
        </form>
    </div>
    <div class="col-6">
        <p>Het BMR klinkt misschien bijna hetzelfde als BMI, maar toch is het iets heel anders. Het BMR kan aangeven hoeveel calorieën iemand gemiddeld dagelijks nodig heeft. Ook dit is niet altijd nuttig voor iemand. Denk hierbij ook aan sporters die (waarschijnlijk) meer voeding nodig hebben dan de gemiddelde persoon van die lengte. Met het BMR kun je er achter komen hoeveel energie jouw lichaam dagelijks verbruikt in ruststand. Gemiddeld ligt dit tussen de 1200 en 1800 calorieën per dag.</p>
        <img src="bmr.webp" alt="image" class="groente" height="400" width="480"/>
    </div>
</div>

<div class="row">
    <div class="col-6">

<?php

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $gewicht = $_POST["gewicht"];
    $lengte = $_POST["lengte"];
    $leeftijd = $_POST["leeftijd"];
    $geslacht = $_POST["geslacht"];

    if ($lengte > 0 && $gewicht > 0 && $leeftijd > 0) {
        $lengte_cm = $lengte * 100;

        if ($geslacht == "man") {
            $bmr = (10 * $gewicht) + (6.25 * $lengte_cm) - (5 * $leeftijd) + 5;
        } elseif ($geslacht == "vrouw") {
            $bmr = (10 * $gewicht) + (6.25 * $lengte_cm) - (5 * $leeftijd) - 161;
        }

        echo "<h2>Je BMR is " . round($bmr, 2) . " kcal/dag</h2>";

    } else {
        echo "<h2>Er is iets fout gegaan</h2>";
    }
}

?>
        </div>
      </div>
    </div>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
  </body>
</html>
