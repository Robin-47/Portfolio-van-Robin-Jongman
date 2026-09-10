<?php
class Category
{
    public int $id;
    public string $name;

    // Haalt alle categorieën uit de database
    public static function findAll()
    {
        $conn = Database::start();
        $sql = "SELECT * FROM categories";
        $result = $conn->query($sql);

        $categories = [];
        if ($result->num_rows > 0) {
            while ($row = $result->fetch_assoc()) {
                $category = new Category();
                $category->id = $row["category_id"];
                $category->name = $row["category_name"];
                $categories[] = $category;
            }
        }

        $conn->close();
        return $categories;
    }
}
?>

