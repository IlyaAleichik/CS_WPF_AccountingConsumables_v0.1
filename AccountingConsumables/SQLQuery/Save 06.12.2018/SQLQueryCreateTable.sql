create database AccountingConsumables
go


use AccountingConsumables

create table Category(
 ID_Category int IDENTITY NOT NULL ,
 NameCategory varchar(20),
 constraint PK_ID_Category primary key(ID_Category)
);

create table Equipment(
 ID_Equipment int IDENTITY NOT NULL ,
 Model varchar(20),
 CountEquipment int,
 Life date,
 Price int,
 Summ int,
 ID_Category int,
 constraint PK_ID_Equipment primary key(ID_Equipment),
 constraint FK_Equipment_Category foreign key(ID_Category) references Category (ID_Category)
 );

 create table TypeMaterial(
  ID_TypeMaterial int IDENTITY NOT NULL ,
  NameTypeMaterial varchar(10),
  constraint PK_ID_TypeMaterial primary key(ID_TypeMaterial)
 );

create table Materials(
 ID_Materials int IDENTITY NOT NULL ,
 NameMaterials varchar(10),
 CountMaterials int,
 Price int,
 DateReceipt date,
 Life date,
 Summ int,
 ID_TypeMaterial int,
 constraint PK_ID_Materials primary key(ID_Materials),
 constraint FK_Material_TypeMaterial foreign key(ID_TypeMaterial) references TypeMaterial(ID_TypeMaterial)
);

create table Expenses(
 ID_Expenses int IDENTITY NOT NULL ,
 Involved int,
 Residue int,
 Summ int,
 ID_Equipment int NOT NULL,
 ID_Materials int NOT NULL,
 constraint PK_ID_Expenses primary key(ID_Expenses),
 constraint FK_Expenses_Equipment foreign key (ID_Equipment) references Equipment(ID_Equipment),
 constraint FK_Expenses_Materials foreign key (ID_Materials) references Materials(ID_Materials)
);

create table Providers(
 ID_Providers int IDENTITY NOT NULL ,
 NameOrganization varchar(20),
 Phone nvarchar(15),
 AddresProviders varchar(20),
 constraint PK_ID_Providers primary key(ID_Providers)
);

create table Orders(
 ID_Orders int IDENTITY NOT NULL,
 DateOrder date,
 ID_Materials int,
 ID_Providers int,
 constraint PK_ID_Orders primary key(ID_Orders),
 constraint FK_Orders_Materials foreign key (ID_Materials) references Materials(ID_Materials),
 constraint FK_Orders_Providers foreign key (ID_Providers) references Providers(ID_Providers)
 );

 create table Hystory(
 ID INT IDENTITY,
 Materials INT NOT NULL,
 Operation NVARCHAR(200) NOT NULL,
 CreateAt DATETIME NOT NULL DEFAULT GETDATE(),

 );


 













