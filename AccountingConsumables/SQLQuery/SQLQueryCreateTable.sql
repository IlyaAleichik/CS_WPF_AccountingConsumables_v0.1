create database AccountingConsumables
go

use AccountingConsumables



 create table TypeMaterial(
  ID_TypeMaterial int IDENTITY NOT NULL ,
  NameTypeMaterial varchar(10),
  constraint PK_ID_TypeMaterial primary key(ID_TypeMaterial)
 );


create table Providers(
 ID_Providers int IDENTITY NOT NULL ,
 NameOrganization varchar(20),
 Phone nvarchar(13),
 AddresProviders varchar(20),
 constraint PK_ID_Providers primary key(ID_Providers)
);

create table Materials(
 ID_Materials int IDENTITY NOT NULL ,
 NameMaterials varchar(10),
 CountMaterials int,
 DateReceipt date,
 Life date,
 ID_TypeMaterial int,
 constraint PK_ID_Materials primary key(ID_Materials),
 constraint FK_Material_TypeMaterial foreign key(ID_TypeMaterial) references TypeMaterial(ID_TypeMaterial)
);



create table Orders(
 ID_Orders int IDENTITY NOT NULL,
 DateOrder date,
 CountOrderMat int,
 ID_Materials int,
 ID_Providers int,
 constraint PK_ID_Orders primary key(ID_Orders),
 constraint FK_Orders_Materials foreign key (ID_Materials) references Materials(ID_Materials),
 constraint FK_Orders_Providers foreign key (ID_Providers) references Providers(ID_Providers)
 );

 create table Departament(
 ID_Departament INT IDENTITY NOT NULL,
 NameDep varchar(20),
 constraint PK_ID_Departament primary key(ID_Departament)
 );



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
 ID_Category int,
 constraint PK_ID_Equipment primary key(ID_Equipment),
 constraint FK_Equipment_Category foreign key(ID_Category) references Category (ID_Category)
 );



create table Expenses(
 ID_Expenses int IDENTITY NOT NULL,
 DateExpensees date,
 Involved int,
 ID_Equipment int NOT NULL,
 ID_Materials int NOT NULL,
 ID_Departament int NOT NULL, 
 constraint PK_ID_Expenses primary key(ID_Expenses),
 constraint FK_Expenses_Equipment foreign key (ID_Equipment) references Equipment(ID_Equipment),
 constraint FK_Expenses_Materials foreign key (ID_Materials) references Materials(ID_Materials),
 constraint FK_Expenses_Departament foreign key (ID_Departament) references Departament(ID_Departament)
);








-- update Expenses set DateExpensees = 'greg',Involved='',ID_Equipment='',ID_Materials='',ID_Departament='' where ID_Expenses = ''
--update Providers set NameOrganization = 'arbb', Phone = '+31648489',AddresProviders = 'Rffd' where ID_Providers = '1'
--update Materials set NameMaterials = 'greg',CountMaterials='3',DateReceipt='31.12.2018',Life='20.12.2018',ID_TypeMaterial='' where ID_Materials = ''
-- update Equipment set Model = 'greg',CountEquipment='',Life='',ID_Category=''  where ID_Equipment = '' --update Category set NameCategory = 'greg'  where ID_Category = ''
-- update Departament set NameDep = 'greg'  where ID_Departament = ''
--update Orders set DateOrder = 'greg',CountOrderMat='3',ID_Materials='31.12.2018',ID_Providers='20.12.2018'  where ID_Orders = ''
--update TypeMaterial set NameTypeMaterial = 'Пластик' where ID_TypeMaterial = 6

--insert into Expenses(DateExpensees,Involved,ID_Equipment,ID_Materials,ID_Departament) values('12.12.2018','12','1','4','2')
--select * from Expenses




 













