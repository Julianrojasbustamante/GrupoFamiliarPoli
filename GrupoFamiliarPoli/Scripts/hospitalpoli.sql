CREATE DATABASE  IF NOT EXISTS `hospitalpoli` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `hospitalpoli`;
-- MySQL dump 10.13  Distrib 8.0.26, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: hospitalpoli
-- ------------------------------------------------------
-- Server version	8.0.26

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
-- Table structure for table `estado`
--

DROP TABLE IF EXISTS `estado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `estado` (
  `id_estado` int NOT NULL AUTO_INCREMENT,
  `nom_estado` varchar(25) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`id_estado`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estado`
--

LOCK TABLES `estado` WRITE;
/*!40000 ALTER TABLE `estado` DISABLE KEYS */;
INSERT INTO `estado` VALUES (0,'Activo'),(1,'Inactivo');
/*!40000 ALTER TABLE `estado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grupo_familiar`
--

DROP TABLE IF EXISTS `grupo_familiar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `grupo_familiar` (
  `id_familiar` int NOT NULL AUTO_INCREMENT,
  `id_paciente` int unsigned NOT NULL,
  `nom_familiar` varchar(100) NOT NULL,
  `num_telefono` int DEFAULT '0',
  `num_id` varchar(50) NOT NULL,
  `email` varchar(100) DEFAULT 'NO TIENE',
  `fecha_ultima_visita` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id_familiar`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grupo_familiar`
--

LOCK TABLES `grupo_familiar` WRITE;
/*!40000 ALTER TABLE `grupo_familiar` DISABLE KEYS */;
INSERT INTO `grupo_familiar` VALUES (2,61,'Jose Rodrigo',2147483647,'2345666','prueba1@gmail.com','2022-04-10 02:34:52'),(3,61,'Alveiro Rodriguez',2147483647,'2346816','prueba2@gmail.com','2022-04-10 02:34:52'),(4,61,'Camilo Cardenas',2147483647,'2347966','prueba3@gmail.com','2022-04-10 02:34:52'),(5,61,'Paula Lara',2147483647,'2349116','prueba4@gmail.com','2022-04-10 02:34:52');
/*!40000 ALTER TABLE `grupo_familiar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pacientes`
--

DROP TABLE IF EXISTS `pacientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pacientes` (
  `id_paciente` int unsigned NOT NULL,
  `estado` tinyint NOT NULL,
  `nom_paciente` varchar(100) NOT NULL,
  `fecha_nacimiento` date DEFAULT NULL,
  `fecha_creacion` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `fecha_actualizacion` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  `num_dni` int NOT NULL,
  PRIMARY KEY (`id_paciente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pacientes`
--

LOCK TABLES `pacientes` WRITE;
/*!40000 ALTER TABLE `pacientes` DISABLE KEYS */;
INSERT INTO `pacientes` VALUES (61,1,'María de los Ángeles','2001-03-15','2022-04-12 00:43:03',NULL,1234),(62,1,'Julian Rojas','2001-02-09','2022-04-10 02:25:28',NULL,1244),(63,1,'Juan David Bastidas','2001-03-30','2022-04-10 02:25:28',NULL,1254),(64,1,'Camilo Moreno Cruz','2001-11-15','2022-04-10 02:25:28',NULL,1264),(65,1,'Nataly Mora Mencera','2001-03-12','2022-04-10 02:25:28',NULL,1274),(66,0,'Victor Hugo Cardenas','2001-03-15','2022-04-12 00:21:54','2022-04-12 00:21:54',1284),(67,0,'Lucas Hernandez Flores','2001-03-15','2022-04-12 00:21:59','2022-04-12 00:21:59',1294),(68,0,'Yenifer Lorena Saavedra','2001-03-15','2022-04-12 00:22:03','2022-04-12 00:22:03',1304),(69,0,'Julian Morales','2001-03-15','2022-04-12 00:22:07','2022-04-12 00:22:07',1314),(70,0,'Samuel de Luke','2001-03-15','2022-04-12 00:22:12','2022-04-12 00:22:12',1324);
/*!40000 ALTER TABLE `pacientes` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-04-11 21:00:33
