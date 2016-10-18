-- MySQL dump 10.13  Distrib 5.5.9, for Win32 (x86)
--
-- Host: localhost    Database: private_institute_central
-- ------------------------------------------------------
-- Server version	5.5.10

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Current Database: `private_institute_central`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `private_institute_central` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `private_institute_central`;

--
-- Table structure for table `tblbranch`
--

DROP TABLE IF EXISTS `tblbranch`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblbranch` (
  `branchid` int(11) NOT NULL AUTO_INCREMENT,
  `branchname` varchar(45) DEFAULT NULL,
  `branchcompanyname` varchar(45) DEFAULT NULL,
  `area` varchar(45) DEFAULT NULL,
  `areacovert` varchar(45) DEFAULT NULL,
  `dateissued` varchar(45) DEFAULT NULL,
  `branchrateforroyalties` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`branchid`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


--
-- Table structure for table `tblbranchadultstudent`
--

DROP TABLE IF EXISTS `tblbranchadultstudent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblbranchadultstudent` (
  `badultid` int(11) NOT NULL AUTO_INCREMENT,
  `branchid` int(11) DEFAULT NULL,
  `firstname` varchar(45) DEFAULT NULL,
  `lastname` varchar(45) DEFAULT NULL,
  `fathername` varchar(45) DEFAULT NULL,
  `levelnow` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `active` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`badultid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblbranchadultstudent`
--

LOCK TABLES `tblbranchadultstudent` WRITE;
/*!40000 ALTER TABLE `tblbranchadultstudent` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblbranchadultstudent` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblbranchstaff`
--

DROP TABLE IF EXISTS `tblbranchstaff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblbranchstaff` (
  `bstaffid` int(11) NOT NULL AUTO_INCREMENT,
  `branchid` int(11) DEFAULT NULL,
  `staffname` varchar(45) DEFAULT NULL,
  `staffsurname` varchar(45) DEFAULT NULL,
  `job` varchar(45) DEFAULT NULL,
  `colification` varchar(45) DEFAULT NULL,
  `dateentered` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`bstaffid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblbranchstaff`
--

LOCK TABLES `tblbranchstaff` WRITE;
/*!40000 ALTER TABLE `tblbranchstaff` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblbranchstaff` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblbranchstudent`
--

DROP TABLE IF EXISTS `tblbranchstudent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblbranchstudent` (
  `bstudentid` int(11) NOT NULL AUTO_INCREMENT,
  `branchid` int(11) DEFAULT NULL,
  `firstname` varchar(45) DEFAULT NULL,
  `lastname` varchar(45) DEFAULT NULL,
  `fathername` varchar(45) DEFAULT NULL,
  `levelnow` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `active` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`bstudentid`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


--
-- Table structure for table `tbllicense`
--

DROP TABLE IF EXISTS `tbllicense`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbllicense` (
  `licenseid` int(11) NOT NULL AUTO_INCREMENT,
  `branchid` int(11) DEFAULT NULL,
  `macaddress` varchar(45) DEFAULT NULL,
  `macaddress1` varchar(45) DEFAULT NULL,
  `dataissued` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`licenseid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbllicense`
--

LOCK TABLES `tbllicense` WRITE;
/*!40000 ALTER TABLE `tbllicense` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbllicense` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblroyalties`
--

DROP TABLE IF EXISTS `tblroyalties`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblroyalties` (
  `royaltyid` int(11) NOT NULL AUTO_INCREMENT,
  `branchid` int(11) DEFAULT NULL,
  `numofstudents` varchar(45) DEFAULT NULL,
  `numofelem` varchar(45) DEFAULT NULL,
  `numofint` varchar(45) DEFAULT NULL,
  `numofhigher` varchar(45) DEFAULT NULL,
  `sumofelem` varchar(45) DEFAULT NULL,
  `sumofint` varchar(45) DEFAULT NULL,
  `sumofhigher` varchar(45) DEFAULT NULL,
  `grandtotal` varchar(45) DEFAULT NULL,
  `month` varchar(45) DEFAULT NULL,
  `date` varchar(45) DEFAULT NULL,
  `schoolyear` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`royaltyid`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


--
-- Table structure for table `tblroyaltieslevel`
--

DROP TABLE IF EXISTS `tblroyaltieslevel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblroyaltieslevel` (
  `royaltieslevelid` int(11) NOT NULL AUTO_INCREMENT,
  `levelname` varchar(45) DEFAULT NULL,
  `royaltiesrate` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`royaltieslevelid`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


--
-- Table structure for table `tblschoolyears`
--

DROP TABLE IF EXISTS `tblschoolyears`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblschoolyears` (
  `syid` int(11) NOT NULL AUTO_INCREMENT,
  `schoolyear` varchar(45) DEFAULT NULL,
  `notes` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`syid`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

/*!40000 ALTER TABLE `tblschoolyears` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2011-08-11 20:36:53
