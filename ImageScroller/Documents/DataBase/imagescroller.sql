-- phpMyAdmin SQL Dump
-- version 4.8.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 27, 2018 at 02:05 PM
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


-- --------------------------------------------------------

--
-- Table structure for table `project_detail`
--

CREATE TABLE `project_detail` (
  `Project_ID` int(11) NOT NULL,
  `Project_name` varchar(255) NOT NULL,
  `computer_IP` varbinary(100) NOT NULL,
  `Project_Type` varchar(255) NOT NULL,
  `date_time` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


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
  `Path_VideoTag` varchar(255) NOT NULL,
  `date_time` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


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

-- --------------------------------------------------------

--
-- Table structure for table `tag_type`
--

CREATE TABLE `tag_type` (
  `TagType_Id` int(11) NOT NULL,
  `TagType_name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tag_type`
--

INSERT INTO `tag_type` (`TagType_Id`, `TagType_name`) VALUES
(1, 'WareHouse'),
(2, 'Retail'),
(3, 'IT');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `channel_detail`
--
ALTER TABLE `channel_detail`
  ADD PRIMARY KEY (`Channel_ID`);

--
-- Indexes for table `project_detail`
--
ALTER TABLE `project_detail`
  ADD PRIMARY KEY (`Project_ID`);

--
-- Indexes for table `project_tag`
--
ALTER TABLE `project_tag`
  ADD PRIMARY KEY (`ProReason_Id`);

--
-- Indexes for table `tag_reason`
--
ALTER TABLE `tag_reason`
  ADD PRIMARY KEY (`TagReason_Id`);

--
-- AUTO_INCREMENT for dumped tables
--


/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
