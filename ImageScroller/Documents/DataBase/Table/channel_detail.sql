-- phpMyAdmin SQL Dump
-- version 4.8.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 25, 2018 at 08:50 AM
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
-- Table structure for table `channel_detail`
--

CREATE TABLE `channel_detail` (
  `Channel_ID` int(11) NOT NULL,
  `Channel_name` varchar(255) DEFAULT NULL,
  `path_Video` varchar(255) DEFAULT NULL,
  `path_Snapshot` varchar(255) DEFAULT NULL,
  `date_time` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Project_ID` int(11) NOT NULL,
  `img_Format` varchar(15) DEFAULT NULL,
  `file_Type` varchar(15) DEFAULT NULL,
  `file_VideoName` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `channel_detail`
--

INSERT INTO `channel_detail` (`Channel_ID`, `Channel_name`, `path_Video`, `path_Snapshot`, `date_time`, `Project_ID`, `img_Format`, `file_Type`, `file_VideoName`) VALUES
(534, 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1\\System_SnapShot\\1', '2018-07-23 18:45:02', 193, 'Number', 'jpg', '1.mp4'),
(535, 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1\\System_SnapShot\\2', '2018-07-23 18:48:41', 193, 'Number', 'jpg', '2.mp4'),
(536, 'Channel_3', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1\\System_SnapShot\\3', '2018-07-23 18:51:22', 193, 'Number', 'jpg', '3.mp4');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `channel_detail`
--
ALTER TABLE `channel_detail`
  ADD PRIMARY KEY (`Channel_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `channel_detail`
--
ALTER TABLE `channel_detail`
  MODIFY `Channel_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=537;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
