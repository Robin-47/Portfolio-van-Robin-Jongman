<?php
class Author
{
    public int $id;
    public string $name;

    // Lees alle auteurs uit de database
    public static function findAll()
    {
        $conn = Database::start();
        $sql = "SELECT * FROM authors";
        $result = $conn->query($sql);

        $authors = [];
        if ($result->num_rows > 0) {
            while ($row = $result->fetch_assoc()) {
                $author = new Author();
                $author->id = $row["author_id"];
                $author->name = $row["author_name"];
                $authors[] = $author;
            }
        }

        $conn->close();
        return $authors;
    }
}
?>

