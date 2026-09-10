<?php
/* Dit bestand zorgt voor de lijst met boeken die passen bij de huidige filters*/

include "classes/database.php";
include "classes/books.php";

// Leest de ingevulde titel en de gekozen filters
$title = $_POST['title'] ?? '';
$categories = $_POST['categories'] ?? [];
$authors = $_POST['authors'] ?? [];

// Zorgt dat de filters correct worden verwerkt
if (!is_array($categories)) {
    $categories = $categories ? explode(',', $categories) : [];
}
if (!is_array($authors)) {
    $authors = $authors ? explode(',', $authors) : [];
}

// Zoekt de juiste boeken in de database
$books = Book::findAll($title, $categories, $authors);

// Vind de beste afbeelding voor een boek

function getBookCoverPath($book)
{
    $paths = [];
    if (!empty($book->image)) {
        $paths[] = 'afbeeldingen/' . basename($book->image);
    }
    $title = $book->titel;
    // Probeert verschillende formaten
    $paths[] = "afbeeldingen/$title.jpg";
    $paths[] = "afbeeldingen/$title.jpeg";
    $paths[] = "afbeeldingen/$title.png";

    // Retourneert de eerste afbeelding die bestaat
    foreach ($paths as $path) {
        if (file_exists($path)) return $path;
    }
    return '';
}
?>

<!-- HTML voor de boekenlijst -->

<p>Resultaten: <?php echo htmlspecialchars($title); ?></p>

<?php if (count($books) === 0): ?>
    <p>Geen boeken gevonden.</p>
<?php else: ?>
    <div class="row row-cols-1 row-cols-md-3 g-4">
        <?php foreach ($books as $book): ?>
            <?php $cover = getBookCoverPath($book); ?>
            <div class="col">
                <div class="card h-100">
                    <?php if ($cover): ?>
                        <img src="<?php echo htmlspecialchars($cover); ?>" class="card-img-top book-cover" alt="<?php echo htmlspecialchars($book->titel); ?>">
                    <?php endif; ?>
                    <div class="card-body">
                        <h5 class="card-title"><?php echo htmlspecialchars($book->titel); ?></h5>
                        <p class="text-muted">
                            Auteur: <?php echo htmlspecialchars($book->authorName ?: 'Onbekend'); ?>
                        </p>
                        <p><strong>Pagina's:</strong> <?php echo (int)$book->page; ?></p>
                        <p><strong>Prijs:</strong> €<?php echo number_format($book->price, 2, ',', '.'); ?></p>
                    </div>
                    <div class="card-footer bg-transparent">
                        <a href="details.php?id=<?php echo $book->id; ?>" class="btn btn-secondary mb-3">
                            Details
                        </a>
                    </div>
                </div>
            </div>
        <?php endforeach; ?>
    </div>
<?php endif; ?>
