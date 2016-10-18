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

--
-- Dumping data for table `tblabsences`
--

LOCK TABLES `tblabsences` WRITE;
/*!40000 ALTER TABLE `tblabsences` DISABLE KEYS */;
INSERT INTO `tblabsences` VALUES (7,2,'Checked'),(12,1,'Checked'),(13,3,'Checked'),(14,3,'Checked'),(16,3,'Checked'),(17,3,'Checked');
/*!40000 ALTER TABLE `tblabsences` ENABLE KEYS */;
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

--
-- Dumping data for table `tbladult`
--

LOCK TABLES `tbladult` WRITE;
/*!40000 ALTER TABLE `tbladult` DISABLE KEYS */;
INSERT INTO `tbladult` VALUES (1,'Mr','Periklis','Drousioths','Pavlis','Male','25142503','99635241','Kapou stin Ekali','Limassol','Cyprus','Cypriot','','03/03/1960','51','Active','30/6/2011','','45632987','','','30/6/2011','0');
/*!40000 ALTER TABLE `tbladult` ENABLE KEYS */;
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

--
-- Dumping data for table `tbladultclass`
--

LOCK TABLES `tbladultclass` WRITE;
/*!40000 ALTER TABLE `tbladultclass` DISABLE KEYS */;
INSERT INTO `tbladultclass` VALUES (10,1,NULL);
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

--
-- Dumping data for table `tbladultpayment`
--

LOCK TABLES `tbladultpayment` WRITE;
/*!40000 ALTER TABLE `tbladultpayment` DISABLE KEYS */;
INSERT INTO `tbladultpayment` VALUES (1,1,'100','2/7/2011','Checked','898656563232','6','100','ok','Periklis Drousioths','Bank Of Cyprus','2010 - 2011');
/*!40000 ALTER TABLE `tbladultpayment` ENABLE KEYS */;
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

--
-- Dumping data for table `tblbranchinfo`
--

LOCK TABLES `tblbranchinfo` WRITE;
/*!40000 ALTER TABLE `tblbranchinfo` DISABLE KEYS */;
INSERT INTO `tblbranchinfo` VALUES (1,'Ekali','22563366552536','ekalis','wwww.cybernetekalis.comlu.com','Vemar Computer Ltd','25526828','15','8');
/*!40000 ALTER TABLE `tblbranchinfo` ENABLE KEYS */;
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

--
-- Dumping data for table `tblclass`
--

LOCK TABLES `tblclass` WRITE;
/*!40000 ALTER TABLE `tblclass` DISABLE KEYS */;
INSERT INTO `tblclass` VALUES (1,'Intermediate III',2,'9','2010 - 2011','Main','A','Monday','15:10','17:10','','','','8','62','No','0','Yes'),(2,'Intermediate II',1,'10','2010 - 2011','Main','B','Monday','15:10','17:10','','','','8','62','No','0','Yes'),(3,'Higher I',1,'9','2010 - 2011','Main','A','Monday','17:20','19:20','','','','8','65','No','0','Yes'),(4,'Intermediate III',2,'9','2010 - 2011','Main','B','Monday','17:20','19:20','','','','8','62','No','0','Yes'),(5,'Intermediate II',1,'9','2010 - 2011','Main','A','Tuesday','15:10','17:10','','','','8','62','No','0','Yes'),(6,'Intermediate II',1,'9','2010 - 2011','Main','A','Tuesday','17:20','19:20','','','','8','62','No','0','Yes'),(7,'Higher I',1,'9','2010 - 2011','Main','B','Friday','15:10','17:10','','','','8','65','No','0','Yes'),(8,'Higher I',1,'9','2010 - 2011','Main','A','Friday','17:20','19:20','','','','8','65','No','0','Yes'),(9,'Higher I',1,'9','2010 - 2011','Main','B','Thursday','15:10','17:10','','','','8','65','No','0','Yes'),(10,'Adults',1,'8','2010 - 2011','Main','B','Thursday','17:20','19:20','','','','5','100','No','0','Yes'),(11,'Higher I',1,'9','2010 - 2011','Main','A','Saturday','9:00','11:00','','','','8','65','No','0','Yes'),(12,'GCE AS',1,'9','2010 - 2011','Main','A','Saturday','11:15','13:15','','','','6','85','No','0','Yes'),(13,'Intermediate III',1,'8','2010 - 2011','Main','A','Wednesday','15:10','17:10','','','','8','62','No','0','Yes'),(14,'Higher I',1,'8','2010 - 2011','Main','B','Wednesday','17:30','19:30','','','','8','65','No','0','Yes');
/*!40000 ALTER TABLE `tblclass` ENABLE KEYS */;
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

