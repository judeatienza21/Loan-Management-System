-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 23, 2021 at 05:49 PM
-- Server version: 10.1.26-MariaDB
-- PHP Version: 7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `loansystemdb`
--
CREATE DATABASE IF NOT EXISTS `loansystemdb` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `loansystemdb`;

-- --------------------------------------------------------

--
-- Table structure for table `costumers`
--

CREATE TABLE `costumers` (
  `CostumersID` int(11) NOT NULL,
  `Firstname` varchar(255) NOT NULL,
  `Middlename` varchar(255) NOT NULL,
  `Lastname` varchar(255) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `LoanID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `costumers`
--

INSERT INTO `costumers` (`CostumersID`, `Firstname`, `Middlename`, `Lastname`, `Address`, `LoanID`) VALUES
(1, 'Jude', 'Artificio', 'Atienza', 'Lalig', 1),
(2, 'Kristine', 'Sales', 'Ompangco', 'Lusacan', 2),
(3, 'Allen', 'F', 'Eraña', 'Laguna', 3),
(4, 'Mark', 'A', 'Caño', 'Laguna', 4);

-- --------------------------------------------------------

--
-- Table structure for table `deletedatatable`
--

CREATE TABLE `deletedatatable` (
  `CostumersID` varchar(255) NOT NULL,
  `LoanAmount` varchar(255) NOT NULL,
  `NumberOfYear` varchar(255) NOT NULL,
  `InterestRate` varchar(255) NOT NULL,
  `MonthlyPayment` varchar(255) NOT NULL,
  `TotalPayment` varchar(255) NOT NULL,
  `FirstName` varchar(255) NOT NULL,
  `MiddleName` varchar(255) NOT NULL,
  `LastName` varchar(255) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `DeletedBy` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `deletedatatable`
--

INSERT INTO `deletedatatable` (`CostumersID`, `LoanAmount`, `NumberOfYear`, `InterestRate`, `MonthlyPayment`, `TotalPayment`, `FirstName`, `MiddleName`, `LastName`, `Address`, `DeletedBy`) VALUES
('5', '$80,345.00', '10', '5.8', '$883.95', '$106,073.54', 'Mark', 'A', 'Caño', 'Laguna', 'Jude'),
('6', '$80,345.00', '10', '5.8', '$883.95', '$106,073.54', 'Jude', 'Artificio', 'Atienza', 'Lalig', 'Jude'),
('5', '$80,345.00', '8', '5.8', '$1,048.04', '$100,611.97', 'Mark', 'A', 'Caño', 'Laguna', 'Jude');

-- --------------------------------------------------------

--
-- Table structure for table `loantable`
--

CREATE TABLE `loantable` (
  `LoanID` int(11) NOT NULL,
  `LoanAmount` varchar(255) NOT NULL,
  `NumberOfYear` varchar(255) NOT NULL,
  `InterestRate` varchar(255) NOT NULL,
  `MonthlyPayment` varchar(255) NOT NULL,
  `TotalPayment` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `loantable`
--

INSERT INTO `loantable` (`LoanID`, `LoanAmount`, `NumberOfYear`, `InterestRate`, `MonthlyPayment`, `TotalPayment`) VALUES
(1, '$80,345.00', '9', '5.8', '$956.67', '$103,320.88'),
(2, '$80,345.00', '9', '5.8', '$956.67', '$103,320.88'),
(3, '$80,345.00', '9', '5.8', '$956.67', '$103,320.88'),
(4, '$80,345.00', '8', '5.8', '$1,048.04', '$100,611.97');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `costumers`
--
ALTER TABLE `costumers`
  ADD PRIMARY KEY (`CostumersID`);

--
-- Indexes for table `loantable`
--
ALTER TABLE `loantable`
  ADD PRIMARY KEY (`LoanID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `costumers`
--
ALTER TABLE `costumers`
  MODIFY `CostumersID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `loantable`
--
ALTER TABLE `loantable`
  MODIFY `LoanID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
