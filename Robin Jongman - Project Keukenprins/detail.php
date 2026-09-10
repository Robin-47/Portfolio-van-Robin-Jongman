<?php
include "classes/blog.php";
include "classes/database.php";

// Terug naar overzicht als er geen id is gevonden
if (!isset($_GET['id'])) {
    header("Location: index.php");
    exit;
}

$id = (int)$_GET['id'];
$blog = Blog::findId($id);

// Stopt als er geen blog gevonden is
if ($blog === null) {
    echo "Blog niet gevonden.";
    exit;
}
?>
<!DOCTYPE html>
<html lang="nl">
<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title><?= htmlspecialchars($blog->blogTitle) ?></title> <!-- Titel van de blog -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />
</head>
<body>
<div class="container mt-4 mb-5">
    <h1><?= htmlspecialchars($blog->blogTitle) ?></h1> <!-- Titel van de blog -->
    <p><em>Auteur: <?= htmlspecialchars($blog->blogAuthor) ?></em></p> <!-- Auteur van de blog -->

    <?php if (!empty($blog->blogImage)): ?> <!-- Controleert of er een afbeelding is -->
        <div class="mb-3">
            <img src="upload/<?= htmlspecialchars($blog->blogImage) ?>" alt="Afbeelding bij blog" class="img-fluid"> <!-- Toont de afbeelding van de blog -->
        </div>
    <?php endif; ?>

    <div>
        <?= $blog->blogContent ?>
    </div>

    <a href="index.php" class="btn btn-secondary mt-3">Terug naar overzicht</a> <!-- Link terug naar het overzicht van blogs -->
</div>
<script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</body>
</html>