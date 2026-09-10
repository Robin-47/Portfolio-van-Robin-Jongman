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

                <button type="submit" class="btn btn-light"><h2>Bereken BMI</h2></button>
            </form>
        </div>
    <div class="col-6">
      <p>BMI staat voor 'Body Mass Index'. Het kan handig zijn om je BMI te berekenen, bijvoorbeeld om te kijken hoe gezond je lichaamsgewicht gemiddeld is ten opzichtte van je lengte. Het BMI is bedacht door de belgische wetenschapper 'Adolphe Quetelet' in de 19e eeuw. Het is een goede schatting naar je gezondheid, maar het is niet altijd bruikbaar. Denk aan mensen met een groeistoornis of mensen boven de 60 jaar waarvan de botmassa daalt.</p>
      <img src="bmi.png" alt="image" class="groente" height="400" width="405"/>
    </div>
  </div>
</div>

      <div class="row">
        <div class="col-6">
<?php

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $gewicht = $_POST["gewicht"];
    $lengte = $_POST["lengte"];
    $geslacht = $_POST["geslacht"];

    if ($lengte > 0 && $gewicht > 0) {
        $bmi = $gewicht / ($lengte * $lengte);
        echo "<h2>Je BMI is " . round($bmi, 2) . "</h2>";

        if ($geslacht == "man") {
            echo "<h2>U heeft ";
            if ($bmi < 20) {
                echo "Ondergewicht.";
            } elseif ($bmi >= 20 && $bmi < 25) {
                echo "Gezond gewicht.";
            } else {
                echo "Overgewicht.";
            }
            echo "</h2>";
        } elseif ($geslacht == "vrouw") {
            echo "<h2>U heeft ";
            if ($bmi < 19) {
                echo "Ondergewicht.";
            } elseif ($bmi >= 19 && $bmi < 24) {
                echo "Gezond gewicht.";
            } else {
                echo "Overgewicht.";
            }
            echo "</h2>";
            }
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
