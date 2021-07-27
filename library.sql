-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 26, 2021 at 12:17 PM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `library`
--

-- --------------------------------------------------------

--
-- Table structure for table `kitaplar`
--

CREATE TABLE `kitaplar` (
  `KitapID` int(11) NOT NULL,
  `KitapAdi` varchar(30) NOT NULL,
  `Tur` varchar(15) NOT NULL,
  `Yazar` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `kitaplar`
--

INSERT INTO `kitaplar` (`KitapID`, `KitapAdi`, `Tur`, `Yazar`) VALUES
(1, 'Sefiller', 'Roman', 'Victor Hugo'),
(2, 'Kırmızı Ve Siyah', 'Roman', 'Stendhal'),
(3, 'Gazap Üzümleri', 'Roman', 'John Steinbeck'),
(4, 'Suç Ve Ceza', 'Roman', 'Fyodor Dostoyevski'),
(5, 'Vadideki Zambak', 'Roman', 'Honoré de Balzac'),
(6, 'Bizim Köy', 'Anı', 'Mahmut Makal'),
(7, 'İlk Şiirler', 'Şiir', 'Nazım Hikmet'),
(8, 'Diyet', 'Hikaye', 'Ömer Seyfettin'),
(9, 'Hayvan Çiftliği', 'Roman', 'George Orwell');

-- --------------------------------------------------------

--
-- Table structure for table `kullanici`
--

CREATE TABLE `kullanici` (
  `KullaniciID` int(11) NOT NULL,
  `Adi` varchar(20) NOT NULL,
  `Tel` int(11) NOT NULL,
  `Sinif` varchar(10) NOT NULL,
  `KayitTarih` date NOT NULL,
  `MaxKitap` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `kullanici`
--

INSERT INTO `kullanici` (`KullaniciID`, `Adi`, `Tel`, `Sinif`, `KayitTarih`, `MaxKitap`) VALUES
(1, 'Ramazan', 0, 'Tam', '2021-04-01', 3),
(2, 'Kazım', 0, 'Tam', '2021-05-06', 3),
(3, 'Kenan', 0, 'Tam', '2021-05-06', 3),
(4, 'İrdal', 0, 'Tam', '2021-05-06', 3),
(5, 'Celal', 0, 'Tam', '2021-05-06', 3),
(6, 'Abuzer', 123, 'Öğrenci', '2021-05-06', 5),
(7, 'asdasdasd', 12332, 'Öğrenci', '2021-05-06', 5);

--
-- Triggers `kullanici`
--
DELIMITER $$
CREATE TRIGGER `kullaniciDelete` AFTER DELETE ON `kullanici` FOR EACH ROW INSERT INTO kullaniciislemleri
VALUES(null,OLD.KullaniciID,OLD.Adi,OLD.Tel,OLD.Sinif,OLD.KayitTarih,OLD.MaxKitap,'deleted')
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `kullaniciUpdate` AFTER UPDATE ON `kullanici` FOR EACH ROW INSERT INTO kullaniciislemleri
VALUES(null,OLD.KullaniciID,OLD.Adi,OLD.Tel,OLD.Sinif,OLD.KayitTarih,OLD.MaxKitap,'update')
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `kullanicialdigi`
--

CREATE TABLE `kullanicialdigi` (
  `KitapID` int(11) NOT NULL,
  `KullaniciID` int(11) NOT NULL,
  `AldigiTarih` date NOT NULL,
  `VerecegiTarih` date NOT NULL,
  `kalankitap` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Triggers `kullanicialdigi`
--
DELIMITER $$
CREATE TRIGGER `VerilenKitaplarDelete` AFTER DELETE ON `kullanicialdigi` FOR EACH ROW INSERT INTO verilenkitaplar VALUES(null,OLD.KitapID,OLD.KullaniciID,OLD.AldigiTarih,OLD.VerecegiTarih,NOW(),'deleted')
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `VerilenKitaplarInsert` AFTER INSERT ON `kullanicialdigi` FOR EACH ROW INSERT INTO verilenkitaplar VALUES(null,NEW.KitapID,NEW.KullaniciID,NOW(),NEW.VerecegiTarih,null,'inserted')
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `kullaniciislemleri`
--

CREATE TABLE `kullaniciislemleri` (
  `ID` int(11) NOT NULL,
  `KullaniciID` int(11) NOT NULL,
  `Adi` varchar(20) NOT NULL,
  `Tel` int(11) NOT NULL,
  `Sinif` varchar(10) NOT NULL,
  `KayitTarih` date NOT NULL,
  `MaxKitap` int(10) NOT NULL,
  `Islem` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `kullaniciislemleri`
--

INSERT INTO `kullaniciislemleri` (`ID`, `KullaniciID`, `Adi`, `Tel`, `Sinif`, `KayitTarih`, `MaxKitap`, `Islem`) VALUES
(1, 7, 'asd', 2, 'Tam', '2021-05-06', 3, 'deleted'),
(2, 7, 'asd', 1, 'Öğrenci', '2021-05-06', 5, 'deleted'),
(3, 7, 'asd', 123, 'Öğrenci', '2021-05-06', 5, 'update');

-- --------------------------------------------------------

--
-- Table structure for table `verilenkitaplar`
--

CREATE TABLE `verilenkitaplar` (
  `ID` int(11) NOT NULL,
  `KitapID` int(11) NOT NULL,
  `KullaniciID` int(11) NOT NULL,
  `AldigiTarih` date NOT NULL,
  `VerecegiTarih` date NOT NULL,
  `VerdigiTarih` date DEFAULT NULL,
  `Islem` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `verilenkitaplar`
--

INSERT INTO `verilenkitaplar` (`ID`, `KitapID`, `KullaniciID`, `AldigiTarih`, `VerecegiTarih`, `VerdigiTarih`, `Islem`) VALUES
(81, 1, 1, '2021-05-06', '2021-05-06', NULL, 'inserted'),
(82, 2, 1, '2021-05-06', '2021-05-06', NULL, 'inserted'),
(83, 1, 1, '2021-05-06', '2021-05-06', '2021-05-06', 'deleted'),
(84, 2, 1, '2021-05-06', '2021-05-06', '2021-05-06', 'deleted');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `kitaplar`
--
ALTER TABLE `kitaplar`
  ADD PRIMARY KEY (`KitapID`);

--
-- Indexes for table `kullanici`
--
ALTER TABLE `kullanici`
  ADD PRIMARY KEY (`KullaniciID`);

--
-- Indexes for table `kullanicialdigi`
--
ALTER TABLE `kullanicialdigi`
  ADD PRIMARY KEY (`KitapID`);

--
-- Indexes for table `kullaniciislemleri`
--
ALTER TABLE `kullaniciislemleri`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `verilenkitaplar`
--
ALTER TABLE `verilenkitaplar`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `kitaplar`
--
ALTER TABLE `kitaplar`
  MODIFY `KitapID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `kullaniciislemleri`
--
ALTER TABLE `kullaniciislemleri`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `verilenkitaplar`
--
ALTER TABLE `verilenkitaplar`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=85;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
