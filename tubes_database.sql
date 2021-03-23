-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 22, 2019 at 08:23 AM
-- Server version: 10.1.21-MariaDB
-- PHP Version: 7.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tubes_database`
--

-- --------------------------------------------------------

--
-- Table structure for table `data_ayah`
--

CREATE TABLE `data_ayah` (
  `Nama_Lengkap` char(20) NOT NULL,
  `Alamat` varchar(50) NOT NULL,
  `Luas_Tanah` int(11) NOT NULL,
  `NJOP_Bumi` int(11) NOT NULL,
  `Luas_Bangunan` int(11) NOT NULL,
  `NJOP_Bangunan` int(11) NOT NULL,
  `Tempat_Lahir` varchar(30) NOT NULL,
  `Tanggal_Lahir` date NOT NULL,
  `Agama` varchar(10) NOT NULL,
  `Pekerjaan` varchar(20) NOT NULL,
  `Jabatan` varchar(20) NOT NULL,
  `Golongan` text NOT NULL,
  `Instansi` varchar(20) NOT NULL,
  `Masa_Kerja` int(2) NOT NULL,
  `Gaji` int(20) NOT NULL,
  `Tunjangan` int(20) NOT NULL,
  `Insentif` int(20) NOT NULL,
  `Pensiun` int(20) NOT NULL,
  `Bonus` int(20) NOT NULL,
  `Penghasilan_Lainnya` int(20) NOT NULL,
  `Pengeluaran_per_Bulan` varchar(20) NOT NULL,
  `Pendidikan_Terakhir` varchar(20) NOT NULL,
  `No_Tel` int(20) NOT NULL,
  `NPWP` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `data_diri`
--

CREATE TABLE `data_diri` (
  `Gaji` int(20) NOT NULL,
  `Tunjangan` int(20) NOT NULL,
  `Insentif` int(20) NOT NULL,
  `Bonus` int(20) NOT NULL,
  `Penghasilan_Lainnya` varchar(20) NOT NULL,
  `Pengeluaran_per_Bulan` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `data_diri`
--

INSERT INTO `data_diri` (`Gaji`, `Tunjangan`, `Insentif`, `Bonus`, `Penghasilan_Lainnya`, `Pengeluaran_per_Bulan`) VALUES
(0, 0, 0, 0, 'j', 'Rp 2 Jt - 3 Jt'),
(0, 0, 0, 0, 'j', 'Rp 2 Jt - 3 Jt'),
(0, 0, 0, 0, 'j', 'j'),
(9, 9, 9, 9, '9', 'Rp 3 Jt - 5 Jt'),
(329, 9, 9, 9, '9', 'Rp 2 Jt - 3 Jt'),
(2000, 2000, 2000, 2000, '2000', '> Rp 10 Jt');

-- --------------------------------------------------------

--
-- Table structure for table `data_ibu`
--

CREATE TABLE `data_ibu` (
  `NamaLengkap` char(20) NOT NULL,
  `Alamat` varchar(50) NOT NULL,
  `LuasTanah` varchar(30) NOT NULL,
  `NJOPBumi` varchar(30) NOT NULL,
  `LuasBangunan` varchar(30) NOT NULL,
  `NJOPBangunan` varchar(30) NOT NULL,
  `TempatLahir` varchar(30) NOT NULL,
  `TanggalLahir` date NOT NULL,
  `Agama` varchar(10) NOT NULL,
  `Pekerjaan` varchar(20) NOT NULL,
  `Jabatan` varchar(20) NOT NULL,
  `Golongan` varchar(20) NOT NULL,
  `NamaPerusahaan` varchar(20) NOT NULL,
  `MasaKerja` varchar(20) NOT NULL,
  `Penghasilan` varchar(20) NOT NULL,
  `Gaji` int(20) NOT NULL,
  `Tunjangan` int(20) NOT NULL,
  `Insentif` int(20) NOT NULL,
  `Pensiun` int(20) NOT NULL,
  `Bonus` int(20) NOT NULL,
  `PenghasilanLainnya` int(20) NOT NULL,
  `PengeluaranPerBulan` varchar(20) NOT NULL,
  `PendidikanTerakhir` varchar(20) NOT NULL,
  `NoHP` int(20) NOT NULL,
  `NPWP` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `data_mahasiswa`
--

CREATE TABLE `data_mahasiswa` (
  `No_pendaftaran` varchar(20) NOT NULL,
  `Nama_Mhs` char(30) DEFAULT NULL,
  `NISN` varchar(15) DEFAULT NULL,
  `Jenjang_prodi` enum('S1','D3') DEFAULT NULL,
  `Bidik_Misi` enum('Ya','Tidak') DEFAULT NULL,
  `Jenis_Kelamin` enum('L','P') DEFAULT NULL,
  `Gol_Darah` enum('A','B','AB','O') DEFAULT NULL,
  `Tanggal_Lahir` varchar(30) DEFAULT NULL,
  `Agama` enum('Islam','Kristen Protestan','Kristen Katolik','Hindu','Budha','Konghucu') DEFAULT NULL,
  `Anak_ke` int(11) DEFAULT NULL,
  `Jlh_Bersaudara` int(11) DEFAULT NULL,
  `Jlh_Saudara_Kuliah` int(11) DEFAULT NULL,
  `Telp` varchar(15) DEFAULT NULL,
  `Pengajuan_UKT` enum('UKT Penuh','UKT Berkeadilan','Program Bidik Misi') DEFAULT NULL,
  `Sumber_Biaya` enum('Diri Sendiri','Orang Tua','Orang Lain','Instansi/Perusahaan') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `data_orang_lain`
--

CREATE TABLE `data_orang_lain` (
  `NamaLengkap` char(20) NOT NULL,
  `Alamat` varchar(50) NOT NULL,
  `LuasTanah` varchar(30) NOT NULL,
  `NJOPBumi` varchar(30) NOT NULL,
  `LuasBangunan` varchar(30) NOT NULL,
  `NJOPBangunan` varchar(30) NOT NULL,
  `TempatLahir` varchar(30) NOT NULL,
  `TanggalLahir` date NOT NULL,
  `Agama` varchar(10) NOT NULL,
  `Pekerjaan` varchar(20) NOT NULL,
  `Jabatan` varchar(20) NOT NULL,
  `Golongan` varchar(20) NOT NULL,
  `NamaPerusahaan` varchar(20) NOT NULL,
  `MasaKerja` varchar(20) NOT NULL,
  `Penghasilan` varchar(20) NOT NULL,
  `Gaji` int(20) NOT NULL,
  `Tunjangan` int(20) NOT NULL,
  `Insentif` int(20) NOT NULL,
  `Pensiun` int(20) NOT NULL,
  `Bonus` int(20) NOT NULL,
  `PenghasilanLainnya` int(20) NOT NULL,
  `PengeluaranPerBulan` varchar(20) NOT NULL,
  `PendidikanTerakhir` varchar(20) NOT NULL,
  `NoHP` int(20) NOT NULL,
  `NPWP` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `instansi_perusahaan`
--

CREATE TABLE `instansi_perusahaan` (
  `Nama_Instansi` varchar(32) NOT NULL,
  `Alamat_Instansi` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `mobil`
--

CREATE TABLE `mobil` (
  `Item_Mobil` int(2) NOT NULL,
  `Jlh_Mobil` int(2) NOT NULL,
  `Asal_Mobil` varchar(20) NOT NULL,
  `Isi_Silinder` varchar(10) NOT NULL,
  `Tahun_Pembuatan` varchar(10) NOT NULL,
  `Pajak_Mobil` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

-- --------------------------------------------------------

--
-- Table structure for table `sepedamotor`
--

CREATE TABLE `sepedamotor` (
  `Item_Motor` int(2) NOT NULL,
  `Jlh_Motor` int(2) NOT NULL,
  `Asal_Motor` char(20) NOT NULL,
  `Isi_SilinderMotor` varchar(10) NOT NULL,
  `Tahun_PembuatanMotor` varchar(10) DEFAULT NULL,
  `Pajak_Motor` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

-- --------------------------------------------------------

--
-- Table structure for table `sumber`
--

CREATE TABLE `sumber` (
  `sumberAir` char(1) DEFAULT NULL,
  `dayaPLN` varchar(20) DEFAULT NULL,
  `Genset` int(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sumber`
