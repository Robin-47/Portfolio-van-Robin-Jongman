<?php
include "classes/blog.php";
include "classes/database.php";

// Haalt alle blogs op uit de database
$blogs = Blog::findAll();
?>
<!DOCTYPE html>
<html lang="nl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Blogs Overzicht</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <link href="https://fonts.googleapis.com/css2?family=Roboto&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="css/style.css">
</head>
<body id="body">
    <header class="text-center">
        <img src="images/flag.png" alt="Icon" width="200" style="margin-top:20px;">
</header>
    <div class="container mt-4">
    <h1>Autosport Blogs van de Dag!</h1>
    <?php
    // Toont alle blogs als 'cards'
    foreach ($blogs as $blog) { ?> <!-- Loop door alle blogs en toont ze -->
        <div class="card mb-3">
            <div class="card-body">
                <h5 class="card-title"><?= htmlspecialchars($blog->blogTitle) ?></h5> <!-- Laat de titel van de blog zien -->
                <p class="card-text"><?= $blog->maakKorter(100) ?></p>
                <p class="card-text"><small class="text-muted">Auteur: <?= htmlspecialchars($blog->blogAuthor) ?></small></p> <!-- Laat de auteur van de blog zien -->
                <a href="detail.php?id=<?= $blog->blogId ?>" class="btn btn-secondary mt-3">Lees meer</a> <!-- Link naar de detailpagina van de blog -->
            </div>
        </div>
        <?php
        }
        ?>
</div>
<script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</body>
</html>