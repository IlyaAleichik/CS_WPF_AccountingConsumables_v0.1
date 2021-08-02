-- Заполнение истоии
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




--стоимость всего оборудования 

use AccountingConsumables
go
create trigger diffExp
on  Expenses
after insert
as
update Materials set CountMaterials = CountMaterials - (select Involved from inserted)
 where ID_Materials = (select ID_Materials from inserted)

drop trigger  

insert into Expenses (DateExpensees,Involved, ID_Equipment, ID_Materials,ID_Departament) values ('21.02.2018',3,21,4,3)
select * from ExpensesView

select * from Materials
select * from Expenses
select * from ExpensesView









 --просмотр hystory и Materials
 Select * from Materials
 Select * from Hystory

-- очитска таблицы hystory
use AccountingConsumables
go
DBCC CHECKIDENT ('Hystory',reseed,0)
delete Hystory
SELECT * From Hystory


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
