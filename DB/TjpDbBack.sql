CREATE DATABASE  IF NOT EXISTS `tjpdb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `tjpdb`;
-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: tjpdb
-- ------------------------------------------------------
-- Server version	8.0.32

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `administrator`
--

DROP TABLE IF EXISTS `administrator`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `administrator` (
  `uid` char(36) NOT NULL,
  `id` varchar(100) NOT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  PRIMARY KEY (`uid`),
  KEY `idx_admin` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='	';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `administrator`
--

LOCK TABLES `administrator` WRITE;
/*!40000 ALTER TABLE `administrator` DISABLE KEYS */;
INSERT INTO `administrator` VALUES ('bd0b8d6f-1ab6-423d-abd7-cd5fcde9170a','22342','admin','admin');
/*!40000 ALTER TABLE `administrator` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `collection`
--

DROP TABLE IF EXISTS `collection`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `collection` (
  `uid` char(36) NOT NULL,
  `id` varchar(100) NOT NULL,
  `customer_uid` char(36) NOT NULL,
  `loan_information_uid` char(36) NOT NULL,
  `collection_amount` decimal(10,2) NOT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`uid`),
  KEY `colIndex` (`uid`),
  KEY `fk_customer_id_idx` (`customer_uid`),
  KEY `fk_loan_information_id_idx` (`loan_information_uid`),
  CONSTRAINT `fk_customer_id` FOREIGN KEY (`customer_uid`) REFERENCES `customer_account` (`uid`),
  CONSTRAINT `fk_loan_information_id` FOREIGN KEY (`loan_information_uid`) REFERENCES `loan_information` (`uid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `collection`
--

