-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 10, 2018 at 03:07 PM
-- Server version: 10.1.34-MariaDB
-- PHP Version: 7.2.7

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
(2, 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\System_SnapShot\\1', '2018-07-30 17:37:57', 3, 'Number', 'jpg', '1.mp4'),
(3, 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\System_SnapShot\\2', '2018-07-30 17:48:00', 3, 'Number', 'jpg', '2.mp4'),
(4, 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\4-BB 2\\System_SnapShot\\1', '2018-07-31 16:23:17', 4, 'Number', 'jpg', '1.mp4'),
(5, 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\4-BB 2\\System_SnapShot\\2', '2018-07-31 16:23:25', 4, 'Number', 'jpg', '2.mp4'),
(6, 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3\\System_SnapShot\\1', '2018-08-01 18:53:03', 5, 'Number', 'jpg', '1.mp4'),
(7, 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3\\System_SnapShot\\2', '2018-08-01 18:54:03', 5, 'Number', 'jpg', '2.mp4'),
(8, 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\System_SnapShot\\1', '2018-08-02 12:12:52', 6, 'Number', 'jpg', '1.mp4'),
(9, 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\System_SnapShot\\2', '2018-08-02 12:17:01', 6, 'Number', 'jpg', '2.mp4'),
(10, 'Channel_3', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\System_SnapShot\\3', '2018-08-02 12:23:10', 6, 'Number', 'jpg', '3.mp4'),
(11, 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\7-BB 4\\System_SnapShot\\A1', '2018-08-02 19:15:42', 7, 'Number', 'jpg', 'A1.mp4'),
(12, 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\7-BB 4\\System_SnapShot\\A2', '2018-08-02 19:15:47', 7, 'Number', 'jpg', 'A2.mp4'),
(13, 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\8-BB 5\\System_SnapShot\\A1', '2018-08-03 16:47:36', 8, 'Number', 'jpg', 'A1.mp4'),
(14, 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\8-BB 5\\System_SnapShot\\A2', '2018-08-03 16:47:37', 8, 'Number', 'jpg', 'A2.mp4'),
(15, 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\9-BB 6\\System_SnapShot\\A1', '2018-08-03 18:40:52', 9, 'Number', 'jpg', 'A1.mp4'),
(16, 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\9-BB 6\\System_SnapShot\\A2', '2018-08-03 18:42:19', 9, 'Number', 'jpg', 'A2.mp4'),
(17, 'Channel_3', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\9-BB 6\\System_SnapShot\\A1', '2018-08-03 18:43:43', 9, 'Number', 'jpg', 'A1.mp4'),
(18, 'Channel_4', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\9-BB 6\\System_SnapShot\\A2', '2018-08-03 18:43:48', 9, 'Number', 'jpg', 'A2.mp4'),
(19, 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\10-BB 7\\System_SnapShot\\A1', '2018-08-07 14:48:27', 10, 'Number', 'jpg', 'A1.mp4'),
(20, 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\10-BB 7\\System_SnapShot\\A2', '2018-08-07 14:50:24', 10, 'Number', 'jpg', 'A2.mp4'),
(21, 'Channel_3', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\10-BB 7\\System_SnapShot\\A2', '2018-08-07 14:50:27', 10, 'Number', 'jpg', 'A2.mp4'),
(22, 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\System_SnapShot\\A1', '2018-08-08 12:05:18', 11, 'Number', 'jpg', 'A1.mp4'),
(23, 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\System_SnapShot\\A2', '2018-08-08 12:05:22', 11, 'Number', 'jpg', 'A2.mp4'),
(24, 'Channel_3', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\System_SnapShot\\A1', '2018-08-08 12:05:25', 11, 'Number', 'jpg', 'A1.mp4'),
(25, 'Channel_4', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\System_SnapShot\\A2', '2018-08-08 12:05:29', 11, 'Number', 'jpg', 'A2.mp4'),
(26, 'Channel_5', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\System_SnapShot\\A1', '2018-08-08 12:05:32', 11, 'Number', 'jpg', 'A1.mp4'),
(27, 'Channel_6', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\System_SnapShot\\A2', '2018-08-08 12:05:34', 11, 'Number', 'jpg', 'A2.mp4'),
(28, 'Channel_7', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\System_SnapShot\\A1', '2018-08-08 12:05:38', 11, 'Number', 'jpg', 'A1.mp4'),
(29, 'Channel_8', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\System_SnapShot\\A2', '2018-08-08 12:05:40', 11, 'Number', 'jpg', 'A2.mp4'),
(30, 'Channel_9', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\System_SnapShot\\A1', '2018-08-08 12:05:43', 11, 'Number', 'jpg', 'A1.mp4'),
(31, 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\12-AA-3\\System_SnapShot\\A1', '2018-08-08 18:46:42', 12, 'Number', 'jpg', 'A1.mp4'),
(32, 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\12-AA-3\\System_SnapShot\\A2', '2018-08-08 18:46:45', 12, 'Number', 'jpg', 'A2.mp4'),
(33, 'Channel_3', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\12-AA-3\\System_SnapShot\\A1', '2018-08-08 18:46:49', 12, 'Number', 'jpg', 'A1.mp4'),
(34, 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\20-BB 8\\System_SnapShot\\A1', '2018-08-09 17:21:30', 20, 'Number', 'jpg', 'A1.mp4'),
(35, 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\20-BB 8\\System_SnapShot\\A2', '2018-08-09 17:21:34', 20, 'Number', 'jpg', 'A2.mp4'),
(36, 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\System_SnapShot\\A1', '2018-08-10 14:57:07', 14, 'Number', 'jpg', 'A1.mp4'),
(37, 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\System_SnapShot\\A2', '2018-08-10 14:57:10', 14, 'Number', 'jpg', 'A2.mp4'),
(38, 'Channel_3', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\System_SnapShot\\A2', '2018-08-10 15:00:41', 14, 'Number', 'jpg', 'A2.mp4'),
(39, 'Channel_4', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\System_SnapShot\\A2', '2018-08-10 15:00:44', 14, 'Number', 'jpg', 'A2.mp4'),
(40, 'Channel_5', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\System_SnapShot\\A2', '2018-08-10 15:02:25', 14, 'Number', 'jpg', 'A2.mp4'),
(41, 'Channel_6', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\System_SnapShot\\A2', '2018-08-10 15:02:28', 14, 'Number', 'jpg', 'A2.mp4'),
(42, 'Channel_7', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\System_SnapShot\\A2', '2018-08-10 15:02:31', 14, 'Number', 'jpg', 'A2.mp4'),
(43, 'Channel_8', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\System_SnapShot\\A2', '2018-08-10 15:02:34', 14, 'Number', 'jpg', 'A2.mp4'),
(44, 'Channel_9', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\System_SnapShot\\A2', '2018-08-10 15:02:37', 14, 'Number', 'jpg', 'A2.mp4');

-- --------------------------------------------------------

--
-- Table structure for table `project_detail`
--

CREATE TABLE `project_detail` (
  `Project_ID` int(11) NOT NULL,
  `Project_name` varchar(255) NOT NULL,
  `computer_IP` varbinary(100) NOT NULL,
  `Project_Type` varchar(255) NOT NULL,
  `Scroll_Index` int(255) DEFAULT NULL,
  `date_time` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `project_detail`
--

INSERT INTO `project_detail` (`Project_ID`, `Project_name`, `computer_IP`, `Project_Type`, `Scroll_Index`, `date_time`) VALUES
(3, 'BB 1', 0x3139322e3136382e312e3530, 'IT', 0, '2018-07-30 17:37:44'),
(4, 'BB 2', 0x3139322e3136382e312e3530, 'WareHouse', 0, '2018-07-31 16:23:07'),
(5, 'BB 3', 0x3139322e3136382e312e3530, 'Retail', 342, '2018-08-01 18:52:55'),
(6, 'BB Test', 0x3139322e3136382e312e3530, 'WareHouse', 56, '2018-08-02 12:12:38'),
(8, 'BB 5', 0x3139322e3136382e312e3530, 'IT', 0, '2018-08-03 16:43:51'),
(10, 'BB 7', 0x3139322e3136382e312e3530, 'Retail', 1, '2018-08-07 14:48:07'),
(11, 'AA-9', 0x3139322e3136382e312e3530, 'IT', 0, '2018-08-08 12:04:19'),
(12, 'AA-3', 0x3139322e3136382e312e3530, 'Retail', 0, '2018-08-08 18:46:23'),
(13, 'ZZ1', 0x3139322e3136382e312e3530, 'IT', 0, '2018-08-09 12:31:47'),
(14, 'ZZ2', 0x3139322e3136382e312e3530, 'Retail', 0, '2018-08-09 12:35:43'),
(15, 'ZZ3', 0x3139322e3136382e312e3530, 'WareHouse', 0, '2018-08-09 12:36:16'),
(16, 'ZZ4', 0x3139322e3136382e312e3530, 'Retail', 0, '2018-08-09 12:41:43'),
(17, 'ZZ', 0x3139322e3136382e312e3530, 'WareHouse', 0, '2018-08-09 12:44:29'),
(19, 'ZZ5', 0x3139322e3136382e312e3530, 'Retail', 0, '2018-08-09 12:45:41'),
(20, 'BB 8', 0x3139322e3136382e312e3530, 'Retail', 0, '2018-08-09 17:21:18'),
(21, 'XXX', 0x3139322e3136382e312e3530, 'Retail', 1, '2018-08-09 19:08:16'),
(22, 'ZZ6', 0x3139322e3136382e312e3530, 'Retail', 1, '2018-08-10 13:45:12');

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

--
-- Dumping data for table `project_tag`
--

INSERT INTO `project_tag` (`ProReason_Id`, `tag_type`, `Path_type`, `tag_reason`, `Path_reason`, `Project_id`, `tag_image`, `Path_ChannelTag`, `Channel_Name`, `Path_SysVideo`, `Path_VideoTag`, `date_time`) VALUES
(1, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\IT', 'Computer Not Start', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Computer Not Start', 3, '00068.jpg;00069.jpg;00070.jpg;00071.jpg;00072.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Computer Not Start\\Channel_1', 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\Create_Video\\Computer Not Start\\Channel_1', '2018-07-30 17:55:00'),
(2, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\IT', 'Computer Not Start', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Computer Not Start', 3, '00068.jpg;00069.jpg;00070.jpg;00071.jpg;00072.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Computer Not Start\\Channel_2', 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\Create_Video\\Computer Not Start\\Channel_2', '2018-07-30 17:55:00'),
(3, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\IT', 'Foot Print', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Foot Print', 3, '00173.jpg;00174.jpg;00175.jpg;00176.jpg;00177.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Foot Print\\Channel_1', 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\Create_Video\\Foot Print\\Channel_1', '2018-07-30 17:55:24'),
(4, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\IT', 'Foot Print', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Foot Print', 3, '00173.jpg;00174.jpg;00175.jpg;00176.jpg;00177.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Foot Print\\Channel_2', 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\Create_Video\\Foot Print\\Channel_2', '2018-07-30 17:55:24'),
(5, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\IT', 'Not Wearing Id', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Not Wearing Id', 3, '00039.jpg;00040.jpg;00041.jpg;00042.jpg;00043.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Not Wearing Id\\Channel_1', 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\Create_Video\\Not Wearing Id\\Channel_1', '2018-07-31 18:33:02'),
(6, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\IT', 'Not Wearing Id', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Not Wearing Id', 3, '00039.jpg;00040.jpg;00041.jpg;00042.jpg;00043.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Not Wearing Id\\Channel_2', 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\Create_Video\\Not Wearing Id\\Channel_2', '2018-07-31 18:33:03'),
(7, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\IT', 'Try', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Try', 3, '00254.jpg;00255.jpg;00256.jpg;00257.jpg;00258.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Try\\Channel_1', 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\Create_Video\\Try\\Channel_1', '2018-07-31 18:33:25'),
(8, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\IT', 'Try', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Try', 3, '00254.jpg;00255.jpg;00256.jpg;00257.jpg;00258.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Try\\Channel_2', 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\Create_Video\\Try\\Channel_2', '2018-07-31 18:33:25'),
(9, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\IT', 'Foot Print', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Foot Print', 3, '00177.jpg;00178.jpg;00179.jpg;00180.jpg;00181.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Foot Print\\Channel_1', 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\Create_Video\\Foot Print\\Channel_1', '2018-08-01 18:18:15'),
(10, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\IT', 'Foot Print', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Foot Print', 3, '00177.jpg;00178.jpg;00179.jpg;00180.jpg;00181.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Foot Print\\Channel_2', 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\Create_Video\\Foot Print\\Channel_2', '2018-08-01 18:18:15'),
(11, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\IT', 'Foot Print', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Foot Print', 3, '00282.jpg;00283.jpg;00284.jpg;00285.jpg;00286.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Foot Print\\Channel_1', 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\Create_Video\\Foot Print\\Channel_1', '2018-08-01 18:18:48'),
(12, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\IT', 'Foot Print', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Foot Print', 3, '00282.jpg;00283.jpg;00284.jpg;00285.jpg;00286.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Foot Print\\Channel_2', 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\Create_Video\\Foot Print\\Channel_2', '2018-08-01 18:18:48'),
(13, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\IT', 'Not Wearing Id', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Not Wearing Id', 3, '00307.jpg;00308.jpg;00309.jpg;00310.jpg;00311.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Not Wearing Id\\Channel_1', 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\Create_Video\\Not Wearing Id\\Channel_1', '2018-08-01 18:19:26'),
(14, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\IT', 'Not Wearing Id', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Not Wearing Id', 3, '00307.jpg;00308.jpg;00309.jpg;00310.jpg;00311.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Not Wearing Id\\Channel_2', 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\Create_Video\\Not Wearing Id\\Channel_2', '2018-08-01 18:19:26'),
(15, 'WareHouse', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\4-BB 2\\User_SnapShot\\WareHouse', 'Computer Not Start', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\4-BB 2\\User_SnapShot\\Computer Not Start', 4, '00038.jpg;00039.jpg;00040.jpg;00041.jpg;00042.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\4-BB 2\\User_SnapShot\\Computer Not Start\\Channel_1', 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\4-BB 2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\4-BB 2\\Create_Video\\Computer Not Start\\Channel_1', '2018-08-01 18:40:33'),
(16, 'WareHouse', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\4-BB 2\\User_SnapShot\\WareHouse', 'Computer Not Start', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\4-BB 2\\User_SnapShot\\Computer Not Start', 4, '00038.jpg;00039.jpg;00040.jpg;00041.jpg;00042.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\4-BB 2\\User_SnapShot\\Computer Not Start\\Channel_2', 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\4-BB 2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\4-BB 2\\Create_Video\\Computer Not Start\\Channel_2', '2018-08-01 18:40:33'),
(17, 'WareHouse', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\4-BB 2\\User_SnapShot\\WareHouse', 'Not Wearing Id', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\4-BB 2\\User_SnapShot\\Not Wearing Id', 4, '00041.jpg;00042.jpg;00043.jpg;00044.jpg;00045.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\4-BB 2\\User_SnapShot\\Not Wearing Id\\Channel_1', 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\4-BB 2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\4-BB 2\\Create_Video\\Not Wearing Id\\Channel_1', '2018-08-01 18:41:01'),
(18, 'WareHouse', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\4-BB 2\\User_SnapShot\\WareHouse', 'Not Wearing Id', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\4-BB 2\\User_SnapShot\\Not Wearing Id', 4, '00041.jpg;00042.jpg;00043.jpg;00044.jpg;00045.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\4-BB 2\\User_SnapShot\\Not Wearing Id\\Channel_2', 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\4-BB 2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\4-BB 2\\Create_Video\\Not Wearing Id\\Channel_2', '2018-08-01 18:41:01'),
(19, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\IT', 'Try', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Try', 3, '00009.jpg;00010.jpg;00011.jpg;00012.jpg;00013.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Try\\Channel_1', 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\Create_Video\\Try\\Channel_1', '2018-08-01 18:41:24'),
(20, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\IT', 'Try', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Try', 3, '00009.jpg;00010.jpg;00011.jpg;00012.jpg;00013.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\User_SnapShot\\Try\\Channel_2', 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\3-BB 1\\Create_Video\\Try\\Channel_2', '2018-08-01 18:41:24'),
(21, 'Retail', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3\\User_SnapShot\\Retail', 'Computer Not Start', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3\\User_SnapShot\\Computer Not Start', 5, '00005.jpg;00006.jpg;00007.jpg;00008.jpg;00009.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3\\User_SnapShot\\Computer Not Start\\Channel_1', 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3\\User_SnapShot\\Computer Not Start\\Channel_1', '2018-08-01 18:57:20'),
(22, 'Retail', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3\\User_SnapShot\\Retail', 'Cleanning Issues', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3\\User_SnapShot\\Cleanning Issues', 5, '00004.jpg;00005.jpg;00006.jpg;00007.jpg;00008.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3\\User_SnapShot\\Cleanning Issues\\Channel_1', 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3\\User_SnapShot\\Cleanning Issues\\Channel_1', '2018-08-01 19:20:52'),
(23, 'Retail', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3\\User_SnapShot\\Retail', 'Cleanning Issues', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3\\User_SnapShot\\Cleanning Issues', 5, '00044.jpg;00045.jpg;00046.jpg;00047.jpg;00048.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3\\User_SnapShot\\Cleanning Issues\\Channel_2', 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3\\User_SnapShot\\Cleanning Issues\\Channel_2', '2018-08-02 11:51:03'),
(24, 'Retail', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3\\User_SnapShot\\Retail', 'Try', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3\\User_SnapShot\\Try', 5, '00305.jpg;00306.jpg;00307.jpg;00308.jpg;00309.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3\\User_SnapShot\\Try\\Channel_1', 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3\\User_SnapShot\\Try\\Channel_1', '2018-08-02 12:03:15'),
(25, 'Retail', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3\\User_SnapShot\\Retail', 'Try', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3\\User_SnapShot\\Try', 5, '00305.jpg;00306.jpg;00307.jpg;00308.jpg;00309.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3\\User_SnapShot\\Try\\Channel_2', 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3\\User_SnapShot\\Try\\Channel_2', '2018-08-02 12:03:15'),
(26, 'Retail', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3\\User_SnapShot\\Retail', 'door not close properly', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3\\User_SnapShot\\door not close properly', 5, '00335.jpg;00336.jpg;00337.jpg;00338.jpg;00339.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3\\User_SnapShot\\door not close properly\\Channel_1', 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\5-BB 3\\User_SnapShot\\door not close properly\\Channel_1', '2018-08-02 12:11:12'),
(27, 'WareHouse', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\WareHouse', 'Cleanning Issues', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\Cleanning Issues', 6, '00007.jpg;00008.jpg;00009.jpg;00010.jpg;00011.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\Cleanning Issues\\Channel_2', 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\Cleanning Issues\\Channel_2', '2018-08-02 12:56:58'),
(28, 'WareHouse', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\WareHouse', 'door not close properly', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\door not close properly', 6, '00047.jpg;00048.jpg;00049.jpg;00050.jpg;00051.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\door not close properly\\Channel_2', 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\door not close properly\\Channel_2', '2018-08-02 13:04:39'),
(29, 'WareHouse', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\WareHouse', 'Try', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\Try', 6, '01809.jpg;01810.jpg;01811.jpg;01812.jpg;01813.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\Try\\Channel_3', 'Channel_3', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\Try\\Channel_3', '2018-08-02 13:06:15'),
(30, 'WareHouse', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\WareHouse', 'door not close properly', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\door not close properly', 6, '01854.jpg;01855.jpg;01856.jpg;01857.jpg;01858.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\door not close properly\\Channel_1', 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\door not close properly\\Channel_1', '2018-08-02 15:12:06'),
(31, 'Retail', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\9-BB 6\\User_SnapShot\\Retail', 'Computer Not Start', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\9-BB 6\\User_SnapShot\\Computer Not Start', 9, '00001.jpg;00002.jpg;00003.jpg;00004.jpg;00005.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\9-BB 6\\User_SnapShot\\Computer Not Start\\Channel_2', 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\9-BB 6', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\9-BB 6\\User_SnapShot\\Computer Not Start\\Channel_2', '2018-08-04 14:15:31'),
(32, 'WareHouse', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\WareHouse', 'door not close properly', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\door not close properly', 6, '00022.jpg;00023.jpg;00024.jpg;00025.jpg;00026.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\door not close properly\\Channel_1', 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\door not close properly\\Channel_1', '2018-08-07 15:11:30'),
(33, 'WareHouse', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\WareHouse', 'door not close properly', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\door not close properly', 6, '00022.jpg;00023.jpg;00024.jpg;00025.jpg;00026.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\door not close properly\\Channel_2', 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\door not close properly\\Channel_2', '2018-08-07 15:11:30'),
(34, 'WareHouse', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\WareHouse', 'door not close properly', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\door not close properly', 6, '00001.jpg;00002.jpg;00003.jpg;00004.jpg;00005.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\door not close properly\\Channel_1', 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\door not close properly\\Channel_1', '2018-08-08 12:11:29'),
(35, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\IT', 'Try', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\Try', 11, '00001.jpg;00002.jpg;00003.jpg;00004.jpg;00005.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\Try\\Channel_1', 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\Try\\Channel_1', '2018-08-08 13:30:38'),
(36, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\IT', 'Try', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\Try', 11, '00001.jpg;00002.jpg;00003.jpg;00004.jpg;00005.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\Try\\Channel_2', 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\Try\\Channel_2', '2018-08-08 13:30:39'),
(37, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\IT', 'Try', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\Try', 11, '00001.jpg;00002.jpg;00003.jpg;00004.jpg;00005.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\Try\\Channel_3', 'Channel_3', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\Try\\Channel_3', '2018-08-08 13:30:39'),
(38, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\IT', 'Try', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\Try', 11, '00001.jpg;00002.jpg;00003.jpg;00004.jpg;00005.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\Try\\Channel_4', 'Channel_4', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\Try\\Channel_4', '2018-08-08 13:30:39'),
(39, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\IT', 'Try', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\Try', 11, '00001.jpg;00002.jpg;00003.jpg;00004.jpg;00005.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\Try\\Channel_5', 'Channel_5', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\Try\\Channel_5', '2018-08-08 13:30:39'),
(40, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\IT', 'Try', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\Try', 11, '00001.jpg;00002.jpg;00003.jpg;00004.jpg;00005.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\Try\\Channel_6', 'Channel_6', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\Try\\Channel_6', '2018-08-08 13:30:39'),
(41, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\IT', 'Try', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\Try', 11, '00001.jpg;00002.jpg;00003.jpg;00004.jpg;00005.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\Try\\Channel_7', 'Channel_7', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\Try\\Channel_7', '2018-08-08 13:30:39'),
(42, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\IT', 'Try', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\Try', 11, '00001.jpg;00002.jpg;00003.jpg;00004.jpg;00005.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\Try\\Channel_8', 'Channel_8', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\Try\\Channel_8', '2018-08-08 13:30:39'),
(43, 'IT', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\IT', 'Try', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\Try', 11, '00001.jpg;00002.jpg;00003.jpg;00004.jpg;00005.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\Try\\Channel_9', 'Channel_9', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\11-AA-9\\User_SnapShot\\Try\\Channel_9', '2018-08-08 13:30:39'),
(44, 'Retail', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Retail', 'Foot Print', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Foot Print', 14, '00001.jpg;00002.jpg;00003.jpg;00004.jpg;00005.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Foot Print\\Channel_1', 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Foot Print\\Channel_1', '2018-08-10 15:15:07'),
(45, 'Retail', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Retail', 'Foot Print', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Foot Print', 14, '00001.jpg;00002.jpg;00003.jpg;00004.jpg;00005.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Foot Print\\Channel_2', 'Channel_2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Foot Print\\Channel_2', '2018-08-10 15:15:07'),
(46, 'Retail', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Retail', 'Foot Print', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Foot Print', 14, '00001.jpg;00002.jpg;00003.jpg;00004.jpg;00005.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Foot Print\\Channel_3', 'Channel_3', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Foot Print\\Channel_3', '2018-08-10 15:15:07'),
(47, 'Retail', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Retail', 'Foot Print', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Foot Print', 14, '00001.jpg;00002.jpg;00003.jpg;00004.jpg;00005.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Foot Print\\Channel_4', 'Channel_4', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Foot Print\\Channel_4', '2018-08-10 15:15:07'),
(48, 'Retail', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Retail', 'Foot Print', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Foot Print', 14, '00001.jpg;00002.jpg;00003.jpg;00004.jpg;00005.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Foot Print\\Channel_5', 'Channel_5', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Foot Print\\Channel_5', '2018-08-10 15:15:07'),
(49, 'Retail', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Retail', 'Foot Print', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Foot Print', 14, '00001.jpg;00002.jpg;00003.jpg;00004.jpg;00005.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Foot Print\\Channel_6', 'Channel_6', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Foot Print\\Channel_6', '2018-08-10 15:15:07'),
(50, 'Retail', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Retail', 'Foot Print', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Foot Print', 14, '00001.jpg;00002.jpg;00003.jpg;00004.jpg;00005.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Foot Print\\Channel_7', 'Channel_7', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Foot Print\\Channel_7', '2018-08-10 15:15:07'),
(51, 'Retail', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Retail', 'Foot Print', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Foot Print', 14, '00001.jpg;00002.jpg;00003.jpg;00004.jpg;00005.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Foot Print\\Channel_8', 'Channel_8', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Foot Print\\Channel_8', '2018-08-10 15:15:07'),
(52, 'Retail', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Retail', 'Foot Print', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Foot Print', 14, '00001.jpg;00002.jpg;00003.jpg;00004.jpg;00005.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Foot Print\\Channel_9', 'Channel_9', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\14-ZZ2\\User_SnapShot\\Foot Print\\Channel_9', '2018-08-10 15:15:07'),
(53, 'WareHouse', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\WareHouse', 'door not close properly', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\door not close properly', 6, '00052.jpg;00053.jpg;00054.jpg;00055.jpg;00056.jpg', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\door not close properly\\Channel_1', 'Channel_1', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test', 'C:\\_Gaurav\\C#\\ImageScroller\\MySql\\Acti Audit\\Testing Video\\6-BB Test\\User_SnapShot\\door not close properly\\Channel_1', '2018-08-10 16:13:10');

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
(7, 'Try'),
(8, 'door not close properly');

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

--
-- AUTO_INCREMENT for table `channel_detail`
--
ALTER TABLE `channel_detail`
  MODIFY `Channel_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;

--
-- AUTO_INCREMENT for table `project_detail`
--
ALTER TABLE `project_detail`
  MODIFY `Project_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `project_tag`
--
ALTER TABLE `project_tag`
  MODIFY `ProReason_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=54;

--
-- AUTO_INCREMENT for table `tag_reason`
--
ALTER TABLE `tag_reason`
  MODIFY `TagReason_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
