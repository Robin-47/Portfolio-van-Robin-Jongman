<?php
include "classes/database.php";
include "classes/books.php";

// Controleert of er een boek is geselecteerd
if (!isset($_GET['id'])) {
    die("Geen boek geselecteerd.");
}

$id = (int) $_GET['id'];

// Haalt het boek op uit de database
$book = Book::findById($id);
if (!$book) {
    die("Boek niet gevonden.");
}

// Zoekt de juiste afbeelding voor het boek
function getBookCoverPath($book)
{
    $paths = [];

    if (!empty($book->image)) {
        $paths[] = 'afbeeldingen/' . basename($book->image);
        $paths[] = 'afbeeldingen/' . basename(pathinfo($book->image, PATHINFO_FILENAME)) . '.jpg';
    }

    $titleFileName = $book->titel;
    $paths[] = 'afbeeldingen/' . $titleFileName . '.jpg';
    $paths[] = 'afbeeldingen/' . $titleFileName . '.jpeg';
    $paths[] = 'afbeeldingen/' . $titleFileName . '.png';

    foreach ($paths as $path) {
        if (file_exists($path)) {
            return $path;
        }
    }

    return '';
}

$cover = getBookCoverPath($book);
?>

<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css">
<div class="container py-4">
    <a href="index.php" class="btn btn-secondary mb-3">← Terug</a>
    <div class="card">
        <div class="row g-0">
            <div class="col-md-4">
                <?php if (!empty($cover)) : ?>
                    <img src="<?php echo htmlspecialchars($cover); ?>" class="img-fluid rounded-start" alt="Cover">
                <?php endif; ?>
            </div>
            <div class="col-md-8">
                <div class="card-body">
                    <h1 class="card-title"><?php echo htmlspecialchars($book->titel); ?></h1>
                    <p><strong>Auteur:</strong> <?php echo htmlspecialchars($book->authorName ?? 'Onbekend'); ?></p>
                    <p><strong>Pagina's:</strong> <?php echo htmlspecialchars($book->page); ?></p>
                    <p><strong>Prijs:</strong> €<?php echo number_format((float)$book->price, 2, ',', '.'); ?></p>
                    <?php if (!empty($book->year)) : ?>
                        <p><strong>Jaar:</strong> <?php echo htmlspecialchars($book->year); ?></p>
                    <?php endif; ?>
                    <?php if (!empty($book->taal)) : ?>
                        <p><strong>Taal:</strong> <?php echo htmlspecialchars($book->taal); ?></p>
                    <?php endif; ?>
                </div>
            </div>
        </div>
    </div>
</div>
