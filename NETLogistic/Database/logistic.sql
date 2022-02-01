-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Време на генериране:  1 фев 2022 в 04:18
-- Версия на сървъра: 10.4.19-MariaDB
-- Версия на PHP: 7.3.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данни: `logistic`
--

-- --------------------------------------------------------

--
-- Структура на таблица `appinfo`
--

CREATE TABLE `appinfo` (
  `app_version` varchar(256) CHARACTER SET utf8 NOT NULL,
  `app_author` varchar(256) CHARACTER SET utf8 NOT NULL,
  `app_last_update` varchar(256) CHARACTER SET utf8 NOT NULL,
  `app_download_link` varchar(256) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Схема на данните от таблица `appinfo`
--

INSERT INTO `appinfo` (`app_version`, `app_author`, `app_last_update`, `app_download_link`) VALUES
('1,0', 'dayofpay', '1/2/2022', 'https://github.com/dayofpay');

-- --------------------------------------------------------

--
-- Структура на таблица `packs`
--

CREATE TABLE `packs` (
  `pack_id` int(200) NOT NULL,
  `pack_weight` int(200) NOT NULL,
  `pack_description` varchar(256) CHARACTER SET utf8 NOT NULL,
  `pack_sent_date` varchar(256) CHARACTER SET utf8 NOT NULL,
  `pack_receiver` varchar(256) CHARACTER SET utf8 NOT NULL,
  `pack_sent_from` varchar(256) CHARACTER SET utf8 NOT NULL,
  `pack_estimated_delivery` varchar(256) CHARACTER SET utf8 NOT NULL,
  `pack_type` varchar(256) CHARACTER SET utf8 NOT NULL,
  `pack_total_price` double NOT NULL,
  `pack_delivery_price` double NOT NULL,
  `pack_deliver_city` varchar(256) CHARACTER SET utf8 NOT NULL,
  `pack_sent_from_city` varchar(256) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Схема на данните от таблица `packs`
--

INSERT INTO `packs` (`pack_id`, `pack_weight`, `pack_description`, `pack_sent_date`, `pack_receiver`, `pack_sent_from`, `pack_estimated_delivery`, `pack_type`, `pack_total_price`, `pack_delivery_price`, `pack_deliver_city`, `pack_sent_from_city`) VALUES
(7777, 0, 'Хартия', '01/02/2022', 'Митко Стефанов', 'Ангел Иванов', '04/02/2022', 'Хартия', 8, 4, 'Добрич', 'Варна'),
(627105, 14, 'Disk', '01/02/2022', 'vladislav emiliyanov ivanov', '01/02/2022', '04/02/2022', 'Plastmasa', 34, 14, 'Sofia', 'Dobrich');

--
-- Indexes for dumped tables
--

--
-- Индекси за таблица `appinfo`
--
ALTER TABLE `appinfo`
  ADD PRIMARY KEY (`app_version`);

--
-- Индекси за таблица `packs`
--
ALTER TABLE `packs`
  ADD PRIMARY KEY (`pack_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
