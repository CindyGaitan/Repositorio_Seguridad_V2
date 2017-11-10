-- MySQL Script generated by MySQL Workbench
-- Fri Oct 27 10:17:31 2017
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema BD_seguridad
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema BD_seguridad
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `BD_seguridad` DEFAULT CHARACTER SET utf8 ;
USE `BD_seguridad` ;

-- -----------------------------------------------------
-- Table `BD_seguridad`.`Usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BD_seguridad`.`Usuario` (
  `id_usuario` INT NOT NULL AUTO_INCREMENT,
  `usuario` VARCHAR(50) NOT NULL,
  `nombre_usuario` VARCHAR(50) NOT NULL,
  `apellido_usuario` VARCHAR(50) NOT NULL,
  `contrasena` VARCHAR(45) NOT NULL,
  `correo_usuario` VARCHAR(45) NULL,
  `telefono_usuario` INT(8) NULL,
  PRIMARY KEY (`id_usuario`),
  UNIQUE INDEX `usuario_UNIQUE` (`usuario` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BD_seguridad`.`Perfil`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BD_seguridad`.`Perfil` (
  `id_perfil` INT NOT NULL AUTO_INCREMENT,
  `nombre_perfil` VARCHAR(50) NOT NULL,
  `descripcion_perfil` VARCHAR(80) NOT NULL,
  PRIMARY KEY (`id_perfil`),
  UNIQUE INDEX `nombre_perfil_UNIQUE` (`nombre_perfil` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BD_seguridad`.`Aplicacion`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BD_seguridad`.`Aplicacion` (
  `id_aplicacion` INT NOT NULL AUTO_INCREMENT,
  `nombre_aplicacion` VARCHAR(50) NOT NULL,
  `descripcion_aplicacion` VARCHAR(80) NOT NULL,
  `habilitar_aplicacion` TINYINT(1) NOT NULL,
  `id_reporte` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_aplicacion`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BD_seguridad`.`Detalle_perfil_aplicacion`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BD_seguridad`.`Detalle_perfil_aplicacion` (
  `id_perfil` INT NOT NULL,
  `id_aplicacion` INT NOT NULL,
  PRIMARY KEY (`id_perfil`, `id_aplicacion`),
  INDEX `FK_detalle_aplicacion_idx` (`id_aplicacion` ASC),
  CONSTRAINT `FK_detalle_perfil`
    FOREIGN KEY (`id_perfil`)
    REFERENCES `BD_seguridad`.`Perfil` (`id_perfil`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_detalle_aplicacion`
    FOREIGN KEY (`id_aplicacion`)
    REFERENCES `BD_seguridad`.`Aplicacion` (`id_aplicacion`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BD_seguridad`.`Detalle_aplicacion_derecho`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BD_seguridad`.`Detalle_aplicacion_derecho` (
  `id_usuario` INT NOT NULL,
  `id_aplicacion` INT NOT NULL,
  `ingresar` TINYINT(1) NOT NULL,
  `modificar` TINYINT(1) NOT NULL,
  `eliminar` TINYINT(1) NOT NULL,
  `imprimir` TINYINT(1) NOT NULL,
  `consultar` TINYINT(1) NOT NULL,
  PRIMARY KEY (`id_usuario`, `id_aplicacion`),
  INDEX `FK_detalle_usuario_idx` (`id_usuario` ASC),
  CONSTRAINT `FK_detalle_aplicacion2`
    FOREIGN KEY (`id_aplicacion`)
    REFERENCES `BD_seguridad`.`Aplicacion` (`id_aplicacion`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_detalle_usuario`
    FOREIGN KEY (`id_usuario`)
    REFERENCES `BD_seguridad`.`Usuario` (`id_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BD_seguridad`.`bitacora_app`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BD_seguridad`.`bitacora_app` (
  `id_aplicacion` INT NOT NULL,
  `desc_app` VARCHAR(45) NULL,
  PRIMARY KEY (`id_aplicacion`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BD_seguridad`.`Bitacora`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BD_seguridad`.`Bitacora` (
  `id_bitacora` INT NOT NULL AUTO_INCREMENT,
  `id_usuario` INT NOT NULL,
  `fecha_bitacora` DATE NOT NULL,
  `hora_bitacora` TIME(6) NOT NULL,
  `accion_usuario` VARCHAR(45) NOT NULL,
  `id_aplicacion` INT NOT NULL,
  `resultado_bitacora` VARCHAR(45) NOT NULL,
  `error_bitacora` VARCHAR(120) NOT NULL,
  `ip_pc` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_bitacora`),
  INDEX `FK_bitacora_usuario_idx` (`id_usuario` ASC),
  INDEX `Fk_app_idx` (`id_aplicacion` ASC),
  CONSTRAINT `FK_bitacora_usuario`
    FOREIGN KEY (`id_usuario`)
    REFERENCES `BD_seguridad`.`Usuario` (`id_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `Fk_app`
    FOREIGN KEY (`id_aplicacion`)
    REFERENCES `BD_seguridad`.`bitacora_app` (`id_aplicacion`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BD_seguridad`.`Detalle_usuario_perfil`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BD_seguridad`.`Detalle_usuario_perfil` (
  `id_usuario` INT NOT NULL,
  `id_perfil` INT NOT NULL,
  PRIMARY KEY (`id_usuario`, `id_perfil`),
  INDEX `FK_detalle_up_perfil_idx` (`id_perfil` ASC),
  CONSTRAINT `FK_detalle_up_usuario`
    FOREIGN KEY (`id_usuario`)
    REFERENCES `BD_seguridad`.`Usuario` (`id_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_detalle_up_perfil`
    FOREIGN KEY (`id_perfil`)
    REFERENCES `BD_seguridad`.`Perfil` (`id_perfil`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

select * from detalle_aplicacion_derecho;
select * from usuario;

select dpd.ingresar from detalle_aplicacion_derecho dpd 
inner join usuario u on u.id_usuario=dpd.id_usuario
where u.usuario='cindyg';


select * from detalle_aplicacion_derecho;
select * from usuario;
select * from aplicacion;
INSERT INTO `bd_seguridad`.`aplicacion` (`id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `habilitar_aplicacion`, `id_reporte`) VALUES ('1', 'Aplicacion1', 'Nueva Aplicacion', '1', '1');
INSERT INTO `bd_seguridad`.`detalle_aplicacion_derecho` (`id_usuario`, `id_aplicacion`, `ingresar`, `modificar`, `eliminar`, `imprimir`, `consultar`) VALUES ('1', '1', '1', '1', '0', '0', '1');