LOCK TABLES `collection` WRITE;
/*!40000 ALTER TABLE `collection` DISABLE KEYS */;
INSERT INTO `collection` VALUES ('0ea7297e-89f2-4a2f-817f-9a243a1f6bbf','193237174-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','bf836c9e-387f-4fe9-9919-0421d5b17ca0',37800.00,'2023-03-17'),('12fe72d0-a96a-45d5-99f5-066fe81faba4','105173237-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','5a69591c-afa1-4a22-b49c-5d77ca3eaea2',3000.00,'2023-03-31'),('146c84ec-2764-42f7-b20c-8a8573995cef','129357992-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','bf836c9e-387f-4fe9-9919-0421d5b17ca0',3246.00,'2023-03-17'),('1ef3f245-342f-4e98-9a74-7b342a492e4f','145148376-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','bf836c9e-387f-4fe9-9919-0421d5b17ca0',20.00,'2023-03-13'),('2a56b844-05b3-49be-98bd-3e9796372d91','189404092-2023','071bac76-565e-4b99-bf5a-7e9515e15a8f','1ac4428e-e2f2-47c1-b3ea-75d2f31ee565',500.00,'2023-06-04'),('2b07e10a-2a78-4c5b-9c85-bfbcde819264','159949342-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',364.00,'2023-06-24'),('2d7c5509-b5f5-463d-825a-1444c3e16315','189082670-2023','071bac76-565e-4b99-bf5a-7e9515e15a8f','c34787f8-dfa0-4007-91e6-c2a054f1b199',1200.00,'2023-06-04'),('37f3ac9a-6278-46ce-99fb-c0cf5bf35626','130827462-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',100.00,'2023-05-04'),('535143c4-93dc-4660-8ddb-8dc5c6880984','194462961-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',400.00,'2023-05-13'),('5414d40f-e298-4c2e-ad74-5cc9be5516ad','123908557-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','fbcc229a-7f5b-4119-9efb-985805dde8b7',28.00,'2023-06-24'),('5c78ee7e-e53a-4fe7-a26e-6379360c9b3e','153611083-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',400.00,'2023-05-02'),('617d6a71-1860-44c0-8e6e-45b971022d42','109303338-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','bf836c9e-387f-4fe9-9919-0421d5b17ca0',500.00,'2023-03-17'),('70115d19-ae18-40ff-97da-d64e9e4a27b3','197296740-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','bf836c9e-387f-4fe9-9919-0421d5b17ca0',12.00,'2023-03-17'),('740faabd-259a-4a21-a58b-bb95acc684f5','146574245-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','31e4a483-750f-4906-85b8-5f6fc473f3cf',100.00,'2023-05-02'),('7a9947b4-17cd-4488-8abf-37b36d93d1fb','172501186-2023','071bac76-565e-4b99-bf5a-7e9515e15a8f','5bb28e57-488d-4f0f-b85b-42c99c04427a',1400.00,'2023-06-05'),('7b862b87-7c62-44d3-bf5a-8223009122e6','171570950-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',400.00,'2023-05-13'),('7d154036-f86b-479f-a8c1-549d6f91a340','116979107-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','bf836c9e-387f-4fe9-9919-0421d5b17ca0',12.00,'2023-03-17'),('873bade1-e28a-4e77-aab6-34d50b357842','105575028-2023','071bac76-565e-4b99-bf5a-7e9515e15a8f','1ac4428e-e2f2-47c1-b3ea-75d2f31ee565',100.00,'2023-06-04'),('91fd39a2-7876-11ec-90ae-74d02be5638f','1231135-2022','0a2e3418-cd79-4e09-9196-fb15e5efb7be','9677ed4a-43f1-433c-938e-80f0b39cd6df',10.00,'2022-01-18'),('9359e267-7876-11ec-90ae-74d02be5638f','1231135-2022','0a2e3418-cd79-4e09-9196-fb15e5efb7be','9677ed4a-43f1-433c-938e-80f0b39cd6df',10.00,'2022-01-18'),('93e91239-7876-11ec-90ae-74d02be5638f','1231135-2022','0a2e3418-cd79-4e09-9196-fb15e5efb7be','9677ed4a-43f1-433c-938e-80f0b39cd6df',10.00,'2022-01-18'),('9467d73d-2862-45e9-9003-850869d6d009','186278343-2023','071bac76-565e-4b99-bf5a-7e9515e15a8f','5bb28e57-488d-4f0f-b85b-42c99c04427a',100.00,'2023-06-05'),('95a53607-76e3-11ec-9684-74d02be5638f','2021-22314414','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',23.00,'2022-01-16'),('9e492f34-215e-4d19-a5a4-65aa0b67b77c','113668830-2023','071bac76-565e-4b99-bf5a-7e9515e15a8f','7f409f92-f620-4faa-9054-c63c0e3442f4',1000.00,'2023-06-24'),('a7fe68de-501b-4367-9123-e2e760bf3671','124186767-2023','071bac76-565e-4b99-bf5a-7e9515e15a8f','7f409f92-f620-4faa-9054-c63c0e3442f4',300.00,'2023-06-24'),('ad6d8d08-76e3-11ec-9684-74d02be5638f','2021-22314414','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',23.00,'2022-01-16'),('ae1b5a97-76e3-11ec-9684-74d02be5638f','2021-22314414','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',23.00,'2022-01-16'),('af1faddb-76e3-11ec-9684-74d02be5638f','2021-22314414','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',23.00,'2022-01-16'),('afc163ef-76e3-11ec-9684-74d02be5638f','2021-22314414','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',23.00,'2022-01-16'),('b02c864d-76e3-11ec-9684-74d02be5638f','2021-22314414','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',23.00,'2022-01-16'),('b0693127-1f8e-4e4a-b123-440d5c575a3b','196100720-2023','071bac76-565e-4b99-bf5a-7e9515e15a8f','1ac4428e-e2f2-47c1-b3ea-75d2f31ee565',500.00,'2023-06-04'),('c16bca24-4f40-4f69-b32b-48635428a7fe','155691751-2023','071bac76-565e-4b99-bf5a-7e9515e15a8f','1ac4428e-e2f2-47c1-b3ea-75d2f31ee565',100.00,'2023-06-04'),('c49d2932-eb04-4b36-92d4-25041645e7b8','179661260-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','bf836c9e-387f-4fe9-9919-0421d5b17ca0',400.00,'2023-03-17'),('d4b63d54-3cfc-4a1c-9020-c5a47363844c','106195084-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','31e4a483-750f-4906-85b8-5f6fc473f3cf',1340.00,'2023-06-08'),('d7901bef-33fc-485f-acf9-853777e39cc4','145606239-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','bf836c9e-387f-4fe9-9919-0421d5b17ca0',10.00,'2023-03-13'),('dbf05e1a-11c3-4f12-b460-4a81a3b7265e','162679141-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','dde73ead-09c1-460f-b07e-af81d2b26a3f',100.00,'2023-06-21'),('ef2e5e3b-e1cc-416b-8eec-1982831abf3b','192526466-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','dde73ead-09c1-460f-b07e-af81d2b26a3f',1200.00,'2023-06-24');
/*!40000 ALTER TABLE `collection` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer_account`
--

DROP TABLE IF EXISTS `customer_account`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer_account` (
  `uid` char(36) NOT NULL,
  `id` varchar(100) NOT NULL,
  `name` varchar(100) NOT NULL,
  `address` varchar(200) NOT NULL,
  `contact_number` char(14) NOT NULL,
  PRIMARY KEY (`uid`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  KEY `idx_customer` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer_account`
--

LOCK TABLES `customer_account` WRITE;
/*!40000 ALTER TABLE `customer_account` DISABLE KEYS */;
INSERT INTO `customer_account` VALUES ('071bac76-565e-4b99-bf5a-7e9515e15a8f','101934821-2022','Kirito Uzumaki','saldjhqdquh','8347624'),('0a2e3418-cd79-4e09-9196-fb15e5efb7be','111920785-2021','john wick','purok green leaves mibang','123989');
/*!40000 ALTER TABLE `customer_account` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer_business_info`
--

DROP TABLE IF EXISTS `customer_business_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer_business_info` (
  `uid` char(36) NOT NULL,
  `id` varchar(100) NOT NULL,
  `customer_uid` char(36) NOT NULL,
  `name` varchar(50) NOT NULL,
  `nature` varchar(50) DEFAULT NULL,
  `address` varchar(100) NOT NULL,
  `gross_business_capital` decimal(10,2) DEFAULT NULL,
  `average_daily_gross_sales` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`uid`),
  UNIQUE KEY `customer_uid` (`customer_uid`),
  KEY `bus_indx` (`customer_uid`),
  CONSTRAINT `FK_cusbusinesstocusaccount` FOREIGN KEY (`customer_uid`) REFERENCES `customer_account` (`uid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer_business_info`
--

LOCK TABLES `customer_business_info` WRITE;
/*!40000 ALTER TABLE `customer_business_info` DISABLE KEYS */;
INSERT INTO `customer_business_info` VALUES ('993c7230-bfc5-44f6-b569-5b6538737fe9','101934821-2022','071bac76-565e-4b99-bf5a-7e9515e15a8f','asofihfoqh','aodiqodij','asofihfoqh',24876.00,23476.00),('b0f48705-28b9-434c-8e63-ec78c13bef8c','111920785-2021','0a2e3418-cd79-4e09-9196-fb15e5efb7be','asdkjh','akjh','asdkjh',122.00,123.00);
/*!40000 ALTER TABLE `customer_business_info` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `loan_information`
--

DROP TABLE IF EXISTS `loan_information`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `loan_information` (
  `uid` char(36) NOT NULL,
  `id` varchar(100) DEFAULT NULL,
  `customer_uid` char(36) NOT NULL,
  `payment_term` varchar(50) NOT NULL,
  `duration` int NOT NULL,
  `effective_date` date NOT NULL,
  `interest` decimal(10,2) unsigned NOT NULL,
  `principal_loan` decimal(10,2) unsigned NOT NULL,
  `status` varchar(50) DEFAULT 'Unpaid',
  PRIMARY KEY (`uid`),
  KEY `fk_loantocustomer_acc_idx` (`customer_uid`),
  CONSTRAINT `fk_loancustomerid_customerid` FOREIGN KEY (`customer_uid`) REFERENCES `customer_account` (`uid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `loan_information`
--

LOCK TABLES `loan_information` WRITE;
/*!40000 ALTER TABLE `loan_information` DISABLE KEYS */;
INSERT INTO `loan_information` VALUES ('1ac4428e-e2f2-47c1-b3ea-75d2f31ee565','135760899-2023','071bac76-565e-4b99-bf5a-7e9515e15a8f','Daily',30,'2023-06-04',20.00,1000.00,'Fully Paid'),('31e4a483-750f-4906-85b8-5f6fc473f3cf','126748266-2022','0a2e3418-cd79-4e09-9196-fb15e5efb7be','Daily',60,'2022-03-21',20.00,1200.00,'Fully Paid'),('51f44357-5cef-11ec-bf7a-74d02be5638f','111920785-2020','0a2e3418-cd79-4e09-9196-fb15e5efb7be','daily',30,'2021-12-14',0.20,1200.00,'Bad Debt'),('5a69591c-afa1-4a22-b49c-5d77ca3eaea2','152924695-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','Daily',30,'2023-03-31',2.00,1000.00,'Fully Paid'),('5bb28e57-488d-4f0f-b85b-42c99c04427a','121054554-2023','071bac76-565e-4b99-bf5a-7e9515e15a8f','Daily',30,'2023-06-05',20.00,1000.00,'Fully Paid'),('7f409f92-f620-4faa-9054-c63c0e3442f4','107627321-2023','071bac76-565e-4b99-bf5a-7e9515e15a8f','Daily',60,'2023-06-21',20.00,1000.00,'Fully Paid'),('80aa37ec-629d-4e88-bdd5-e59e614ab7e4','154323717-2022','071bac76-565e-4b99-bf5a-7e9515e15a8f','Daily',30,'2022-05-29',20.00,1000.00,'Fully Paid'),('9677ed4a-43f1-433c-938e-80f0b39cd6df','198037871-2021','0a2e3418-cd79-4e09-9196-fb15e5efb7be','Daily',30,'2021-12-19',20.00,1000.00,'Fully Paid'),('bf836c9e-387f-4fe9-9919-0421d5b17ca0','166840711-2022','0a2e3418-cd79-4e09-9196-fb15e5efb7be','Daily',60,'2022-11-01',20.00,2000.00,'Fully Paid'),('c34787f8-dfa0-4007-91e6-c2a054f1b199','187306430-2023','071bac76-565e-4b99-bf5a-7e9515e15a8f','Daily',30,'2023-06-04',20.00,1000.00,'Fully Paid'),('dde73ead-09c1-460f-b07e-af81d2b26a3f','137356529-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','Daily',30,'2023-06-21',20.00,1000.00,'Fully Paid'),('ea500314-9d35-40f9-a621-1ea800d83e68','100439555-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','Daily',30,'2023-06-24',20.00,1000.00,'Unpaid'),('f7cf751a-2468-4afc-a8e1-b9be79caa87c','138968069-2022','0a2e3418-cd79-4e09-9196-fb15e5efb7be','Daily',60,'2022-03-21',20.00,1000.00,'Fully Paid'),('fbcc229a-7f5b-4119-9efb-985805dde8b7','141070883-2022','0a2e3418-cd79-4e09-9196-fb15e5efb7be','Daily',60,'2022-03-21',20.00,23.00,'Fully Paid');
/*!40000 ALTER TABLE `loan_information` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `penalty`
--

DROP TABLE IF EXISTS `penalty`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `penalty` (
  `uid` char(36) NOT NULL,
  `id` varchar(100) NOT NULL,
  `customer_uid` char(36) NOT NULL,
  `loan_information_uid` char(36) NOT NULL,
  `penalty_amount` decimal(10,2) NOT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`uid`),
  KEY `index2` (`id`),
  KEY `fk_customer_uid_index` (`customer_uid`),
  KEY `fk_penalty_loan_information_uid_idx` (`loan_information_uid`),
  CONSTRAINT `fk_penalty_customer_account_uid` FOREIGN KEY (`customer_uid`) REFERENCES `customer_account` (`uid`),
  CONSTRAINT `fk_penalty_loan_information_uid` FOREIGN KEY (`loan_information_uid`) REFERENCES `loan_information` (`uid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `penalty`
--

LOCK TABLES `penalty` WRITE;
/*!40000 ALTER TABLE `penalty` DISABLE KEYS */;
INSERT INTO `penalty` VALUES ('0b51e647-9480-4d62-aad6-84d878508813','127980425-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','dde73ead-09c1-460f-b07e-af81d2b26a3f',100.00,'2023-06-21'),('114c0f32-a093-4ed0-a64a-7faf00371512','186033541-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',100.00,'2023-05-04'),('3243aa0e-9d53-4761-8c40-96f2a917dbec','117072962-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',100.00,'2023-05-25'),('3f9b80f0-0c9c-45a2-bfac-3fc6ef1cee9d','123419433-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',100.00,'2023-05-02'),('596a7935-0b80-43d8-8190-0ccc527b891a','122288079-2023','071bac76-565e-4b99-bf5a-7e9515e15a8f','7f409f92-f620-4faa-9054-c63c0e3442f4',100.00,'2023-06-21'),('6e50134a-8c6e-4ebd-bf8c-793d6fe7b1a4','195350238-2023','071bac76-565e-4b99-bf5a-7e9515e15a8f','5bb28e57-488d-4f0f-b85b-42c99c04427a',200.00,'2023-06-05'),('7965cf42-7031-4815-b8c9-9e9525daa0a3','142196989-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',100.00,'2023-05-04'),('ba8d4f51-828f-4389-8ac4-3328c082c8de','145181489-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','ea500314-9d35-40f9-a621-1ea800d83e68',500.00,'2023-06-24'),('bce46757-923f-4585-82d6-08106df346a8','185762316-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',100.00,'2023-05-23'),('d480eaf1-ed39-4251-8f0f-8eaa3a43eec7','180567346-2023','071bac76-565e-4b99-bf5a-7e9515e15a8f','5bb28e57-488d-4f0f-b85b-42c99c04427a',100.00,'2023-06-05'),('ee3530aa-4024-4ad2-a557-0745041567d8','141716144-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',100.00,'2023-05-04');
/*!40000 ALTER TABLE `penalty` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_system_account`
--

DROP TABLE IF EXISTS `user_system_account`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user_system_account` (
  `uid` char(36) NOT NULL,
  `id` varchar(100) DEFAULT NULL,
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`uid`),
  KEY `idx_user` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_system_account`
--

LOCK TABLES `user_system_account` WRITE;
/*!40000 ALTER TABLE `user_system_account` DISABLE KEYS */;
INSERT INTO `user_system_account` VALUES ('466414dd-b2b8-11ec-82b2-fc349701f832','123','user','user');
/*!40000 ALTER TABLE `user_system_account` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `v_customerinformation`
--

DROP TABLE IF EXISTS `v_customerinformation`;
/*!50001 DROP VIEW IF EXISTS `v_customerinformation`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_customerinformation` AS SELECT 
 1 AS `id`,
 1 AS `name`,
 1 AS `address`,
 1 AS `contact_number`,
 1 AS `BusinessName`,
 1 AS `BusinessNature`,
 1 AS `BusinessAddress`,
 1 AS `gross_business_capital`,
 1 AS `average_daily_gross_sales`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_loaninformation`
--

DROP TABLE IF EXISTS `v_loaninformation`;
/*!50001 DROP VIEW IF EXISTS `v_loaninformation`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_loaninformation` AS SELECT 
 1 AS `LoanID`,
 1 AS `CustomerID`,
 1 AS `CustomerName`,
 1 AS `PaymentTerm`,
 1 AS `Duration`,
 1 AS `EffectiveDate`,
 1 AS `Interest`,
 1 AS `PrincipalLoan`,
 1 AS `Status`,
 1 AS `Amount`*/;
