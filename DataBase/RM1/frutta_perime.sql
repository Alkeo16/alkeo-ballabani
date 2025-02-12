-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 12, 2025 at 09:05 AM
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
-- Database: `frutta,perime`
--

-- --------------------------------------------------------

--
-- Table structure for table `adresa`
--

CREATE TABLE `adresa` (
  `Id` int(11) NOT NULL,
  `Id_Klientit` int(11) NOT NULL,
  `Locationi` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `blerja`
--

CREATE TABLE `blerja` (
  `Id` int(11) NOT NULL,
  `Id_Adresa` int(11) NOT NULL,
  `Id_Motorristat` int(11) NOT NULL,
  `Id_Produkti` int(11) NOT NULL,
  `Sasia` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `karta_klientit`
--

CREATE TABLE `karta_klientit` (
  `Id` int(11) NOT NULL,
  `Id_Klientit` int(11) NOT NULL,
  `Piket` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `kategoria`
--

CREATE TABLE `kategoria` (
  `ID` int(11) NOT NULL,
  `Lloji` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `klienti`
--

CREATE TABLE `klienti` (
  `Id` int(11) NOT NULL,
  `Emri` varchar(30) NOT NULL,
  `Mbiemri` varchar(30) NOT NULL,
  `E_Mail` varchar(30) NOT NULL,
  `Gjinia` varchar(1) NOT NULL,
  `Mosha` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `motorristat`
--

CREATE TABLE `motorristat` (
  `Id` int(11) NOT NULL,
  `Emri` varchar(20) NOT NULL,
  `Mbiemri` varchar(20) NOT NULL,
  `Nr_Cel` varchar(15) NOT NULL,
  `E_Mail` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `produkti`
--

CREATE TABLE `produkti` (
  `ID` int(11) NOT NULL,
  `Emri` varchar(30) NOT NULL,
  `Cmimi` int(11) NOT NULL,
  `Id_Kategoria` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `adresa`
--
ALTER TABLE `adresa`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Fk_IDKlientit` (`Id_Klientit`);

--
-- Indexes for table `blerja`
--
ALTER TABLE `blerja`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Fk_Adresa` (`Id_Adresa`),
  ADD KEY `Fk_Motorristat` (`Id_Motorristat`),
  ADD KEY `Fk_Produkti` (`Id_Produkti`);

--
-- Indexes for table `karta_klientit`
--
ALTER TABLE `karta_klientit`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Fk_ID_Klientit` (`Id_Klientit`);

--
-- Indexes for table `kategoria`
--
ALTER TABLE `kategoria`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `klienti`
--
ALTER TABLE `klienti`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `motorristat`
--
ALTER TABLE `motorristat`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `produkti`
--
ALTER TABLE `produkti`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `FK_kategoria` (`Id_Kategoria`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `adresa`
--
ALTER TABLE `adresa`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `blerja`
--
ALTER TABLE `blerja`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `karta_klientit`
--
ALTER TABLE `karta_klientit`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `kategoria`
--
ALTER TABLE `kategoria`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `klienti`
--
ALTER TABLE `klienti`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `motorristat`
--
ALTER TABLE `motorristat`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `produkti`
--
ALTER TABLE `produkti`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `adresa`
--
ALTER TABLE `adresa`
  ADD CONSTRAINT `Fk_IDKlientit` FOREIGN KEY (`Id_Klientit`) REFERENCES `klienti` (`Id`);

--
-- Constraints for table `blerja`
--
ALTER TABLE `blerja`
  ADD CONSTRAINT `Fk_Adresa` FOREIGN KEY (`Id_Adresa`) REFERENCES `adresa` (`Id`),
  ADD CONSTRAINT `Fk_Id_Adresa` FOREIGN KEY (`Id_Adresa`) REFERENCES `adresa` (`Id`),
  ADD CONSTRAINT `Fk_Motorristat` FOREIGN KEY (`Id_Motorristat`) REFERENCES `motorristat` (`Id`),
  ADD CONSTRAINT `Fk_Produkti` FOREIGN KEY (`Id_Produkti`) REFERENCES `produkti` (`ID`);

--
-- Constraints for table `karta_klientit`
--
ALTER TABLE `karta_klientit`
  ADD CONSTRAINT `Fk_ID_Klientit` FOREIGN KEY (`Id_Klientit`) REFERENCES `klienti` (`Id`);

--
-- Constraints for table `produkti`
--
ALTER TABLE `produkti`
  ADD CONSTRAINT `FK_kategoria` FOREIGN KEY (`Id_Kategoria`) REFERENCES `kategoria` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
