/*
SQLyog Ultimate v10.42 
MySQL - 5.5.5-10.1.21-MariaDB : Database - db_ticket
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`db_ticket` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `db_ticket`;

/*Table structure for table `dtl_transaksi` */

DROP TABLE IF EXISTS `dtl_transaksi`;

CREATE TABLE `dtl_transaksi` (
  `id_detail_transaksi` int(10) NOT NULL AUTO_INCREMENT,
  `id_transaksi` varchar(20) DEFAULT NULL,
  `tgl_transaksi` date DEFAULT NULL,
  `id_pegawai` varchar(30) DEFAULT NULL,
  `id_games` varchar(50) DEFAULT NULL,
  `jumlah` int(10) DEFAULT NULL,
  KEY `nama_games` (`id_games`),
  KEY `id_transaksi` (`id_detail_transaksi`),
  KEY `id_transaksi_2` (`id_transaksi`),
  KEY `id_pegawai` (`id_pegawai`),
  CONSTRAINT `dtl_transaksi_ibfk_2` FOREIGN KEY (`id_games`) REFERENCES `games` (`id_games`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `dtl_transaksi_ibfk_3` FOREIGN KEY (`id_transaksi`) REFERENCES `master_transaksi` (`id_transaksi`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `dtl_transaksi_ibfk_4` FOREIGN KEY (`id_pegawai`) REFERENCES `users` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

/*Data for the table `dtl_transaksi` */

insert  into `dtl_transaksi`(`id_detail_transaksi`,`id_transaksi`,`tgl_transaksi`,`id_pegawai`,`id_games`,`jumlah`) values (1,'TRN0001','2018-02-12','KSR0001','4DRDR',2),(2,'TRN0001','2018-02-12','KSR0001','ATVA1',1),(3,'TRN0001','2018-02-12','KSR0001','BGLM1',1),(4,'TRN0001','2018-02-12','KSR0001','BMBT1',2);

/*Table structure for table `games` */

DROP TABLE IF EXISTS `games`;

CREATE TABLE `games` (
  `no` int(3) NOT NULL AUTO_INCREMENT,
  `id_games` varchar(30) NOT NULL,
  `nama_games` varchar(50) DEFAULT NULL,
  `harga` double DEFAULT NULL,
  PRIMARY KEY (`id_games`),
  KEY `no` (`no`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=latin1;

/*Data for the table `games` */

insert  into `games`(`no`,`id_games`,`nama_games`,`harga`) values (1,'4DRDR','4D Rider',50000),(2,'ATVA1','ATV Adventure',125000),(3,'BGLM1','Buggy Limo',75000),(4,'BMBT1','Bumper Boat',30000),(5,'BTMN1','Batman Car',25000),(6,'CHPL1','Children Playground',20000),(7,'DMRY1','Delman Roya',60000),(8,'FMBG1','Family Buggy',60000),(9,'FMKT1','Formula Kart',50000),(10,'FTTN1','Futuristic Train',15000),(11,'GNTC1','Giant Car',25000),(12,'HRSR1','Horse Riding',20000),(13,'IRNM1','Ironman Car',25000),(14,'MNAV1','Mini ATV',20000),(15,'NB2S1','New Buggy 2 Seat',40000),(16,'NB4S1','New Buggy 4 Seat',60000),(17,'PNTBL1','Paint Ball',70000),(18,'RMHN1','Rumah Hantu',30000),(19,'SKYR1','Sky Rider',40000),(20,'SOBX1','Soboxx',40000),(21,'TRLN1','Trampoline',20000),(22,'TRNS1','Transformer',50000),(23,'TRSC1','Transformer Car',25000),(24,'TTWK1','Tiket Terusan Weekdays',150000),(25,'TTWK2','Tiket Terusan Weekend',200000),(26,'TUBY1','Tubby',20000),(27,'TWBW1','Tiket Waterboom Weekdays',80000),(28,'TWBW2','Tiket Waterboom Weekend',100000);

/*Table structure for table `master_transaksi` */

DROP TABLE IF EXISTS `master_transaksi`;

CREATE TABLE `master_transaksi` (
  `id_transaksi` varchar(20) NOT NULL,
  `status_transaksi` int(2) DEFAULT '0',
  PRIMARY KEY (`id_transaksi`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `master_transaksi` */

insert  into `master_transaksi`(`id_transaksi`,`status_transaksi`) values ('TRN0001',1);

/*Table structure for table `users` */

DROP TABLE IF EXISTS `users`;

CREATE TABLE `users` (
  `no` int(3) NOT NULL AUTO_INCREMENT,
  `id` varchar(25) NOT NULL,
  `nama_pegawai` varchar(35) DEFAULT NULL,
  `jabatan` enum('Kasir','Supervisior') DEFAULT NULL,
  `passwords` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `no` (`no`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

/*Data for the table `users` */

insert  into `users`(`no`,`id`,`nama_pegawai`,`jabatan`,`passwords`) values (1,'KSR0001','Pegi','Kasir','pegy'),(2,'KSR0002','Neng Siti','Kasir','nengsiti'),(3,'KSR0003','Sarah','Kasir','sarah'),(4,'KSR0004','Nita','Kasir','nita'),(5,'KSR0006','Iyep','Kasir','iyep'),(6,'KSR0007','Suci','Kasir','suci'),(7,'KSR0008','Elsa','Kasir','elsa'),(8,'KSR0009','Devi','Kasir','devi'),(9,'SPV0001','Imas','Supervisior','imas'),(10,'SPV0002','Lunglung','Supervisior','lunglung');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