--
-- Dumping data for table `tbldiscountlevel`
--

LOCK TABLES `tbldiscountlevel` WRITE;
/*!40000 ALTER TABLE `tbldiscountlevel` DISABLE KEYS */;
INSERT INTO `tbldiscountlevel` VALUES (1,'Tow Childrens','5'),(2,'Three Childrens','10'),(3,'Normal','0');
/*!40000 ALTER TABLE `tbldiscountlevel` ENABLE KEYS */;
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

--
-- Dumping data for table `tblevents`
--

LOCK TABLES `tblevents` WRITE;
/*!40000 ALTER TABLE `tblevents` DISABLE KEYS */;
INSERT INTO `tblevents` VALUES (1,'WaterPark','27/6/2011','Fasouri'),(2,'Athkiaseroi','22/6/2011','oi athkiaseroi en polloi en einai mono enas');
/*!40000 ALTER TABLE `tblevents` ENABLE KEYS */;
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

--
-- Dumping data for table `tblexamoffer`
--

LOCK TABLES `tblexamoffer` WRITE;
/*!40000 ALTER TABLE `tblexamoffer` DISABLE KEYS */;
INSERT INTO `tblexamoffer` VALUES (1,'Βασικές Γνώσεις Πληροφορικής','ICT Europe','Μ1','70'),(2,'Χρήση Η/Υ και Διαχείριση Αρχείων','ICT Europe','Μ2','70'),(3,'Επεξεργασία Κειμένου','ICT Europe','M3','70'),(4,'Υπολογιστικά Φύλλα','ICT Europe','M4','70'),(5,'Υπηρεσίες Διαδικτύου','ICT Europe','M5','70'),(6,'Βάσεις Δεδομένων','ICT Europe','M6','70'),(7,'Παρουσιάσεις','ICT Europe','M7','70');
/*!40000 ALTER TABLE `tblexamoffer` ENABLE KEYS */;
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

--
-- Dumping data for table `tblinstructor`
--

LOCK TABLES `tblinstructor` WRITE;
/*!40000 ALTER TABLE `tblinstructor` DISABLE KEYS */;
INSERT INTO `tblinstructor` VALUES (1,'Christos','Yiallouras','25391657','99343548','25555555','37th street k. polemidia','Limassol','4152','04/06/1983','1025','4234234234234','850072'),(2,'Andreas','Andreou','25','99876543','25223344','monovolikos','Limassol','3322','15/04/1976','1200','545567878','323454');
/*!40000 ALTER TABLE `tblinstructor` ENABLE KEYS */;
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

--
-- Dumping data for table `tbllesson`
--

LOCK TABLES `tbllesson` WRITE;
/*!40000 ALTER TABLE `tbllesson` DISABLE KEYS */;
INSERT INTO `tbllesson` VALUES (1,14,'24/11/2010','ms access','ms excel, ms powerpoint'),(2,9,'5/5/2011','theory','theory'),(3,6,'11/5/2011','power point k6, askhsh','power point k7 k8 k9');
/*!40000 ALTER TABLE `tbllesson` ENABLE KEYS */;
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

--
-- Dumping data for table `tbllevel`
--

LOCK TABLES `tbllevel` WRITE;
/*!40000 ALTER TABLE `tbllevel` DISABLE KEYS */;
INSERT INTO `tbllevel` VALUES (1,'Elementary I','2','4',NULL),(2,'Elementary II','2','4',NULL),(3,'Elementary III','2','4',NULL),(4,'Intermediate I','2','5',NULL),(5,'Intermediate II','2','5',NULL),(6,'Intermediate III','2','5',NULL),(7,'Higher I','2','6',NULL),(8,'Higher II','2','6',NULL),(9,'Higher II','2','6',NULL),(10,'GCE AS','2','6',NULL),(11,'GCE A2','4','6',NULL),(12,'Adults','2','6',NULL);
/*!40000 ALTER TABLE `tbllevel` ENABLE KEYS */;
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

--
-- Dumping data for table `tblpayment`
--

