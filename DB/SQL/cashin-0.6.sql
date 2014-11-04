SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema cashin
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `cashin` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `cashin` ;

-- -----------------------------------------------------
-- Table `cashin`.`Pessoa`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `cashin`.`Pessoa` ;

CREATE TABLE IF NOT EXISTS `cashin`.`Pessoa` (
  `idPessoa` INT NOT NULL AUTO_INCREMENT,
  `Nome` VARCHAR(200) NULL,
  `nscto` DATE NULL,
  `sexo` CHAR NULL,
  `email` VARCHAR(100) NULL,
  `documento` VARCHAR(20) NULL,
  `tipoPessoa` CHAR NULL,
  `telefone` VARCHAR(20) NULL,
  PRIMARY KEY (`idPessoa`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cashin`.`UF`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `cashin`.`UF` ;

CREATE TABLE IF NOT EXISTS `cashin`.`UF` (
  `idUf` INT NOT NULL AUTO_INCREMENT,
  `Nome` VARCHAR(100) NULL,
  PRIMARY KEY (`idUf`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cashin`.`Cidade`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `cashin`.`Cidade` ;

CREATE TABLE IF NOT EXISTS `cashin`.`Cidade` (
  `idCidade` INT NOT NULL AUTO_INCREMENT,
  `idUf` INT NULL,
  `Nome` VARCHAR(100) NULL,
  PRIMARY KEY (`idCidade`),
  INDEX `fk_Cidade_UF1_idx` (`idUf` ASC),
  CONSTRAINT `fk_Cidade_UF1`
    FOREIGN KEY (`idUf`)
    REFERENCES `cashin`.`UF` (`idUf`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cashin`.`Endereco`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `cashin`.`Endereco` ;

CREATE TABLE IF NOT EXISTS `cashin`.`Endereco` (
  `idEndereco` INT NOT NULL AUTO_INCREMENT,
  `idPessoa` INT NULL,
  `idTipo` INT NULL,
  `idCidade` INT NULL,
  `Bairro` VARCHAR(200) NULL,
  `Logradouro` VARCHAR(200) NULL,
  PRIMARY KEY (`idEndereco`),
  INDEX `fk_Endereco_Cidade1_idx` (`idCidade` ASC),
  CONSTRAINT `fk_Endereco_Cidade1`
    FOREIGN KEY (`idCidade`)
    REFERENCES `cashin`.`Cidade` (`idCidade`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cashin`.`Cliente`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `cashin`.`Cliente` ;

CREATE TABLE IF NOT EXISTS `cashin`.`Cliente` (
  `idCliente` INT NOT NULL AUTO_INCREMENT,
  `idPessoa` INT NULL,
  `descricao` VARCHAR(300) NULL,
  PRIMARY KEY (`idCliente`),
  INDEX `fk_Cliente_Pessoa1_idx` (`idPessoa` ASC),
  CONSTRAINT `fk_Cliente_Pessoa1`
    FOREIGN KEY (`idPessoa`)
    REFERENCES `cashin`.`Pessoa` (`idPessoa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cashin`.`Usuario`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `cashin`.`Usuario` ;

CREATE TABLE IF NOT EXISTS `cashin`.`Usuario` (
  `idUsuario` INT NOT NULL AUTO_INCREMENT,
  `idPessoa` INT NULL,
  `user` VARCHAR(20) NULL,
  `pass` VARCHAR(45) NULL,
  PRIMARY KEY (`idUsuario`),
  INDEX `fk_Usuario_Pessoa1_idx` (`idPessoa` ASC),
  CONSTRAINT `fk_Usuario_Pessoa1`
    FOREIGN KEY (`idPessoa`)
    REFERENCES `cashin`.`Pessoa` (`idPessoa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cashin`.`Orcamento`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `cashin`.`Orcamento` ;

CREATE TABLE IF NOT EXISTS `cashin`.`Orcamento` (
  `idOrcamento` INT NOT NULL AUTO_INCREMENT,
  `idCliente` INT NULL,
  `idUsuario` INT NULL,
  `data` DATE NULL,
  `validade` DATE NULL,
  PRIMARY KEY (`idOrcamento`),
  INDEX `fk_Orcamento_Cliente1_idx` (`idCliente` ASC),
  INDEX `fk_Orcamento_Usuario1_idx` (`idUsuario` ASC),
  CONSTRAINT `fk_Orcamento_Cliente1`
    FOREIGN KEY (`idCliente`)
    REFERENCES `cashin`.`Cliente` (`idCliente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Orcamento_Usuario1`
    FOREIGN KEY (`idUsuario`)
    REFERENCES `cashin`.`Usuario` (`idUsuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cashin`.`itemsOrcamento`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `cashin`.`itemsOrcamento` ;

CREATE TABLE IF NOT EXISTS `cashin`.`itemsOrcamento` (
  `iditemOrcamento` INT NOT NULL AUTO_INCREMENT,
  `idOrcamento` INT NULL,
  `nome` VARCHAR(100) NULL,
  `descricao` VARCHAR(300) NULL,
  `valor` DECIMAL NULL,
  PRIMARY KEY (`iditemOrcamento`),
  INDEX `fk_itemsOrcamento_Orcamento1_idx` (`idOrcamento` ASC),
  CONSTRAINT `fk_itemsOrcamento_Orcamento1`
    FOREIGN KEY (`idOrcamento`)
    REFERENCES `cashin`.`Orcamento` (`idOrcamento`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cashin`.`itensPadrao`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `cashin`.`itensPadrao` ;

CREATE TABLE IF NOT EXISTS `cashin`.`itensPadrao` (
  `iditensPadrao` INT NOT NULL AUTO_INCREMENT,
  `idUsuario` INT NULL,
  `descricao` VARCHAR(45) NULL,
  `valor` DECIMAL NULL,
  PRIMARY KEY (`iditensPadrao`),
  INDEX `fk_itensPadrao_Usuario1_idx` (`idUsuario` ASC),
  CONSTRAINT `fk_itensPadrao_Usuario1`
    FOREIGN KEY (`idUsuario`)
    REFERENCES `cashin`.`Usuario` (`idUsuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cashin`.`Projeto`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `cashin`.`Projeto` ;

CREATE TABLE IF NOT EXISTS `cashin`.`Projeto` (
  `idProjeto` INT NOT NULL AUTO_INCREMENT,
  `idOrcamento` INT NULL,
  `inicio` DATE NULL,
  `prazo` DATE NULL,
  PRIMARY KEY (`idProjeto`),
  INDEX `fk_Projeto_Orcamento1_idx` (`idOrcamento` ASC),
  CONSTRAINT `fk_Projeto_Orcamento1`
    FOREIGN KEY (`idOrcamento`)
    REFERENCES `cashin`.`Orcamento` (`idOrcamento`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cashin`.`StatusTarefa`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `cashin`.`StatusTarefa` ;

CREATE TABLE IF NOT EXISTS `cashin`.`StatusTarefa` (
  `idStatusTarefa` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NULL,
  PRIMARY KEY (`idStatusTarefa`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cashin`.`Tarefas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `cashin`.`Tarefas` ;

CREATE TABLE IF NOT EXISTS `cashin`.`Tarefas` (
  `idTarefas` INT NOT NULL AUTO_INCREMENT,
  `idProjeto` INT NULL,
  `idUsuarioAlocado` INT NULL,
  `idStatus` INT NULL,
  `idTarefaPai` INT NULL,
  `titulo` VARCHAR(100) NULL,
  `descricao` VARCHAR(300) NULL,
  PRIMARY KEY (`idTarefas`),
  INDEX `fk_Tarefas_Projeto1_idx` (`idProjeto` ASC),
  INDEX `fk_Tarefas_StatusTarefa1_idx` (`idStatus` ASC),
  CONSTRAINT `fk_Tarefas_Projeto1`
    FOREIGN KEY (`idProjeto`)
    REFERENCES `cashin`.`Projeto` (`idProjeto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Tarefas_StatusTarefa1`
    FOREIGN KEY (`idStatus`)
    REFERENCES `cashin`.`StatusTarefa` (`idStatusTarefa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cashin`.`Notas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `cashin`.`Notas` ;

CREATE TABLE IF NOT EXISTS `cashin`.`Notas` (
  `idNotas` INT NOT NULL AUTO_INCREMENT,
  `idProjeto` INT NULL,
  `valor` DECIMAL NULL,
  `data` DATE NULL,
  PRIMARY KEY (`idNotas`),
  INDEX `fk_Notas_Projeto1_idx` (`idProjeto` ASC),
  CONSTRAINT `fk_Notas_Projeto1`
    FOREIGN KEY (`idProjeto`)
    REFERENCES `cashin`.`Projeto` (`idProjeto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cashin`.`PgtoProjeto`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `cashin`.`PgtoProjeto` ;

CREATE TABLE IF NOT EXISTS `cashin`.`PgtoProjeto` (
  `idPgtoProjeto` INT NOT NULL AUTO_INCREMENT,
  `idProjeto` INT NOT NULL,
  `valor` DECIMAL NULL,
  `data` DATE NULL,
  `recibo` VARCHAR(300) NULL,
  PRIMARY KEY (`idPgtoProjeto`),
  INDEX `fk_PgtoProjeto_Projeto1_idx` (`idProjeto` ASC),
  CONSTRAINT `fk_PgtoProjeto_Projeto1`
    FOREIGN KEY (`idProjeto`)
    REFERENCES `cashin`.`Projeto` (`idProjeto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
