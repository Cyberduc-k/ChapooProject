CREATE TABLE [dbo].[Tables] (
  [id] INT NOT NULL PRIMARY KEY IDENTITY,
  [occupied] BIT NOT NULL,
  [seats] TINYINT NOT NULL,
)

CREATE TABLE [dbo].[Employees] (
  [id] INT NOT NULL PRIMARY KEY IDENTITY(1000,1),
  [dateOfBirth] DATE NOT NULL,
  [dateOfEmployment] DATE NOT NULL,
  [firstname] VARCHAR(100) NOT NULL,
  [lastname] VARCHAR(100) NOT NULL,
  [password] VARCHAR(100) NOT NULL,
  [employeeType] TINYINT NOT NULL,
  [gender] TINYINT NOT NULL,
)

CREATE TABLE [dbo].[Dishes] (
  [id] INT NOT NULL PRIMARY KEY IDENTITY,
  [name] VARCHAR(100) NOT NULL,
  [description] TEXT,
  [ingredients] TEXT,
  [price] FLOAT NOT NULL,
  [stock] INT NOT NULL
)

CREATE TABLE [dbo].[Drinks] (
  [id] INT NOT NULL PRIMARY KEY IDENTITY,
  [name] VARCHAR(100) NOT NULL,
  [alcoholic] BIT NOT NULL,
  [price] FLOAT NOT NULL,
  [stock] INT NOT NULL
)

CREATE TABLE [dbo].[Menus] (
  [id] INT NOT NULL PRIMARY KEY IDENTITY,
  [menuType] TINYINT NOT NULL
)

CREATE TABLE [dbo].[Reservations] (
  [id] INT NOT NULL PRIMARY KEY IDENTITY,
  [date] DATE NOT NULL,
  [from] TIME NOT NULL,
  [to] TIME NOT NULL,
  [name] VARCHAR(100) NOT NULL,
  [numberOfPeople] TINYINT NOT NULL,
  [tableId] INT FOREIGN KEY REFERENCES Tables(id) ON UPDATE CASCADE NOT NULL
)  

CREATE TABLE [dbo].[Bills] (
  [id] INT NOT NULL PRIMARY KEY IDENTITY,
  [tableId] INT FOREIGN KEY REFERENCES Tables(id) ON UPDATE CASCADE NOT NULL,
)  

CREATE TABLE [dbo].[Orders] (
  [id] INT NOT NULL PRIMARY KEY IDENTITY,
  [comment] VARCHAR(100) NULL,
  [date] DATE NOT NULL,
  [timeOrdering] TIME NOT NULL,
  [timeFinished] TIME NULL,
  [tableId] INT FOREIGN KEY REFERENCES Tables(id) ON DELETE CASCADE NOT NULL,
  [employeeId] INT FOREIGN KEY REFERENCES Employees(id) ON DELETE CASCADE NOT NULL,
)
	
CREATE TABLE [dbo].[Bill_has_order]
(
    [billId] INT FOREIGN KEY REFERENCES Bills(id) ON DELETE CASCADE NOT NULL,
    [orderId] INT FOREIGN KEY REFERENCES Orders(id) ON DELETE CASCADE NOT NULL
)

CREATE TABLE [dbo].[Menu_has_dish]
(
    [menuId] INT FOREIGN KEY REFERENCES Menus(id) ON DELETE CASCADE NOT NULL,
    [dishId] INT FOREIGN KEY REFERENCES Dishes(id) ON DELETE CASCADE NOT NULL
)

CREATE TABLE [dbo].[Menu_has_drink]
(
    [menuId] INT FOREIGN KEY REFERENCES Menus(id) ON DELETE CASCADE NOT NULL,
    [drinkId] INT FOREIGN KEY REFERENCES Drinks(id) ON DELETE CASCADE NOT NULL
)

CREATE TABLE [dbo].[Order_has_dish]
(
    [orderId] INT FOREIGN KEY REFERENCES Orders(id) ON DELETE CASCADE NOT NULL,
    [dishId] INT FOREIGN KEY REFERENCES Dishes(id) ON DELETE CASCADE NOT NULL
)

CREATE TABLE [dbo].[Order_has_drink]
(
    [orderId] INT FOREIGN KEY REFERENCES Orders(id) ON DELETE CASCADE NOT NULL,
    [drinkId] INT FOREIGN KEY REFERENCES Drinks(id) ON DELETE CASCADE NOT NULL
)

