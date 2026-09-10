-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 10, 2026 at 12:22 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bookshop`
--

-- --------------------------------------------------------

--
-- Table structure for table `authors`
--

CREATE TABLE `authors` (
  `author_id` int(11) NOT NULL,
  `author_name` varchar(100) NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `authors`
--

INSERT INTO `authors` (`author_id`, `author_name`) VALUES
(1, 'A.F.Th. van der Heijden'),
(2, 'Alain-Fournier'),
(3, 'Albert Camus'),
(4, 'Alex Michaelides'),
(5, 'Alexandre Dumas'),
(6, 'Alexandre Dumas fils'),
(7, 'Alfred Döblin'),
(8, 'Alice Walker'),
(9, 'Andy Weir'),
(10, 'Anne Frank'),
(11, 'Annett Gröschner'),
(12, 'Antoine de Saint-Exupéry'),
(13, 'Arnon Grunberg'),
(14, 'Bernard Werber'),
(15, 'Bernhard Schlink'),
(16, 'Bert Wagendorp'),
(17, 'Carl Zuckmayer'),
(18, 'Carlos Ruiz Zafón'),
(19, 'Connie Palmen'),
(20, 'Cormac McCarthy'),
(21, 'Dan Brown'),
(22, 'Delia Owens'),
(23, 'Dörte Hansen'),
(24, 'Edmond Rostand'),
(25, 'Émile Zola'),
(26, 'Erich Maria Remarque'),
(27, 'Eva Menasse'),
(28, 'F. Bordewijk'),
(29, 'F. Scott Fitzgerald'),
(30, 'Françoise Sagan'),
(31, 'Franz Kafka'),
(32, 'Friedrich Schiller'),
(33, 'Gabriel García Márquez'),
(34, 'George Orwell'),
(35, 'George R.R. Martin'),
(36, 'Georges Simenon'),
(37, 'Gerard Reve'),
(38, 'Günter Grass'),
(39, 'Gustave Flaubert'),
(40, 'Harper Lee'),
(41, 'Harry Mulisch'),
(42, 'Hella S. Haasse'),
(43, 'Herman Koch'),
(44, 'Herman Melville'),
(45, 'Hermann Hesse'),
(46, 'Honoré de Balzac'),
(47, 'J. Bernlef'),
(48, 'J.D. Salinger'),
(49, 'J.K. Rowling'),
(50, 'J.R.R. Tolkien'),
(51, 'Jan Siebelink'),
(52, 'Jane Austen'),
(53, 'Jean-Michel Guenassia'),
(54, 'Johann Wolfgang von Goethe'),
(55, 'John Green'),
(56, 'Kathryn Stockett'),
(57, 'Kees van Kooten'),
(58, 'Liane Moriarty'),
(59, 'Lize Spit'),
(60, 'Louis-Ferdinand Céline'),
(61, 'Marguerite Duras'),
(62, 'Marlen Haushofer'),
(63, 'Max Frisch'),
(64, 'Michel Houellebecq'),
(65, 'Michelle Obama'),
(66, 'Multatuli'),
(67, 'Muriel Barbery'),
(68, 'Paolo Cognetti'),
(69, 'Patrick Süskind'),
(70, 'Paul Valéry'),
(71, 'Paulo Coelho'),
(72, 'Pierre Corneille'),
(73, 'Rascha Peper'),
(74, 'Romain Gary'),
(75, 'Ronald Giphart'),
(76, 'Simone de Beauvoir'),
(77, 'Stefan Hertmans'),
(78, 'Stendhal'),
(79, 'Stephen King'),
(80, 'Stieg Larsson'),
(81, 'Suzanne Collins'),
(82, 'Tara Westover'),
(83, 'Theodor Fontane'),
(84, 'Theun de Vries'),
(85, 'Thomas Mann'),
(86, 'Toni Morrison'),
(87, 'Uwe Timm'),
(88, 'Vercors'),
(89, 'Victor Hugo'),
(90, 'W.F. Hermans'),
(91, 'Walter Benjamin'),
(92, 'Wolfgang Herrndorf'),
(93, 'Yuval Noah Harari');

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE `books` (
  `book_id` int(11) NOT NULL,
  `book_title` varchar(100) NOT NULL,
  `book_price` decimal(20,2) DEFAULT NULL,
  `book_pages` int(11) DEFAULT NULL,
  `book_image` varchar(255) DEFAULT NULL,
  `book_category_id` int(11) DEFAULT NULL,
  `book_author_id` int(11) DEFAULT NULL,
  `book_publication_year` int(11) DEFAULT NULL,
  `book_language` varchar(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`book_id`, `book_title`, `book_price`, `book_pages`, `book_image`, `book_category_id`, `book_author_id`, `book_publication_year`, `book_language`) VALUES
(1, 'The Catcher in the Rye', 8.99, 214, 'The Catcher in the Rye.jpg', 7, 1, 1951, 'en'),
(2, 'To Kill a Mockingbird', 10.99, 336, 'To Kill a Mockingbird.jpg', 7, 40, 1960, 'en'),
(3, '1984', 9.49, 328, '1984.jpg', 5, 34, 1949, 'en'),
(4, 'Pride and Prejudice', 9.99, 279, 'Pride and Prejudice.jpg', 16, 52, 1813, 'en'),
(5, 'The Great Gatsby', 10.49, 180, 'The Great Gatsby.jpg', 12, 29, 1925, 'en'),
(6, 'Moby-Dick', 12.99, 720, 'Moby-Dick.jpg', 1, 44, 1851, 'en'),
(7, 'The Hobbit', 11.99, 310, 'The Hobbit.jpg', 6, 50, 1937, 'en'),
(8, 'Harry Potter and the Sorcerer\'s Stone', 10.99, 309, 'Harry Potter and the Sorcerers Stone.jpg', 6, 49, 1997, 'en'),
(9, 'The Da Vinci Code', 9.99, 454, 'The Da Vinci Code.jpg', 19, 21, 2003, 'en'),
(10, 'The Shining', 10.99, 447, 'The Shining.jpg', 10, 79, 1977, 'en'),
(11, 'A Game of Thrones', 12.99, 694, 'A Game of Thrones.jpg', 6, 1, 1996, 'en'),
(12, 'Beloved', 10.99, 324, 'Beloved.jpg', 8, 86, 1987, 'en'),
(13, 'The Road', 8.99, 287, 'The Road.jpg', 5, 20, 2006, 'en'),
(14, 'The Color Purple', 9.99, 295, 'The Color Purple.jpg', 12, 8, 1982, 'en'),
(15, 'The Girl with the Dragon Tattoo', 11.99, 465, 'The Girl with the Dragon Tattoo.jpg', 19, 80, 2005, 'en'),
(16, 'The Hunger Games', 8.99, 374, 'The Hunger Games.jpg', 5, 81, 2008, 'en'),
(17, 'The Fault in Our Stars', 9.99, 313, 'The Fault in Our Stars.jpg', 20, 55, 2012, 'en'),
(18, 'The Alchemist', 10.99, 208, 'The Alchemist.jpg', 1, 71, 1988, 'en'),
(19, 'The Martian', 11.99, 369, 'The Martian.jpg', 17, 9, 2011, 'en'),
(20, 'The Help', 10.49, 466, 'The Help.jpg', 8, 56, 2009, 'en'),
(21, 'The Silent Patient', 11.99, 368, 'The Silent Patient.jpg', 19, 4, 2019, 'en'),
(22, 'Where the Crawdads Sing', 12.49, 384, 'Where the Crawdads Sing.jpg', 7, 22, 2018, 'en'),
(23, 'Educated', 9.49, 334, 'Educated.jpg', 13, 82, 2018, 'en'),
(24, 'Becoming', 10.99, 448, 'Becoming.jpg', 2, 65, 2018, 'en'),
(25, 'Sapiens: A Brief History of Humankind', 12.49, 498, 'Sapiens A Brief History of Humankind.jpg', 9, 93, 2011, 'en'),
(26, 'Max Havelaar', 9.99, 366, 'Max Havelaar.jpg', 12, 66, 1860, 'nl'),
(27, 'De Avonden', 12.99, 284, 'De Avonden.jpg', 12, 37, 1947, 'nl'),
(28, 'Het Achterhuis', 10.99, 283, 'Het Achterhuis.jpg', 2, 10, 1947, 'nl'),
(29, 'Karakter', 8.99, 288, 'Karakter.jpg', 12, 28, 1938, 'nl'),
(30, 'De Ansjovisvrouw', 9.49, 300, 'De Ansjovisvrouw.jpg', 7, 73, 1993, 'nl'),
(31, 'De ontdekking van de hemel', 11.49, 905, 'De ontdekking van de hemel.jpg', 12, 41, 1992, 'nl'),
(32, 'Het diner', 10.99, 301, 'Het diner.jpg', 19, 43, 2009, 'nl'),
(33, 'Tirza', 9.99, 334, 'Tirza.jpg', 7, 13, 2006, 'nl'),
(34, 'De Vriendschap', 12.99, 295, 'De Vriendschap.jpg', 7, 19, 1995, 'nl'),
(35, 'Het meisje met het rode haar', 7.99, 192, 'Het meisje met het rode haar.jpg', 8, 84, 1956, 'nl'),
(36, 'Knielen op een bed violen', 10.99, 576, 'Knielen op een bed violen.jpg', 7, 51, 2005, 'nl'),
(37, 'Rita en Kroonenberg', 11.99, 316, 'Rita en Kroonenberg.jpg', 11, 57, 2011, 'nl'),
(38, 'Oorlog en Terpentijn', 12.99, 304, 'Oorlog en Terpentijn.jpg', 2, 77, 2013, 'nl'),
(39, 'Oeroeg', 8.99, 130, 'Oeroeg.jpg', 12, 42, 1948, 'nl'),
(40, 'De donkere kamer van Damokles', 9.99, 337, 'De donkere kamer van Damokles.jpg', 12, 90, 1956, 'nl'),
(41, 'Ik omhels je met duizend armen', 10.49, 377, 'Ik omhels je met duizend armen.jpg', 12, 75, 2002, 'nl'),
(42, 'Zomerhuis met zwembad', 11.49, 288, 'Zomerhuis met zwembad.jpg', 19, 43, 2011, 'nl'),
(43, 'Tonio', 10.99, 416, 'Tonio.jpg', 2, 1, 2011, 'nl'),
(44, 'Ventoux', 9.99, 416, 'Ventoux.jpg', 12, 16, 2013, 'nl'),
(45, 'Hersenschimmen', 8.99, 168, 'Hersenschimmen.jpg', 12, 47, 1984, 'nl'),
(46, 'Het geheim van mijn man', 10.49, 399, 'Het geheim van mijn man.jpg', 14, 58, 2013, 'nl'),
(47, 'De acht bergen', 11.99, 336, 'De acht bergen.jpg', 12, 68, 2016, 'nl'),
(48, 'Kroniek van een aangekondigde dood', 9.99, 127, 'Kroniek van een aangekondigde dood.jpg', 12, 33, 1981, 'nl'),
(49, 'Het smelt', 10.99, 358, 'Het smelt.jpg', 7, 59, 2016, 'nl'),
(50, 'Schaduw van de wind', 9.99, 496, 'Schaduw van de wind.jpg', 7, 18, 2001, 'nl'),
(77, 'Le Petit Prince', 10.99, 96, 'Le Petit Prince.jpg', 3, 12, 1943, 'fr'),
(78, 'Madame Bovary', 11.49, 432, 'Madame Bovary.jpg', 12, 39, 1857, 'fr'),
(79, 'Les Misérables', 12.99, 1463, 'Les Misérables.jpg', 8, 89, 1862, 'fr'),
(80, 'Le Rouge et le Noir', 9.99, 580, 'Le Rouge et le Noir.jpg', 12, 78, 1830, 'fr'),
(81, 'L\'Étranger', 10.49, 123, 'LÉtranger.jpg', 12, 3, 1942, 'fr'),
(82, 'Le Comte de Monte-Cristo', 11.99, 1276, 'Le Comte de Monte-Cristo.jpg', 1, 5, 1844, 'fr'),
(83, 'Le Père Goriot', 9.49, 299, 'Le Père Goriot.jpg', 12, 46, 1835, 'fr'),
(84, 'Cyrano de Bergerac', 9.99, 160, 'Cyrano de Bergerac.jpg', 18, 24, 1897, 'fr'),
(85, 'Les Trois Mousquetaires', 11.99, 700, 'Les Trois Mousquetaires.jpg', 1, 5, 1844, 'fr'),
(86, 'La Peste', 12.49, 450, 'La Peste.jpg', 12, 3, 1947, 'fr'),
(87, 'Le Père de nos Pères', 8.99, 288, 'Le Père de nos Pères.jpg', 17, 14, 1998, 'fr'),
(88, 'Le Cimetière marin', 9.99, 27, 'Le Cimetière marin.jpg', 15, 70, 1920, 'fr'),
(89, 'Les Particules élémentaires', 10.99, 406, 'Les Particules élémentaires.jpg', 12, 64, 1998, 'fr'),
(90, 'Le Ravissement de Lol V. Stein', 9.99, 192, 'Le Ravissement de Lol V. Stein.jpg', 12, 61, 1964, 'fr'),
(91, 'Voyage au bout de la nuit', 12.99, 505, 'Voyage au bout de la nuit.jpg', 12, 60, 1932, 'fr'),
(92, 'Le Grand Meaulnes', 10.49, 329, 'Le Grand Meaulnes.jpg', 12, 2, 1913, 'fr'),
(93, 'Thérèse Raquin', 9.49, 243, 'Thérèse Raquin.jpg', 12, 25, 1867, 'fr'),
(94, 'Le Chien jaune', 10.49, 192, 'Le Chien jaune.jpg', 4, 36, 1931, 'fr'),
(95, 'Bonjour tristesse', 9.49, 144, 'Bonjour tristesse.jpg', 12, 30, 1954, 'fr'),
(96, 'La Dame aux camélias', 8.99, 320, 'La Dame aux camélias.jpg', 12, 6, 1848, 'fr'),
(97, 'Le Club des Incorrigibles Optimistes', 11.99, 624, 'Le Club des Incorrigibles Optimistes.jpg', 12, 53, 2009, 'fr'),
(98, 'Le Cid', 9.49, 78, 'Le Cid.jpg', 18, 72, 1637, 'fr'),
(99, 'La Promesse de l\'aube', 10.99, 442, 'La Promesse de laube.jpg', 2, 74, 1960, 'fr'),
(100, 'L\'Élégance du hérisson', 9.99, 400, 'LÉlégance du hérisson.jpg', 12, 67, 2006, 'fr'),
(101, 'Le Silence de la mer', 8.99, 116, 'Le Silence de la mer.jpg', 12, 88, 1942, 'fr'),
(102, 'La Femme rompue', 11.49, 234, 'La Femme rompue.jpg', 12, 76, 1967, 'fr'),
(103, 'Die Verwandlung', 10.99, 55, 'Die Verwandlung.jpg', 12, 31, 1915, 'fr'),
(104, 'Der Vorleser', 12.49, 216, 'Der Vorleser.jpg', 12, 15, 1995, 'de'),
(105, 'Der Steppenwolf', 11.99, 256, 'Der Steppenwolf.jpg', 12, 45, 1927, 'de'),
(106, 'Berlin Alexanderplatz', 10.99, 750, 'Berlin Alexanderplatz.jpg', 12, 7, 1929, 'de'),
(107, 'Der Zauberberg', 13.99, 720, 'Der Zauberberg.jpg', 12, 85, 1924, 'de'),
(108, 'Buddenbrooks', 12.99, 736, 'Buddenbrooks.jpg', 12, 85, 1901, 'de'),
(109, 'Im Westen nichts Neues', 10.99, 224, 'Im Westen nichts Neues.jpg', 8, 26, 1929, 'de'),
(110, 'Die Blechtrommel', 11.99, 672, 'Die Blechtrommel.jpg', 12, 38, 1959, 'de'),
(111, 'Effi Briest', 9.99, 365, 'Effi Briest.jpg', 12, 83, 1895, 'de'),
(112, 'Faust', 10.99, 703, 'Faust.jpg', 18, 54, 1808, 'de'),
(113, 'Der Prozess', 12.49, 220, 'Der Prozess.jpg', 12, 31, 1925, 'de'),
(114, 'Homo Faber', 10.49, 186, 'Homo Faber.jpg', 12, 63, 1957, 'de'),
(115, 'Die Wand', 9.99, 256, 'Die Wand.jpg', 17, 62, 1963, 'de'),
(116, 'Das Parfum', 10.99, 272, 'Das Parfum.jpg', 14, 69, 1985, 'de'),
(117, 'Tschick', 9.99, 253, 'Tschick.jpg', 12, 92, 2010, 'de'),
(118, 'Die Entdeckung der Currywurst', 8.99, 237, 'Die Entdeckung der Currywurst.jpg', 12, 87, 1993, 'de'),
(119, 'Der Hauptmann von Köpenick', 9.99, 80, 'Der Hauptmann von Köpenick.jpg', 18, 17, 1931, 'de'),
(120, 'Der Geisterseher', 11.49, 178, 'Der Geisterseher.jpg', 12, 32, 1789, 'de'),
(121, 'Berlin Poplars', 10.99, 112, 'Berlin Poplars.jpg', 12, 11, 2012, 'de'),
(122, 'Berlin Childhood around 1900', 11.49, 206, 'Berlin Childhood around 1900.jpg', 2, 91, 1938, 'de'),
(123, 'Altes Land', 10.99, 368, 'Altes Land.jpg', 12, 23, 2015, 'de'),
(124, 'Die Wand', 9.99, 256, 'Die Wand.jpg', 12, 62, 1963, 'de'),
(125, 'Alle Menschen sind sterblich', 10.99, 431, 'Alle Menschen sind sterblich.jpg', 12, 76, 1946, 'de'),
(126, 'Leichte Sprache', 9.99, 264, 'Leichte Sprache.jpg', 12, 27, 2021, 'de'),
(127, 'Die Spur der Bienen', 10.49, 320, 'Die Spur der Bienen.jpg', 12, 38, 2004, 'de');

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `category_id` int(11) NOT NULL,
  `category_name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`category_id`, `category_name`) VALUES
(1, 'Adventure'),
(2, 'Biography'),
(3, 'Children\'s'),
(4, 'Crime Fiction'),
(5, 'Dystopian'),
(6, 'Fantasy'),
(7, 'Fiction'),
(8, 'Historical Fiction'),
(9, 'History'),
(10, 'Horror'),
(11, 'Humor'),
(12, 'Literary Fiction'),
(13, 'Memoir'),
(14, 'Mystery'),
(15, 'Poetry'),
(16, 'Romance'),
(17, 'Science Fiction'),
(18, 'Theater'),
(19, 'Thriller'),
(20, 'Young Adult');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `authors`
--
ALTER TABLE `authors`
  ADD PRIMARY KEY (`author_id`);

--
-- Indexes for table `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`book_id`),
  ADD KEY `book_category_id` (`book_category_id`),
  ADD KEY `book_author_id` (`book_author_id`);

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`category_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `authors`
--
ALTER TABLE `authors`
  MODIFY `author_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=128;

--
-- AUTO_INCREMENT for table `books`
--
ALTER TABLE `books`
  MODIFY `book_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=131;

--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `category_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
