-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 28, 2021 at 05:20 PM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `barangay_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `archive_officials`
--

CREATE TABLE `archive_officials` (
  `Name` varchar(50) NOT NULL,
  `AGE` char(2) NOT NULL,
  `BIRTHDATE` varchar(50) NOT NULL,
  `SEX` varchar(10) NOT NULL,
  `TERM` varchar(12) DEFAULT NULL,
  `STATUS` varchar(10) DEFAULT 'UNKNOWN',
  `POSITION` varchar(50) NOT NULL,
  `Citizenship` varchar(50) NOT NULL,
  `Educational Attainment` varchar(50) NOT NULL,
  `ImagePath` varchar(200) NOT NULL,
  `CONTACT` char(11) NOT NULL,
  `ImageName` varchar(100) NOT NULL,
  `Purok` varchar(50) NOT NULL,
  `Address` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `archive_officials`
--

INSERT INTO `archive_officials` (`Name`, `AGE`, `BIRTHDATE`, `SEX`, `TERM`, `STATUS`, `POSITION`, `Citizenship`, `Educational Attainment`, `ImagePath`, `CONTACT`, `ImageName`, `Purok`, `Address`) VALUES
('okiedoc', '4', '24/03/2017', 'Female', 'none', 'Active', 'Barangay Captain', 'asffa', 'asd', 'C:\\Users\\Admin\\Desktop\\FinalsRepoJannRose\\BrgySystem\\BrgySystem\\BrgySystem\\bin\\Debug\\OfficialsImages\\backupform.png', '23123', 'backupform.png', 'asdasds', 'sdasg'),
('pedro', '4', '03/03/2017', 'Male', '3 years', 'Active', 'Barangay Councilor', 'Filipino', 'college', 'C:\\Users\\Admin\\Desktop\\FinalsRepoJannRose\\BrgySystem\\BrgySystem\\BrgySystem\\bin\\Debug\\OfficialsImages\\cali.jpg', '09123456789', 'cali.jpg', 'purok uno', 'Tanauan Batngas');

-- --------------------------------------------------------

--
-- Table structure for table `archive_purok`
--

CREATE TABLE `archive_purok` (
  `PurokName` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `archive_purok`
--

INSERT INTO `archive_purok` (`PurokName`) VALUES
('hello'),
('Purok E');

-- --------------------------------------------------------

--
-- Table structure for table `archive_residents`
--

CREATE TABLE `archive_residents` (
  `FULLNAME` varchar(75) NOT NULL,
  `SUFFIX` varchar(50) DEFAULT NULL,
  `SEX` varchar(10) NOT NULL,
  `BIRTHDATE` varchar(50) NOT NULL,
  `AGE` char(2) NOT NULL,
  `OCCUPATION` varchar(50) NOT NULL,
  `RELIGION` varchar(30) NOT NULL,
  `Educational Attainment` varchar(50) NOT NULL,
  `PUROK` varchar(100) NOT NULL,
  `ADDRESS` varchar(75) NOT NULL,
  `CIVIL_STATUS` varchar(100) NOT NULL,
  `REGISTERED_VOTER` varchar(5) NOT NULL,
  `CONTACT_NUMBER` char(11) NOT NULL,
  `CITIZENSHIP` varchar(50) NOT NULL,
  `IMAGEPATH` varchar(200) NOT NULL,
  `ImageName` varchar(100) NOT NULL,
  `SeniorCitizen` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `archive_residents`
--

INSERT INTO `archive_residents` (`FULLNAME`, `SUFFIX`, `SEX`, `BIRTHDATE`, `AGE`, `OCCUPATION`, `RELIGION`, `Educational Attainment`, `PUROK`, `ADDRESS`, `CIVIL_STATUS`, `REGISTERED_VOTER`, `CONTACT_NUMBER`, `CITIZENSHIP`, `IMAGEPATH`, `ImageName`, `SeniorCitizen`) VALUES
('Manny pacquiao', 'None', 'Female', '15/02/2013', '8', 'Senator', 'Roman Catholic', 'College', 'Purok Dos', 'Tanauan Batangas', 'Married', 'Yes ', '09123456754', 'Filipino', 'C:\\Users\\Admin\\Desktop\\FinalsRepoJannRose\\BrgySystem\\BrgySystem\\BrgySystem\\bin\\Debug\\ResidentsImages\\isko moreno.jpg', 'isko moreno.jpg', 'Yes');

-- --------------------------------------------------------

--
-- Table structure for table `barangaydetails`
--

CREATE TABLE `barangaydetails` (
  `ID` int(11) NOT NULL,
  `AdminName` varchar(50) NOT NULL,
  `Address` varchar(100) NOT NULL,
  `ContactNumber` varchar(40) NOT NULL,
  `BarangayCaptain` varchar(50) NOT NULL,
  `Zipcode` varchar(10) NOT NULL,
  `ImagePath` varchar(1000) NOT NULL,
  `ImageName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `barangaydetails`