LOCK TABLES `tblpayment` WRITE;
/*!40000 ALTER TABLE `tblpayment` DISABLE KEYS */;
INSERT INTO `tblpayment` VALUES (1,10,'117.8','21/11/2010','Checked','453535353','11','117,8','tipote','Eleonora & Eliza','Bank Of Cyprus','2010 - 2011'),(2,12,'62','21/11/2010','Checked','34343434','11','62','TEST','Andreas Xristodoulou','spe polenidion','2010 - 2011'),(3,13,'62','21/11/2010','Checked','4353535353','11','62','test','Rafaellos Papageorgiou','spe agias fylas','2010 - 2011'),(4,10,'117,8','22/11/2010','Checked','4242342342342','10','117,8','test kai touto','Eleonora Alonefti','Bank of cyprus','2010 - 2011'),(5,10,'117,8','22/11/2010','Checked','5656565','9','117,8','test again','Eliza Alonefti','bank of cyprus','2010 - 2011'),(6,2,'62','26/11/2010','Checked','7686868','11','62','test','Studentb Familyb','trapeza','2010 - 2011'),(7,10,'117,8','20/1/2011','Checked','2342544557','1','117,8','ok','Eleonora Alonefti','Bank OF Cyprus','2010 - 2011'),(8,10,'117,8','20/1/2011','Checked','456547678','12','117,8','ok','Eliza Alonefti','Bank Of Cyprus','2010 - 2011'),(9,13,'124','20/1/2011','Checked','234356565','12, 1','124','ok','Rafaellos Papageorgiou','Spe kapu','2010 - 2011'),(10,10,'351','9/4/2011','Checked','656565656','2, 3, 4','351','ok','Eleonora Alonefti','Bank of cyprus','2010 - 2011'),(11,12,'310','22/4/2011','Checked','251478963','12, 1, 2 ,3, 4','310','ok','Andreas Xristodoulou','Bank Of Cyprus','2010 - 2011'),(12,10,'117','3/5/2011','Checked','332256698','5','117','ok','Eliza Alonefti','Bank Of Cyprus','2010 - 2011'),(13,12,'62','3/5/2011','Checked','4444444444444','5','62','ok','Andreas Xristodoulou','Bank Of Cyprus','2010 - 2011'),(14,13,'310','18/6/2011','Checked','25668886633','2, 3, 4, 5, 6','62','','Rafaellos Papageorgiou','SPE Daskalon','2010 - 2011'),(15,15,'117,8','23/6/2011','Checked','45454545454','6','117,8','οκ','Έλενα Ιωάννου','ΣΠΕ ΓΕΡΜΑΣΟΓΕΙΑΣ','2010 - 2011'),(16,10,'117,8','30/6/2011','Checked','98656532','6','117,8','','Eleonora Alonefti','Bank Of Cyprus','2010 - 2011');
/*!40000 ALTER TABLE `tblpayment` ENABLE KEYS */;
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

--
-- Dumping data for table `tblroyalties`
--

LOCK TABLES `tblroyalties` WRITE;
/*!40000 ALTER TABLE `tblroyalties` DISABLE KEYS */;
INSERT INTO `tblroyalties` VALUES (1,'9','0','7','2','0','208,32','62,4','270.72','6','2010 - 2011','15/6/2011'),(2,'11','0','9','2','0','267,84','62,4','329','5','2010 - 2011','25/7/2011');
/*!40000 ALTER TABLE `tblroyalties` ENABLE KEYS */;
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

--
-- Dumping data for table `tblstudent`
--

