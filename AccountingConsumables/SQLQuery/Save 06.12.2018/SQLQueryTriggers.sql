
use AccountingConsumables
 go
 create trigger Hystory_Materials on Materials 
 after insert
 as
 insert into Hystory(Materials,Operation)
select ID_Materials,'Добавлен материал' +  NameMaterials  from inserted



 use AccountingConsumables
 go
 create trigger Hystory_Materials_Update on Materials 
 after update
 as
 insert into Hystory(Materials,Operation)
select ID_Materials,'Обновлен материал ' +  NameMaterials  from inserted



 use AccountingConsumables
 go
 create trigger Hystory_Materials_delete on Materials 
 after delete
 as
 insert into Hystory(Materials,Operation)
select ID_Materials,'Удален материал ' +  NameMaterials  from deleted

-- SummEquipment
use AccountingConsumables
go
create trigger Equipment_sum
on Equipment
After insert,update
as
update Equipment
SET Summ = CountEquipment * Price
where ID_Equipment = (SELECT ID_Equipment from inserted)


-- SummMat
use AccountingConsumables
go
create trigger Materials_summ
on Materials
After insert,update
as
update Materials
SET Summ = CountMaterials * Price
where ID_Materials = (SELECT ID_Materials from inserted)

-- SummExp
use AccountingConsumables
go
create trigger Materials_summ
on Materials
After insert,update
as
update Materials
SET Summ = CountMaterials * Price
where ID_Materials = (SELECT ID_Materials from inserted)





 --просмотр hystory и Materials
 Select * from Materials
 Select * from Hystory

-- очитска таблицы hystory
use AccountingConsumables
go
DBCC CHECKIDENT ('Hystory',reseed,0)
delete Hystory
SELECT * From Hystory

-- проверка уровня вложености 
Select TRIGGER_NESTLEVEL( OBJECT_ID('Hystory_Materials_delete') , 'AFTER' , 'DML') 


-- обновление 
use AccountingConsumables
UPDATE Materials SET NameMaterials = 'Столешница'  where ID_Materials= '9'
SELECT * From Materials
SELECT * From Hystory

--добовление
use AccountingConsumables
INSERT INTO Materials(NameMaterials,Unit,CountMaterials,ID_TypeMaterial) Values('Столешница','кг',5,2)
SELECT * From Materials
SELECT * From Hystory

--удаление
use AccountingConsumables
delete from Materials where CountMaterials = 5
SELECT * From Materials
SELECT * From Hystory

--удаление тригеров
drop trigger Hystory_Materials_Update
drop trigger HystoryMaxCount

--отключение триг
DISABLE  TRIGGER Materials_Ins_Upd ON Materials

ENABLE  TRIGGER Materials_Ins_Upd ON Materials
