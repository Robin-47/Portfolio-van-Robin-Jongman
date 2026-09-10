-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 10, 2026 at 12:16 PM
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
-- Database: `garage`
--

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `customer_id` int(11) NOT NULL,
  `customer_firstname` varchar(50) NOT NULL,
  `customer_lastname` varchar(50) NOT NULL,
  `customer_address` varchar(50) NOT NULL,
  `customer_zipcode` varchar(7) NOT NULL,
  `customer_city` varchar(50) NOT NULL,
  `customer_email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`customer_id`, `customer_firstname`, `customer_lastname`, `customer_address`, `customer_zipcode`, `customer_city`, `customer_email`) VALUES
(101, 'J.', 'Albema', 'Hoofdstraat 55', '1025 KN', 'Amsterdam', 'J.Albema@Ziggo.nl'),
(102, 'K.', 'Balema', 'Lindengracht 33', '1082 KL', 'Amsterdam', 'KBaal@hotmail.com'),
(103, 'P.', 'de Vries', 'Kasteel 5', '3872 LM', 'Alkmaar', 'PdeVries@hotmail.com'),
(104, 'P.', 'Haarlem', 'Amsterdamse weg 107', '3038 DF', 'Haarlem', 'PHaarlem@gmail.com'),
(105, 'L.', 'Halsema', 'Boerenlaan 77', '3974 PK', 'Groningen', 'Superman@hotmail.com'),
(106, 'V.', 'Groothoofd', 'Jan de Bouvierstraat 21', '8564 LP', 'Amstelveen', 'Grootkop@gmail.com'),
(107, 'L.', 'Bartels', 'Veenwegen 974', '2963 KL', 'Hoofddorp', 'Bartel@gmail.com'),
(108, 'P.', 'de Jong', 'Amstelkade 64', '1957 ED', 'Rotterdam', 'P.deJong@hotmail.com'),
(109, 'K.', 'Vrolijk', 'Parkstraat 54', '4045 MN', 'Rotterdam', 'Vrolijkjoch@gmail.com'),
(110, 'L.', 'Vroom', 'Kerkstraat 9', '2046 LK', 'Haarlem ', 'VroomL@gmail.com'),
(111, 'K.', 'Klein', 'Gartmanplantsoen 4', '1087 AQ', 'Amsterdam', 'Klein@kpn.com'),
(112, 'L.', 'Ravenstein', 'Keienstraat 9', '4837 LM', 'Rotterdam', 'Ravenstein@dat.com'),
(113, 'M.', 'Rood', 'Kleurenplantsoen 2', '5463 FS', 'Nieuw-Vennep', 'Rood@hotmail.com'),
(114, 'W.', 'van Oranje', 'Paleisstraat 52', '8372 UJ', 'Soestdijk', 'Prinsgemaal@hotmail.com'),
(115, 'Mark', 'de Boer', 'Landweg 43', '8877 AA', 'St. Oedenrode', 'Mark@deboer');

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `order_id` int(11) NOT NULL,
  `order_customer_id` int(11) NOT NULL,
  `order_date` datetime NOT NULL,
  `order_paid` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`order_id`, `order_customer_id`, `order_date`, `order_paid`) VALUES
(1, 101, '2023-11-05 12:54:15', 1),
(2, 102, '2023-10-08 07:23:51', 0),
(3, 108, '2023-01-05 23:04:22', 0),
(4, 102, '2023-10-07 11:43:01', 0),
(5, 107, '2023-11-05 20:45:21', 1),
(6, 111, '2023-10-08 22:42:51', 1),
(7, 108, '2023-04-02 06:49:12', 1),
(8, 105, '2023-08-07 12:30:52', 0);

-- --------------------------------------------------------

--
-- Table structure for table `order_lines`
--

CREATE TABLE `order_lines` (
  `order_line_id` int(11) NOT NULL,
  `order_line_order_id` int(11) NOT NULL,
  `order_line_product_id` int(11) NOT NULL,
  `order_line_quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `order_lines`
--

INSERT INTO `order_lines` (`order_line_id`, `order_line_order_id`, `order_line_product_id`, `order_line_quantity`) VALUES
(1, 1, 1001, 4),
(2, 1, 1002, 1),
(3, 2, 1003, 1),
(4, 2, 1004, 2),
(5, 3, 2001, 3),
(6, 3, 2002, 1),
(7, 3, 1006, 1),
(8, 3, 1004, 2),
(9, 4, 1003, 1),
(10, 4, 2002, 2),
(11, 4, 1006, 1),
(12, 4, 1002, 1),
(13, 5, 2002, 10),
(14, 6, 1003, 2),
(15, 6, 1005, 1),
(16, 7, 2001, 5),
(17, 7, 2002, 3),
(18, 7, 1005, 1),
(19, 8, 1004, 1);

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `product_id` int(11) NOT NULL,
  `product_name` varchar(50) NOT NULL,
  `product_category` varchar(50) DEFAULT NULL,
  `product_price` decimal(8,2) NOT NULL,
  `product_instock` tinyint(4) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`product_id`, `product_name`, `product_category`, `product_price`, `product_instock`) VALUES
(1001, 'Citroenpers', 'Keukengereedschap', 22.50, 38),
(1002, 'Koffieautomaat \"Cello\"', 'Koffiecorner', 499.00, 4),
(1003, 'Broodmachine', 'Keukengereedschap', 87.50, 5),
(1004, 'Messenset XL', 'Keukengereedschap', 145.50, 21),
(1005, 'Keukenschaal Rood', 'Keukengereedschap', 42.80, 23),
(1006, 'Broodmachine Basic', 'Keukengereedschap', 67.00, 5),
(2001, 'Longdrinkglazen rond 6 st', 'Serviesgoed', 23.95, 20),
(2002, 'Drinkbekers wit 3 st', 'Serviesgoed', 8.99, 43);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`customer_id`) USING BTREE;

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`order_id`);

--
-- Indexes for table `order_lines`
--
ALTER TABLE `order_lines`
  ADD PRIMARY KEY (`order_line_id`) USING BTREE;

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`product_id`) USING BTREE;

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `customer_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=116;

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `order_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `order_lines`
--
ALTER TABLE `order_lines`
  MODIFY `order_line_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `product_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2009;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
