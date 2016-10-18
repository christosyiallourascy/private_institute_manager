-- MySQL dump 10.13  Distrib 5.5.9, for Win32 (x86)
--
-- Host: localhost    Database: private_institute
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
-- Current Database: `private_institute`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `private_institute` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `private_institute`;

--
-- Table structure for table `tblabsences`
--

DROP TABLE IF EXISTS `tblabsences`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblabsences` (
  `studentID` int(10) unsigned NOT NULL,
  `lessonID` int(10) unsigned NOT NULL,
  `absent` varchar(20) NOT NULL,
  PRIMARY KEY (`studentID`,`lessonID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


UNLOCK TABLES;

--
-- Table structure for table `tbladult`
--

DROP TABLE IF EXISTS `tbladult`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbladult` (
  `adultid` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(45) DEFAULT NULL,
  `firstname` varchar(45) DEFAULT NULL,
  `lastname` varchar(45) DEFAULT NULL,
  `middlename` varchar(45) DEFAULT NULL,
  `sex` varchar(45) DEFAULT NULL,
  `homephone` varchar(45) DEFAULT NULL,
  `mobilephone` varchar(45) DEFAULT NULL,
  `address` varchar(45) DEFAULT NULL,
  `city` varchar(45) DEFAULT NULL,
  `country` varchar(45) DEFAULT NULL,
  `nationality` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `age` varchar(45) DEFAULT NULL,
  `birthdate` varchar(45) DEFAULT NULL,
  `status` varchar(45) DEFAULT NULL,
  `dateissued` varchar(45) DEFAULT NULL,
  `idexams` varchar(45) DEFAULT NULL,
  `idnumber` varchar(45) DEFAULT NULL,
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `entereddate` varchar(45) DEFAULT NULL,
  `discount` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`adultid`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


UNLOCK TABLES;

--
-- Table structure for table `tbladultclass`
--

DROP TABLE IF EXISTS `tbladultclass`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbladultclass` (
  `classID` int(11) NOT NULL,
  `adultID` int(11) NOT NULL,
  `grade` double DEFAULT NULL,
  PRIMARY KEY (`classID`,`adultID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


/*!40000 ALTER TABLE `tbladultclass` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbladultpayment`
--

DROP TABLE IF EXISTS `tbladultpayment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbladultpayment` (
  `adultpaymentID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `adultid` int(10) unsigned NOT NULL,
  `paymentamount` varchar(45) DEFAULT NULL,
  `paymentdate` varchar(45) NOT NULL,
  `cheque` varchar(45) DEFAULT NULL,
  `chequenum` varchar(45) DEFAULT NULL,
  `month` varchar(45) DEFAULT NULL,
  `monthlyfee` varchar(45) DEFAULT NULL,
  `other` varchar(45) DEFAULT NULL,
  `receivedby` varchar(45) DEFAULT NULL,
  `bankname` varchar(45) DEFAULT NULL,
  `schoolyear` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`adultpaymentID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


UNLOCK TABLES;

--
-- Table structure for table `tblbranchinfo`
--

DROP TABLE IF EXISTS `tblbranchinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblbranchinfo` (
  `infoid` int(11) NOT NULL AUTO_INCREMENT,
  `branch` varchar(45) DEFAULT NULL,
  `vatnumber` varchar(45) DEFAULT NULL,
  `address` varchar(45) DEFAULT NULL,
  `website` varchar(45) DEFAULT NULL,
  `companybranchname` varchar(45) DEFAULT NULL,
  `notes` varchar(45) DEFAULT NULL,
  `vat` varchar(45) DEFAULT NULL,
  `royaltiesrate` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`infoid`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


UNLOCK TABLES;

--
-- Table structure for table `tblclass`
--

DROP TABLE IF EXISTS `tblclass`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblclass` (
  `classid` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `classname` varchar(45) NOT NULL,
  `instructorid` int(10) unsigned NOT NULL,
  `units` varchar(45) NOT NULL,
  `year` varchar(45) NOT NULL,
  `location` varchar(45) DEFAULT NULL,
  `room` varchar(45) NOT NULL,
  `day1` varchar(45) DEFAULT NULL,
  `time1` varchar(45) DEFAULT NULL,
  `time1a` varchar(45) DEFAULT NULL,
  `day2` varchar(45) DEFAULT NULL,
  `time2` varchar(45) DEFAULT NULL,
  `time2a` varchar(45) DEFAULT NULL,
  `max` varchar(45) DEFAULT NULL,
  `classfees` varchar(45) NOT NULL,
  `vatyesno` varchar(45) DEFAULT NULL,
  `classdiscount` varchar(20) DEFAULT NULL,
  `closed` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`classid`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


UNLOCK TABLES;

--
-- Table structure for table `tbldiscountlevel`
--

DROP TABLE IF EXISTS `tbldiscountlevel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbldiscountlevel` (
  `discountlevelid` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `discountname` varchar(45) NOT NULL,
  `discount` varchar(45) NOT NULL,
  PRIMARY KEY (`discountlevelid`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


UNLOCK TABLES;

--
-- Table structure for table `tblevents`
--

DROP TABLE IF EXISTS `tblevents`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblevents` (
  `eventid` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `eventname` varchar(45) DEFAULT NULL,
  `eventdate` varchar(45) DEFAULT NULL,
  `description` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`eventid`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


UNLOCK TABLES;

--
-- Table structure for table `tblexamoffer`
--

DROP TABLE IF EXISTS `tblexamoffer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblexamoffer` (
  `examofferid` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `examname` varchar(45) NOT NULL,
  `distributor` varchar(45) DEFAULT NULL,
  `subjectcode` varchar(45) NOT NULL,
  `base` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`examofferid`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


UNLOCK TABLES;

--
-- Table structure for table `tblguest`
--

DROP TABLE IF EXISTS `tblguest`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblguest` (
  `guestid` int(11) NOT NULL AUTO_INCREMENT,
  `firstname` varchar(45) DEFAULT NULL,
  `lastname` varchar(45) DEFAULT NULL,
  `fathername` varchar(45) DEFAULT NULL,
  `homephone` varchar(20) DEFAULT NULL,
  `mobilephone` varchar(20) DEFAULT NULL,
  `fatherphone` varchar(20) DEFAULT NULL,
  `motherphone` varchar(20) DEFAULT NULL,
  `age` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`guestid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblguest`
--

LOCK TABLES `tblguest` WRITE;
/*!40000 ALTER TABLE `tblguest` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblguest` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblinstructor`
--

DROP TABLE IF EXISTS `tblinstructor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblinstructor` (
  `instructorID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(45) NOT NULL,
  `LastName` varchar(45) NOT NULL,
  `PhoneNumber` varchar(45) DEFAULT NULL,
  `MobilePhone` varchar(45) NOT NULL,
  `Fax` varchar(45) DEFAULT NULL,
  `Address` varchar(45) NOT NULL,
  `City` varchar(45) NOT NULL,
  `PostalCode` varchar(45) NOT NULL,
  `BirthDate` varchar(45) NOT NULL,
  `Salary` varchar(45) NOT NULL,
  `SINumber` varchar(45) NOT NULL,
  `IDNumber` varchar(45) NOT NULL,
  PRIMARY KEY (`instructorID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


UNLOCK TABLES;

--
-- Table structure for table `tbllesson`
--

DROP TABLE IF EXISTS `tbllesson`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbllesson` (
  `lessonID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `classID` int(10) unsigned NOT NULL,
  `lessondate` varchar(45) NOT NULL,
  `materialteached` varchar(45) NOT NULL,
  `materialtoteachnext` varchar(45) NOT NULL,
  PRIMARY KEY (`lessonID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


UNLOCK TABLES;

--
-- Table structure for table `tbllevel`
--

DROP TABLE IF EXISTS `tbllevel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbllevel` (
  `levelid` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `levelname` varchar(45) NOT NULL,
  `hoursperweek` varchar(45) NOT NULL,
  `royaltiesrate` varchar(45) DEFAULT NULL,
  `notes` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`levelid`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


UNLOCK TABLES;

--
-- Table structure for table `tblpayment`
--

DROP TABLE IF EXISTS `tblpayment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblpayment` (
  `paymentID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `studentaccID` int(10) unsigned NOT NULL,
  `paymentamount` varchar(45) DEFAULT NULL,
  `paymentdate` varchar(45) NOT NULL,
  `cheque` varchar(45) DEFAULT NULL,
  `chequenum` varchar(45) DEFAULT NULL,
  `month` varchar(45) DEFAULT NULL,
  `monthlyfee` varchar(45) DEFAULT NULL,
  `other` varchar(45) DEFAULT NULL,
  `receivedby` varchar(45) DEFAULT NULL,
  `bankname` varchar(45) DEFAULT NULL,
  `schoolyear` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`paymentID`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


UNLOCK TABLES;

--
-- Table structure for table `tblroyalties`
--

DROP TABLE IF EXISTS `tblroyalties`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblroyalties` (
  `royaltyid` int(11) NOT NULL AUTO_INCREMENT,
  `numofstudents` varchar(45) DEFAULT NULL,
  `numofelem` varchar(45) DEFAULT NULL,
  `numofint` varchar(45) DEFAULT NULL,
  `numofhigher` varchar(45) DEFAULT NULL,
  `sumofelem` varchar(45) DEFAULT NULL,
  `sumofint` varchar(45) DEFAULT NULL,
  `sumofhigher` varchar(45) DEFAULT NULL,
  `grandtotal` varchar(45) DEFAULT NULL,
  `month` varchar(45) DEFAULT NULL,
  `schoolyear` varchar(45) DEFAULT NULL,
  `date` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`royaltyid`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


UNLOCK TABLES;

--
-- Table structure for table `tblstudent`
--

DROP TABLE IF EXISTS `tblstudent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblstudent` (
  `studentID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `studentaccID` int(10) unsigned NOT NULL,
  `title` varchar(45) DEFAULT NULL,
  `firstname` varchar(45) NOT NULL,
  `lastname` varchar(45) NOT NULL,
  `sex` varchar(45) NOT NULL,
  `middlename` varchar(45) DEFAULT NULL,
  `mobilephone` varchar(45) DEFAULT NULL,
  `birthdate` varchar(45) NOT NULL,
  `nationality` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `gradeatschool` varchar(45) DEFAULT NULL,
  `entereddate` varchar(45) NOT NULL,
  `age` varchar(45) NOT NULL,
  `status` varchar(20) DEFAULT NULL,
  `primaryschool` varchar(45) DEFAULT NULL,
  `secondaryschool` varchar(45) DEFAULT NULL,
  `lyciumschool` varchar(45) DEFAULT NULL,
  `sclass` varchar(45) DEFAULT NULL,
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `idnumber` varchar(45) DEFAULT NULL,
  `dateissued` varchar(20) DEFAULT NULL,
  `idexams` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`studentID`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;
/*!40101 SET character_set_client = @saved_cs_client */;


UNLOCK TABLES;

--
-- Table structure for table `tblstudentaccount`
--

DROP TABLE IF EXISTS `tblstudentaccount`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblstudentaccount` (
  `studentaccID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `fathername` varchar(45) NOT NULL,
  `fprofession` varchar(45) DEFAULT NULL,
  `mothername` varchar(45) NOT NULL,
  `mprofession` varchar(45) DEFAULT NULL,
  `discount` varchar(45) DEFAULT NULL,
  `nationality` varchar(45) DEFAULT NULL,
  `address` varchar(45) DEFAULT NULL,
  `city` varchar(45) DEFAULT NULL,
  `community` varchar(45) DEFAULT NULL,
  `postalcode` varchar(45) DEFAULT NULL,
  `homephone` varchar(45) NOT NULL,
  `workphone` varchar(45) DEFAULT NULL,
  `mobilefather` varchar(45) DEFAULT NULL,
  `mobilemother` varchar(45) DEFAULT NULL,
  `fax` varchar(45) DEFAULT NULL,
  `notes` varchar(45) DEFAULT NULL,
  `status` varchar(20) DEFAULT NULL,
  `familyname` varchar(45) DEFAULT NULL,
  `fatheremail` varchar(45) DEFAULT NULL,
  `motheremail` varchar(45) DEFAULT NULL,
  `area` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`studentaccID`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


UNLOCK TABLES;

--
-- Table structure for table `tblstudentclass`
--

DROP TABLE IF EXISTS `tblstudentclass`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblstudentclass` (
  `classID` int(10) unsigned NOT NULL,
  `studentID` int(10) unsigned NOT NULL,
  `grade` double DEFAULT NULL,
  PRIMARY KEY (`classID`,`studentID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


UNLOCK TABLES;

--
-- Table structure for table `tblstudentevents`
--

DROP TABLE IF EXISTS `tblstudentevents`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblstudentevents` (
  `studentid` int(11) NOT NULL,
  `eventid` int(11) NOT NULL,
  PRIMARY KEY (`studentid`,`eventid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


UNLOCK TABLES;

--
-- Table structure for table `tblstudentexam`
--

DROP TABLE IF EXISTS `tblstudentexam`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblstudentexam` (
  `studentexamid` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `examofferid` int(11) DEFAULT NULL,
  `studentid` int(11) DEFAULT NULL,
  `examdate` varchar(45) DEFAULT NULL,
  `grade` varchar(45) DEFAULT NULL,
  `examtime` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`studentexamid`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


UNLOCK TABLES;

--
-- Table structure for table `tbltemplate`
--

DROP TABLE IF EXISTS `tbltemplate`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbltemplate` (
  `templateid` int(11) NOT NULL AUTO_INCREMENT,
  `to` varchar(45) DEFAULT NULL,
  `subject` varchar(45) DEFAULT NULL,
  `body` longtext,
  `date` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`templateid`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2011-09-10 16:46:21