--

INSERT INTO `barangaydetails` (`ID`, `AdminName`, `Address`, `ContactNumber`, `BarangayCaptain`, `Zipcode`, `ImagePath`, `ImageName`) VALUES
(1, 'Juan', 'Barangay 1 Tanauan City, Batangas', '09123456789', 'Gerry Bara', '4232', 'C:\\Users\\Admin\\Desktop\\FinalsRepoJannRose\\BrgySystem\\BrgySystem\\BrgySystem\\bin\\Debug\\BarangayDetails\\barangay1Logo.png', 'barangay1Logo.png');

-- --------------------------------------------------------

--
-- Table structure for table `clearance`
--

CREATE TABLE `clearance` (
  `TransactNo` bigint(20) NOT NULL,
  `Fullname` varchar(50) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Sex` varchar(10) NOT NULL,
  `Age` char(2) NOT NULL,
  `Quantity` int(100) NOT NULL,
  `DateAndTime` varchar(50) NOT NULL,
  `Given_By` varchar(50) NOT NULL,
  `Purpose` varchar(50) NOT NULL,
  `Type` varchar(50) NOT NULL,
  `Amount` int(255) NOT NULL,
  `Total` int(255) NOT NULL,
  `Business Name` varchar(50) NOT NULL,
  `Kind Of Business` varchar(50) NOT NULL,
  `Issued At` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `clearance`
--

INSERT INTO `clearance` (`TransactNo`, `Fullname`, `Address`, `Sex`, `Age`, `Quantity`, `DateAndTime`, `Given_By`, `Purpose`, `Type`, `Amount`, `Total`, `Business Name`, `Kind Of Business`, `Issued At`) VALUES
(202138984, 'Aling Pasing', 'Tanauan Batangas', 'Male ', '91', 3, '28/05/2021 11:05:08 pm', 'ADMIN', 'Employment', 'Barangay Business Clearance', 1000, 225, 'Foods', 'Foods', 'Tanauan Batangas');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `Username` varchar(25) NOT NULL,
  `Password` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`Username`, `Password`) VALUES
('Avocadorable', 'abcdefgh123');

-- --------------------------------------------------------

--
-- Table structure for table `mission_vision`
--

CREATE TABLE `mission_vision` (
  `id` int(11) NOT NULL,
  `Mission` varchar(500) NOT NULL,
  `Vision` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `mission_vision`
--

INSERT INTO `mission_vision` (`id`, `Mission`, `Vision`) VALUES
(1, 'TO FORGE TOTAL WELL-BEING OF POPULACE; TO PROMOTE PROGRESS THRU ENCOURAGEMENT OF THEIR PARTICIPATION AND COOPERATION IN A REALISTIC AND SUSTAINABLE SOCIO-CULTURAL, ECONOMICAL, ECOLOGICAL AND HUMAN DEVELOPMENT ENDEAVORS, AND THRU THE COLLABORATION OF DIFFERENT NGO’S AND CIVIC ORGANIZATIONS TOWARDS ECONOMICAL AND TECHNOLOGICAL ADVANCEMENT PROGRAMS WITH OTHER NEIGHBORING BARANGAYS.\n', 'A COMMUNITY OF HEALTHY AND HAPPY PEOPLE; COOPERATIVE AND PARTICIPATIVE, YET REMAINS TO BE SELF-RELIANT; LIVING IN A PEACEFUL, PROGRESSIVE AND ENVIRONMENT-FRIENDLY NEIGHBORHOOD THAT HAS AFFECTED CHANGE TOWARDS SUSTAINABLE DEVELOPMENT IN THE MUNICIPALITY.\n');

-- --------------------------------------------------------

--
-- Table structure for table `officials`
--

CREATE TABLE `officials` (
  `Name` varchar(50) NOT NULL,
  `AGE` char(2) NOT NULL,
  `BIRTHDATE` varchar(50) NOT NULL,
  `SEX` varchar(10) NOT NULL,
  `TERM` varchar(12) DEFAULT NULL,
  `STATUS` varchar(10) DEFAULT 'UNKNOWN',
  `POSITION` varchar(50) NOT NULL,
  `Citizenship` varchar(50) NOT NULL,
  `Educational Attainment` varchar(50) NOT NULL,
  `ImagePath` varchar(200) NOT NULL,
  `CONTACT` char(11) NOT NULL,
  `ImageName` varchar(100) NOT NULL,
  `Purok` varchar(50) NOT NULL,
  `Address` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `officials`
--

INSERT INTO `officials` (`Name`, `AGE`, `BIRTHDATE`, `SEX`, `TERM`, `STATUS`, `POSITION`, `Citizenship`, `Educational Attainment`, `ImagePath`, `CONTACT`, `ImageName`, `Purok`, `Address`) VALUES
('Juan', '17', '28/02/2004', 'Male', '3 years', 'Active', 'Barangay Captain', 'Tambay', 'College', 'C:\\Users\\Admin\\Desktop\\FinalsRepoJannRose\\BrgySystem\\BrgySystem\\BrgySystem\\bin\\Debug\\OfficialsImages\\unnamed.jpg', '09126453252', 'unnamed.jpg', 'New Purok', 'Tanauan Batangas'),
('Manny', '14', '01/03/2007', 'Male', '3 years', 'Active', 'Barangay Secretary', 'Filipino', 'College', 'C:\\Users\\Admin\\Desktop\\FinalsRepoJannRose\\BrgySystem\\BrgySystem\\BrgySystem\\bin\\Debug\\OfficialsImages\\9e4551b5-693c-4f75-9cb3-b6857f3226b0.jpeg', '09194341831', '9e4551b5-693c-4f75-9cb3-b6857f3226b0.jpeg', 'Bagong Purok', 'Tanauan Batangas'),
('Pedro De Jesus', '9', '28/03/2012', 'Male', '3 years', 'Active', 'SK Councilor', 'Filipino', 'High School', 'C:\\Users\\Admin\\Desktop\\FinalsRepoJannRose\\BrgySystem\\BrgySystem\\BrgySystem\\bin\\Debug\\OfficialsImages\\FUENTES-2X2-300x300.jpg', '09124323532', 'FUENTES-2X2-300x300.jpg', 'Purok Dos', 'Tanauan Batangas Poblacion Uno');

-- --------------------------------------------------------

--
-- Table structure for table `orgchart`
--

CREATE TABLE `orgchart` (
  `ID` int(50) NOT NULL,
  `Fullname` varchar(50) NOT NULL,
  `ImagePath` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `orgchart`
--

INSERT INTO `orgchart` (`ID`, `Fullname`, `ImagePath`) VALUES
(1, 'manny', 'C:\\Users\\Admin\\Desktop\\FinalsRepoJannRose\\BrgySystem\\BrgySystem\\BrgySystem\\bin\\Debug\\OfficialsImages\\9e4551b5-693c-4f75-9cb3-b6857f3226b0.jpeg'),
(2, 'Manny', 'C:\\Users\\Admin\\Desktop\\FinalsRepoJannRose\\BrgySystem\\BrgySystem\\BrgySystem\\bin\\Debug\\OfficialsImages\\9e4551b5-693c-4f75-9cb3-b6857f3226b0.jpeg'),
(3, '', ' '),
(4, '', ' '),
(5, '', ' '),
(6, '', ' '),
(7, '', ' '),
(8, '', ' '),
(9, '', ' '),
(10, '', ' '),
(11, '', ' '),
(12, 'Juan', 'C:\\Users\\Admin\\Desktop\\FinalsRepoJannRose\\BrgySystem\\BrgySystem\\BrgySystem\\bin\\Debug\\OfficialsImages\\unnamed.jpg'),
(13, '', ' ');

-- --------------------------------------------------------

--
-- Table structure for table `purok`
--

CREATE TABLE `purok` (
  `PurokName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `purok`
--

INSERT INTO `purok` (`PurokName`) VALUES
('Bagong Purok'),
('NEW PUROK'),
('Purok Tres'),
('Purok Uno');

-- --------------------------------------------------------

--
-- Table structure for table `residents`
--

CREATE TABLE `residents` (
  `FULLNAME` varchar(75) NOT NULL,
  `SUFFIX` varchar(50) DEFAULT NULL,
  `SEX` varchar(10) NOT NULL,
  `BIRTHDATE` varchar(50) NOT NULL,
  `AGE` char(2) NOT NULL,
  `OCCUPATION` varchar(50) NOT NULL,
  `RELIGION` varchar(30) NOT NULL,
  `Educational Attainment` varchar(50) NOT NULL,
  `PUROK` varchar(100) NOT NULL,
  `ADDRESS` varchar(75) NOT NULL,
  `CIVIL_STATUS` varchar(100) NOT NULL,
  `REGISTERED_VOTER` varchar(5) NOT NULL,
  `CONTACT_NUMBER` char(11) NOT NULL,
  `CITIZENSHIP` varchar(50) NOT NULL,
  `IMAGEPATH` varchar(200) NOT NULL,
  `ImageName` varchar(100) NOT NULL,
  `SeniorCitizen` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `residents`
--

INSERT INTO `residents` (`FULLNAME`, `SUFFIX`, `SEX`, `BIRTHDATE`, `AGE`, `OCCUPATION`, `RELIGION`, `Educational Attainment`, `PUROK`, `ADDRESS`, `CIVIL_STATUS`, `REGISTERED_VOTER`, `CONTACT_NUMBER`, `CITIZENSHIP`, `IMAGEPATH`, `ImageName`, `SeniorCitizen`) VALUES
('Aling Pasing', 'III', 'Male ', '28/05/1930', '91', 'Retired', 'Roman Catholic', 'College', 'Purok Uno', 'Tanauan Batangas', 'Widowed', 'Yes ', '09123414789', 'Filipino', 'C:\\Users\\Admin\\Desktop\\FinalsRepoJannRose\\BrgySystem\\BrgySystem\\BrgySystem\\bin\\Debug\\ResidentsImages\\1wrM4SVh_400x400.jpg', '1wrM4SVh_400x400.jpg', 'Yes'),
('Joselito Carandang', 'Sr', 'Male ', '01/02/2006', '15', 'Tambay', 'Muslim', 'College', 'Purok Sais', 'Tanauan Batangas', 'Widowed', 'No', '09126457892', 'Filipino', 'C:\\Users\\Admin\\Desktop\\FinalsRepoJannRose\\BrgySystem\\BrgySystem\\BrgySystem\\bin\\Debug\\ResidentsImages\\batas.jpg', 'batas.jpg', 'No'),
('Juan Tamad', 'Sr', 'Female', '15/02/2003', '18', 'Tambay', 'Muslim', 'College', 'Purok Singko', 'Tanauan Batangas', 'Divorced', 'Yes ', '09123456789', 'Filipino', 'C:\\Users\\Admin\\Desktop\\FinalsRepoJannRose\\BrgySystem\\BrgySystem\\BrgySystem\\bin\\Debug\\ResidentsImages\\9e4551b5-693c-4f75-9cb3-b6857f3226b0.jpeg', '9e4551b5-693c-4f75-9cb3-b6857f3226b0.jpeg', 'No'),
('Marites Reyes', 'None', 'Male ', '28/03/2008', '13', 'Tambay', 'Roman Catholic', 'College', 'Bagong Purok', 'Tanauan Batangas', 'Widowed', 'No', '09123123762', 'Filipino', 'C:\\Users\\Admin\\Desktop\\FinalsRepoJannRose\\BrgySystem\\BrgySystem\\BrgySystem\\bin\\Debug\\ResidentsImages\\isko moreno on drug queen.png', 'isko moreno on drug queen.png', 'No');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `archive_officials`
--
ALTER TABLE `archive_officials`
  ADD PRIMARY KEY (`Name`),
  ADD UNIQUE KEY `CONTACT` (`CONTACT`),
  ADD UNIQUE KEY `ImageName` (`ImageName`);

--
-- Indexes for table `archive_purok`
--
ALTER TABLE `archive_purok`
  ADD PRIMARY KEY (`PurokName`);

--
-- Indexes for table `archive_residents`
--
ALTER TABLE `archive_residents`
  ADD PRIMARY KEY (`FULLNAME`),
  ADD UNIQUE KEY `CONTACT_NUMBER` (`CONTACT_NUMBER`),
  ADD UNIQUE KEY `IMAGENAME` (`ImageName`);

--
-- Indexes for table `barangaydetails`
--
ALTER TABLE `barangaydetails`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `AdminName` (`AdminName`),
  ADD UNIQUE KEY `TelephoneNumber` (`ContactNumber`),
  ADD UNIQUE KEY `BarangayCaptain` (`BarangayCaptain`),
  ADD UNIQUE KEY `Zipcode` (`Zipcode`),
  ADD UNIQUE KEY `ImageName` (`ImageName`),
  ADD UNIQUE KEY `ImagePath` (`ImagePath`) USING HASH;

--
-- Indexes for table `clearance`
--
ALTER TABLE `clearance`
  ADD PRIMARY KEY (`TransactNo`),
  ADD UNIQUE KEY `Business Name` (`Business Name`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`Username`),
  ADD UNIQUE KEY `Password` (`Password`);

--
-- Indexes for table `mission_vision`
--
ALTER TABLE `mission_vision`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `officials`
--
ALTER TABLE `officials`
  ADD PRIMARY KEY (`Name`),
  ADD UNIQUE KEY `CONTACT` (`CONTACT`),
  ADD UNIQUE KEY `ImageName` (`ImageName`);

--
-- Indexes for table `orgchart`
--
ALTER TABLE `orgchart`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `purok`
--
ALTER TABLE `purok`
  ADD PRIMARY KEY (`PurokName`);

--
-- Indexes for table `residents`
--
ALTER TABLE `residents`
  ADD PRIMARY KEY (`FULLNAME`),
  ADD UNIQUE KEY `CONTACT_NUMBER` (`CONTACT_NUMBER`),
  ADD UNIQUE KEY `IMAGENAME` (`ImageName`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `barangaydetails`
--
ALTER TABLE `barangaydetails`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `clearance`
--
ALTER TABLE `clearance`
  MODIFY `TransactNo` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=202195615;

--
-- AUTO_INCREMENT for table `mission_vision`
--
ALTER TABLE `mission_vision`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `orgchart`
--
ALTER TABLE `orgchart`
  MODIFY `ID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
