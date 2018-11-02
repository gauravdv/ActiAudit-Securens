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
-- Table structure for table `project_tag`
--

CREATE TABLE `project_tag` (
  `ProReason_Id` int(11) NOT NULL,
  `tag_type` varchar(255) NOT NULL,
  `Path_type` varchar(255) NOT NULL,
  `tag_reason` varchar(255) NOT NULL,
  `Path_reason` varchar(255) NOT NULL,
  `Project_id` int(100) NOT NULL,
  `tag_image` varchar(255) NOT NULL,
  `Path_ChannelTag` varchar(255) NOT NULL,
  `Channel_Name` varchar(255) NOT NULL,
  `Path_SysVideo` varchar(255) NOT NULL,
  `Path_VideoTag` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `project_tag`
--

INSERT INTO `project_tag` (`ProReason_Id`, `tag_type`, `Path_type`, `tag_reason`, `Path_reason`, `Project_id`, `tag_image`, `Path_ChannelTag`, `Channel_Name`, `Path_SysVideo`, `Path_VideoTag`) VALUES
(197, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1\\User_SnapShot\\IT', 'Cleanning Issues', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1\\User_SnapShot\\Cleanning Issues', 193, '00037.jpg,00038.jpg,00039.jpg,00040.jpg,00041.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1\\User_SnapShot\\Cleanning Issues\\Channel_1', 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1\\Create_Video\\Cleanning Issues\\Channel_1'),
(198, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1\\User_SnapShot\\IT', 'Cleanning Issues', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1\\User_SnapShot\\Cleanning Issues', 193, '00037.jpg,00038.jpg,00039.jpg,00040.jpg,00041.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1\\User_SnapShot\\Cleanning Issues\\Channel_2', 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1\\Create_Video\\Cleanning Issues\\Channel_2'),
(199, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1\\User_SnapShot\\IT', 'Cleanning Issues', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1\\User_SnapShot\\Cleanning Issues', 193, '00037.jpg,00038.jpg,00039.jpg,00040.jpg,00041.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1\\User_SnapShot\\Cleanning Issues\\Channel_3', 'Channel_3', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1\\Create_Video\\Cleanning Issues\\Channel_3'),
(200, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1\\User_SnapShot\\IT', 'Computer Not Start', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1\\User_SnapShot\\Computer Not Start', 193, '00088.jpg,00089.jpg,00090.jpg,00091.jpg,00092.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1\\User_SnapShot\\Computer Not Start\\Channel_1', 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1\\Create_Video\\Computer Not Start\\Channel_1'),
(201, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1\\User_SnapShot\\IT', 'Computer Not Start', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1\\User_SnapShot\\Computer Not Start', 193, '00088.jpg,00089.jpg,00090.jpg,00091.jpg,00092.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1\\User_SnapShot\\Computer Not Start\\Channel_3', 'Channel_3', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1\\Create_Video\\Computer Not Start\\Channel_3'),
(202, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1\\User_SnapShot\\IT', 'Foot Print', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1\\User_SnapShot\\Foot Print', 193, '00119.jpg,00120.jpg,00121.jpg,00122.jpg,00123.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1\\User_SnapShot\\Foot Print\\Channel_3', 'Channel_3', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\193-BB 1\\Create_Video\\Foot Print\\Channel_3');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `project_tag`
--
ALTER TABLE `project_tag`
  ADD PRIMARY KEY (`ProReason_Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `project_tag`
--
ALTER TABLE `project_tag`
  MODIFY `ProReason_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=203;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
