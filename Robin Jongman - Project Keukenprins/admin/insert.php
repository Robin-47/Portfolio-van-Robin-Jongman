<?php
include "../classes/blog.php";
include "../classes/database.php";
include "../classes/sessie.php";

$sessie = Sessie::vindActieveSessie(); // Zoekt actieve sessie

if (isset($_POST['submit'])) {
    $titel = $_POST['blogTitle'];
    $content = $_POST['blogContent'];
    $author = $_POST['blogAuthor'];

    $imageName = null;

    // Upload gekozen afbeelding
    if (isset($_FILES['blogImage']) && $_FILES['blogImage']['error'] === 0) { // Controleert of er een afbeelding is geüpload
        $imageName = basename($_FILES['blogImage']['name']); // Haalt de bestandsnaam van de afbeelding op
        move_uploaded_file($_FILES['blogImage']['tmp_name'], '../upload/' . $imageName); // Verplaatst de afbeelding naar de upload map
    }

    $conn = Database::start();

    // Voegt blog toe aan database
    $query = "INSERT INTO blogs (blog_title, blog_content, blog_author, blog_image) 
              VALUES ('$titel', '$content', '$author', '$imageName')";
    $conn->query($query);

    $conn->close();

    header("Location: admin.php?msg=Toegevoegd"); // Stuurt gebruiker terug naar admin.php na het toevoegen van de blog
    exit;
}
?>

<!doctype html>
<html lang="nl">
<head>
    <meta charset="utf-8">
    <title>Blog toevoegen</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
    <link rel="stylesheet" href="../css/jquery-te-1.4.0.css">
</head>
<body>
<div class="container mt-4">
    <h2>Nieuwe Blog Toevoegen</h2>
    <form method="post" action="insert.php" enctype="multipart/form-data">
        <div class="mb-3">
            <label for="blogTitle" class="form-label">Titel</label>
            <input type="text" id="blogTitle" name="blogTitle" class="form-control">
        </div>

        <div class="mb-3">
            <label for="blogAuthor" class="form-label">Auteur</label>
            <input type="text" id="blogAuthor" name="blogAuthor" class="form-control">
        </div>

        <div class="mb-3">
            <label for="blogImage" class="form-label">Afbeelding</label>
            <input type="file" id="blogImage" name="blogImage" class="form-control">
        </div>

        <div class="mb-3">
            <label for="blogContent" class="form-label">Inhoud</label>
            <textarea id="blogContent" name="blogContent" class="form-control richtext" rows="6"></textarea>
        </div>

        <button type="submit" name="submit" class="btn btn-success">Toevoegen</button>
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