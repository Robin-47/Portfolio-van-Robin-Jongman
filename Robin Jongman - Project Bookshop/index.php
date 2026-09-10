<?php

include "classes/database.php";
include "classes/books.php";
include "classes/categories.php";
include "classes/authors.php";
?>


<!DOCTYPE html>
<html lang="nl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Boeken Overzicht</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css">
    <link rel="stylesheet" href="css/styles.css">
</head>
<body>
    <div class="container py-4">
        <nav class="navbar navbar-light bg-light rounded mb-4 px-3 py-2">
            <a class="navbar-brand" href="index.php">Bookshop</a>
        </nav>
        
        <h1 class="mb-4">Boeken Overzicht</h1>
        
        <?php if (isset($_GET['message'])): ?>
            <p><?php echo htmlspecialchars($_GET['message']); ?></p>
        <?php endif; ?>
        
        <div class="row g-4">
            <!-- Filter kolom -->
            <div class="col-md-3">
                <!-- Categorieën Filter -->
                <div class="card mb-3">
                    <div class="card-body">
                        <fieldset>
                            <legend>Categorieën</legend>
                            <?php foreach (Category::findAll() as $c): ?>
                                <div class="form-check">
                                    <input class="form-check-input"
                                           type="checkbox"
                                           name="categories[]"
                                           value="<?php echo $c->id; ?>"
                                           onchange="loadOverview()"
                                           id="cat-<?php echo $c->id; ?>">
                                    <label class="form-check-label" for="cat-<?php echo $c->id; ?>">
                                        <?php echo htmlspecialchars($c->name); ?>
                                    </label>
                                </div>
                            <?php endforeach; ?>
                        </fieldset>
                    </div>
                </div>

                <!-- Auteurs Filter -->
                <div class="card">
                    <div class="card-body">
                        <fieldset>
                            <legend>Auteurs</legend>
                            <div id="author-filter">
                                <!-- Auteurs komen hier -->
                            </div>
                        </fieldset>
                    </div>
                </div>
            </div>

            <!-- Boeken kolom -->
            <div class="col-md-9">
                <div class="card mb-3">
                    <div class="card-body">
                        <input type="text"
                               id="search-input"
                               class="form-control"
                               placeholder="Zoek titel"
                               onkeyup="loadOverview()">
                    </div>
                </div>

                <div id="overview">
                    <!-- Boeken komen hier -->
                </div>
            </div>
        </div>
    </div>

    <script src="js/ajax.js"></script>
    <script>
        document.addEventListener('DOMContentLoaded', function() {
            loadOverview();
        });
    </script>
</body>
</html>
