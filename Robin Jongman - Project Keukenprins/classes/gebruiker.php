<?php
class Gebruiker
{
    public string $userId;
    public string $username;
    public string $password;
    public string $userAdmin;
    public string $firstname;

    public static function vindGebruiker($username, $password) // Zoekt de juiste gebruiker
    {
        $conn = Database::start();

        // Voorkomt SQL-injectie
        $username = mysqli_real_escape_string($conn, $username);
        $password = mysqli_real_escape_string($conn, $password);

        $query = "SELECT * FROM users WHERE user_username = '$username' AND user_password = '$password'";
        $resultaat = $conn->query($query);

        $user = null;

        if ($resultaat->num_rows > 0) {
            $row = $resultaat->fetch_assoc();

            $user = new Gebruiker();
            $user->userId = $row['user_id'];
            $user->username = $row['user_username'];
            $user->password = $row['user_password'];
            $user->userAdmin = $row['user_admin'];
            $user->firstname = $row['user_firstname'];
        }

        $conn->close();

        return $user; // Geef gevonden gebruiker terug (of null wanneer niet gevonden)
    }

    // Zoekt een gebruiker op user ID.
    public static function vindOpId($userId)
    {
        $conn = Database::start();

        $userId = mysqli_real_escape_string($conn, $userId);

        $query = "SELECT * FROM users WHERE user_id = '$userId'";
        $resultaat = $conn->query($query);

        $user = null;

        if ($resultaat->num_rows > 0) {
            $row = $resultaat->fetch_assoc();

            $user = new Gebruiker();
            $user->userId = $row['user_id'];
            $user->firstname = $row['user_firstname'];
            $user->username = $row['user_username'];
            $user->password = $row['user_password'];
            $user->userAdmin = $row['user_admin'];
        }

        $conn->close();

        return $user; // Geef gevonden gebruiker terug (of null wanneer niet gevonden)
    }
}