--Datagen
INSERT INTO Employees([dateOfBirth],[dateOfEmployment],[firstname],[lastname],[password],[employeeType],[gender]) VALUES('2020-01-30','2020-05-26','Clayton','Atkins',5771,0,1),('2019-06-14','2019-12-24','Brock','Velazquez',1836,1,1),('2020-05-19','2019-10-05','Kevin','Delgado',4339,0,1),('2020-01-26','2019-09-07','Zachery','Lopez',4800,0,1),('2020-02-18','2019-07-10','Devin','Solis',9653,2,1),('2020-02-20','2021-02-15','Nero','Leblanc',1828,2,1),('2019-12-15','2019-12-19','Emery','Kirk',41002,0,0),('2019-07-04','2019-10-14','Colorado','Carney',3513,1,0),('2019-12-25','2020-04-22','Duncan','Pickett',9277,2,1),('2019-07-04','2021-04-09','Silas','Butler',2771,0,1);
INSERT INTO Employees([dateOfBirth],[dateOfEmployment],[firstname],[lastname],[password],[employeeType],[gender]) VALUES('2019-07-08','2020-10-03','Walker','Turner',3099,0,0),('2019-07-15','2020-02-09','Kane','Warren',7812,2,1),('2020-05-03','2020-08-14','Harding','Shaffer',7124,0,1),('2020-03-30','2020-03-10','Preston','Rush',1518,2,1),('2019-10-25','2019-10-01','Bradley','Fischer',6675,1,0),('2020-01-03','2021-04-09','Akeem','Everett',8019,1,1),('2020-01-06','2020-12-14','Cole','Mckinney',5747,1,0),('2020-02-28','2019-12-27','Silas','Zamora',6438,2,0),('2020-02-01','2020-01-24','Carlos','Fitzpatrick',8606,0,0),('2019-07-31','2019-10-21','Hiram','Avila',2673,2,1);
INSERT INTO Employees([dateOfBirth],[dateOfEmployment],[firstname],[lastname],[password],[employeeType],[gender]) VALUES('2020-03-10','2021-01-05','Orson','Howe',9142,1,1),('2020-01-16','2020-07-12','Laith','Alexander',4153,1,1),('2019-12-04','2020-04-17','Nero','Acevedo',30100,1,1),('2020-04-17','2019-11-08','Cade','Powers',2674,0,1),('2019-09-26','2020-06-16','Blake','Sears',5154,1,0),('2020-01-04','2020-01-05','Ira','Eaton',2024,2,0),('2020-01-02','2020-10-19','Matthew','Nash',8644,0,0),('2020-02-22','2020-12-25','Damon','Pollard',9127,1,0),('2019-07-03','2020-05-24','Mohammad','Burch',8269,0,0),('2019-06-20','2019-08-29','Ferris','Peck',8576,0,0);
INSERT INTO Employees([dateOfBirth],[dateOfEmployment],[firstname],[lastname],[password],[employeeType],[gender]) VALUES('2019-06-16','2020-05-02','Harper','Griffin',6704,0,0),('2020-03-12','2019-11-29','Nasim','Mann',8496,1,1),('2019-11-27','2019-10-16','Luke','Mccullough',7785,2,0),('2019-06-19','2019-07-12','Brent','Payne',4339,0,1),('2019-10-04','2019-06-20','Dillon','Solis',1730,2,0),('2019-11-04','2020-01-08','Maxwell','Travis',9656,1,1),('2020-05-12','2021-01-31','Cole','Alvarez',2926,0,1),('2020-02-27','2019-06-04','Hyatt','Buckley',1982,0,1),('2019-08-05','2019-11-08','Leonard','Miller',6923,1,1),('2019-08-11','2021-01-04','Russell','Nguyen',1604,2,0);
INSERT INTO Employees([dateOfBirth],[dateOfEmployment],[firstname],[lastname],[password],[employeeType],[gender]) VALUES('2020-02-29','2019-08-03','Caesar','Drake',4863,2,1),('2019-10-14','2019-11-18','Joshua','Holmes',8851,0,0),('2019-11-26','2020-03-27','Drake','Williams',8044,0,1),('2019-12-27','2020-06-18','Gary','Melendez',7602,0,1),('2019-08-14','2020-11-11','Aquila','Scott',6710,2,0),('2019-08-07','2020-08-01','Josiah','Vargas',6627,0,1),('2020-02-12','2021-04-22','Phillip','Weber',1388,1,1),('2019-12-27','2019-09-08','Damian','Kaufman',3772,2,0),('2019-11-30','2020-07-01','Rogan','Kirk',5757,0,0),('2019-07-13','2020-08-21','Nathan','Hurst',7989,0,1);
INSERT INTO Employees([dateOfBirth],[dateOfEmployment],[firstname],[lastname],[password],[employeeType],[gender]) VALUES('2020-01-09','2021-04-06','Xavier','Nash',8951,1,0),('2019-10-04','2019-09-21','Clarke','Small',3770,2,0),('2020-03-08','2020-10-02','Erasmus','Gardner',3675,0,1),('2019-08-26','2020-06-15','Baxter','Cole',7824,1,0),('2019-11-09','2019-06-04','Gil','Vaughan',5142,2,0),('2020-04-08','2021-04-12','Bert','Haley',6940,2,1),('2019-11-08','2020-11-24','Nicholas','Hogan',4402,1,1),('2019-07-28','2020-08-12','Ian','Ashley',1911,1,0),('2020-03-30','2020-06-24','Leo','Benton',3085,0,0),('2020-01-19','2021-03-21','Hop','Delgado',1773,2,0);
INSERT INTO Employees([dateOfBirth],[dateOfEmployment],[firstname],[lastname],[password],[employeeType],[gender]) VALUES('2020-03-09','2021-03-26','Elton','Santiago',1580,1,0),('2019-09-08','2020-06-13','Eagan','Graham',6885,0,1),('2020-03-03','2021-03-17','Malachi','Fields',9008,0,0),('2019-09-21','2020-08-19','Cyrus','Goodman',7507,1,1),('2019-10-25','2021-02-27','Jarrod','Ware',4839,0,1),('2020-03-07','2019-11-12','Stone','Black',9895,2,0),('2020-01-31','2021-02-25','Yoshio','Bullock',4900,0,0),('2019-07-23','2021-03-31','Abel','Santiago',8407,0,1),('2020-03-31','2019-06-04','Phillip','Ortega',9957,0,1),('2019-07-22','2021-01-05','Quinn','Rice',7028,1,1);
INSERT INTO Employees([dateOfBirth],[dateOfEmployment],[firstname],[lastname],[password],[employeeType],[gender]) VALUES('2020-05-18','2019-11-16','Barrett','Graves',1590,1,1),('2019-10-29','2020-08-30','Calvin','Douglas',8520,1,0),('2020-01-12','2019-10-25','Declan','Kim',5083,2,0),('2020-01-29','2021-01-14','Patrick','Gray',5346,2,0),('2019-08-16','2020-02-28','Christopher','Riggs',2817,0,1),('2019-10-28','2021-04-18','Wayne','Sims',1606,1,0),('2019-05-24','2020-10-03','Chaney','Guerrero',7084,2,1),('2020-01-10','2020-02-14','August','Mercado',4851,0,0),('2019-07-22','2020-12-18','Giacomo','Wallace',7859,1,1),('2019-11-07','2021-05-22','Chandler','Underwood',4819,0,1);
INSERT INTO Employees([dateOfBirth],[dateOfEmployment],[firstname],[lastname],[password],[employeeType],[gender]) VALUES('2019-06-09','2019-08-08','Merritt','Wilkinson',2709,2,1),('2019-10-10','2019-10-25','Nathan','Nieves',9265,1,1),('2020-01-17','2019-07-28','Christopher','Campbell',4223,1,0),('2020-03-10','2019-07-21','Gareth','Santana',4476,0,1),('2019-05-28','2020-09-14','Akeem','Terrell',6476,2,1),('2020-04-07','2019-06-13','Deacon','Walton',9229,0,1),('2020-04-27','2021-01-29','Hoyt','Avery',7286,2,0),('2019-07-29','2020-09-24','Tanner','Contreras',3373,0,1),('2019-10-21','2020-02-03','Jonas','Burnett',3121,2,1),('2019-06-11','2019-10-22','Kelly','Richmond',8690,2,1);
INSERT INTO Employees([dateOfBirth],[dateOfEmployment],[firstname],[lastname],[password],[employeeType],[gender]) VALUES('2020-04-23','2020-05-11','Laith','Joseph',7339,1,1),('2020-05-24','2019-12-19','Damian','Cobb',5095,2,0),('2019-11-14','2020-06-24','David','Wong',4876,1,1),('2020-04-23','2020-07-11','Justin','Talley',5755,2,0),('2019-06-12','2019-08-21','Cade','Rivera',6904,2,0),('2020-05-21','2020-05-29','Hector','Robbins',4312,2,0),('2020-02-12','2019-10-24','Malik','Conway',7127,0,0),('2019-10-11','2020-03-16','Ira','Nunez',3693,2,1),('2020-03-04','2020-10-03','Laith','Compton',6296,2,0),('2019-11-14','2019-07-14','Eaton','Dawson',7034,2,1);

INSERT INTO Dishes([name],[ingredients],[price],[stock]) VALUES ('Kalfstartaar met tonijnmayonaise en gefrituurde mosselen','Tonijn, mayonaise, mosselen','8.50','10'),('Paté van fazant met Monegaskische uitjes','Fazant, ui, knoflook','8.50','12'),('Provençaalse vissoep met rouille en croutons','Vis, mayonaise, mosselen','8.50','10'),('Krab-zalm koekjes met zoetzure-chilisaus','Zalm, krab, chili','9.00','13');

INSERT INTO Drinks([name],[alcoholic],[price],[stock]) VALUES ('Spa rood',0,'2.50',20),('Spa groen',0,'2.50',22),('Hertog Jan',1,'3.00',25);

INSERT INTO Menus([menuType]) VALUES(0),(1),(2);

INSERT INTO Tables([occupied],[seats]) VALUES (0, 5),(1, 7),(0, 3),(0, 4); 

INSERT INTO Reservations([date],[from],[to],[name],[numberOfPeople],[tableId]) VALUES ('2020-05-24', '18:00:00', '22:00:00', 'Sierhuis', 5, 1),('2020-05-24', '17:00:00', '23:00:00', 'Ooijevaar', 3, 3);
