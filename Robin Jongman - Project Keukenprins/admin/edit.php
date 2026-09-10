<?php
include "../classes/database.php";
include "../classes/blog.php";
include "../classes/sessie.php";

$id = $_GET["id"]; // Haalt de id van de blog op uit de URL
$blog = Blog::findId($id); // Zoekt de blog op basis van de id

if ($blog == null) {
    echo "Niet gevonden."; // Foutmelding als blog niet wordt gevonden
    exit;
}

if ($_SERVER["REQUEST_METHOD"] === "POST") { // Controleert of het formulier is verzonden
    $blog->blogTitle = $_POST["blogTitle"];
    $blog->blogAuthor = $_POST["blogAuthor"];
    $blog->blogContent = $_POST["blogContent"];

    // Upload gekozen afbeelding
    if (isset($_FILES['blogImage']) && $_FILES['blogImage']['error'] === 0) { // Controleert of er een afbeelding is geüpload
        $blog->blogImage = basename($_FILES['blogImage']['name']); // Haalt de bestandsnaam van de afbeelding op
        move_uploaded_file($_FILES['blogImage']['tmp_name'], '../upload/' . $blog->blogImage); // Verplaatst de afbeelding naar de upload map
    }

    $blog->update(); // Werkt blog bij in de database
    header("Location: admin.php?msg=aangepast"); // Stuurt gebruiker terug naar admin.php na het aanpassen van de blog
    exit;
}
?>

<!DOCTYPE html>
<html lang="nl">
<head>
    <meta charset="utf-8">
    <title>Blog aanpassen</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
    <link rel="stylesheet" href="../css/jquery-te-1.4.0.css">
</head>
<body>
<div class="container mt-4">
    <h2>Blog aanpassen</h2>
    <form method="POST" enctype="multipart/form-data">
        <div class="mb-3">
            <label for="blogTitle" class="form-label">Titel</label>
            <input type="text" name="blogTitle" id="blogTitle" class="form-control" value="<?= $blog->blogTitle ?>">
        </div>

        <div class="mb-3">
            <label for="blogAuthor" class="form-label">Auteur</label>
            <input type="text" name="blogAuthor" id="blogAuthor" class="form-control" value="<?= $blog->blogAuthor ?>">
        </div>

        <div class="mb-3">
            <label for="blogImage" class="form-label">Afbeelding</label>
            <input type="file" name="blogImage" id="blogImage" class="form-control">
            <?php if ($blog->blogImage): ?>
                <img src="../upload/<?= $blog->blogImage ?>" width="100" class="mt-2"> <!-- Vertoond gekozen afbeelding -->
            <?php endif; ?>
        </div>

        <div class="mb-3">
            <label for="blogContent" class="form-label">Inhoud</label>
            <textarea name="blogContent" id="blogContent" class="form-control richtext" rows="6"><?= $blog->blogContent ?></textarea>
        </div>

        <input type="submit" value="Opslaan" class="btn btn-success">
        <a href="admin.php" class="btn btn-secondary">Annuleren</a>
    </form>
</div>

<script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
<script src="../js/jquery-te-1.4.0.min.js"></script>
<script>
    $(".richtext").jqte(); // Activeert rich text editor
</script>
</body>
</html>