LOCK TABLES `tblstudent` WRITE;
/*!40000 ALTER TABLE `tblstudent` DISABLE KEYS */;
INSERT INTO `tblstudent` VALUES (1,2,'Mr','Studentb','Familyb','Male','Fatherb','9913456','11/11/2000','Cypriot','studentb@gmail.com','15','20/10/2009','9','Active','Ε','','',NULL,'studentb','s25223344%','23456721','20/10/2009',''),(2,4,NULL,'Studentd','Lastnamed','Male',NULL,NULL,'01/01/2000',NULL,NULL,NULL,'10/02/2010','10','Active','E','','',NULL,NULL,NULL,NULL,NULL,NULL),(3,4,NULL,'Studentd1','Lastnamed1','Female',NULL,NULL,'01/10/1998',NULL,NULL,NULL,'10/2/2010','12','Active','','A','',NULL,NULL,NULL,NULL,NULL,NULL),(4,3,NULL,'ΜαθητήςΓ','ΕπύθετοΓ','Male',NULL,NULL,'10/10/98',NULL,NULL,NULL,'10/2/2010','12','Active','','A','',NULL,NULL,NULL,NULL,NULL,NULL),(5,3,NULL,'StudentG1','LastnameG1','Male',NULL,NULL,'10/10/97',NULL,NULL,NULL,'10/2/2010','13','Active','','B','',NULL,NULL,NULL,NULL,NULL,NULL),(6,2,NULL,'StudentB1','Lastnameb1','Male',NULL,NULL,'02/06/1998',NULL,NULL,NULL,'11/2/2010','12','Active','','A','',NULL,NULL,NULL,NULL,NULL,NULL),(7,6,NULL,'Kyriakos','Yiallouras','Male',NULL,NULL,'15/04/2003',NULL,NULL,NULL,'5/11/2010','7','Active','A','','',NULL,NULL,NULL,NULL,NULL,NULL),(8,1,NULL,'Kostas','Kosta','Male',NULL,NULL,'01/01/1998',NULL,NULL,NULL,'7/11/2010','12','Active','A','','',NULL,NULL,NULL,NULL,NULL,NULL),(9,8,NULL,'Andreas','Kyriakou','Male',NULL,NULL,'10/10/1998',NULL,NULL,NULL,'7/11/2010','12','Active','','Α','',NULL,NULL,NULL,NULL,NULL,NULL),(10,1,NULL,'Nicolas','Kosta','Male',NULL,NULL,'03/04/2000',NULL,NULL,NULL,'7/11/2010','10','Active','Ε','','',NULL,NULL,NULL,NULL,NULL,NULL),(11,9,NULL,'Elena','Andreou','Female',NULL,NULL,'10/10/1999',NULL,NULL,NULL,'7/11/2010','11','Active','','Α','',NULL,NULL,NULL,NULL,NULL,NULL),(12,9,NULL,'Eleonora','Andreou','Female',NULL,NULL,'30/05/1997',NULL,NULL,NULL,'7/11/2010','13','Active','','Α','',NULL,NULL,NULL,NULL,NULL,NULL),(13,10,NULL,'Eliza','Alonefti','Female',NULL,NULL,'12/12/1998',NULL,NULL,NULL,'7/11/2010','12','Active','','Α','',NULL,NULL,NULL,'923650',NULL,NULL),(14,10,NULL,'Eleonora','Alonefti','Female',NULL,NULL,'12/03/1997',NULL,NULL,NULL,'7/11/2010','13','Active','','Α','',NULL,NULL,NULL,'926551',NULL,NULL),(15,11,NULL,'Andreas','Alexandrou','Male',NULL,NULL,'24/04/2000',NULL,NULL,NULL,'14/11/2010','10','Active','Ε','','',NULL,NULL,NULL,NULL,NULL,NULL),(16,12,NULL,'Andreas','Xristodoulou','Male',NULL,NULL,'23/10/1998',NULL,NULL,NULL,'16/11/2010','12','Active','','Α','',NULL,NULL,NULL,NULL,NULL,NULL),(17,13,NULL,'Rafaellos','Papageorgiou','Male',NULL,NULL,'12/12/1998',NULL,NULL,NULL,'16/11/2010','12','Active','','Α','',NULL,NULL,NULL,NULL,NULL,NULL),(18,12,'Teen','Maria','Xristodoulou','Female','Antros','99854722','1/1/1998','Cypriot','m.xristodoulou@hotmail.com','','','15','Inactive','','Agias Fylas','','','m.xristodoulou','m25669988%','9266398','30/04/2010',''),(19,15,NULL,'Έλενα','Ιωάννου','Female',NULL,NULL,'02/02/1998',NULL,NULL,NULL,'22/6/2011','13','Active','','Β','',NULL,NULL,NULL,NULL,NULL,NULL),(20,15,NULL,'Αγγέλα','Ιωάννου','Female',NULL,NULL,'02/05/1999',NULL,NULL,NULL,'22/6/2011','12','Active','','Α','',NULL,NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `tblstudent` ENABLE KEYS */;
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

--
-- Dumping data for table `tblstudentaccount`
--

LOCK TABLES `tblstudentaccount` WRITE;
/*!40000 ALTER TABLE `tblstudentaccount` DISABLE KEYS */;
INSERT INTO `tblstudentaccount` VALUES (1,'Fathera','Fprofessiona','Mothera','Mprofessiona','5','Cyprus','address1','Limassol','','2536','25111111','25','99111111','96111111','','','Active','Familya','fathera@gmail.com','mothera@yahoo.com','Areaa'),(2,'Fatherb','Fprofessionb','Motherb','Mprofessionb','0','Cypriot','address2','Limassol','','3658','25222222','25','99222222','96222222','','','Active','Famlimyb','fatherb@gmail.com','motherb@hotmail.com','Areab'),(3,'Fatherc','Fprofessionc','Motherc','Mprofessionc','0','Cypriot','address3','Limassol','','1425','25333333','25','99333333','96333333','','nothing','Active','Familyc','fatherc@gmail.com','motherc@yahoo.com','Areac'),(4,'Fatherd','Fprofessiond','Motherd','Mprofessiond','0','Cypriot','address4','Limassol','','1258','25444444','25','99444444','96444444','','nothing','Active','Familyd','fatherd@hotmail.com','motherd@gmail.com','aread'),(5,'Fathere','Fprofessione','Mothere','Mprofessione','0','Cypriot','address5','Limassol','','5522','25555555','25','99555555','96555555','','nothing e','Active','Familye','fathere@hotmail.com','mothere@gmail.com','areae'),(6,'Andreas','Banker','Evi','Accountant','5','','Monovolikos','','','','25123456','25','99424217','99776655','','','Active','Yiallouras','','',''),(7,'Andreas','Banker','Ioanna','Banker','0',NULL,'Kapou stin Ekali',NULL,NULL,NULL,'25434343',NULL,'99888888','99334477',NULL,NULL,'Active',NULL,NULL,NULL,NULL),(8,'Ioannis','Teacher','Pavlina','Teacher','0',NULL,'Velanidiwn 5',NULL,NULL,NULL,'25098765',NULL,'99785634','96787878',NULL,NULL,'Active',NULL,NULL,NULL,NULL),(9,'Michalis','Private employee','Ioulia','Teacher','5','','Kapou stin lemeso 5','','','','25775566','25','99881100','96882233','','','Active','Andreou','','',''),(10,'Pavlos','Manager','Loukia','Manager','5','','Kapou stin ekali 12','','','','25343433','25','99887711','96123543','','','Active','Alonefti','','',''),(11,'Nicolas','kati kanei','Koulla','nikotzira','0',NULL,'kapou 12',NULL,NULL,NULL,'25771100',NULL,'99993311','96123242',NULL,NULL,'Active','Alexandrou',NULL,NULL,NULL),(12,'Antros','Kati','Maria','Kati kanei','0','','kapou allou','','','','25477008','25','99778800','96432760','','','Active','Xristodoulou','','',''),(13,'Andreas','Xerw egw','Katia','Kathete','0','','kapou kapote','','','','25440032','25','99123321','99000000','','','Active','Papageorgiou','','',''),(14,'Παύλος','Καλουπαντζής','Κούλλα','Καλουπαντζίνα',NULL,NULL,'Κάπου στην Κύπρο',NULL,NULL,NULL,'24391657',NULL,'99881345','96231416',NULL,NULL,'Active','Παυλίνου',NULL,NULL,NULL),(15,'Κώστας','Καλούπια','Άντρια','Οικοκύρα','5','','Εκάλι κάπου εκεί','','','','25001122','25','99123456','99456123','','','Active','Ιωάννου','','','');
/*!40000 ALTER TABLE `tblstudentaccount` ENABLE KEYS */;
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

--
-- Dumping data for table `tblstudentclass`
--

LOCK TABLES `tblstudentclass` WRITE;
/*!40000 ALTER TABLE `tblstudentclass` DISABLE KEYS */;
INSERT INTO `tblstudentclass` VALUES (5,1,NULL),(5,2,NULL),(5,3,NULL),(6,13,NULL),(6,14,NULL),(6,16,NULL),(6,17,NULL),(9,7,NULL),(13,19,NULL),(13,20,NULL),(14,12,NULL);
/*!40000 ALTER TABLE `tblstudentclass` ENABLE KEYS */;
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

--
-- Dumping data for table `tblstudentevents`
--

LOCK TABLES `tblstudentevents` WRITE;
/*!40000 ALTER TABLE `tblstudentevents` DISABLE KEYS */;
INSERT INTO `tblstudentevents` VALUES (5,2),(6,2),(9,2),(12,2);
/*!40000 ALTER TABLE `tblstudentevents` ENABLE KEYS */;
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

--
-- Dumping data for table `tblstudentexam`
--

LOCK TABLES `tblstudentexam` WRITE;
/*!40000 ALTER TABLE `tblstudentexam` DISABLE KEYS */;
INSERT INTO `tblstudentexam` VALUES (1,3,13,'5/3/2011','85',NULL),(2,3,14,'5/3/2011','93',NULL);
/*!40000 ALTER TABLE `tblstudentexam` ENABLE KEYS */;
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

--
-- Dumping data for table `tbltemplate`
--

LOCK TABLES `tbltemplate` WRITE;
/*!40000 ALTER TABLE `tbltemplate` DISABLE KEYS */;
INSERT INTO `tbltemplate` VALUES (1,'Γονείς','Water Park','Εν να πάμε να λουθούμεν τα νέρα πάλε','27/6/2011');
/*!40000 ALTER TABLE `tbltemplate` ENABLE KEYS */;
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