--

INSERT INTO `sumber` (`sumberAir`, `dayaPLN`, `Genset`) VALUES
('P', '<= 450 VA', 2123);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `Nomor_pendaftaran` varchar(20) NOT NULL,
  `Password` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`Nomor_pendaftaran`, `Password`) VALUES
('101101', '03091998'),
('101102', '09021998'),
('101103', '01011998'),
('101104', '06051999'),
('101105', '09071998'),
('101106', '31121998');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `data_ayah`
--
ALTER TABLE `data_ayah`
  ADD PRIMARY KEY (`Nama_Lengkap`);

--
-- Indexes for table `data_ibu`
--
ALTER TABLE `data_ibu`
  ADD PRIMARY KEY (`NamaLengkap`);

--
-- Indexes for table `data_mahasiswa`
--
ALTER TABLE `data_mahasiswa`
  ADD PRIMARY KEY (`No_pendaftaran`);

--
-- Indexes for table `data_orang_lain`
--
ALTER TABLE `data_orang_lain`
  ADD PRIMARY KEY (`NamaLengkap`);

--
-- Indexes for table `instansi_perusahaan`
--
ALTER TABLE `instansi_perusahaan`
  ADD PRIMARY KEY (`Nama_Instansi`);

--
-- Indexes for table `mobil`
--
ALTER TABLE `mobil`
  ADD PRIMARY KEY (`Item_Mobil`);

--
-- Indexes for table `sepedamotor`
--
ALTER TABLE `sepedamotor`
  ADD PRIMARY KEY (`Item_Motor`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`Nomor_pendaftaran`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
