-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 03, 2023 at 02:23 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_inventorymobil`
--

-- --------------------------------------------------------

--
-- Table structure for table `konsumen`
--

CREATE TABLE `konsumen` (
  `id_konsumen` varchar(6) NOT NULL,
  `nama_konsumen` varchar(255) NOT NULL,
  `alamat_konsumen` varchar(255) NOT NULL,
  `telp_konsumen` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `konsumen`
--

INSERT INTO `konsumen` (`id_konsumen`, `nama_konsumen`, `alamat_konsumen`, `telp_konsumen`) VALUES
('K001', 'ucup', 'jl.123', '00810018'),
('K002', 'Agusyah', 'Jl. in aja', '089765433456'),
('K003', 'Agung', 'Jl. Komang', '089765433456');

-- --------------------------------------------------------

--
-- Table structure for table `mobil_supplier`
--

CREATE TABLE `mobil_supplier` (
  `kd_jenis` varchar(6) NOT NULL,
  `jenis_s` varchar(255) NOT NULL,
  `id_supplier` varchar(6) NOT NULL,
  `tipe_s` varchar(6) NOT NULL,
  `warna_s` varchar(255) NOT NULL,
  `harga_jual` int(11) NOT NULL,
  `no_mesin` varchar(9) NOT NULL,
  `no_rangka` varchar(17) NOT NULL,
  `stok` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `mobil_supplier`
--

INSERT INTO `mobil_supplier` (`kd_jenis`, `jenis_s`, `id_supplier`, `tipe_s`, `warna_s`, `harga_jual`, `no_mesin`, `no_rangka`, `stok`) VALUES
('KJ001', 'Sedan', 'S001', 'SDN1', 'Merah', 100000000, '123456789', '12345QWERT54321TR', 49),
('KJ002', 'Sport', 'S001', 'SPT1', 'Hitam', 500000000, '987654321', '54321ABCDE12345AB', -20);

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `id_supplier` varchar(6) NOT NULL,
  `nama_supplier` varchar(255) NOT NULL,
  `alamat_supplier` varchar(255) NOT NULL,
  `telp_supplier` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`id_supplier`, `nama_supplier`, `alamat_supplier`, `telp_supplier`) VALUES
('S001', 'PT. Honda Jembo', 'Jl Sangkuriang', '0213456543');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_mobil`
--