SET character_set_client = @saved_cs_client;

--
-- Dumping events for database 'tjpdb'
--

--
-- Dumping routines for database 'tjpdb'
--
/*!50003 DROP PROCEDURE IF EXISTS `sp_createLoanInformationReport` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_createLoanInformationReport`(
	IN loan_id varchar(100)
)
BEGIN
	select
	v_loaninformation.LoanID,
	v_loaninformation.CustomerID,
    v_loaninformation.CustomerName,
    v_loaninformation.PrincipalLoan,
    v_loaninformation.Interest,
    v_loaninformation.PrincipalLoan + (v_loaninformation.PrincipalLoan * v_loaninformation.Interest / 100) as 'TotalLoan',
    (v_loaninformation.PrincipalLoan + (v_loaninformation.PrincipalLoan * v_loaninformation.Interest / 100)) / v_loaninformation.Duration as 'DailyPayment',
    v_loaninformation.PaymentTerm	
	from v_loaninformation where
	v_loaninformation.LoanID like concat(loan_id,'%');
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_getCollection` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getCollection`(
	IN loanId varchar(100)
)
BEGIN
	select
		b.id as ID,
        b.date as 'Date',			
        b.collection_amount as Remmit		
		from loan_information as a
		left join collection as b on a.uid = b.loan_information_uid		
        where a.id = loanId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_getCustomer` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getCustomer`(
	IN customerId varchar(100)
)
BEGIN
select v_customerinformation.id as id,
v_customerinformation.name as name,
v_customerinformation.address as address,
v_customerinformation.contact_number as contactnumber,
v_customerinformation.BusinessName as BusinessName,
v_customerinformation.BusinessNature as BusinessNature,
v_customerinformation.BusinessAddress as BusinessAddress,
v_customerinformation.gross_business_capital as grossbusinesscapital,
v_customerinformation.average_daily_gross_sales as averagedailygrosssales
from v_customerinformation where
v_customerinformation.id = customerId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_getCustomerGuid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getCustomerGuid`(
	IN customerId varchar(100)
)
BEGIN
	select uid from customer_account
    where id = customerId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_getCustomerList` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getCustomerList`(
	IN customerId varchar(100),
    IN customerName varchar(100)
)
BEGIN
select v_customerinformation.id as id,
v_customerinformation.name as name,
v_customerinformation.address as address,
v_customerinformation.contact_number as contactnumber,
v_customerinformation.BusinessName as BusinessName,
v_customerinformation.BusinessNature as BusinessNature,
v_customerinformation.BusinessAddress as BusinessAddress,
v_customerinformation.gross_business_capital as grossbusinesscapital,
v_customerinformation.average_daily_gross_sales as averagedailygrosssales
from v_customerinformation where
v_customerinformation.id like concat(customerId,'%') or
v_customerinformation.name like concat(customerName,'%');
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_getLoanGuid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getLoanGuid`(
	IN loanId varchar(100)
)
BEGIN
	select uid from loan_information
    where id = loanId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_getLoanInformation` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getLoanInformation`(
	IN customerId varchar(100)    
)
BEGIN   	
    SET sql_mode=(SELECT REPLACE(@@sql_mode,'ONLY_FULL_GROUP_BY',''));
    
	select a.id as 'Loan ID',
	b.id as 'Customer ID',
	b.name as 'Customer Name',
	a.payment_term as 'Payment Term',
	a.duration as 'Duration',
	a.effective_date as 'Effective Date',
	a.interest as 'Interest Rate',
	a.principal_loan as 'Principal Loan',
	a.status as 'Status'
    from loan_information as a
    left join customer_account as b on a.customer_uid = b.uid
    where
	b.id = customerId;            
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_getLoanInformationUsingCustomerId` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getLoanInformationUsingCustomerId`(
	IN customerId varchar(100)    
)
BEGIN   	
    SET sql_mode=(SELECT REPLACE(@@sql_mode,'ONLY_FULL_GROUP_BY',''));
    
	select a.id as 'Loan ID',
	b.id as 'Customer ID',
	b.name as 'Customer Name',
	a.payment_term as 'Payment Term',
	a.duration as 'Duration',
	a.effective_date as 'Effective Date',
	a.interest as 'Interest Rate',
	a.principal_loan as 'Principal Loan',
	a.status as 'Status'
    from loan_information as a
    left join customer_account as b on a.customer_uid = b.uid
    where
	b.id = customerId;            
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_getLoanInformationUsingCustomerName` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getLoanInformationUsingCustomerName`(	
    IN customerName varchar(100)    
)
BEGIN   	
    SET sql_mode=(SELECT REPLACE(@@sql_mode,'ONLY_FULL_GROUP_BY',''));
    
	select a.id as 'Loan ID',
	b.id as 'Customer ID',
	b.name as 'Customer Name',
	a.payment_term as 'Payment Term',
	a.duration as 'Duration',
	a.effective_date as 'Effective Date',
	a.interest as 'Interest Rate',
	a.principal_loan as 'Principal Loan',
	a.status as 'Status'
    from loan_information as a
    left join customer_account as b on a.customer_uid = b.uid
    where	
	b.name like concat(customerName,'%');            
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_getLoanInformationUsingLoanId` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getLoanInformationUsingLoanId`(
	IN loan_id varchar(100)
)
BEGIN
	select
	v_loaninformation.LoanID,
	v_loaninformation.CustomerID,
	v_loaninformation.CustomerName,
	v_loaninformation.PaymentTerm,
	v_loaninformation.Duration,
	v_loaninformation.EffectiveDate,
	v_loaninformation.Interest as 'InterestRate',
	v_loaninformation.PrincipalLoan,	
	v_loaninformation.Status,
    case
    when v_loaninformation.Amount is null then 0
    else v_loaninformation.Amount 
    end as 'Amount'
	from v_loaninformation where
	v_loaninformation.LoanID like concat(loan_id,'%');
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_getPenalty` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getPenalty`(
		IN loanId varchar(100)
)
BEGIN
	select
		b.id as ID,
        b.date as 'Date',			
        b.penalty_amount as Penalty		
		from loan_information as a
		left join penalty as b on a.uid = b.loan_information_uid		
        where a.id = loanId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_getPenaltyTotal` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getPenaltyTotal`(
	IN loanUID varchar(100)
)
BEGIN
	select		
        b.date as 'Date',			
        Sum(b.penalty_amount) as 'Total Penalty'
		from loan_information as a
		left join penalty as b on a.uid = b.loan_information_uid		
        where a.uid = loanUID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_getPostingList` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getPostingList`(
	IN customerIdOrName varchar(100)
)
BEGIN		
    
    SET sql_mode=(SELECT REPLACE(@@sql_mode,'ONLY_FULL_GROUP_BY',''));

	select DATE_ADD(a.effective_date, INTERVAL a.duration DAY) as 'Due',
	a.loanId as 'Loan No',
	a.customerName as 'Name',
	a.principal_loan as 'Return', 
	truncate(a.principal_loan * a.interest / 100,2) as 'Interest',
	truncate((a.principal_loan * a.interest / 100) + a.principal_loan,2) as 'Total Loan Amount',
	a.status as 'Status',
	case
	when a.collectedAmount is null
	then 0
	else a.collectedAmount
	end as 'Total Amount Collected'	
	from (
				select c.loan_information_uid,
				customer.id as customerID,            
				l.id as loanId,
				customer.name as customerName,
				l.payment_term as term,
				l.duration as duration,
				l.effective_date as effectiveDate,
				l.interest as Interest,
				l.principal_loan as PrincipalLoan,
				l.status as Status,
				l.effective_date,
				l.principal_loan,
				sum(c.collection_amount) as collectedAmount
				from loan_information as l
				left join customer_account as customer on l.customer_uid = customer.uid
				left join collection as c on l.uid = c.loan_information_uid
				group by l.id
			) as a
			left join
			(
				select p.loan_information_uid,
				customer.id as customerID,            
				l.id as loanId,
				customer.name as customerName,
				l.payment_term as term,
				l.duration as duration,
				l.effective_date as effectiveDate,
				l.interest as Interest,
				l.principal_loan as PrincipalLoan,
				l.status as Status,
				l.effective_date,
				l.principal_loan,
                sum(p.penalty_amount) as penaltyAmount
				from loan_information as l
				left join customer_account as customer on l.customer_uid = customer.uid
				left join penalty as p on l.uid = p.loan_information_uid
				group by l.id
			) as b
			on a.loan_information_uid = b.loan_information_uid
			where (a.customerID = customerIdOrName OR a.customerName like concat(customerIdOrName,'%'))
			AND a.Status <> 'Fully Paid'
			group by a.loanId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_getReleasedAmount` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getReleasedAmount`(
	IN loan_id varchar(100)
)
BEGIN
		DROP TEMPORARY TABLE IF EXISTS temp;
		CREATE TEMPORARY TABLE temp(
			select
			v_loaninformation.LoanID,
			v_loaninformation.CustomerID,
			v_loaninformation.CustomerName,
			v_loaninformation.PaymentTerm,
			v_loaninformation.Duration,
			v_loaninformation.EffectiveDate,
			v_loaninformation.Interest,
			v_loaninformation.PrincipalLoan,
			v_loaninformation.Penalty,
			v_loaninformation.Status,
			v_loaninformation.Amount
			from v_loaninformation where
			v_loaninformation.LoanID like concat(loan_id,'%')        
		);
        select (PrincipalLoan * 0.2) + PrincipalLoan as 'Release Amount' from temp;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_getTotalCollection` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getTotalCollection`(
	IN loanUID char(36)
)
BEGIN
	select cl.loan_information_uid,Sum(cl.collection_amount) as 'Total Collection'
    from collection as cl
	inner join loan_information as l on cl.loan_information_uid = l.uid
	where cl.loan_information_uid = loanUID
	group by cl.loan_information_uid;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_getTotalCollectionPerLoanSummary` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getTotalCollectionPerLoanSummary`(

)
BEGIN
	SET sql_mode=(SELECT REPLACE(@@sql_mode,'ONLY_FULL_GROUP_BY',''));

	select a.loanId as 'ID',
	a.customerName as 'Name_of_the_Owner',
	a.principal_loan + (a.principal_loan * 0.2) as 'Released_Amount_with_Interest',
	case
	when a.collectedAmount is null or a.collectedAmount = '' then 0
	else a.collectedAmount
	end as 'Total_Collection',
	case
	when b.penaltyAmount is null or b.penaltyAmount = '' then 0
	else b.penaltyAmount
	end as 'Total_Penalty_Amount'
	from (
				select c.loan_information_uid,
				customer.id as customerID,            
				l.id as loanId,
				customer.name as customerName,
				l.payment_term as term,
				l.duration as duration,
				l.effective_date as effectiveDate,
				l.interest as Interest,
				l.principal_loan as PrincipalLoan,
				l.status as Status,
				l.principal_loan,sum(c.collection_amount) as collectedAmount
				from loan_information as l
				join customer_account as customer on l.customer_uid = customer.uid
				left join collection as c on l.uid = c.loan_information_uid
				group by l.id
			) as a
			left join
			(
				select p.loan_information_uid,l.id as loanId,customer.name,
				l.principal_loan, sum(p.penalty_amount) as penaltyAmount
				from loan_information as l
				left join customer_account as customer on l.customer_uid = customer.uid
				left join penalty as p on l.uid = p.loan_information_uid
				group by l.id
			) as b
	on a.loan_information_uid = b.loan_information_uid;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_insertCollection` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insertCollection`(
	IN collectionUid char(36),
    IN collectionId varchar(100),
    IN customerUid char(36),
    IN loanInformationUid varchar(100),
    IN collectionAmount int,
	IN collectionDate date
)
BEGIN
	insert into collection(uid,id,customer_uid,loan_information_uid,collection_amount,`date`)
    values(collectionUid,collectionId,customerUid,loanInformationUid,collectionAmount,collectionDate);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_insertCustomer` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insertCustomer`(
	IN customerUid char(36),
	IN customerId varchar(100),
	IN customerName varchar(100),
	IN address varchar(200),
	IN contactNumber int,
	IN businessUid char(36), 
	IN businessId varchar(100),
	IN businessName varchar(50),
	IN businessNature varchar(50),
	IN businessAddress varchar(100),
	IN grossBusinessCapital decimal(10,5),
	IN averageDailyGrossSales decimal(10,5)
)
BEGIN
	INSERT INTO `tjpdb`.`customer_account`
	(`uid`,
	`id`,
	`name`,
	`address`,
	`contact_number`)
	VALUES
	(trim(customerUid),trim(customerId),trim(customerName),
    address,contactNumber);
    
    INSERT INTO `tjpdb`.`customer_business_info`
	(`uid`,
	`id`,
	`customer_uid`,
	`name`,
	`nature`,
	`address`,
	`gross_business_capital`,
	`average_daily_gross_sales`)
	VALUES
	(trim(businessUid),
    trim(businessId),
    trim(customerUId),
    trim(businessName),
    businessNature,
    businessAddress,
    grossBusinessCapital,
    averageDailyGrossSales
    );
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_insertLoan` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insertLoan`(
	IN loaninformationUid char(36),
    IN loaninformationId varchar(100),
    IN customerUid char(36),
    IN paymentTerm varchar(50),
    IN duration int,
    IN effectiveDate date,
    IN interest decimal(10,2),
    IN principalLoan decimal(10,2)    
)
BEGIN
	INSERT INTO `tjpdb`.`loan_information`
	(`uid`,
	`id`,
	`customer_uid`,
	`payment_term`,
	`duration`,
	`effective_date`,
	`interest`,
	`principal_loan`)
	VALUES
	(
		loaninformationUid,
		loaninformationId,
		customerUid,
		paymentTerm,
		duration,
		effectiveDate,
		interest,
		principalLoan		
    );
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_insertPenalty` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insertPenalty`(
	IN penalty_Uid char(36),
    IN penalty_Id varchar(100),
    IN customer_Uid char(36),
    IN loanInformation_Uid varchar(100),
    IN penalty_Amnt int,
	IN penalty_Date date
)
BEGIN
	insert into penalty(uid,id,customer_uid,loan_information_uid,penalty_amount,`date`)
    values(penalty_Uid,penalty_Id,customer_Uid,loanInformation_Uid,penalty_Amnt,penalty_Date);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_isLoanUnpaid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_isLoanUnpaid`(
IN ID varchar(50),
OUT rslt tinyint(1))
BEGIN
	DECLARE status_result boolean;
	SELECT IF(Status='Unpaid',1,0)
	INTO status_result
	FROM v_loaninformation
	WHERE CustomerID = ID and Status = 'Unpaid';   
    Set rslt = status_result;
	SELECT ifnull(rslt,0) as Status;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_updateCustomer` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_updateCustomer`(
IN customerId varchar(100),
IN customerName varchar(100),
IN address varchar(200),
IN contactNumber char(14),
IN businessName varchar(50),
IN businessNature varchar(50),
IN businessAddress varchar(100),
IN grossBusinessCapital decimal(10,5),
IN averageDailyGrossSales decimal(10,5)
)
BEGIN
	UPDATE `tjpdb`.`customer_account`
	SET		
	`name` = customerName,
	`address` = address,
	`contact_number` = contactNumber
	WHERE `id` = customerId;
	
    UPDATE `tjpdb`.`customer_business_info`
	SET		
	`name` = businessName,
	`nature` = businessNature,
	`address` = businessAddress,
	`gross_business_capital` = grossBusinessCapital,
	`average_daily_gross_sales` = averageDailyGrossSales
	WHERE `id` = customerId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_updateLoanStatus` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_updateLoanStatus`(
	IN loanId varchar(100)
)
BEGIN
	update loan_information set status = 'Fully Paid' where id = loanId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `v_customerinformation`
--

/*!50001 DROP VIEW IF EXISTS `v_customerinformation`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_customerinformation` AS select `customeraccount`.`id` AS `id`,`customeraccount`.`name` AS `name`,`customeraccount`.`address` AS `address`,`customeraccount`.`contact_number` AS `contact_number`,`businessinfo`.`name` AS `BusinessName`,`businessinfo`.`nature` AS `BusinessNature`,`businessinfo`.`address` AS `BusinessAddress`,`businessinfo`.`gross_business_capital` AS `gross_business_capital`,`businessinfo`.`average_daily_gross_sales` AS `average_daily_gross_sales` from (`customer_account` `customeraccount` join `customer_business_info` `businessinfo` on((`customeraccount`.`uid` = `businessinfo`.`customer_uid`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_loaninformation`
--

/*!50001 DROP VIEW IF EXISTS `v_loaninformation`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_loaninformation` AS select `loan`.`id` AS `LoanID`,`customer`.`id` AS `CustomerID`,`customer`.`name` AS `CustomerName`,`loan`.`payment_term` AS `PaymentTerm`,`loan`.`duration` AS `Duration`,`loan`.`effective_date` AS `EffectiveDate`,`loan`.`interest` AS `Interest`,`loan`.`principal_loan` AS `PrincipalLoan`,`loan`.`status` AS `Status`,sum(`collect`.`collection_amount`) AS `Amount` from ((`loan_information` `loan` left join `collection` `collect` on((`loan`.`uid` = `collect`.`loan_information_uid`))) left join `customer_account` `customer` on((`loan`.`customer_uid` = `customer`.`uid`))) group by `loan`.`id`,`customer`.`id`,`customer`.`name`,`loan`.`payment_term`,`loan`.`duration`,`loan`.`effective_date`,`loan`.`interest`,`loan`.`principal_loan`,`loan`.`status` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-26 22:58:03
