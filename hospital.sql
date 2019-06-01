CREATE DATABASE  IF NOT EXISTS `hospital` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `hospital`;


DROP TABLE IF EXISTS `accountant`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `accountant` (
  `Acct_ID` int(11) NOT NULL,
  `Acct_Name` char(20) DEFAULT NULL,
  `Age` int(11) DEFAULT NULL,
  `Working_Time` varchar(45) DEFAULT NULL,
  `Address` varchar(45) DEFAULT NULL,
  `Salary` int(11) DEFAULT NULL,
  `Mob_num` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`Acct_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `accountant`
--

LOCK TABLES `accountant` WRITE;
/*!40000 ALTER TABLE `accountant` DISABLE KEYS */;
INSERT INTO `accountant` (`Acct_ID`, `Acct_Name`, `Age`, `Working_Time`, `Address`, `Salary`, `Mob_num`) VALUES (1,'Aleena Hassan',24,'Evening','H#19, st#10, I-8/1, Islamabad',20000,'0336-8366947'),(2,'Sarwat Vusqa',20,'Afternoon','House10, st19, I-8/2, Pindi',30000,'0336-8366948'),(3,'Suzie Wilbur Jimmy',19,'Morning','Suzie Xzavier & Donald Aaron 199 Burbank,CA',30000,'818-555-9999'),(4,'George K\nDanny',20,'Evening','Suzie Xzavier & Donald Aaron 200 Burbank,CA',20000,'818-555-0000'),(5,'Haider Agha',22,'Evening','Bahria town, phase 2, Rawalpindi',20000,'0334-56735478');
/*!40000 ALTER TABLE `accountant` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `admission`
--

DROP TABLE IF EXISTS `admission`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `admission` (
  `Admission_ID` int(11) NOT NULL,
  `Patient_ID` int(11) DEFAULT NULL,
  `Room_ID` int(11) DEFAULT NULL,
  `Rep_ID` int(11) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  `Time` time DEFAULT NULL,
  PRIMARY KEY (`Admission_ID`),
  KEY `Patient_ID_idx` (`Patient_ID`),
  KEY `Room_ID_idx` (`Room_ID`),
  KEY `Rep_ID_idx` (`Rep_ID`),
  CONSTRAINT `Patient2_ID` FOREIGN KEY (`Patient_ID`) REFERENCES `patient` (`Patient_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Rep_ID` FOREIGN KEY (`Rep_ID`) REFERENCES `receptionist` (`Rep_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Room_ID` FOREIGN KEY (`Room_ID`) REFERENCES `room` (`Room_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `admission`
--

LOCK TABLES `admission` WRITE;
/*!40000 ALTER TABLE `admission` DISABLE KEYS */;
INSERT INTO `admission` (`Admission_ID`, `Patient_ID`, `Room_ID`, `Rep_ID`, `Date`, `Time`) VALUES (1,1,1,1,'2015-01-11','01:29:00'),(2,2,2,2,'2015-02-11','11:29:00'),(3,4,5,3,'2015-04-11','01:57:00'),(4,3,3,1,'2015-01-11','01:29:00'),(5,5,3,1,'2015-01-11','03:45:00');
/*!40000 ALTER TABLE `admission` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ambulance`
--

DROP TABLE IF EXISTS `ambulance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ambulance` (
  `Ambulance_ID` int(11) NOT NULL,
  `Ambulance_Num` varchar(45) DEFAULT NULL,
  `Ambulance_capacity` int(11) DEFAULT NULL,
  PRIMARY KEY (`Ambulance_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ambulance`
--

LOCK TABLES `ambulance` WRITE;
/*!40000 ALTER TABLE `ambulance` DISABLE KEYS */;
INSERT INTO `ambulance` (`Ambulance_ID`, `Ambulance_Num`, `Ambulance_capacity`) VALUES (1,'Amb001',5),(2,'Amb002',5),(3,'Amb003',5),(4,'Amb004',3),(5,'Amb005',3);
/*!40000 ALTER TABLE `ambulance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ambulance_service`
--

DROP TABLE IF EXISTS `ambulance_service`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ambulance_service` (
  `AS_ID` int(11) NOT NULL,
  `Patient_ID` int(11) DEFAULT NULL,
  `Driver_ID` int(11) DEFAULT NULL,
  `Ambulance_ID` int(11) DEFAULT NULL,
  PRIMARY KEY (`AS_ID`),
  KEY `Patien_ID_idx` (`Patient_ID`),
  KEY `Driver_ID_idx` (`Driver_ID`),
  KEY `Ambulance_ID_idx` (`Ambulance_ID`),
  CONSTRAINT `Ambulance_ID` FOREIGN KEY (`Ambulance_ID`) REFERENCES `ambulance` (`Ambulance_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Driver_ID` FOREIGN KEY (`Driver_ID`) REFERENCES `driver` (`Driver_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Patient_ID` FOREIGN KEY (`Patient_ID`) REFERENCES `patient` (`Patient_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ambulance_service`
--

LOCK TABLES `ambulance_service` WRITE;
/*!40000 ALTER TABLE `ambulance_service` DISABLE KEYS */;
INSERT INTO `ambulance_service` (`AS_ID`, `Patient_ID`, `Driver_ID`, `Ambulance_ID`) VALUES (1,1,1,5),(2,2,2,1),(3,3,3,2),(4,4,4,4),(5,5,5,2);
/*!40000 ALTER TABLE `ambulance_service` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `appointment`
--

DROP TABLE IF EXISTS `appointment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `appointment` (
  `App_ID` int(11) NOT NULL,
  `Patient_ID` int(11) DEFAULT NULL,
  `Doc_ID` int(11) DEFAULT NULL,
  `Rep_ID` int(11) DEFAULT NULL,
  `App_Date` date DEFAULT NULL,
  `App_Time` time DEFAULT NULL,
  PRIMARY KEY (`App_ID`),
  KEY `Patient_ID_idx` (`Patient_ID`),
  KEY `Doc_ID_idx` (`Doc_ID`),
  KEY `Rep_ID_idx` (`Rep_ID`),
  CONSTRAINT `Doc_ID` FOREIGN KEY (`Doc_ID`) REFERENCES `doctor` (`Doc_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Patient3_ID` FOREIGN KEY (`Patient_ID`) REFERENCES `patient` (`Patient_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Rep1_ID` FOREIGN KEY (`Rep_ID`) REFERENCES `receptionist` (`Rep_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `appointment`
--

LOCK TABLES `appointment` WRITE;
/*!40000 ALTER TABLE `appointment` DISABLE KEYS */;
INSERT INTO `appointment` (`App_ID`, `Patient_ID`, `Doc_ID`, `Rep_ID`, `App_Date`, `App_Time`) VALUES (1,1,2,1,'2015-01-12','02:00:00'),(2,2,3,2,'2015-10-12','05:00:00'),(3,3,3,3,'2015-12-10','12:00:00'),(4,3,4,1,'2015-11-10','04:00:00'),(5,2,5,1,'2015-12-09','08:00:00');
/*!40000 ALTER TABLE `appointment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `assist`
--

DROP TABLE IF EXISTS `assist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `assist` (
  `Serial_Num` int(11) NOT NULL,
  `Patient_ID` int(11) DEFAULT NULL,
  `Doc_ID` int(11) DEFAULT NULL,
  `Test_ID` int(11) DEFAULT NULL,
  `Time` time DEFAULT NULL,
  `Date` date DEFAULT NULL,
  PRIMARY KEY (`Serial_Num`),
  KEY `Patie_ID_idx` (`Patient_ID`),
  KEY `Doctor_ID_idx` (`Doc_ID`),
  KEY `Test_ID_idx` (`Test_ID`),
  CONSTRAINT `Doct1or_ID` FOREIGN KEY (`Doc_ID`) REFERENCES `doctor` (`Doc_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Patie1_ID` FOREIGN KEY (`Patient_ID`) REFERENCES `patient` (`Patient_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Test1_ID` FOREIGN KEY (`Test_ID`) REFERENCES `test` (`Test_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `assist`
--

LOCK TABLES `assist` WRITE;
/*!40000 ALTER TABLE `assist` DISABLE KEYS */;
INSERT INTO `assist` (`Serial_Num`, `Patient_ID`, `Doc_ID`, `Test_ID`, `Time`, `Date`) VALUES (1,1,2,1,'01:30:00','2015-01-10'),(2,2,2,2,'01:35:00','2015-10-10'),(3,3,3,3,'12:30:00','2015-12-08'),(4,4,4,4,'03:30:00','2016-10-09'),(5,5,5,5,'12:30:00','2015-11-12');
/*!40000 ALTER TABLE `assist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bill`
--

DROP TABLE IF EXISTS `bill`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bill` (
  `Bill_ID` int(11) NOT NULL,
  `Bill_Purpose` varchar(45) DEFAULT NULL,
  `Bill_Total` int(11) DEFAULT NULL,
  PRIMARY KEY (`Bill_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bill`
--

LOCK TABLES `bill` WRITE;
/*!40000 ALTER TABLE `bill` DISABLE KEYS */;
INSERT INTO `bill` (`Bill_ID`, `Bill_Purpose`, `Bill_Total`) VALUES (1,'Discharge payment',20000),(2,'Discharge payment',40000),(3,'Test 1 payment',5000),(4,'Test 2 payment',2000),(5,'Test 3 payment',1500),(6,'Test 3 payment',2000),(7,'Test 4  payment',4300);
/*!40000 ALTER TABLE `bill` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `carriers`
--

DROP TABLE IF EXISTS `carriers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `carriers` (
  `CR_ID` int(11) NOT NULL,
  `CR_Name` char(20) DEFAULT NULL,
  `Mob_Num` varchar(20) DEFAULT NULL,
  `Address` varchar(45) DEFAULT NULL,
  `Salary` int(11) DEFAULT NULL,
  PRIMARY KEY (`CR_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `carriers`
--

LOCK TABLES `carriers` WRITE;
/*!40000 ALTER TABLE `carriers` DISABLE KEYS */;
INSERT INTO `carriers` (`CR_ID`, `CR_Name`, `Mob_Num`, `Address`, `Salary`) VALUES (1,'Chukandar Karela','0332-5356454','H#13, st#2, I-8/1, Islamabad',10000),(2,'Faraz hassan','0313-5353954','H#17, st#25, I-10/1, Islamabad',10000),(3,'Hassan Shabir','0342-7685431','H#152, st#92, G-8/1, Islamabad',10000),(4,'Muneeb Babar','0313-6543210','H#344-Q, st#72, G-11/2, Islamabad',10000),(5,'Ali Farman','0333-5249188','H#764, st#109, H-13/1, Islamabad',10000);
/*!40000 ALTER TABLE `carriers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `carrying_service`
--

DROP TABLE IF EXISTS `carrying_service`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `carrying_service` (
  `Crrs_ID` int(11) NOT NULL,
  `CR_ID` int(11) DEFAULT NULL,
  `Ambulance_ID` int(11) DEFAULT NULL,
  `Patient_ID` int(11) DEFAULT NULL,
  PRIMARY KEY (`Crrs_ID`),
  KEY `CR_ID_idx` (`CR_ID`),
  KEY `Ambulance_ID_idx` (`Ambulance_ID`),
  KEY `Patient_ID_idx` (`Patient_ID`),
  CONSTRAINT `Ambulancee_ID` FOREIGN KEY (`Ambulance_ID`) REFERENCES `ambulance` (`Ambulance_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `CRR_ID` FOREIGN KEY (`CR_ID`) REFERENCES `carriers` (`CR_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Patientt_ID` FOREIGN KEY (`Patient_ID`) REFERENCES `patient` (`Patient_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `carrying_service`
--

LOCK TABLES `carrying_service` WRITE;
/*!40000 ALTER TABLE `carrying_service` DISABLE KEYS */;
INSERT INTO `carrying_service` (`Crrs_ID`, `CR_ID`, `Ambulance_ID`, `Patient_ID`) VALUES (1,1,5,1),(2,2,3,2),(3,3,2,3),(4,4,2,4),(5,5,1,5);
/*!40000 ALTER TABLE `carrying_service` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cleaning_service`
--

DROP TABLE IF EXISTS `cleaning_service`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cleaning_service` (
  `CS_ID` int(11) NOT NULL,
  `Patient_ID` int(11) DEFAULT NULL,
  `WB_ID` int(11) DEFAULT NULL,
  `Room_ID` int(11) DEFAULT NULL,
  PRIMARY KEY (`CS_ID`),
  KEY `Patient_ID_idx` (`Patient_ID`),
  KEY `WB_ID_idx` (`WB_ID`),
  KEY `Rom_ID_idx` (`Room_ID`),
  CONSTRAINT `Patient5_ID` FOREIGN KEY (`Patient_ID`) REFERENCES `patient` (`Patient_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Room3_ID` FOREIGN KEY (`Room_ID`) REFERENCES `room` (`Room_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `WB_ID` FOREIGN KEY (`WB_ID`) REFERENCES `ward_boy` (`WB_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cleaning_service`
--

LOCK TABLES `cleaning_service` WRITE;
/*!40000 ALTER TABLE `cleaning_service` DISABLE KEYS */;
INSERT INTO `cleaning_service` (`CS_ID`, `Patient_ID`, `WB_ID`, `Room_ID`) VALUES (1,1,1,1),(2,2,2,2),(3,3,3,2),(4,4,4,4),(5,5,5,5);
/*!40000 ALTER TABLE `cleaning_service` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `department`
--

DROP TABLE IF EXISTS `department`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `department` (
  `Dept_ID` int(11) NOT NULL,
  `Dept_Name` varchar(45) DEFAULT NULL,
  `Treatment` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Dept_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `department`
--

LOCK TABLES `department` WRITE;
/*!40000 ALTER TABLE `department` DISABLE KEYS */;
INSERT INTO `department` (`Dept_ID`, `Dept_Name`, `Treatment`) VALUES (1,'Cardiology','Heart treatment'),(2,'Neurology',' botulinium toxin injections'),(3,'Artheopedic ',' nonsteroidal anti-inflammatory drugs '),(4,'Oncology ',' Chemo'),(5,'Pulmonology ',' Ventilation ');
/*!40000 ALTER TABLE `department` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `doctor`
--

DROP TABLE IF EXISTS `doctor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `doctor` (
  `Doc_ID` int(11) NOT NULL,
  `Doc_Name` char(45) NOT NULL,
  `Passed_From` varchar(45) NOT NULL,
  `Age` int(11) DEFAULT NULL,
  `Address` varchar(45) DEFAULT NULL,
  `Designation` varchar(45) DEFAULT NULL,
  `Speciality` varchar(45) DEFAULT NULL,
  `Salary` int(11) DEFAULT NULL,
  PRIMARY KEY (`Doc_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `doctor`
--

LOCK TABLES `doctor` WRITE;
/*!40000 ALTER TABLE `doctor` DISABLE KEYS */;
INSERT INTO `doctor` (`Doc_ID`, `Doc_Name`, `Passed_From`, `Age`, `Address`, `Designation`, `Speciality`, `Salary`) VALUES (1,'Urwat-Til-Vusqa','Army medical college',30,'House#19, st#10, Cat#2, I-8/1, Islamabad','Head of Neuorosurgery','Neurosurgeon',100000),(2,'Arshad Nazir','Al-Shifa',50,'House#30, st#1, I-8/4, Islamabad','None','Cardiologist',100000),(3,'Nadeem Ahmed','Rifa International',50,'H#213, St#13, F-9/2, Islamabad','Head of Cardiology','Cardiosurgeon',200000),(4,'Hammad Tahir','King Edward Medical College',47,'H#751, St#57, F-10/2, Islamabad','Head ofNeurology','Neurosurgeon',270000),(5,'Hamza Abbasi','Army Medical College',52,'H#76-B, St#10, G-13/2, Islamabad','Oncologist','Oncologic surgery',225000),(6,'Osama Hamid','Shifa Medical College',47,'H#517, St#89, I-9/2, Islamabad','Nephrologist','Kidney Transplant surgery',195000),(7,'Christian Grey','  Minnesota’s Mayo Medical School',33,'H#87, St#19, Bahria Town, Islamabad','Ortheopefician','Ortheopedicsurgeon',185000);
/*!40000 ALTER TABLE `doctor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `doctor_from_dept`
--

DROP TABLE IF EXISTS `doctor_from_dept`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `doctor_from_dept` (
  `DFD_ID` int(11) NOT NULL,
  `Doc_ID` int(11) DEFAULT NULL,
  `Dept_ID` int(11) DEFAULT NULL,
  PRIMARY KEY (`DFD_ID`),
  KEY `Docto_ID_idx` (`Doc_ID`),
  KEY `Depart_ID_idx` (`Dept_ID`),
  CONSTRAINT `Depart_ID` FOREIGN KEY (`Dept_ID`) REFERENCES `department` (`Dept_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Docto_ID` FOREIGN KEY (`Doc_ID`) REFERENCES `doctor` (`Doc_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `doctor_from_dept`
--

LOCK TABLES `doctor_from_dept` WRITE;
/*!40000 ALTER TABLE `doctor_from_dept` DISABLE KEYS */;
INSERT INTO `doctor_from_dept` (`DFD_ID`, `Doc_ID`, `Dept_ID`) VALUES (1,2,1),(2,2,2),(3,1,1),(4,4,4),(5,3,2);
/*!40000 ALTER TABLE `doctor_from_dept` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `driver`
--

DROP TABLE IF EXISTS `driver`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `driver` (
  `Driver_ID` int(11) NOT NULL,
  `Driver_name` char(45) NOT NULL,
  `Mob_num` varchar(20) DEFAULT NULL,
  `Address` varchar(45) DEFAULT NULL,
  `Salary` int(11) DEFAULT NULL,
  `Shift` char(20) DEFAULT NULL,
  PRIMARY KEY (`Driver_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `driver`
--

LOCK TABLES `driver` WRITE;
/*!40000 ALTER TABLE `driver` DISABLE KEYS */;
INSERT INTO `driver` (`Driver_ID`, `Driver_name`, `Mob_num`, `Address`, `Salary`, `Shift`) VALUES (1,'Urwat Poopsie','0333-1682131','Gali#1, I-8/1, Islamabad',12000,'Morning'),(2,'Hannan Rehmat','0332-5798562','House 157,Street#89, I-11/1, Islamabad',15000,'Evening'),(3,'farman bukhari','0321-8674309','Gali#9,G-10/1, Islamabad',12000,'Morning'),(4,'Zegham khan','0334-7685761','Flat#55,Gov. Appartments,G-9/1,Islamabad',12000,'Evening'),(5,'Sikandar hayat','0312-7653422','Gali#1, I-8/3,Islamabad',12000,'Morning');
/*!40000 ALTER TABLE `driver` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medication`
--

DROP TABLE IF EXISTS `medication`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `medication` (
  `Med_ID` int(11) NOT NULL,
  `Med_Name` varchar(45) DEFAULT NULL,
  `Company` varchar(45) DEFAULT NULL,
  `Man_Date` date DEFAULT NULL,
  `Exp_Date` date DEFAULT NULL,
  `Price` int(11) DEFAULT NULL,
  PRIMARY KEY (`Med_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medication`
--

LOCK TABLES `medication` WRITE;
/*!40000 ALTER TABLE `medication` DISABLE KEYS */;
INSERT INTO `medication` (`Med_ID`, `Med_Name`, `Company`, `Man_Date`, `Exp_Date`, `Price`) VALUES (1,'Clinagel','Nofartist','2015-01-11','2015-02-22',200),(2,'Tears plus','Nofartist','2015-01-11','2015-10-01',400),(3,'Accutane',' AKRIMAX PHARMACEUTICALS','2014-01-01','2016-10-01',700),(4,' Alprazolam ',' Multum','2014-01-01','2016-10-01',700),(5,' Gablofen ',' FDA','2014-01-10','2016-10-01',1100),(6,'Xenical',' AFAXYS PHARMACEUTICALS','2014-01-11','2016-12-01',1700);
/*!40000 ALTER TABLE `medication` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nurse`
--

DROP TABLE IF EXISTS `nurse`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `nurse` (
  `Nurse_ID` int(11) NOT NULL,
  `Nurse_Name` char(45) DEFAULT NULL,
  `Age` int(11) DEFAULT NULL,
  `Address` varchar(45) DEFAULT NULL,
  `WorkShift` enum('morning','afternoon','night') DEFAULT NULL,
  `Experience` varchar(45) DEFAULT NULL,
  `salary` int(11) DEFAULT NULL,
  PRIMARY KEY (`Nurse_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nurse`
--

LOCK TABLES `nurse` WRITE;
/*!40000 ALTER TABLE `nurse` DISABLE KEYS */;
INSERT INTO `nurse` (`Nurse_ID`, `Nurse_Name`, `Age`, `Address`, `WorkShift`, `Experience`, `salary`) VALUES (1,'Faseeh Rasool',19,'5674 Treeline Drive, Cheviot Hills,CA','night','None',10000),(2,'habiba haseeb',22,'House# 176, Street# 89, H-8 ','morning','1 year',10000),(3,'Kulsoom Naveed',20,'House#234, Street 98, G-7/1 , Islamabad','night','1 year',10000),(4,'Nawaz Sharif',24,'House 432, Street 154, G-8/2, Islamabad','morning','2 Year',12000),(5,'Ahmed Naveed',22,'House # 431, Street # 200, H-9/1, Islamabad','night','1 year',10000),(6,'Dumsah Waseem',20,'House#19, street10','morning','none',11000),(7,'Haleema farook',29,'block#17, f-8/4','night','2 years',12000),(8,'test',20,'house19street10','night','none',120000);
/*!40000 ALTER TABLE `nurse` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nursing_service`
--

DROP TABLE IF EXISTS `nursing_service`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `nursing_service` (
  `NS_ID` int(11) NOT NULL,
  `Nurse_ID` int(11) DEFAULT NULL,
  `Patient_ID` int(11) DEFAULT NULL,
  `Room_ID` int(11) DEFAULT NULL,
  PRIMARY KEY (`NS_ID`),
  KEY `Nurse_ID_idx` (`Nurse_ID`),
  KEY `Patient_ID_idx` (`Patient_ID`),
  KEY `Room_ID_idx` (`Room_ID`),
  CONSTRAINT `Nurse_ID` FOREIGN KEY (`Nurse_ID`) REFERENCES `nurse` (`Nurse_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Patient4_ID` FOREIGN KEY (`Patient_ID`) REFERENCES `patient` (`Patient_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Room2_ID` FOREIGN KEY (`Room_ID`) REFERENCES `room` (`Room_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nursing_service`
--

LOCK TABLES `nursing_service` WRITE;
/*!40000 ALTER TABLE `nursing_service` DISABLE KEYS */;
INSERT INTO `nursing_service` (`NS_ID`, `Nurse_ID`, `Patient_ID`, `Room_ID`) VALUES (1,1,1,1),(2,2,2,2),(3,3,3,3),(4,4,4,4),(5,5,5,5);
/*!40000 ALTER TABLE `nursing_service` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `op_theater`
--

DROP TABLE IF EXISTS `op_theater`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `op_theater` (
  `OT_ID` int(11) NOT NULL,
  `OT_Room` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`OT_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `op_theater`
--

LOCK TABLES `op_theater` WRITE;
/*!40000 ALTER TABLE `op_theater` DISABLE KEYS */;
INSERT INTO `op_theater` (`OT_ID`, `OT_Room`) VALUES (1,'Ot01'),(2,'Ot02'),(3,'Ot03'),(4,'Ot04'),(5,'Ot05');
/*!40000 ALTER TABLE `op_theater` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `operation`
--

DROP TABLE IF EXISTS `operation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `operation` (
  `OP_ID` int(11) NOT NULL,
  `Doc_ID` int(11) DEFAULT NULL,
  `Patient_ID` int(11) DEFAULT NULL,
  `OT_ID` int(11) DEFAULT NULL,
  `OP_Date` date DEFAULT NULL,
  `OP_Time` time DEFAULT NULL,
  PRIMARY KEY (`OP_ID`),
  KEY `Doct_ID_idx` (`Doc_ID`),
  KEY `Pati_ID_idx` (`Patient_ID`),
  KEY `Otp_ID_idx` (`OT_ID`),
  CONSTRAINT `Doct_ID` FOREIGN KEY (`Doc_ID`) REFERENCES `doctor` (`Doc_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Otp_ID` FOREIGN KEY (`OT_ID`) REFERENCES `op_theater` (`OT_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Pati_ID` FOREIGN KEY (`Patient_ID`) REFERENCES `patient` (`Patient_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `operation`
--

LOCK TABLES `operation` WRITE;
/*!40000 ALTER TABLE `operation` DISABLE KEYS */;
INSERT INTO `operation` (`OP_ID`, `Doc_ID`, `Patient_ID`, `OT_ID`, `OP_Date`, `OP_Time`) VALUES (1,2,1,1,'2015-01-30','19:00:00'),(2,2,2,2,'2015-02-20','17:00:00'),(3,3,3,3,'2015-04-25','01:00:00'),(4,1,4,4,'2015-01-25','19:30:00'),(5,3,5,5,'2015-12-25','23:35:00');
/*!40000 ALTER TABLE `operation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patient`
--

DROP TABLE IF EXISTS `patient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `patient` (
  `Patient_ID` int(11) NOT NULL,
  `Patient_Name` char(20) DEFAULT NULL,
  `Age` int(11) DEFAULT NULL,
  `Gender` enum('Male','Female') DEFAULT NULL,
  `Address` varchar(45) DEFAULT NULL,
  `D-O-B` date DEFAULT NULL,
  `Mob_num` varchar(20) DEFAULT NULL,
  `Dicharged` char(10) DEFAULT NULL,
  PRIMARY KEY (`Patient_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patient`
--

LOCK TABLES `patient` WRITE;
/*!40000 ALTER TABLE `patient` DISABLE KEYS */;
INSERT INTO `patient` (`Patient_ID`, `Patient_Name`, `Age`, `Gender`, `Address`, `D-O-B`, `Mob_num`, `Dicharged`) VALUES (1,'Aleena Yunus',18,'Female','1987 Allegheny Ct.Westlake Village,CA','1994-05-19','0333-3323169','No'),(2,'Ramsha Waseem',20,'Female','House 543, Askari Town, RawalPindi','1994-06-15','0332-83765783','No'),(3,'Muheeb Mustafa',50,'Male','House 432, Sadar , Rawalpindi','1954-05-19','0333-3323169','No'),(4,'Kamran Liaqat',27,'Male','1965 Allegheny Ct.Westlake Village,WestIndies','1987-07-25','0333-7694684','Yes'),(5,'Fahana Babar',56,'Female','House 76-C, Street 25, F-7/1 , Islamabad','1965-05-19','0333-336587169','Yes');
/*!40000 ALTER TABLE `patient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payment`
--

DROP TABLE IF EXISTS `payment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `payment` (
  `Pay_ID` int(11) NOT NULL,
  `Accnt_ID` int(11) DEFAULT NULL,
  `Bill_ID` int(11) DEFAULT NULL,
  `Patient_ID` int(11) DEFAULT NULL,
  `Pay_Date` date DEFAULT NULL,
  `Pay_Time` time DEFAULT NULL,
  PRIMARY KEY (`Pay_ID`),
  KEY `Patient_ID_idx` (`Patient_ID`),
  KEY `Accnt_ID_idx` (`Accnt_ID`),
  KEY `Bill_ID_idx` (`Bill_ID`),
  CONSTRAINT `Accnt1_ID` FOREIGN KEY (`Accnt_ID`) REFERENCES `accountant` (`Acct_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Bill1_ID` FOREIGN KEY (`Bill_ID`) REFERENCES `bill` (`Bill_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Patient1_ID` FOREIGN KEY (`Patient_ID`) REFERENCES `patient` (`Patient_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payment`
--

LOCK TABLES `payment` WRITE;
/*!40000 ALTER TABLE `payment` DISABLE KEYS */;
INSERT INTO `payment` (`Pay_ID`, `Accnt_ID`, `Bill_ID`, `Patient_ID`, `Pay_Date`, `Pay_Time`) VALUES (1,2,3,1,'2015-01-11','01:15:00'),(2,1,2,2,'2015-12-30','12:15:00'),(3,3,1,3,'2015-02-25','10:15:00'),(4,4,4,4,'2015-04-11','01:30:00'),(5,5,5,5,'2015-10-27','16:15:00');
/*!40000 ALTER TABLE `payment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prescription`
--

DROP TABLE IF EXISTS `prescription`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prescription` (
  `Prs_ID` int(11) NOT NULL,
  `Doc_ID` int(11) DEFAULT NULL,
  `Med_ID` int(11) DEFAULT NULL,
  `Patient_ID` int(11) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  `Fee` int(11) DEFAULT NULL,
  PRIMARY KEY (`Prs_ID`),
  KEY `Doctor_ID_idx` (`Doc_ID`),
  KEY `Medi_ID_idx` (`Med_ID`),
  KEY `Pat_ID_idx` (`Patient_ID`),
  CONSTRAINT `Doctor_ID` FOREIGN KEY (`Doc_ID`) REFERENCES `doctor` (`Doc_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Medi_ID` FOREIGN KEY (`Med_ID`) REFERENCES `medication` (`Med_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Pat_ID` FOREIGN KEY (`Patient_ID`) REFERENCES `patient` (`Patient_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prescription`
--

LOCK TABLES `prescription` WRITE;
/*!40000 ALTER TABLE `prescription` DISABLE KEYS */;
INSERT INTO `prescription` (`Prs_ID`, `Doc_ID`, `Med_ID`, `Patient_ID`, `Date`, `Fee`) VALUES (1,2,1,1,'2015-01-08',1000),(2,1,2,2,'2015-01-09',1700),(3,3,3,3,'2015-12-23',5000),(4,4,4,4,'2015-10-18',2000),(5,5,5,5,'2015-02-15',2500),(6,3,5,5,NULL,600),(7,4,4,4,'2015-01-27',600),(8,3,2,5,'2015-01-27',400);
/*!40000 ALTER TABLE `prescription` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `receptionist`
--

DROP TABLE IF EXISTS `receptionist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `receptionist` (
  `Rep_ID` int(11) NOT NULL,
  `Rep_Name` char(20) DEFAULT NULL,
  `Age` int(11) DEFAULT NULL,
  `Address` varchar(45) DEFAULT NULL,
  `Mob_Num` varchar(20) DEFAULT NULL,
  `Shift` enum('morning','afternoon','night') DEFAULT NULL,
  PRIMARY KEY (`Rep_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `receptionist`
--

LOCK TABLES `receptionist` WRITE;
/*!40000 ALTER TABLE `receptionist` DISABLE KEYS */;
INSERT INTO `receptionist` (`Rep_ID`, `Rep_Name`, `Age`, `Address`, `Mob_Num`, `Shift`) VALUES (1,'Nyma Altaf',23,'199 Country Club Drive,Burbank,CA','0313-3232324','morning'),(2,'Arham Abbas',22,'H#32, St# 54,Gulshan Ravi,lahore','0313-7653321','afternoon'),(3,'Amna Hameed',21,'House # 21, Street 7, G-11/4,Islamabad','0313-68756872','morning');
/*!40000 ALTER TABLE `receptionist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `room`
--

DROP TABLE IF EXISTS `room`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `room` (
  `Room_ID` int(11) NOT NULL,
  `Room_num` int(11) DEFAULT NULL,
  `Room_Type` varchar(45) DEFAULT NULL,
  `Room_Cost` int(11) DEFAULT NULL,
  PRIMARY KEY (`Room_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `room`
--

LOCK TABLES `room` WRITE;
/*!40000 ALTER TABLE `room` DISABLE KEYS */;
INSERT INTO `room` (`Room_ID`, `Room_num`, `Room_Type`, `Room_Cost`) VALUES (1,1,'Patient room',2000),(2,2,'VIP Patient Room',10000),(3,3,'VVIP Patient room',35000),(4,4,'Patient room #02',2000),(5,5,'Waiting Room',0);
/*!40000 ALTER TABLE `room` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `test`
--

DROP TABLE IF EXISTS `test`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `test` (
  `Test_ID` int(11) NOT NULL,
  `Test_Name` varchar(45) NOT NULL,
  `Date` date NOT NULL,
  `Rep_Date` date NOT NULL,
  `Fee` int(11) NOT NULL,
  PRIMARY KEY (`Test_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `test`
--

LOCK TABLES `test` WRITE;
/*!40000 ALTER TABLE `test` DISABLE KEYS */;
INSERT INTO `test` (`Test_ID`, `Test_Name`, `Date`, `Rep_Date`, `Fee`) VALUES (1,'Blood sugar level','2015-01-10','2015-01-20',2000),(2,'Bronchoscopy','2015-02-23','2015-03-03',6000),(3,'MRI','2015-02-10','2015-02-11',5000),(4,'CT Scan','2015-01-12','2015-01-13',5400),(5,'Cholesterol level','2015-01-10','2015-01-20',2000);
/*!40000 ALTER TABLE `test` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ward_boy`
--

DROP TABLE IF EXISTS `ward_boy`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ward_boy` (
  `WB_ID` int(11) NOT NULL,
  `WB_Name` char(45) DEFAULT NULL,
  `Mob_num` varchar(20) DEFAULT NULL,
  `Shift` enum('morning','afternoon','night') DEFAULT NULL,
  `Salary` int(11) DEFAULT NULL,
  PRIMARY KEY (`WB_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ward_boy`
--

LOCK TABLES `ward_boy` WRITE;
/*!40000 ALTER TABLE `ward_boy` DISABLE KEYS */;
INSERT INTO `ward_boy` (`WB_ID`, `WB_Name`, `Mob_num`, `Shift`, `Salary`) VALUES (1,'Timmy Khan','0323-323232','night',2000),(2,'Amamr Hakeem','0323-72648798','morning',2000),(3,'Hamid Naeem','0323-6729874','night',2000),(4,'Amir Liaqat','0323-3756089','morning',2000),(5,'Kamaran Aslam','0332-7835602','night',2000);
/*!40000 ALTER TABLE `ward_boy` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
