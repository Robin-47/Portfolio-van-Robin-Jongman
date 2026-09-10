<?php
/* Dit bestand zorgt voor de lijst met auteurs die passen bij de huidige filters*/

include "classes/database.php";
include "classes/books.php";

// Leest de ingevoerde titel en de gekozen filters
$categories = $_POST['categories'] ?? [];
$title = $_POST['title'] ?? '';
$authors = $_POST['authors'] ?? [];

// Zorgt dat de filters correct worden verwerkt
if (!is_array($categories)) {
    $categories = $categories ? explode(',', $categories) : [];
}
if (!is_array($authors)) {
    $authors = $authors ? explode(',', $authors) : [];
}

// Zoekt auteurs die passen bij de huidige filters
$filteredAuthors = Book::findAuthorsFromFilters($categories, $title, $authors);

?>

<!-- Auteurs die passen bij de filters -->
<?php foreach ($filteredAuthors as $a): ?>
    <div class="form-check">
        <!-- Resultaten worden ververst bij het aanvinken van een filter -->
        <input class="form-check-input" 
               type="checkbox" 
               name="authors[]" 
               value="<?php echo htmlspecialchars($a->id); ?>" 
               onchange="loadOverview()" 
               id="author-<?php echo htmlspecialchars($a->id); ?>"
               <?php echo in_array($a->id, $authors, true) ? 'checked' : ''; ?>>
        <label class="form-check-label" for="author-<?php echo htmlspecialchars($a->id); ?>">
            <?php echo htmlspecialchars($a->name); ?>
        </label>
    </div>
<?php endforeach; ?>
