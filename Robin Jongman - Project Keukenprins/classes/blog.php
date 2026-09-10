<?php

class Blog
{
    // Eigenschappen
    
    public $blogId;
    public $blogTitle;
    public $blogImage;
    public $blogContent;
    public $blogAuthor;

    public static function findAll() {
        $conn = Database::start();

        $query = "SELECT * FROM blogs"; // SQL-query om alle blogs op te halen
        $result = $conn->query($query);

        $blogs = [];

        if ($result->num_rows > 0) { // Controleert of er blogs zijn gevonden
            while ($row = $result->fetch_assoc()) { // Haalt elke gevonden blog op
                $blog = new Blog();
                $blog->blogId = $row["blog_id"];
                $blog->blogTitle = $row["blog_title"];
                $blog->blogImage = $row["blog_image"];
                $blog->blogContent = $row["blog_content"];
                $blog->blogAuthor = $row["blog_author"];
                $blogs[] = $blog;
            }
        }

        $conn->close();

        return $blogs; // Geeft alle blogs terug
    }

    public function delete() { // Functie voor het verwijderen van een blog
        $conn = Database::start();

        $query = "DELETE FROM blogs WHERE blog_id = " . $this->blogId;
        $conn->query($query);

        $conn->close();
    }

    public function update() {
        $conn = Database::start();

        // Updatet blog in database
        $sql = "UPDATE blogs SET 
                    blog_title = '{$this->blogTitle}',
                    blog_content = '{$this->blogContent}',
                    blog_author = '{$this->blogAuthor}',
                    blog_image = '{$this->blogImage}'
                WHERE blog_id = {$this->blogId}";

        $result = $conn->query($sql);
        $conn->close();

        return $result;
    }

    public function maakKorter($aantalTekens = 40) {
        // Maakt de  korte versie van de blog
        $kort = mb_substr($this->blogContent, 0, $aantalTekens);
        if (mb_strlen($this->blogContent) > $aantalTekens) { // Controleert of de blog langer is dan het aantal tekens
            $kort .= '...';
        }
        return $kort;
    }

    public static function findId($blogId) // Functie om een blog te vinden op basis van de blog ID
    {
        $conn = Database::start();

        $query = "SELECT * FROM blogs WHERE blog_id = '$blogId'"; // SQL-query om de blog op te halen
        $result = $conn->query($query);

        if ($result->num_rows > 0) {
            $row = $result->fetch_assoc(); // Haalt de gevonden blog op
            $blog = new Blog();
            $blog->blogId = $row["blog_id"];
            $blog->blogTitle = $row["blog_title"];
            $blog->blogImage = $row["blog_image"];
            $blog->blogContent = $row["blog_content"];
            $blog->blogAuthor = $row["blog_author"];
            return $blog; // Geeft de blog terug als gevonden
        }

        $conn->close();
        return null; // Geen blog gevonden
    }
}

?>