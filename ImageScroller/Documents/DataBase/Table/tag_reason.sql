-- phpMyAdmin SQL Dump
-- version 4.8.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 25, 2018 at 08:52 AM
-- Server version: 10.1.31-MariaDB
-- PHP Version: 7.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `imagescroller`
--

-- --------------------------------------------------------

--
-- Table structure for table `tag_reason`
--

CREATE TABLE `tag_reason` (
  `TagReason_Id` int(11) NOT NULL,
  `TagReason_name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tag_reason`
--

INSERT INTO `tag_reason` (`TagReason_Id`, `TagReason_name`) VALUES
(1, 'Not Wearing Id'),
(2, 'Cleanning Issues'),
(3, 'Computer Not Start'),
(4, 'Others'),
(5, 'Foot Print'),
(7, 'Try');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tag_reason`
--
ALTER TABLE `tag_reason`
  ADD PRIMARY KEY (`TagReason_Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tag_reason`
--
ALTER TABLE `tag_reason`
  MODIFY `TagReason_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
