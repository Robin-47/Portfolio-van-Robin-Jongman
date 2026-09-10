<?php
class Book
{
    public int $id;
    public string $titel;
    public int $page;
    public string $image;
    public int $categorie;
    public int $author;
    public string $authorName;
    public int $year;
    public string $taal;
    public float $price;
    
    // Zoekt boeken op titel, categorie en auteur
    public static function findAll(string $titel = "", array $categories = [], array $authors = [])
    {
        $conn = database::start();

        // Zorgt dat zoektekst veilig wordt gebruikt in de query
        $titel = mysqli_real_escape_string($conn, $titel);

        $sql = "SELECT b.*, a.author_name AS authorName
                FROM books b
                LEFT JOIN authors a ON b.book_author_id = a.author_id
                WHERE b.book_title LIKE '%$titel%'";

        if (!empty($categories)) {
            $cats = array_map('intval', $categories);
            $sql .= " AND b.book_category_id IN (" . implode(',', $cats) . ")";
        }

        if (!empty($authors)) {
            $auts = array_map('intval', $authors);
            $sql .= " AND b.book_author_id IN (" . implode(',', $auts) . ")";
        }

        $sql .= " ORDER BY b.book_title";

        $result = $conn->query($sql);

        $books = [];

        if ($result && $result->num_rows > 0) {
            while ($row = $result->fetch_assoc()) {
                $book = new Book();
                $book->id = $row['book_id'];
                $book->titel = $row['book_title'];
                $book->page = $row['book_pages'];
                $book->price = $row['book_price'];
                $book->image = $row['book_image'];
                $book->authorName = $row['authorName'] ?? '';
                $books[] = $book;
            }
        }

        $conn->close();
        return $books;
    }

    // Vind auteurs die passen bij de huidige zoekwoorden en filters
    public static function findAuthorsFromFilters(array $categories = [], string $titel = "", array $authors = [])
    {
        $conn = database::start();

        $titel = mysqli_real_escape_string($conn, $titel);

        $sql = "SELECT DISTINCT a.author_id, a.author_name
                FROM books b
                LEFT JOIN authors a ON b.book_author_id = a.author_id
                WHERE b.book_title LIKE '%$titel%'";

        if (!empty($categories)) {
            $cats = array_map('intval', $categories);
            $sql .= " AND b.book_category_id IN (" . implode(',', $cats) . ")";
        }

        if (!empty($authors)) {
            $auts = array_map('intval', $authors);
            $sql .= " AND b.book_author_id IN (" . implode(',', $auts) . ")";
        }

        $result = $conn->query($sql);

        $authors = [];
        if ($result) {
            while ($row = $result->fetch_assoc()) {
                $a = new stdClass();
                $a->id = $row['author_id'];
                $a->name = $row['author_name'];
                $authors[] = $a;
            }
        }

        $conn->close();
        return $authors;
    }

    // Haalt één boek op met het gegeven id
    public static function findById(int $id)
    {
        $conn = database::start();
        $id = (int)$id;

        $sql = "SELECT b.*, a.author_name AS authorName
                FROM books b
                LEFT JOIN authors a ON b.book_author_id = a.author_id
                WHERE b.book_id = $id";
        $result = $conn->query($sql);

        $book = null;
        if ($result && $result->num_rows > 0) {
            $row = $result->fetch_assoc();
            $book = new Book();
            $book->id = $row['book_id'];
            $book->titel = $row['book_title'];
            $book->page = $row['book_pages'];
            $book->price = $row['book_price'];
            $book->image = $row['book_image'];
            $book->categorie = $row['book_category_id'];
            $book->author = $row['book_author_id'];
            $book->authorName = $row['authorName'] ?? '';
            $book->year = $row['book_publication_year'];
            $book->taal = $row['book_language'];
        }

        $conn->close();
        return $book;
    }
}
?>
