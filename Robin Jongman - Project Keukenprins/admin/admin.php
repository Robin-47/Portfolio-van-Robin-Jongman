<?php
include "../classes/blog.php"; // linkt bestanden met admin.php
include "../classes/database.php";
include "../classes/sessie.php";

$sessie = Sessie::vindActieveSessie(); // Zoekt actieve sessie

$blogs = Blog::findAll(); // Haal alle blogs op
?>
<!doctype html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Inlog pagina</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
</head>

<body id="body">
    <header class="text-center">
        <img src="../images/logo.png" alt="Logo" width="200">
    </header>
    <div class="container">
        <div class="row">
            <div class="col">
                <h3>Admin Mode</h3>
            </div>
            <div class="col">
                <?php if (isset($_GET["message"])): ?>
                    <?= htmlspecialchars($_GET["message"]) // Toont succesbericht ?>
                <?php endif; ?>

                <?php if (isset($_GET["error"])): ?>
                    <?= htmlspecialchars($_GET["error"]) // Toont foutmelding ?>
                <?php endif; ?>
            </div>
            <div class="col text-end">
                <a href="insert.php" class="btn btn-dark" id="knop">Toevoegen</a> <!-- Voegt blog toe -->
            </div>
        </div>
        <div class="row" style="margin-top: 30px;">
            <table>
                <tbody>
                    <?php foreach ($blogs as $blog) { ?>
                        <tr>
                            <td><strong><?= $blog->blogTitle; ?></strong><br>
                                <?= $blog->maakKorter(40); // De korte versie van de blog ?>
                            </td>
                            <td>
                                <div class="d-flex gap-2">
                                    <a href="edit.php?id=<?= $blog->blogId; ?>" class="btn btn-dark">Aanpassen</a> <!-- Blog bewerken -->
                                    <a href="delete.php?id=<?= $blog->blogId; ?>" class="btn btn-dark" onclick="return confirm('Weet je zeker dat je deze blog wilt verwijderen?')">Verwijderen</a> <!-- Blog verwijderen -->
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="height: 30px;"></td>
                        </tr>
                    <?php } ?>
                </tbody>
            </table>
        </div>
    </div>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
</body>

</html>