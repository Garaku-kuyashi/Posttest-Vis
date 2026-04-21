-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 20, 2026 at 08:41 PM
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
-- Table structure for table `tbdetail`
--

CREATE TABLE `tbdetail` (
  `KodeKarakter` varchar(5) NOT NULL,
  `AnimusKode` varchar(5) NOT NULL,
  `senjata` varchar(50) NOT NULL,
  `ordo` varchar(50) NOT NULL,
  `deskripsi` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbdetail`
--

INSERT INTO `tbdetail` (`KodeKarakter`, `AnimusKode`, `senjata`, `ordo`, `deskripsi`) VALUES
('11', '34464', 'Gambit', 'The Hidden Ones', 'bayek of shiwa'),
('1212', 'yRS1t', 'wqwq', 'Assassin\'s', 'qwqwq'),
('2121', '', 'wew', '', 'dfasd'),
('2345', 'Syn23', 'Cane-Sword', 'Assassin\'s', 'Evie frye adalah saudara dari jacob frye');

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
('2121', 'Haytam', '1212', 'sasa'),
('Syn23', 'Evie Frye', '1868', 'Britania Raya'),
('yRS1t', 'Altaïr Ibn-La\'Ahad', '1191', 'Yerussalem');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbdetail`
--
ALTER TABLE `tbdetail`
  ADD PRIMARY KEY (`KodeKarakter`);

--
-- Indexes for table `tbjenis`
--
ALTER TABLE `tbjenis`
  ADD PRIMARY KEY (`AnimusKode`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
