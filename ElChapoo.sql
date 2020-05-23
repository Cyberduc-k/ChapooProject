-- MySQL Workbench Forward Engineering

/* SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0; */
/* SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0; */
/* SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION'; */

-- -----------------------------------------------------
-- Schema ElChapoo
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema ElChapoo
-- -----------------------------------------------------
-- CREATE SCHEMA IF NOT EXISTS ElChapoo DEFAULT CHARACTER SET utf8 ;
USE [dbchapoo12]

-- -----------------------------------------------------
-- Table `ElChapoo`.`Table`
-- -----------------------------------------------------
CREATE TABLE [dbchapoo12].[Table] (
  [id] INT NOT NULL IDENTITY,
  [occupied] SMALLINT NOT NULL,
  [seats] INT NOT NULL,
  PRIMARY KEY ([id]))
;


-- -----------------------------------------------------
-- Table `ElChapoo`.`Reservation`
-- -----------------------------------------------------
CREATE TABLE [dbchapoo12].[Reservation] (
  [id] INT NOT NULL IDENTITY,
  [date] DATETIME2(0) NOT NULL,
  [from] DATETIME2(0) NOT NULL,
  [to] DATETIME2(0) NOT NULL,
  [name] VARCHAR(45) NOT NULL,
  [numberOfPeople] INT NOT NULL,
  [Table_id] INT NOT NULL,
  PRIMARY KEY ([id]),
  CONSTRAINT [fk_Reservation_Table]
    FOREIGN KEY ([Table_id])
    REFERENCES [dbchapoo12].[Table] ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION) ;


-- -----------------------------------------------------
-- Table `ElChapoo`.`Employee`
-- -----------------------------------------------------
CREATE TABLE [dbchapoo12].[Employee] (
  [id] INT NOT NULL IDENTITY,
  [dateOfBirth] DATETIME2(0) NOT NULL,
  [dateEmployment] DATETIME2(0) NOT NULL,
  [firstname] VARCHAR(45) NOT NULL,
  [lastname] VARCHAR(45) NOT NULL,
  [password] VARCHAR(45) NOT NULL,
  [employeeType] INT NOT NULL,
  [gender] INT NOT NULL,
  PRIMARY KEY ([id]))
;


-- -----------------------------------------------------
-- Table `ElChapoo`.`Bill`
-- -----------------------------------------------------
CREATE TABLE [dbchapoo12].[Bill] (
  [id] INT NOT NULL IDENTITY,
  [price] FLOAT NOT NULL,
  [Table_id] INT NOT NULL,
  [Employee_id] INT NOT NULL,
  PRIMARY KEY ([id]),
  CONSTRAINT [fk_Bill_Table1]
    FOREIGN KEY ([Table_id])
    REFERENCES [dbchapoo12].[Table] ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Bill_Employee1]
    FOREIGN KEY ([Employee_id])
    REFERENCES [dbchapoo12].[Employee] ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);


-- -----------------------------------------------------
-- Table `ElChapoo`.`Menu`
-- -----------------------------------------------------
CREATE TABLE [dbchapoo12].[Menu] (
  [id] INT NOT NULL IDENTITY,
  [menuType] INT NOT NULL,
  PRIMARY KEY ([id]))
;


-- -----------------------------------------------------
-- Table `ElChapoo`.`Dish`
-- -----------------------------------------------------
CREATE TABLE [dbchapoo12].[Dish] (
  [id] INT NOT NULL IDENTITY,
  [discription] VARCHAR(45) NOT NULL,
  [ingredienst] VARCHAR(100) NOT NULL,
  PRIMARY KEY ([id]))
;


-- -----------------------------------------------------
-- Table `ElChapoo`.`Drink`
-- -----------------------------------------------------
CREATE TABLE [dbchapoo12].[Drink] (
  [id] INT NOT NULL IDENTITY,
  [alcoholic] SMALLINT NOT NULL,
  PRIMARY KEY ([id]))
;


-- -----------------------------------------------------
-- Table `ElChapoo`.`Item`
-- -----------------------------------------------------
CREATE TABLE [dbchapoo12].[Item] (
  [id] INT NOT NULL IDENTITY,
  [name] VARCHAR(45) NOT NULL,
  [numberInStock] INT NOT NULL,
  [price] FLOAT NOT NULL,
  [Menu_id] INT NOT NULL,
  [Dish_id] INT NULL,
  [Drink_id] INT NULL,
  PRIMARY KEY ([id]),
  CONSTRAINT [fk_Item_Menu1]
    FOREIGN KEY ([Menu_id])
    REFERENCES [dbchapoo12].[Menu] ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Item_Dish1]
    FOREIGN KEY ([Dish_id])
    REFERENCES [dbchapoo12].[Dish] ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Item_Drink1]
    FOREIGN KEY ([Drink_id])
    REFERENCES [dbchapoo12].[Drink] ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);


-- -----------------------------------------------------
-- Table `ElChapoo`.`Order`
-- -----------------------------------------------------
CREATE TABLE [dbchapoo12].[Order] (
  [id] INT NOT NULL IDENTITY,
  [comment] VARCHAR(100) NULL,
  [date] DATETIME2(0) NOT NULL,
  [timeOrdering] DATETIME2(0) NOT NULL,
  [timeFinished] DATETIME2(0) NULL,
  [totalPrice] VARCHAR(45) NOT NULL,
  [Table_id] INT NOT NULL,
  [Employee_id] INT NOT NULL,
  [Bill_id] INT NOT NULL,
  PRIMARY KEY ([id]),
  CONSTRAINT [fk_Order_Table1]
    FOREIGN KEY ([Table_id])
    REFERENCES [dbchapoo12].[Table] ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Order_Employee1]
    FOREIGN KEY ([Employee_id])
    REFERENCES [dbchapoo12].[Employee] ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Order_Bill1]
    FOREIGN KEY ([Bill_id])
    REFERENCES [dbchapoo12].[Bill] ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);


-- -----------------------------------------------------
-- Table `ElChapoo`.`Order_has_Item`
-- -----------------------------------------------------
CREATE TABLE ElChapoo.Order_has_Item (
  [Order_id] INT NOT NULL,
  [Item_id] INT NOT NULL,
  PRIMARY KEY ([Order_id], [Item_id]),
  CONSTRAINT [fk_Order_has_Item_Order1]
    FOREIGN KEY ([Order_id])
    REFERENCES [dbchapoo12].[Order] ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Order_has_Item_Item1]
    FOREIGN KEY ([Item_id])
    REFERENCES [dbchapoo12].[Item] ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);


/* SET SQL_MODE=@OLD_SQL_MODE; */
/* SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS; */
/* SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS; */
