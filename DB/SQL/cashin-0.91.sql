CREATE DATABASE  IF NOT EXISTS `cashin` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `cashin`;
-- MySQL dump 10.13  Distrib 5.6.17, for Win32 (x86)
--
-- Host: localhost    Database: cashin
-- ------------------------------------------------------
-- Server version	5.6.14

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
-- Table structure for table `cidade`
--

DROP TABLE IF EXISTS `cidade`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cidade` (
  `idCidade` int(11) NOT NULL AUTO_INCREMENT,
  `idUF` char(2) DEFAULT NULL,
  `Nome` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idCidade`),
  KEY `fk_Cidade_UF1_idx` (`idUF`),
  CONSTRAINT `fk_Cidade_UF` FOREIGN KEY (`idUF`) REFERENCES `uf` (`idUf`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cidade`
--

LOCK TABLES `cidade` WRITE;
/*!40000 ALTER TABLE `cidade` DISABLE KEYS */;
INSERT INTO `cidade` VALUES (1,'SP','Caraguatatuba'),(2,'RJ','Niterói'),(3,'MG','Itajubá'),(4,'SP','Ubatuba');
/*!40000 ALTER TABLE `cidade` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `idCliente` int(11) NOT NULL AUTO_INCREMENT,
  `idPessoa` int(11) DEFAULT NULL,
  `descricao` varchar(300) DEFAULT NULL,
  PRIMARY KEY (`idCliente`),
  KEY `fk_Cliente_Pessoa1_idx` (`idPessoa`),
  CONSTRAINT `fk_Cliente_Pessoa1` FOREIGN KEY (`idPessoa`) REFERENCES `pessoa` (`idPessoa`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (1,5,'Pet Shop especializado em banho e tosa. Atenção com os prazos, cliente muito sistemático.');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `endereco`
--

DROP TABLE IF EXISTS `endereco`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `endereco` (
  `idEndereco` int(11) NOT NULL AUTO_INCREMENT,
  `idPessoa` int(11) DEFAULT NULL,
  `idCidade` int(11) DEFAULT NULL,
  `Bairro` varchar(200) DEFAULT NULL,
  `Logradouro` varchar(200) DEFAULT NULL,
  `cep` varchar(9) DEFAULT NULL,
  PRIMARY KEY (`idEndereco`),
  KEY `fk_Endereco_Cidade1_idx` (`idCidade`),
  KEY `FK_endereco_pessoa` (`idPessoa`),
  CONSTRAINT `FK_endereco_pessoa` FOREIGN KEY (`idPessoa`) REFERENCES `pessoa` (`idPessoa`),
  CONSTRAINT `fk_Endereco_Cidade1` FOREIGN KEY (`idCidade`) REFERENCES `cidade` (`idCidade`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `endereco`
--

LOCK TABLES `endereco` WRITE;
/*!40000 ALTER TABLE `endereco` DISABLE KEYS */;
INSERT INTO `endereco` VALUES (1,1,1,'Golfinho','Avenida Marginal Saveiro, 115',NULL),(2,2,4,'Jardim Sumaré','Rua Manoel da Cruz Barbosa, 439',NULL),(3,6,4,'Jd. Sumaré','Manoel da Cruz Barbosa, 439 Casa 2','11680-000'),(4,7,4,'Jardn. Sumaré','manoel da cruz barbosa 439','11680000'),(5,8,3,'Bairro do bar','rua do bira 414','12312312'),(6,9,1,'Qualquer','Algum','10625480'),(7,10,1,'Samambaia','Rua dos apês do centro','115548965'),(8,11,4,'Pedreira','Rua das pedreiras','11680-000'),(9,12,4,'Centro','Rua das araras 79','11680-000'),(10,13,1,'Sumaré','Rua das orquides, 341','11684-448'),(11,14,2,'teste','teste','1231242');
/*!40000 ALTER TABLE `endereco` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `itensorcamento`
--

DROP TABLE IF EXISTS `itensorcamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `itensorcamento` (
  `iditemOrcamento` int(11) NOT NULL AUTO_INCREMENT,
  `idOrcamento` int(11) DEFAULT NULL,
  `nome` varchar(100) DEFAULT NULL,
  `descricao` varchar(300) DEFAULT NULL,
  `valor` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`iditemOrcamento`),
  KEY `fk_itemsOrcamento_Orcamento1_idx` (`idOrcamento`),
  CONSTRAINT `fk_itemsOrcamento_Orcamento1` FOREIGN KEY (`idOrcamento`) REFERENCES `orcamento` (`idOrcamento`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `itensorcamento`
--

LOCK TABLES `itensorcamento` WRITE;
/*!40000 ALTER TABLE `itensorcamento` DISABLE KEYS */;
INSERT INTO `itensorcamento` VALUES (1,3,'Vetorizar Logo-marca','Digitalizar logo do cliente que possui apenas um arquivo com baixa resolução.',150),(2,3,'Tratamento de imagens','Tratar e padronizar fotos da loja para publicação.',120),(3,3,'Produzir banner do site','Trabalhar com o logo, fotos fornecidas pelo cliente e cores da loja.',210);
/*!40000 ALTER TABLE `itensorcamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `itenspadrao`
--

DROP TABLE IF EXISTS `itenspadrao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `itenspadrao` (
  `iditensPadrao` int(11) NOT NULL AUTO_INCREMENT,
  `idUsuario` int(11) DEFAULT NULL,
  `descricao` varchar(45) DEFAULT NULL,
  `valor` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`iditensPadrao`),
  KEY `fk_itensPadrao_Usuario1_idx` (`idUsuario`),
  CONSTRAINT `fk_itensPadrao_Usuario1` FOREIGN KEY (`idUsuario`) REFERENCES `usuario` (`idUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `itenspadrao`
--

LOCK TABLES `itenspadrao` WRITE;
/*!40000 ALTER TABLE `itenspadrao` DISABLE KEYS */;
INSERT INTO `itenspadrao` VALUES (1,1,'Diagramação Texto e Fotos, por página.',30),(2,1,'Produção Slides, por slide',15);
/*!40000 ALTER TABLE `itenspadrao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `notas`
--

DROP TABLE IF EXISTS `notas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `notas` (
  `idNotas` int(11) NOT NULL AUTO_INCREMENT,
  `idProjeto` int(11) DEFAULT NULL,
  `valor` decimal(10,0) DEFAULT NULL,
  `data` date DEFAULT NULL,
  PRIMARY KEY (`idNotas`),
  KEY `fk_Notas_Projeto1_idx` (`idProjeto`),
  CONSTRAINT `fk_Notas_Projeto1` FOREIGN KEY (`idProjeto`) REFERENCES `projeto` (`idProjeto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `notas`
--

LOCK TABLES `notas` WRITE;
/*!40000 ALTER TABLE `notas` DISABLE KEYS */;
INSERT INTO `notas` VALUES (1,1,400,'2014-01-11');
/*!40000 ALTER TABLE `notas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orcamento`
--

DROP TABLE IF EXISTS `orcamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `orcamento` (
  `idOrcamento` int(11) NOT NULL AUTO_INCREMENT,
  `idCliente` int(11) DEFAULT NULL,
  `idUsuario` int(11) DEFAULT NULL,
  `data` date DEFAULT NULL,
  `validade` date DEFAULT NULL,
  PRIMARY KEY (`idOrcamento`),
  KEY `fk_Orcamento_Cliente1_idx` (`idCliente`),
  KEY `fk_Orcamento_Usuario1_idx` (`idUsuario`),
  CONSTRAINT `fk_Orcamento_Cliente1` FOREIGN KEY (`idCliente`) REFERENCES `cliente` (`idCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Orcamento_Usuario1` FOREIGN KEY (`idUsuario`) REFERENCES `usuario` (`idUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orcamento`
--

LOCK TABLES `orcamento` WRITE;
/*!40000 ALTER TABLE `orcamento` DISABLE KEYS */;
INSERT INTO `orcamento` VALUES (2,1,1,'2014-10-30','2014-11-30'),(3,1,2,'2014-11-17','2014-12-17');
/*!40000 ALTER TABLE `orcamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pessoa`
--

DROP TABLE IF EXISTS `pessoa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pessoa` (
  `idPessoa` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(200) DEFAULT NULL,
  `nscto` date DEFAULT NULL,
  `sexo` char(1) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `documento` varchar(20) DEFAULT NULL,
  `tipoPessoa` char(1) DEFAULT NULL,
  `telefone` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`idPessoa`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pessoa`
--

LOCK TABLES `pessoa` WRITE;
/*!40000 ALTER TABLE `pessoa` DISABLE KEYS */;
INSERT INTO `pessoa` VALUES (1,'Luiz Gustavo Nicola Mendes','1982-02-04','M','lg.caragua@gmail.com','304.501.088-13','F','(12)98157-7672'),(2,'Erik Xavier de Alvarenga Monteiro','1990-01-06','M','erik.xam@gmail.com','357.962.848-86','F','(12)99743-2815'),(3,'Karol','1990-05-09','F','karol@gmail.com','321.654.987-25','F','(12)98745-5689'),(4,'Alfredo Boa Ventura','1970-02-04','F','alfredaum@hotmail.com','369.258.147-21','F','(12)3885-9875'),(5,'Dog&CIA','2013-10-10','M','dogecia@gmail.com','32.221.365/0001-25','J','(12)3884-6523'),(6,'Renata Pereira','1985-03-02','F','mulhervitrola@gmail.com','115349684-45','F','12996544966'),(7,'Lico','1990-01-06','M','licoloko@yahoo.com.br','467998371','F','38339063'),(8,'teste','2010-06-08','M','teste@teste','12313213','J','2123123123'),(9,'William Kose','1990-02-23','M','will.i.am@gmail.com','98336594582','F','1299834563'),(10,'André Azimovas','1989-06-11','M','andremovas@gmail.com','445487898456','F','12555458546'),(11,'Rafael Sabóia','1992-03-12','M','saboia@gmail.com','45621254896','F','12996548745'),(12,'Karol Moura','1990-05-22','F','karolqgcm@gmail.com','1123124123','F','4560223154'),(13,'Izabela Alves','1986-05-06','M','izalves@gmail.com','45646512345','F','1299658745'),(14,'teste','2014-11-21','F','teste','teste','J','12312312');
/*!40000 ALTER TABLE `pessoa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pgtoprojeto`
--

DROP TABLE IF EXISTS `pgtoprojeto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pgtoprojeto` (
  `idPgtoProjeto` int(11) NOT NULL AUTO_INCREMENT,
  `idProjeto` int(11) NOT NULL,
  `valor` decimal(10,0) DEFAULT NULL,
  `data` date DEFAULT NULL,
  `recibo` varchar(300) DEFAULT NULL,
  PRIMARY KEY (`idPgtoProjeto`),
  KEY `fk_PgtoProjeto_Projeto1_idx` (`idProjeto`),
  CONSTRAINT `fk_PgtoProjeto_Projeto1` FOREIGN KEY (`idProjeto`) REFERENCES `projeto` (`idProjeto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pgtoprojeto`
--

LOCK TABLES `pgtoprojeto` WRITE;
/*!40000 ALTER TABLE `pgtoprojeto` DISABLE KEYS */;
INSERT INTO `pgtoprojeto` VALUES (1,1,120,'0201-02-09','C:\\Users\\a1355147\\Desktop\\ProvaEx1');
/*!40000 ALTER TABLE `pgtoprojeto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `projeto`
--

DROP TABLE IF EXISTS `projeto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `projeto` (
  `idProjeto` int(11) NOT NULL AUTO_INCREMENT,
  `idOrcamento` int(11) DEFAULT NULL,
  `inicio` date DEFAULT NULL,
  `prazo` date DEFAULT NULL,
  PRIMARY KEY (`idProjeto`),
  KEY `fk_Projeto_Orcamento1_idx` (`idOrcamento`),
  CONSTRAINT `fk_Projeto_Orcamento1` FOREIGN KEY (`idOrcamento`) REFERENCES `orcamento` (`idOrcamento`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `projeto`
--

LOCK TABLES `projeto` WRITE;
/*!40000 ALTER TABLE `projeto` DISABLE KEYS */;
INSERT INTO `projeto` VALUES (1,2,'2014-02-09','2014-02-12'),(2,3,'2014-11-18','2014-12-18');
/*!40000 ALTER TABLE `projeto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `statustarefa`
--

DROP TABLE IF EXISTS `statustarefa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `statustarefa` (
  `idStatusTarefa` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idStatusTarefa`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `statustarefa`
--

LOCK TABLES `statustarefa` WRITE;
/*!40000 ALTER TABLE `statustarefa` DISABLE KEYS */;
INSERT INTO `statustarefa` VALUES (1,'Nova'),(2,'Executando'),(3,'Finalizada');
/*!40000 ALTER TABLE `statustarefa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tarefas`
--

DROP TABLE IF EXISTS `tarefas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tarefas` (
  `idTarefas` int(11) NOT NULL AUTO_INCREMENT,
  `idProjeto` int(11) DEFAULT NULL,
  `idUsuarioAlocado` int(11) DEFAULT NULL,
  `idStatus` int(11) DEFAULT NULL,
  `idTarefaPai` int(11) DEFAULT NULL,
  `titulo` varchar(100) DEFAULT NULL,
  `descricao` varchar(300) DEFAULT NULL,
  PRIMARY KEY (`idTarefas`),
  KEY `fk_Tarefas_Projeto1_idx` (`idProjeto`),
  KEY `fk_Tarefas_StatusTarefa1_idx` (`idStatus`),
  CONSTRAINT `fk_Tarefas_Projeto1` FOREIGN KEY (`idProjeto`) REFERENCES `projeto` (`idProjeto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Tarefas_StatusTarefa1` FOREIGN KEY (`idStatus`) REFERENCES `statustarefa` (`idStatusTarefa`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tarefas`
--

LOCK TABLES `tarefas` WRITE;
/*!40000 ALTER TABLE `tarefas` DISABLE KEYS */;
INSERT INTO `tarefas` VALUES (1,1,1,1,NULL,'Vetorizar Logo','Digitalizar no CorelDraw o Logo da Empresa.'),(2,1,1,2,NULL,'Tratar Imagens','Aplicar Mascara ecolhida pelo Cliente'),(15,2,NULL,NULL,NULL,'Vetorizar Logo-marca','Digitalizar logo do cliente que possui apenas um arquivo com baixa resolução.'),(16,2,NULL,NULL,NULL,'Tratamento de imagens','Tratar e padronizar fotos da loja para publicação.'),(17,2,NULL,1,NULL,'Produzir banner do site','Trabalhar com o logo, fotos fornecidas pelo cliente e cores da loja.'),(18,2,NULL,NULL,17,'Desenhar personagem para logo','Desenhar um pato laranja para inserção na logo do banner'),(19,2,NULL,NULL,17,'Montar banner de vários tamanhos','Criar nos tamanhos: 200x800, 360x1024 e 480x1980');
/*!40000 ALTER TABLE `tarefas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `uf`
--

DROP TABLE IF EXISTS `uf`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `uf` (
  `idUf` char(2) NOT NULL DEFAULT '',
  `Nome` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idUf`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `uf`
--

LOCK TABLES `uf` WRITE;
/*!40000 ALTER TABLE `uf` DISABLE KEYS */;
INSERT INTO `uf` VALUES ('MG','Minas Gerais'),('RJ','Rio de Janeiro'),('SP','São Paulo');
/*!40000 ALTER TABLE `uf` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `idUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `idPessoa` int(11) DEFAULT NULL,
  `user` varchar(20) DEFAULT NULL,
  `pass` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idUsuario`),
  KEY `fk_Usuario_Pessoa1_idx` (`idPessoa`),
  CONSTRAINT `fk_Usuario_Pessoa1` FOREIGN KEY (`idPessoa`) REFERENCES `pessoa` (`idPessoa`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,1,'lg.caragua','lg.caragua'),(2,2,'erik.xam','erik.xam');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'cashin'
--
/*!50003 DROP FUNCTION IF EXISTS `fn_totalOrcamento` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `fn_totalOrcamento`(idorc INT) RETURNS decimal(10,0)
BEGIN
	DECLARE total DECIMAL;
	SELECT SUM(valor) INTO total FROM itensorcamento WHERE idorcamento = idorc;
RETURN total;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_orcamentoTarefas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_orcamentoTarefas`(idProjeto int)
BEGIN
DECLARE done INT DEFAULT FALSE;
DECLARE nome VARCHAR(100);
DECLARE descr VARCHAR(300);
DECLARE itens CURSOR FOR 
	SELECT 	i.nome,i.descricao FROM itensorcamento i
	WHERE i.idorcamento = (SELECT p.idorcamento FROM projeto p WHERE p.idprojeto = idProjeto);
 DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = TRUE;

OPEN itens;

read_loop : LOOP
	FETCH itens INTO nome, descr;
	IF done THEN
		leave read_loop;
	END IF;
	INSERT INTO tarefas(idprojeto, titulo, descricao) VALUES(idProjeto, nome, descr);
END LOOP;

CLOSE itens;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `statusTarefasFilho` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `statusTarefasFilho`(idt int, ids int)
BEGIN
	UPDATE tarefas t SET t.idStatus = ids WHERE t.idtarefapai = idt;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2014-11-18 22:00:14
