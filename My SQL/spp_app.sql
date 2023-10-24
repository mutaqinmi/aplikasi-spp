-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 24, 2023 at 12:34 PM
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
-- Database: `spp_app`
--

-- --------------------------------------------------------

--
-- Table structure for table `data_kelas`
--

CREATE TABLE `data_kelas` (
  `id_kelas` int(11) NOT NULL,
  `nama_kelas` varchar(10) NOT NULL,
  `kompetensi_keahlian` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `data_kelas`
--

INSERT INTO `data_kelas` (`id_kelas`, `nama_kelas`, `kompetensi_keahlian`) VALUES
(1, 'X DPIB 1', 'Desain Pemodelan Informasi Bangunan'),
(2, 'X DPIB 2', 'Desain Pemodelan Informasi Bangunan'),
(3, 'X DPIB 3', 'Desain Pemodelan Informasi Bangunan'),
(4, 'X DPIB 4', 'Desain Pemodelan Informasi Bangunan'),
(5, 'X TE 1', 'Teknik Elektronika'),
(6, 'X TE 2', 'Teknik Elektronika'),
(7, 'X TE 3', 'Teknik Elektronika'),
(8, 'X TK 1', 'Teknik Ketenagalistrikan'),
(9, 'X TK 2', 'Teknik Ketenagalistrikan'),
(10, 'X TK 3', 'Teknik Ketenagalistrikan'),
(11, 'X TK 4', 'Teknik Ketenagalistrikan'),
(12, 'X TM 1', 'Teknik Mesin'),
(13, 'X TM 2', 'Teknik Mesin'),
(14, 'X TM 3', 'Teknik Mesin'),
(15, 'X TM 4', 'Teknik Mesin'),
(16, 'X TO 1', 'Teknik Otomotif'),
(17, 'X TO 2', 'Teknik Otomotif'),
(18, 'X TO 3', 'Teknik Otomotif'),
(19, 'X TO 4', 'Teknik Otomotif'),
(20, 'X TJKT 1', 'Teknik Jaringan Komputer dan Telekomunikasi'),
(21, 'X TJKT 2', 'Teknik Jaringan Komputer dan Telekomunikasi'),
(22, 'X PPLG', 'Pengembangan Perangkat Lunak dan Gim'),
(23, 'X BP 1', 'Broadcasting dan Perfilman'),
(24, 'X BP 2', 'Broadcasting dan Perfilman'),
(25, 'XI DPIB 1', 'Desain Pemodelan Informasi Bangunan'),
(26, 'XI DPIB 2', 'Desain Pemodelan Informasi Bangunan'),
(27, 'XI DPIB 3', 'Desain Pemodelan Informasi Bangunan'),
(28, 'XI DPIB 4', 'Desain Pemodelan Informasi Bangunan'),
(29, 'XI TE 1', 'Teknik Elektronika'),
(30, 'XI TE 2', 'Teknik Elektronika'),
(31, 'XI TE 3', 'Teknik Elektronika'),
(32, 'XI TK 1', 'Teknik Ketenagalistrikan'),
(33, 'XI TK 2', 'Teknik Ketenagalistrikan'),
(34, 'XI TK 3', 'Teknik Ketenagalistrikan'),
(35, 'XI TK 4', 'Teknik Ketenagalistrikan'),
(36, 'XI TM 1', 'Teknik Mesin'),
(37, 'XI TM 2', 'Teknik Mesin'),
(38, 'XI TM 3', 'Teknik Mesin'),
(39, 'XI TM 4', 'Teknik Mesin'),
(40, 'XI TO 1', 'Teknik Otomotif'),
(41, 'XI TO 2', 'Teknik Otomotif'),
(42, 'XI TO 3', 'Teknik Otomotif'),
(43, 'XI TO 4', 'Teknik Otomotif'),
(44, 'XI TJKT 1', 'Teknik Jaringan Komputer dan Telekomunikasi'),
(45, 'XI TJKT 2', 'Teknik Jaringan Komputer dan Telekomunikasi'),
(46, 'XI PPLG', 'Pengembangan Perangkat Lunak dan Gim'),
(47, 'XI BP 1', 'Broadcasting dan Perfilman'),
(48, 'XI BP 2', 'Broadcasting dan Perfilman'),
(49, 'XII DPIB 1', 'Desain Pemodelan Informasi Bangunan'),
(50, 'XII DPIB 2', 'Desain Pemodelan Informasi Bangunan'),
(51, 'XII DPIB 3', 'Desain Pemodelan Informasi Bangunan'),
(52, 'XII DPIB 4', 'Desain Pemodelan Informasi Bangunan'),
(53, 'XII TE 1', 'Teknik Elektronika'),
(54, 'XII TE 2', 'Teknik Elektronika'),
(55, 'XII TE 3', 'Teknik Elektronika'),
(56, 'XII TK 1', 'Teknik Ketenagalistrikan'),
(57, 'XII TK 2', 'Teknik Ketenagalistrikan'),
(58, 'XII TK 3', 'Teknik Ketenagalistrikan'),
(59, 'XII TK 4', 'Teknik Ketenagalistrikan'),
(60, 'XII TM 1', 'Teknik Mesin'),
(61, 'XII TM 2', 'Teknik Mesin'),
(62, 'XII TM 3', 'Teknik Mesin'),
(63, 'XII TM 4', 'Teknik Mesin'),
(64, 'XII TO 1', 'Teknik Otomotif'),
(65, 'XII TO 2', 'Teknik Otomotif'),
(66, 'XII TO 3', 'Teknik Otomotif'),
(67, 'XII TO 4', 'Teknik Otomotif'),
(68, 'XII TJKT 1', 'Teknik Jaringan Komputer dan Telekomunikasi'),
(69, 'XII TJKT 2', 'Teknik Jaringan Komputer dan Telekomunikasi'),
(70, 'XII PPLG', 'Pengembangan Perangkat Lunak dan Gim'),
(71, 'XII BP 1', 'Broadcasting dan Perfilman'),
(72, 'XII BP 2', 'Broadcasting dan Perfilman');

-- --------------------------------------------------------

--
-- Table structure for table `data_pembayaran`
--

CREATE TABLE `data_pembayaran` (
  `id_pembayaran` int(11) NOT NULL,
  `id_petugas` int(11) NOT NULL,
  `nisn` varchar(10) NOT NULL,
  `tgl_bayar` date NOT NULL,
  `bulan_dibayar` varchar(8) NOT NULL,
  `tahun_dibayar` varchar(4) NOT NULL,
  `id_spp` int(11) NOT NULL,
  `jumlah_bayar` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `data_siswa`
--

CREATE TABLE `data_siswa` (
  `nisn` char(10) NOT NULL,
  `nis` char(8) NOT NULL,
  `nama` varchar(35) NOT NULL,
  `id_kelas` int(11) NOT NULL,
  `alamat` text NOT NULL,
  `no_telp` varchar(13) NOT NULL,
  `id_spp` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `data_siswa`
--

INSERT INTO `data_siswa` (`nisn`, `nis`, `nama`, `id_kelas`, `alamat`, `no_telp`, `id_spp`) VALUES
('0000000000', '12225174', 'Muhammad Raffi Fabiansyah', 46, 'Mangkubumi, Tasikmalaya', '08123456789', 1),
('0000000001', '12225172', 'Muhammad Hafidz', 46, 'Kawalu, Tasikmalaya', '08123456789', 1),
('0000000002', '12225171', 'Muhammad Azka Fakhri Fairuz', 46, 'Mangkubumi, Tasikmalaya 46181', '08123456789', 1),
('0000000003', '12225170', 'Muhamad Hazmi Alfarizqi', 46, 'Kawalu', '08123456789', 1),
('0000000004', '12225169', 'Maulana Yusuf Al Ghani', 46, 'Bungursari', '0812345678', 1),
('0062113566', '12225173', 'Muhammad Ilham Mutaqin', 46, 'Mangkubumi, Tasikmalaya 46181', '085155114492', 1);

-- --------------------------------------------------------

--
-- Table structure for table `data_spp`
--

CREATE TABLE `data_spp` (
  `id_spp` int(11) NOT NULL,
  `tahun` int(11) NOT NULL,
  `nominal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `data_spp`
--

INSERT INTO `data_spp` (`id_spp`, `tahun`, `nominal`) VALUES
(1, 2023, 1500000);

-- --------------------------------------------------------

--
-- Table structure for table `data_user`
--

CREATE TABLE `data_user` (
  `id_petugas` int(11) NOT NULL,
  `username` varchar(25) NOT NULL,
  `password` varchar(32) NOT NULL,
  `nama_petugas` varchar(35) NOT NULL,
  `jenis_petugas` enum('admin','petugas') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `data_user`
--

INSERT INTO `data_user` (`id_petugas`, `username`, `password`, `nama_petugas`, `jenis_petugas`) VALUES
(1, 'admin', 'admin123', 'Admin', 'admin'),
(4, 'petugas1', 'petugas123', 'Petugas 1', 'petugas'),
(6, 'petugas2', 'petugas123', 'Petugas 2', 'petugas');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `data_kelas`
--
ALTER TABLE `data_kelas`
  ADD PRIMARY KEY (`id_kelas`);

--
-- Indexes for table `data_pembayaran`
--
ALTER TABLE `data_pembayaran`
  ADD PRIMARY KEY (`id_pembayaran`),
  ADD KEY `data_petugas` (`id_petugas`),
  ADD KEY `data_siswa` (`nisn`),
  ADD KEY `data_spp_pembayaran` (`id_spp`);

--
-- Indexes for table `data_siswa`
--
ALTER TABLE `data_siswa`
  ADD PRIMARY KEY (`nisn`),
  ADD KEY `data_kelas` (`id_kelas`),
  ADD KEY `data_spp` (`id_spp`);

--
-- Indexes for table `data_spp`
--
ALTER TABLE `data_spp`
  ADD PRIMARY KEY (`id_spp`);

--
-- Indexes for table `data_user`
--
ALTER TABLE `data_user`
  ADD PRIMARY KEY (`id_petugas`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `data_kelas`
--
ALTER TABLE `data_kelas`
  MODIFY `id_kelas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=73;

--
-- AUTO_INCREMENT for table `data_pembayaran`
--
ALTER TABLE `data_pembayaran`
  MODIFY `id_pembayaran` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `data_spp`
--
ALTER TABLE `data_spp`
  MODIFY `id_spp` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `data_user`
--
ALTER TABLE `data_user`
  MODIFY `id_petugas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `data_pembayaran`
--
ALTER TABLE `data_pembayaran`
  ADD CONSTRAINT `data_petugas` FOREIGN KEY (`id_petugas`) REFERENCES `data_user` (`id_petugas`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `data_siswa` FOREIGN KEY (`nisn`) REFERENCES `data_siswa` (`nisn`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `data_spp_pembayaran` FOREIGN KEY (`id_spp`) REFERENCES `data_spp` (`id_spp`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `data_siswa`
--
ALTER TABLE `data_siswa`
  ADD CONSTRAINT `data_kelas` FOREIGN KEY (`id_kelas`) REFERENCES `data_kelas` (`id_kelas`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `data_spp` FOREIGN KEY (`id_spp`) REFERENCES `data_spp` (`id_spp`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
