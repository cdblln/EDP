CREATE DATABASE  IF NOT EXISTS `perfume_ecom` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `perfume_ecom`;
-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: localhost    Database: perfume_ecom
-- ------------------------------------------------------
-- Server version	8.0.40

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
-- Temporary view structure for view `avg_rating_perfume`
--

DROP TABLE IF EXISTS `avg_rating_perfume`;
/*!50001 DROP VIEW IF EXISTS `avg_rating_perfume`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `avg_rating_perfume` AS SELECT 
 1 AS `perfume_name`,
 1 AS `average_rating`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `best_selling_perfumes`
--

DROP TABLE IF EXISTS `best_selling_perfumes`;
/*!50001 DROP VIEW IF EXISTS `best_selling_perfumes`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `best_selling_perfumes` AS SELECT 
 1 AS `perfume_name`,
 1 AS `total_quantity`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `brands`
--

DROP TABLE IF EXISTS `brands`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `brands` (
  `brand_id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `brand_name` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`brand_id`),
  UNIQUE KEY `brand_id` (`brand_id`),
  UNIQUE KEY `brand_name` (`brand_name`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `brands`
--

LOCK TABLES `brands` WRITE;
/*!40000 ALTER TABLE `brands` DISABLE KEYS */;
INSERT INTO `brands` VALUES (7,'Armani'),(8,'Burberry'),(13,'Byredo'),(9,'Calvin Klein'),(1,'Chanel'),(14,'Creed'),(2,'Dior'),(11,'Dolce & Gabbana'),(4,'Gucci'),(12,'Jo Malone'),(15,'Maison Francis Kurkdjian'),(10,'Prada'),(3,'Tom Ford'),(5,'Versace'),(6,'Yves Saint Laurent');
/*!40000 ALTER TABLE `brands` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categories` (
  `category_id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `category_name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`category_id`),
  UNIQUE KEY `category_id` (`category_id`),
  UNIQUE KEY `category_name` (`category_name`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories`
--

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
INSERT INTO `categories` VALUES (9,'Aromatic'),(8,'Chypre'),(6,'Citrus'),(1,'Floral'),(4,'Fresh'),(5,'Fruity'),(7,'Gourmand'),(10,'Leather'),(3,'Oriental'),(2,'Woody');
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `categories_BEFORE_DELETE` BEFORE DELETE ON `categories` FOR EACH ROW BEGIN
 INSERT INTO category_logs (category_id, category_name, action, action_time)
    VALUES (OLD.category_id, OLD.category_name, 'BEFORE DELETE', NOW());
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `categories_AFTER_DELETE` AFTER DELETE ON `categories` FOR EACH ROW BEGIN
INSERT INTO category_logs (category_id, action, action_time)
    VALUES (OLD.category_id, 'AFTER DELETE', NOW());
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `category_logs`
--

DROP TABLE IF EXISTS `category_logs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `category_logs` (
  `log_id` int NOT NULL AUTO_INCREMENT,
  `category_id` bigint unsigned NOT NULL,
  `category_name` varchar(255) DEFAULT NULL,
  `action` varchar(50) NOT NULL,
  `action_time` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`log_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `category_logs`
--

LOCK TABLES `category_logs` WRITE;
/*!40000 ALTER TABLE `category_logs` DISABLE KEYS */;
/*!40000 ALTER TABLE `category_logs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer_logs`
--

DROP TABLE IF EXISTS `customer_logs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer_logs` (
  `log_id` int unsigned NOT NULL AUTO_INCREMENT,
  `customer_id` int unsigned DEFAULT NULL,
  `action` varchar(10) NOT NULL,
  `action_time` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `log_description` text,
  `old_data` text,
  `new_data` text,
  PRIMARY KEY (`log_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer_logs`
--

LOCK TABLES `customer_logs` WRITE;
/*!40000 ALTER TABLE `customer_logs` DISABLE KEYS */;
INSERT INTO `customer_logs` VALUES (1,21,'INSERT','2025-05-13 06:59:19',NULL,NULL,NULL),(2,21,'ADD','2025-05-13 06:59:19',NULL,NULL,NULL),(3,21,'EDIT','2025-05-13 07:02:26',NULL,NULL,NULL),(4,21,'DELETE','2025-05-13 07:02:42',NULL,NULL,NULL),(5,19,'EDIT','2025-05-13 07:07:07','Customer information updated','{\"email\": \"drib@gmail.com\", \"last_name\": \"Ataiza\", \"first_name\": \"Dreev\", \"customer_id\": 19}','{\"email\": \"drib@gmail.com\", \"last_name\": \"Ataiza\", \"first_name\": \"Andreev\", \"customer_id\": 19}');
/*!40000 ALTER TABLE `customer_logs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `customer_orders`
--

DROP TABLE IF EXISTS `customer_orders`;
/*!50001 DROP VIEW IF EXISTS `customer_orders`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `customer_orders` AS SELECT 
 1 AS `order_id`,
 1 AS `first_name`,
 1 AS `last_name`,
 1 AS `order_date`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customers` (
  `customer_id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `first_name` varchar(50) DEFAULT NULL,
  `last_name` varchar(50) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `gender` varchar(10) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`customer_id`),
  UNIQUE KEY `customer_id` (`customer_id`),
  CONSTRAINT `customers_chk_1` CHECK ((`email` like _utf8mb4'%@gmail.com')),
  CONSTRAINT `customers_chk_2` CHECK ((`gender` in (_utf8mb4'Male',_utf8mb4'Female',_utf8mb4'Other')))
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` VALUES (1,'John','Doe','johndoe@gmail.com','Male','john123'),(2,'Jane Ganda','Smith','janesmithpogi@gmail.com','Female','cute'),(3,'Alice','Brown','alicebrown@gmail.com','Female','yellow56'),(4,'Robert','Johnson','robertjohnson@gmail.com','Male','roberto'),(5,'Michael','Williams','michaelwilliams@gmail.com','Male','jordan12'),(6,'Emma','Davis','emmadavis@gmail.com','Female','wow1234'),(8,'Liam','Wilson','liamwilson@gmail.com','Male','password'),(9,'Sophia','Moore','sophiamoore@gmail.com','Female','imcute45'),(10,'James','Taylor','jamestaylor@gmail.com','Male','taylorswift'),(11,'Charlotte','Anderson','charlotteanderson@gmail.com','Female','wowlods'),(12,'William','Thomas','williamthomas@gmail.com','Male','12345'),(13,'Mia','Martinez','miamartinez@gmail.com','Female','crushkosijohn'),(15,'Cedrick','Lensoco','cedrick@gmail.com','Male','sidrek'),(16,'Vinz','Palomillo','vinz@gmail.com','Male','vinz123'),(17,'Christian','Ballon','cd@gmail.com','Male','cdpogi'),(18,'Jay','Balane','jay@gmail.com','Male','jay111'),(19,'Andreev','Ataiza','drib@gmail.com','Male','dribgod');
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `customers_after_insert` AFTER INSERT ON `customers` FOR EACH ROW BEGIN
    INSERT INTO customer_logs (
        customer_id,
        action,
        log_description,
        new_data
    ) VALUES (
        NEW.customer_id,
        'ADD',
        'New customer added',
        JSON_OBJECT(
            'customer_id', NEW.customer_id,
            'first_name', NEW.first_name,
            'last_name', NEW.last_name,
            'email', NEW.email
        )
    );
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `customers_after_update` AFTER UPDATE ON `customers` FOR EACH ROW BEGIN
    INSERT INTO customer_logs (
        customer_id,
        action,
        log_description,
        old_data,
        new_data
    ) VALUES (
        NEW.customer_id,
        'EDIT',
        'Customer information updated',
        JSON_OBJECT(
            'customer_id', OLD.customer_id,
            'first_name', OLD.first_name,
            'last_name', OLD.last_name,
             'email', OLD.email
        ),
        JSON_OBJECT(
            'customer_id', NEW.customer_id,
            'first_name', NEW.first_name,
            'last_name', NEW.last_name,
            'email', NEW.email
        )
    );
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `customers_before_delete` BEFORE DELETE ON `customers` FOR EACH ROW BEGIN
    INSERT INTO customer_logs (
        customer_id,
        action,
        log_description,
        old_data
    ) VALUES (
        OLD.customer_id,
        'DELETE',
        'Customer deleted',
        JSON_OBJECT(
            'customer_id', OLD.customer_id,
            'first_name', OLD.first_name,
            'last_name', OLD.last_name,
            'email', OLD.email
        )
    );
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Temporary view structure for view `detailed_feedback_section`
--

DROP TABLE IF EXISTS `detailed_feedback_section`;
/*!50001 DROP VIEW IF EXISTS `detailed_feedback_section`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `detailed_feedback_section` AS SELECT 
 1 AS `customer_name`,
 1 AS `brand_name`,
 1 AS `perfume_name`,
 1 AS `rating`,
 1 AS `review_text`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `order_items`
--

DROP TABLE IF EXISTS `order_items`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `order_items` (
  `order_item_id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `order_id` bigint unsigned DEFAULT NULL,
  `perfume_id` bigint unsigned DEFAULT NULL,
  `quantity` int DEFAULT NULL,
  PRIMARY KEY (`order_item_id`),
  UNIQUE KEY `order_item_id` (`order_item_id`),
  KEY `fk_order_items_order_id` (`order_id`),
  KEY `fk_order_items_perfume_id` (`perfume_id`),
  CONSTRAINT `fk_order_items_order_id` FOREIGN KEY (`order_id`) REFERENCES `orders` (`order_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_order_items_perfume_id` FOREIGN KEY (`perfume_id`) REFERENCES `perfumes` (`perfume_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `order_items_chk_1` CHECK ((`quantity` > 0))
) ENGINE=InnoDB AUTO_INCREMENT=230 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order_items`
--

LOCK TABLES `order_items` WRITE;
/*!40000 ALTER TABLE `order_items` DISABLE KEYS */;
INSERT INTO `order_items` VALUES (176,68,7,1),(177,69,5,1),(178,69,13,1),(179,70,6,1),(180,70,11,1),(181,70,7,1),(182,71,9,1),(183,71,14,1),(184,71,15,1),(185,72,7,1),(186,72,1,1),(187,72,12,1),(188,73,2,1),(189,73,9,1),(190,73,10,1),(191,74,15,1),(192,74,14,1),(193,75,12,1),(194,75,13,1),(195,75,10,1),(196,76,6,1),(197,76,10,1),(198,77,9,1),(199,78,2,1),(200,78,12,1),(201,79,9,1),(202,79,4,1),(207,82,14,1),(208,83,6,1),(209,83,9,1),(210,84,9,1),(211,85,2,1),(212,86,3,1),(213,87,8,1),(214,87,2,1),(215,87,15,1),(216,88,10,1),(217,88,6,1),(218,88,14,1),(219,89,12,1),(220,90,9,1),(221,91,3,1),(222,91,7,1),(223,91,4,1),(224,92,11,1),(225,92,3,1),(226,92,15,1),(227,93,9,1),(228,93,1,1),(229,93,14,1);
/*!40000 ALTER TABLE `order_items` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `order_id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `customer_id` bigint unsigned DEFAULT NULL,
  `order_date` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`order_id`),
  UNIQUE KEY `order_id` (`order_id`),
  KEY `fk_orders_customer_id` (`customer_id`),
  CONSTRAINT `fk_orders_customer_id` FOREIGN KEY (`customer_id`) REFERENCES `customers` (`customer_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=94 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1,1,'2025-02-18 09:50:21'),(2,2,'2025-02-18 09:50:21'),(3,3,'2025-02-18 09:50:21'),(4,4,'2025-02-18 09:50:21'),(5,5,'2025-02-18 09:50:21'),(6,6,'2025-02-18 09:50:21'),(8,8,'2025-02-18 09:50:21'),(9,9,'2025-02-18 09:50:21'),(10,10,'2025-02-18 09:50:21'),(11,11,'2025-02-18 09:50:21'),(12,12,'2025-02-18 09:50:21'),(13,13,'2025-02-18 09:50:21'),(16,1,'2025-02-18 10:34:47'),(17,1,'2025-02-18 10:34:47'),(18,2,'2025-02-18 10:34:47'),(19,2,'2025-02-18 10:34:47'),(20,3,'2025-02-18 10:34:47'),(21,3,'2025-02-18 10:34:47'),(22,4,'2025-02-18 10:34:47'),(23,4,'2025-02-18 10:34:47'),(24,5,'2025-02-18 10:34:47'),(25,5,'2025-02-18 10:34:47'),(26,6,'2025-02-18 10:34:47'),(27,6,'2025-02-18 10:34:47'),(30,8,'2025-02-18 10:34:47'),(31,8,'2025-02-18 10:34:47'),(32,9,'2025-02-18 10:34:47'),(33,9,'2025-02-18 10:34:47'),(34,10,'2025-02-18 10:34:47'),(35,10,'2025-02-18 10:34:47'),(36,11,'2025-02-18 10:34:47'),(37,11,'2025-02-18 10:34:47'),(38,12,'2025-02-18 10:34:47'),(39,12,'2025-02-18 10:34:47'),(40,13,'2025-02-18 10:34:47'),(41,13,'2025-02-18 10:34:47'),(42,1,'2025-02-18 11:57:52'),(43,1,'2025-02-18 11:57:52'),(44,2,'2025-02-18 11:57:52'),(45,2,'2025-02-18 11:57:52'),(46,3,'2025-02-18 11:57:52'),(47,3,'2025-02-18 11:57:52'),(48,4,'2025-02-18 11:57:52'),(49,4,'2025-02-18 11:57:52'),(50,5,'2025-02-18 11:57:52'),(51,5,'2025-02-18 11:57:52'),(52,6,'2025-02-18 11:57:52'),(53,6,'2025-02-18 11:57:52'),(56,8,'2025-02-18 11:57:52'),(57,8,'2025-02-18 11:57:52'),(58,9,'2025-02-18 11:57:52'),(59,9,'2025-02-18 11:57:52'),(60,10,'2025-02-18 11:57:52'),(61,10,'2025-02-18 11:57:52'),(62,11,'2025-02-18 11:57:52'),(63,11,'2025-02-18 11:57:52'),(64,12,'2025-02-18 11:57:52'),(65,12,'2025-02-18 11:57:52'),(66,13,'2025-02-18 11:57:52'),(67,13,'2025-02-18 11:57:52'),(68,1,'2025-02-18 12:00:45'),(69,1,'2025-02-18 12:00:45'),(70,2,'2025-02-18 12:00:45'),(71,2,'2025-02-18 12:00:45'),(72,3,'2025-02-18 12:00:45'),(73,3,'2025-02-18 12:00:45'),(74,4,'2025-02-18 12:00:45'),(75,4,'2025-02-18 12:00:45'),(76,5,'2025-02-18 12:00:45'),(77,5,'2025-02-18 12:00:45'),(78,6,'2025-02-18 12:00:45'),(79,6,'2025-02-18 12:00:45'),(82,8,'2025-02-18 12:00:45'),(83,8,'2025-02-18 12:00:45'),(84,9,'2025-02-18 12:00:45'),(85,9,'2025-02-18 12:00:45'),(86,10,'2025-02-18 12:00:45'),(87,10,'2025-02-18 12:00:45'),(88,11,'2025-02-18 12:00:45'),(89,11,'2025-02-18 12:00:45'),(90,12,'2025-02-18 12:00:45'),(91,12,'2025-02-18 12:00:45'),(92,13,'2025-02-18 12:00:45'),(93,13,'2025-02-18 12:00:45');
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `perfume_logs`
--

DROP TABLE IF EXISTS `perfume_logs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `perfume_logs` (
  `log_id` int unsigned NOT NULL AUTO_INCREMENT,
  `perfume_id` bigint unsigned DEFAULT NULL,
  `log_timestamp` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `log_type` varchar(10) NOT NULL,
  `perfume_name` varchar(255) DEFAULT NULL,
  `brand_id` bigint unsigned DEFAULT NULL,
  `category_id` bigint unsigned DEFAULT NULL,
  `price` decimal(10,2) DEFAULT NULL,
  `quantity` int DEFAULT NULL,
  `old_perfume_name` varchar(255) DEFAULT NULL,
  `old_brand_id` bigint unsigned DEFAULT NULL,
  `old_category_id` bigint unsigned DEFAULT NULL,
  `old_price` decimal(10,2) DEFAULT NULL,
  `old_quantity` int DEFAULT NULL,
  PRIMARY KEY (`log_id`),
  KEY `brand_id` (`brand_id`),
  KEY `category_id` (`category_id`),
  KEY `old_brand_id` (`old_brand_id`),
  KEY `old_category_id` (`old_category_id`),
  CONSTRAINT `perfume_logs_ibfk_1` FOREIGN KEY (`brand_id`) REFERENCES `brands` (`brand_id`),
  CONSTRAINT `perfume_logs_ibfk_2` FOREIGN KEY (`category_id`) REFERENCES `categories` (`category_id`),
  CONSTRAINT `perfume_logs_ibfk_3` FOREIGN KEY (`old_brand_id`) REFERENCES `brands` (`brand_id`),
  CONSTRAINT `perfume_logs_ibfk_4` FOREIGN KEY (`old_category_id`) REFERENCES `categories` (`category_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `perfume_logs`
--

LOCK TABLES `perfume_logs` WRITE;
/*!40000 ALTER TABLE `perfume_logs` DISABLE KEYS */;
INSERT INTO `perfume_logs` VALUES (1,21,'2025-05-13 06:52:14','ADD','Creed Silver Mountain Water',14,6,23451.00,3,NULL,NULL,NULL,NULL,NULL),(2,21,'2025-05-13 06:52:50','EDIT','Creed Cologne',14,6,23451.00,3,'Creed Silver Mountain Water',14,6,23451.00,3),(3,21,'2025-05-13 06:53:07','DELETE','Creed Cologne',14,6,23451.00,3,NULL,NULL,NULL,NULL,NULL),(4,22,'2025-05-13 15:52:16','ADD','Bleu de Chanel',1,6,8956.00,12,NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `perfume_logs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `perfume_prices`
--

DROP TABLE IF EXISTS `perfume_prices`;
/*!50001 DROP VIEW IF EXISTS `perfume_prices`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `perfume_prices` AS SELECT 
 1 AS `perfume_id`,
 1 AS `perfume_name`,
 1 AS `price`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `perfumes`
--

DROP TABLE IF EXISTS `perfumes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `perfumes` (
  `perfume_id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `perfume_name` varchar(100) DEFAULT NULL,
  `brand_id` bigint unsigned DEFAULT NULL,
  `category_id` bigint unsigned DEFAULT NULL,
  `price` decimal(10,2) DEFAULT NULL,
  `quantity` int DEFAULT NULL,
  PRIMARY KEY (`perfume_id`),
  UNIQUE KEY `perfume_id` (`perfume_id`),
  KEY `fk_perfumes_brand_id` (`brand_id`),
  KEY `fk_perfumes_category_id` (`category_id`),
  CONSTRAINT `fk_perfumes_brand_id` FOREIGN KEY (`brand_id`) REFERENCES `brands` (`brand_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_perfumes_category_id` FOREIGN KEY (`category_id`) REFERENCES `categories` (`category_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `perfumes`
--

LOCK TABLES `perfumes` WRITE;
/*!40000 ALTER TABLE `perfumes` DISABLE KEYS */;
INSERT INTO `perfumes` VALUES (1,'Chanel No. 5',1,1,8912.56,12),(2,'Miss Dior',2,1,7212.80,10),(3,'Tom Ford Black Orchid',3,3,9909.76,5),(4,'Gucci Bloom',4,1,7808.64,4),(5,'Versace Bright Crystal',5,5,4986.24,8),(6,'YSL Libre',6,6,6993.28,7),(7,'Armani Code',7,8,5488.00,5),(8,'Burberry Her',8,7,6240.64,9),(9,'Calvin Klein Eternity',9,9,4515.84,12),(10,'Prada Luna Rossa',10,10,8000.00,22),(11,'Dolce & Gabbana Light Blue',11,4,6742.40,3),(12,'Jo Malone Peony & Blush Suede',12,1,8498.56,1),(13,'Byredo Gypsy Water',13,9,8749.44,7),(14,'Creed Aventus',14,2,12512.64,7),(15,'Maison Francis Kurkdjian Baccarat Rouge 540',15,3,14990.08,11),(19,'Calvin Klein Eternity',9,9,4515.84,12),(22,'Bleu de Chanel',1,6,8956.00,12);
/*!40000 ALTER TABLE `perfumes` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `perfumes_after_insert` AFTER INSERT ON `perfumes` FOR EACH ROW BEGIN
    INSERT INTO perfume_logs (
        perfume_id,
        log_type,
        perfume_name,
        brand_id,
        category_id,
        price,
        quantity
    ) VALUES (
        NEW.perfume_id,
        'ADD',
        NEW.perfume_name,
        NEW.brand_id,
        NEW.category_id,
        NEW.price,
        NEW.quantity
    );
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `perfumes_update` AFTER UPDATE ON `perfumes` FOR EACH ROW BEGIN
    INSERT INTO perfume_logs (
        perfume_id,
        log_type,
        perfume_name,
        brand_id,
        category_id,
        price,
        quantity,
        old_perfume_name,
        old_brand_id,
        old_category_id,
        old_price,
        old_quantity
    ) VALUES (
        NEW.perfume_id,
        'EDIT',
        NEW.perfume_name,
        NEW.brand_id,
        NEW.category_id,
        NEW.price,
        NEW.quantity,
        OLD.perfume_name,
        OLD.brand_id,
        OLD.category_id,
        OLD.price,
        OLD.quantity
    );
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `perfumes_before_delete` BEFORE DELETE ON `perfumes` FOR EACH ROW BEGIN
    INSERT INTO perfume_logs (
        perfume_id,
        log_type,
        perfume_name,
        brand_id,
        category_id,
        price,
        quantity
    ) VALUES (
        OLD.perfume_id,
        'DELETE',
        OLD.perfume_name,
        OLD.brand_id,
        OLD.category_id,
        OLD.price,
        OLD.quantity
    );
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `reviews`
--

DROP TABLE IF EXISTS `reviews`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reviews` (
  `review_id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `customer_id` bigint unsigned DEFAULT NULL,
  `perfume_id` int DEFAULT NULL,
  `rating` int DEFAULT NULL,
  `review_text` text,
  `review_date` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`review_id`),
  UNIQUE KEY `review_id` (`review_id`),
  KEY `fk_reviews_customer_id` (`customer_id`),
  CONSTRAINT `fk_reviews_customer_id` FOREIGN KEY (`customer_id`) REFERENCES `customers` (`customer_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `reviews_chk_1` CHECK ((`rating` between 1 and 5))
) ENGINE=InnoDB AUTO_INCREMENT=148 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reviews`
--

LOCK TABLES `reviews` WRITE;
/*!40000 ALTER TABLE `reviews` DISABLE KEYS */;
INSERT INTO `reviews` VALUES (120,1,5,4,'I get so many compliments when I wear this.','2025-02-18 12:00:45'),(121,1,13,1,'This one is too strong and overpowering for me.','2025-02-18 12:00:45'),(122,2,14,4,'I get so many compliments when I wear this.','2025-02-18 12:00:45'),(123,2,9,4,'This scent is perfect for any occasion.','2025-02-18 12:00:45'),(124,2,15,5,'This scent is perfect for any occasion.','2025-02-18 12:00:45'),(125,3,1,4,'This will definitely be my signature scent!','2025-02-18 12:00:45'),(126,3,12,2,'I wish it lasted longer, the scent disappears too fast.','2025-02-18 12:00:45'),(127,3,10,2,'It smells good at first, but dries down to something unremarkable.','2025-02-18 12:00:45'),(128,4,15,2,'I was hoping for something with more depth.','2025-02-18 12:00:45'),(129,4,14,2,'A bit synthetic-smelling after a while.','2025-02-18 12:00:45'),(130,4,10,3,'Might be better layered with another scent.','2025-02-18 12:00:45'),(131,5,10,3,'A good casual scent, but lacks a wow factor.','2025-02-18 12:00:45'),(132,5,9,3,'A good casual scent, but lacks a wow factor.','2025-02-18 12:00:45'),(133,6,12,4,'Such a well-crafted and timeless scent.','2025-02-18 12:00:45'),(136,8,14,3,'It’s nice, but something feels missing.','2025-02-18 12:00:45'),(137,8,6,4,'It makes me feel confident and elegant.','2025-02-18 12:00:45'),(138,8,9,2,'It smells good at first, but dries down to something unremarkable.','2025-02-18 12:00:45'),(139,9,2,1,'I wanted to love this, but it just doesn’t suit me.','2025-02-18 12:00:45'),(140,10,15,5,'My partner absolutely loves when I wear this!','2025-02-18 12:00:45'),(141,10,3,3,'It’s nice, but something feels missing.','2025-02-18 12:00:45'),(142,11,14,5,'My partner absolutely loves when I wear this!','2025-02-18 12:00:45'),(143,12,7,5,'A must-have in my collection!','2025-02-18 12:00:45'),(144,12,4,1,'I wanted to love this, but it just doesn’t suit me.','2025-02-18 12:00:45'),(145,12,3,4,'A must-have in my collection!','2025-02-18 12:00:45'),(146,13,1,1,'Not what I imagined, but might work for someone else.','2025-02-18 12:00:45'),(147,13,14,1,'I expected something more unique, but it feels generic.','2025-02-18 12:00:45');
/*!40000 ALTER TABLE `reviews` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'perfume_ecom'
--
/*!50106 SET @save_time_zone= @@TIME_ZONE */ ;
/*!50106 DROP EVENT IF EXISTS `clear_old_logs` */;
DELIMITER ;;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;;
/*!50003 SET character_set_client  = utf8mb4 */ ;;
/*!50003 SET character_set_results = utf8mb4 */ ;;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;;
/*!50003 SET @saved_time_zone      = @@time_zone */ ;;
/*!50003 SET time_zone             = 'SYSTEM' */ ;;
/*!50106 CREATE*/ /*!50117 DEFINER=`root`@`localhost`*/ /*!50106 EVENT `clear_old_logs` ON SCHEDULE EVERY 1 DAY STARTS '2025-04-04 03:20:54' ON COMPLETION NOT PRESERVE ENABLE DO BEGIN  
    DELETE FROM customer_logs WHERE action_time < NOW() - INTERVAL 30 DAY;  
    DELETE FROM category_logs WHERE action_time < NOW() - INTERVAL 30 DAY;  
    DELETE FROM perfume_logs WHERE action_time < NOW() - INTERVAL 30 DAY;  
END */ ;;
/*!50003 SET time_zone             = @saved_time_zone */ ;;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;;
/*!50003 SET character_set_client  = @saved_cs_client */ ;;
/*!50003 SET character_set_results = @saved_cs_results */ ;;
/*!50003 SET collation_connection  = @saved_col_connection */ ;;
DELIMITER ;
/*!50106 SET TIME_ZONE= @save_time_zone */ ;

--
-- Dumping routines for database 'perfume_ecom'
--
/*!50003 DROP FUNCTION IF EXISTS `convert_price_to_usd` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `convert_price_to_usd`(perfume_id INT, exchange_rate DOUBLE) RETURNS double
    DETERMINISTIC
BEGIN
    DECLARE price_in_php DOUBLE;
    DECLARE price_in_usd DOUBLE;

    -- Get the perfume price, ensuring only one row is selected
    SELECT price INTO price_in_php
    FROM perfumes
    WHERE perfume_id = perfume_id
    LIMIT 1;

    -- Convert the price to USD
    SET price_in_usd = price_in_php / exchange_rate;

    RETURN price_in_usd;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `get_avg_rating` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `get_avg_rating`(perfume_id INT) RETURNS double
    DETERMINISTIC
BEGIN
    DECLARE avg_rating DOUBLE;
    
    SELECT AVG(rating) INTO avg_rating 
    FROM reviews 
    WHERE perfume_id = perfume_id;
    
    RETURN IFNULL(avg_rating, 0);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `get_customer_full_name` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `get_customer_full_name`(cust_id INT) RETURNS varchar(255) CHARSET utf8mb4
    DETERMINISTIC
BEGIN
    DECLARE full_name VARCHAR(255);

    SELECT CONCAT(first_name, ' ', last_name) INTO full_name
    FROM customers
    WHERE customer_id = cust_id;

    RETURN full_name;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `get_total_orders` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `get_total_orders`(cust_id INT) RETURNS int
    DETERMINISTIC
BEGIN
    DECLARE total_orders INT;

    SELECT COUNT(*) INTO total_orders
    FROM orders
    WHERE customer_id = cust_id;

    RETURN total_orders;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `get_total_reviews` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `get_total_reviews`(perfume_id INT) RETURNS int
    DETERMINISTIC
BEGIN
    DECLARE total_reviews INT;
    
    SELECT COUNT(*) INTO total_reviews 
    FROM reviews 
    WHERE reviews.perfume_id = perfume_id;
    
    RETURN total_reviews;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `AddPerfume` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `AddPerfume`(
    IN p_perfume_name VARCHAR(255),
    IN p_brand_id BIGINT UNSIGNED,
    IN p_category_id BIGINT UNSIGNED,
    IN p_price DECIMAL(10,2),
    IN p_quantity INT
)
BEGIN
    INSERT INTO perfumes (perfume_name, brand_id, category_id, price, quantity)
    VALUES (p_perfume_name, p_brand_id, p_category_id, p_price, p_quantity);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ConvertPricesToPHP` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ConvertPricesToPHP`(IN conversion_rate DECIMAL(10,2))
BEGIN
    UPDATE Perfumes SET price = price * conversion_rate;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ConvertPricesToUSD` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ConvertPricesToUSD`(IN conversion_rate DECIMAL(10,2))
BEGIN
    UPDATE Perfumes SET price = price / conversion_rate;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `DeletePerfume` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `DeletePerfume`(
    IN p_perfume_id BIGINT UNSIGNED
)
BEGIN
    DELETE FROM perfumes
    WHERE perfume_id = p_perfume_id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetCustomerOrderHistory` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetCustomerOrderHistory`(IN customer_email VARCHAR(100))
BEGIN
    SELECT o.order_id, o.order_date FROM Orders o
    JOIN Customers c ON o.customer_id = c.customer_id
    WHERE c.email = customer_email;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetPerfumeReviews` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetPerfumeReviews`(IN perfume_name_param VARCHAR(100))
BEGIN
    SELECT r.review_text FROM Reviews r
    JOIN Perfumes p ON r.perfume_id = p.perfume_id
    WHERE p.perfume_name = perfume_name_param;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `UpdatePerfume` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdatePerfume`(
    IN p_perfume_id BIGINT UNSIGNED,
    IN p_perfume_name VARCHAR(255),
    IN p_brand_id BIGINT UNSIGNED,
    IN p_category_id BIGINT UNSIGNED,
    IN p_price DECIMAL(10,2),
    IN p_quantity INT
)
BEGIN
    UPDATE perfumes
    SET
        perfume_name = p_perfume_name,
        brand_id = p_brand_id,
        category_id = p_category_id,
        price = p_price,
        quantity = p_quantity
    WHERE perfume_id = p_perfume_id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `avg_rating_perfume`
--

/*!50001 DROP VIEW IF EXISTS `avg_rating_perfume`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `avg_rating_perfume` AS select `p`.`perfume_name` AS `perfume_name`,avg(`r`.`rating`) AS `average_rating` from (`reviews` `r` join `perfumes` `p` on((`r`.`perfume_id` = `p`.`perfume_id`))) group by `p`.`perfume_name` order by `average_rating` desc */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `best_selling_perfumes`
--

/*!50001 DROP VIEW IF EXISTS `best_selling_perfumes`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `best_selling_perfumes` AS select `p`.`perfume_name` AS `perfume_name`,sum(`oi`.`quantity`) AS `total_quantity` from (`order_items` `oi` join `perfumes` `p` on((`oi`.`perfume_id` = `p`.`perfume_id`))) group by `p`.`perfume_name` order by `total_quantity` desc */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `customer_orders`
--

/*!50001 DROP VIEW IF EXISTS `customer_orders`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `customer_orders` AS select `o`.`order_id` AS `order_id`,`c`.`first_name` AS `first_name`,`c`.`last_name` AS `last_name`,`o`.`order_date` AS `order_date` from (`orders` `o` join `customers` `c` on((`o`.`customer_id` = `c`.`customer_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `detailed_feedback_section`
--

/*!50001 DROP VIEW IF EXISTS `detailed_feedback_section`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `detailed_feedback_section` AS select concat(`c`.`first_name`,' ',`c`.`last_name`) AS `customer_name`,`b`.`brand_name` AS `brand_name`,`p`.`perfume_name` AS `perfume_name`,`r`.`rating` AS `rating`,`r`.`review_text` AS `review_text` from (((`reviews` `r` join `customers` `c` on((`r`.`customer_id` = `c`.`customer_id`))) join `perfumes` `p` on((`r`.`perfume_id` = `p`.`perfume_id`))) join `brands` `b` on((`p`.`brand_id` = `b`.`brand_id`))) order by `r`.`review_date` desc */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `perfume_prices`
--

/*!50001 DROP VIEW IF EXISTS `perfume_prices`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `perfume_prices` AS select `perfumes`.`perfume_id` AS `perfume_id`,`perfumes`.`perfume_name` AS `perfume_name`,`perfumes`.`price` AS `price` from `perfumes` */;
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

-- Dump completed on 2025-05-14  3:33:48
