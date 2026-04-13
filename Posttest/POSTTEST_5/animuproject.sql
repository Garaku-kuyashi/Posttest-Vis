-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 13, 2026 at 05:39 AM
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
-- Database: `animuproject`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbjenis`
--

CREATE TABLE `tbjenis` (
  `AnimusKode` varchar(5) NOT NULL,
  `NamaKarakter` varchar(100) NOT NULL,
  `Tahun` varchar(4) NOT NULL,
  `Lokasi` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbjenis`
--

INSERT INTO `tbjenis` (`AnimusKode`, `NamaKarakter`, `Tahun`, `Lokasi`) VALUES
('2Nimu', 'Ezio Auditore', '1467', 'Italia'),
('Syn23', 'Evie Frye', '1868', 'Britania Raya'),
('yRS1t', 'Altaïr Ibn-La\'Ahad', '1191', 'Yerussalem');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbjenis`
--
ALTER TABLE `tbjenis`
  ADD PRIMARY KEY (`AnimusKode`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
