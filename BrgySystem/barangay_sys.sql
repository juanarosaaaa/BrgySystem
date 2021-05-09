-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 06, 2021 at 02:50 PM
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
-- Database: `barangay_sys`
--

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
('asd', '111'),
('test', 'password'),
('myadmin111', 'pw_admin1212');

-- --------------------------------------------------------

--
-- Table structure for table `officials`
--

CREATE TABLE `officials` (
  `Name` varchar(50) NOT NULL,
  `AGE` char(2) NOT NULL,
  `BIRTHDATE` date NOT NULL,
  `SEX` varchar(10) NOT NULL,
  `TERM` varchar(12) DEFAULT NULL,
  `STATUS` varchar(10) DEFAULT 'UNKNOWN',
  `POSITION` varchar(50) NOT NULL,
  `ImagePath` varchar(200) NOT NULL,
  `CONTACT` char(11) NOT NULL,
  `ImageName` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `officials`
--

INSERT INTO `officials` (`Name`, `AGE`, `BIRTHDATE`, `SEX`, `TERM`, `STATUS`, `POSITION`, `ImagePath`, `CONTACT`, `ImageName`) VALUES
('JOHN DOE', '23', '2021-03-30', 'FEMALE', '5 YEARS', NULL, 'PUNONG BARANGAY', 'C:\\Users\\Admin\\Pictures\\ProjectFolder\\typesOFSQLCOMMANDS.jpg', '09283208902', 'typesOFSQLCOMMANDS.jpg'),
('JOHN DOE1', '12', '2021-03-29', 'FEMALE', '', NULL, 'COUNCIL', 'C:\\Users\\Admin\\Pictures\\ProjectFolder\\image3.png', '09263208907', 'image3.png'),
('NUMB', '12', '2021-03-28', 'MALE', '5 YEARS', NULL, 'PUNONG BARANGAY', 'C:\\Users\\Admin\\Pictures\\ProjectFolder\\backiee-123343.jpg', '53565345745', 'backiee-123343.jpg'),
('NUMBER', '46', '2021-03-01', 'MALE', '', NULL, 'COUNCIL', 'C:\\Users\\Admin\\Pictures\\ProjectFolder\\image5.png', '09091212875', 'image5.png');

-- --------------------------------------------------------

--
-- Table structure for table `purok`
--

CREATE TABLE `purok` (
  `PurokName` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `purok`
--

INSERT INTO `purok` (`PurokName`) VALUES
('1'),
('ASD1123121'),
('ASD112323'),
('KRAM1'),
('NUMBER'),
('NUMBER8'),
('PUROK 3'),
('Purok12');

-- --------------------------------------------------------

--
-- Table structure for table `residents`
--

CREATE TABLE `residents` (
  `FULLNAME` varchar(75) NOT NULL,
  `SUFFIX` varchar(50) DEFAULT NULL,
  `SEX` varchar(10) NOT NULL,
  `BIRTHDATE` date NOT NULL,
  `AGE` char(2) NOT NULL,
  `OCCUPATION` varchar(50) NOT NULL,
  `RELIGION` varchar(30) NOT NULL,
  `MONTHLY_INCOME` int(15) NOT NULL,
  `TRIBE` varchar(50) DEFAULT NULL,
  `NATIONALITY` varchar(50) NOT NULL,
  `PUROK` varchar(100) NOT NULL,
  `ADDRESS` varchar(75) NOT NULL,
  `PWD` varchar(5) NOT NULL,
  `CIVIL_STATUS` varchar(100) NOT NULL,
  `REGISTERED_VOTER` varchar(5) NOT NULL,
  `CONTACT_NUMBER` char(11) NOT NULL,
  `CITIZENSHIP` varchar(50) NOT NULL,
  `IMAGEPATH` varchar(200) NOT NULL,
  `ImageName` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `residents`
--

INSERT INTO `residents` (`FULLNAME`, `SUFFIX`, `SEX`, `BIRTHDATE`, `AGE`, `OCCUPATION`, `RELIGION`, `MONTHLY_INCOME`, `TRIBE`, `NATIONALITY`, `PUROK`, `ADDRESS`, `PWD`, `CIVIL_STATUS`, `REGISTERED_VOTER`, `CONTACT_NUMBER`, `CITIZENSHIP`, `IMAGEPATH`, `ImageName`) VALUES
('efef', 'Jr', 'MALE', '2021-04-01', '45', 'UHHUIasd', 'ger', 6345234, '23sdfsdfh', 'tudtsdfsdf', 'ASD', 'asdnasikj80', 'YES', 'MARRIED', 'YES', '38472895933', 'rhergfg', 'C:\\Users\\Admin\\Pictures\\ProjectFolder\\Java-Collections-Hierarchy-1.png', 'Java-Collections-Hierarchy-1.png'),
('mynameis', 'Jr', 'FEMALE', '2021-04-19', '12', 'asdasda', 'asdasdasd', 123, 'asdasd', 'asdasdasd', 'NEWPUROK', 'asdasdasd', 'YES', 'WIDOWED', 'YES', '12312343211', 'citizenship', 'C:\\Users\\Admin\\Pictures\\ProjectFolder\\mixkit-game-level-music-689.wav', 'mixkit-game-level-music-689.wav'),
('therter', 'III', 'MALE', '2013-12-05', '65', '4rgdfg', '4dfgdfgw', 423334634, '2hjghwzz', '43fgergdfg', 'KRAM', '43edgdfgrert', 'NO', 'SINGLE', 'YES', '56485674564', '23ejfiowefoi', 'C:\\Users\\Admin\\Pictures\\ProjectFolder\\images2.png', 'images2.png'),
('yeye^&', 'II', 'MALE', '2021-04-16', '34', '&%$&', '(&', 453452, 'fwefwef', 'gerg', 'PUROK12', 'adsuoashd(', 'YES', 'MARRIED', 'NO', '45346345275', 'asdasd', 'C:\\Users\\Admin\\Pictures\\ProjectFolder\\image5.png', 'image5.png');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`Username`),
  ADD UNIQUE KEY `Password` (`Password`);

--
-- Indexes for table `officials`
--
ALTER TABLE `officials`
  ADD PRIMARY KEY (`Name`),
  ADD UNIQUE KEY `ImagePath` (`ImagePath`),
  ADD UNIQUE KEY `CONTACT` (`CONTACT`),
  ADD UNIQUE KEY `ImageName` (`ImageName`);

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
  ADD UNIQUE KEY `IMAGEPATH` (`IMAGEPATH`),
  ADD UNIQUE KEY `CONTACT_NUMBER_2` (`CONTACT_NUMBER`),
  ADD UNIQUE KEY `IMAGENAME` (`ImageName`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