CREATE TABLE `tbl_mobil` (
  `kd_jenis` varchar(6) NOT NULL,
  `jenis` varchar(255) NOT NULL,
  `tipe` varchar(255) NOT NULL,
  `warna` varchar(255) NOT NULL,
  `no_rangka` varchar(17) NOT NULL,
  `no_mesin` varchar(9) NOT NULL,
  `harga_jual` varchar(12) NOT NULL,
  `stok` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_mobil`
--

INSERT INTO `tbl_mobil` (`kd_jenis`, `jenis`, `tipe`, `warna`, `no_rangka`, `no_mesin`, `harga_jual`, `stok`) VALUES
('KJ001', 'Sedan', 'SDN1', 'Silver', '12345QWERT54321QW', '123456789', '110000000', 60),
('KJ002', 'Sport', 'SPT1', 'Hitam', '54321ABCDE12345AB', '987654321', '510000000', 70);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pembelian`
--

CREATE TABLE `tbl_pembelian` (
  `nota` varchar(5) NOT NULL,
  `tgl_beli` varchar(10) NOT NULL,
  `kd_jenis` varchar(6) NOT NULL,
  `id_supplier` varchar(6) NOT NULL,
  `no_rangka` varchar(17) NOT NULL,
  `no_mesin` varchar(9) NOT NULL,
  `qty` int(4) NOT NULL,
  `harga_beli` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_pembelian`
--

INSERT INTO `tbl_pembelian` (`nota`, `tgl_beli`, `kd_jenis`, `id_supplier`, `no_rangka`, `no_mesin`, `qty`, `harga_beli`) VALUES
('001', '12/03/2004', 'KJ001', 'K001', '12345QWERT54321TR', '12345678', 5, 110000000),
('002', '12/03/2004', 'KJ001', 'K001', '12345QWERT54321TR', '123456789', 100, 110000000),
('003', '12/2/2008', 'KJ001', 'S001', '12345QWERT54321TR', '123456789', 5, 100000000),
('004', '12/2/2009', 'KJ001', 'S001', '12345QWERT54321TR', '123456789', 5, 100000000),
('005', '01/07/2023', 'KJ002', 'S001', '54321ABCDE12345AB', '987654321', 50, 2147483647),
('006', '03/07/2023', 'KJ001', 'S001', '12345QWERT54321TR', '123456789', 1, 100000000);

--
-- Triggers `tbl_pembelian`
--
DELIMITER $$
CREATE TRIGGER `Tambah_mobil` AFTER INSERT ON `tbl_pembelian` FOR EACH ROW BEGIN
	UPDATE tbl_mobil SET stok = stok + NEW.qty WHERE kd_jenis = NEW.kd_jenis;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `ambil_mobilsupp` AFTER INSERT ON `tbl_pembelian` FOR EACH ROW BEGIN
 UPDATE mobil_supplier SET stok	= stok - New.qty WHERE kd_jenis = New.kd_jenis;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_penjualan`
--

CREATE TABLE `tbl_penjualan` (
  `no_faktur` varchar(5) NOT NULL,
  `tgl_jual` varchar(10) NOT NULL,
  `kd_jenis` varchar(6) NOT NULL,
  `id_konsumen` varchar(6) NOT NULL,
  `no_rangka` varchar(17) NOT NULL,
  `no_mesin` varchar(9) NOT NULL,
  `qty` int(4) NOT NULL,
  `harga_jual` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_penjualan`
--

INSERT INTO `tbl_penjualan` (`no_faktur`, `tgl_jual`, `kd_jenis`, `id_konsumen`, `no_rangka`, `no_mesin`, `qty`, `harga_jual`) VALUES
('001', '12/03/2004', 'KJ001', 'K001', '12345QWERT54321TR', '12345678', 5, 110000000),
('002', '12/03/2004', 'KJ001', 'K001', '12345QWERT54321TR', '123456789', 100, 110000000),
('003', '12/2/2008', 'KJ001', 'S001', '12345QWERT54321TR', '123456789', 5, 100000000),
('004', '12/2/2009', 'KJ001', 'S001', '12345QWERT54321TR', '123456789', 5, 100000000),
('003', '01/07/2023', 'KJ001', 's001', '12345QWERT54321QW', '123456789', 1, 0),
('005', '01/07/2023', 'KJ001', 's001', '12345QWERT54321QW', '123456789', 4, 440000000),
('006', '01/07/2023', 'KJ002', 'S001', '54321ABCDE12345AB', '987654321', 5, 2147483647),
('007', '01/07/2023', 'KJ002', 's001', '54321ABCDE12345AB', '987654321', 3, 0),
('008', '01/07/2023', 'KJ002', 'K002', '54321ABCDE12345AB', '987654321', 2, 1020000000),
('009', '03/07/2023', 'KJ001', 'K001', '12345QWERT54321QW', '123456789', 1, 110000000);

--
-- Triggers `tbl_penjualan`
--
DELIMITER $$
CREATE TRIGGER `AMBIL_Mobil` AFTER INSERT ON `tbl_penjualan` FOR EACH ROW BEGIN
	INSERT INTO tbl_mobil SET kd_jenis = New.kd_jenis,
    stok = New.qty
    ON DUPLICATE KEY UPDATE stok = stok - New.qty;
END
$$
DELIMITER ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `konsumen`
--
ALTER TABLE `konsumen`
  ADD PRIMARY KEY (`id_konsumen`);

--
-- Indexes for table `mobil_supplier`
--
ALTER TABLE `mobil_supplier`
  ADD PRIMARY KEY (`kd_jenis`),
  ADD KEY `fk_idsupp` (`id_supplier`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`id_supplier`);

--
-- Indexes for table `tbl_mobil`
--
ALTER TABLE `tbl_mobil`
  ADD PRIMARY KEY (`kd_jenis`);

--
-- Indexes for table `tbl_pembelian`
--
ALTER TABLE `tbl_pembelian`
  ADD KEY `FK_KdJenis` (`kd_jenis`),
  ADD KEY `id_kons` (`id_supplier`);

--
-- Indexes for table `tbl_penjualan`
--
ALTER TABLE `tbl_penjualan`
  ADD KEY `FK_KdJenis` (`kd_jenis`),
  ADD KEY `id_kons` (`id_konsumen`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `mobil_supplier`
--
ALTER TABLE `mobil_supplier`
  ADD CONSTRAINT `fk_idsupp` FOREIGN KEY (`id_supplier`) REFERENCES `supplier` (`id_supplier`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_pembelian`
--
ALTER TABLE `tbl_pembelian`
  ADD CONSTRAINT `kd_jenisb` FOREIGN KEY (`kd_jenis`) REFERENCES `tbl_mobil` (`kd_jenis`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
