use AccountingConsumables
go

--материалы
CREATE VIEW MaterialsTypeMaterials AS 
SELECT Materials.NameMaterials as Название,
	   Materials.CountMaterials as 'Кол-во',
	   Materials.Price as 'Цена',
	   Materials.DateReceipt as 'Дата прибытия',
	   Materials.Life as 'Срок службы',
	   Materials.Summ as 'Сумма',
	   TypeMaterial.NameTypeMaterial as 'Тип'
	   from Materials inner join TypeMaterial on Materials.ID_TypeMaterial = TypeMaterial.ID_TypeMaterial

	   Select * from MaterialsTypeMaterials

	   --оборудование
CREATE VIEW EquipmentCategory AS 
SELECT Equipment.Model as 'Модель/Наименование',
       Category.NameCategory as 'Категория',
	   Equipment.CountEquipment as 'Кол-во',
	   Equipment.Life as 'Срок службы',
	   Equipment.Price as 'Цена',
	   Equipment.Summ as 'Сумма'
	   from Equipment inner join Category on Equipment.ID_Category = Category.ID_Category

	   Select * from EquipmentCategory
	   drop view EquipmentCategory

	   --заказы
CREATE VIEW ProvidersOrders AS 
SELECT Orders.ID_Orders as '№',
Materials.NameMaterials as 'Наименование заказа',
Materials.CountMaterials as 'Кол-во',
Materials.Price as 'Цена',
Materials.Life as 'Срок службы',
Orders.DateOrder as 'Дата заказа',
Providers.NameOrganization as 'Наименование организации',
	   Providers.Phone as 'Телефон',
	   Providers.AddresProviders as 'Адресс'
	   from Orders inner join Providers on Orders.ID_Providers = Providers.ID_Providers 
	   inner join  Materials on Orders.ID_Materials = Materials.ID_Materials
	   Select * from ProvidersOrders
	   drop view ProvidersOrders



	 

 CREATE VIEW ExpensesMaterial 
 AS 
SELECT Materials.NameMaterials as 'Наименование материала',
	   Materials.CountMaterials as 'Кол-во',
	   Materials.Price as 'Цена',
	   Expenses.Involved as 'Задействовано',
	   Expenses.Residue as 'Расход',
	   Expenses.Summ as 'Сумма'
	   from Expenses inner join Materials on Expenses.ID_Materials = Materials.ID_Materials 
	 
	 	

	  



use AccountingConsumables
go
create trigger ExpensesMaterial_Residue_Summ
on ExpensesMaterial 
instead of insert
as
update ExpensesMaterial
SET Остаток = [Кол-во] - Расход
where [Наименование материала] = (SELECT [Наименование материала] from inserted)

drop trigger ExpensesMaterial_Residue_Summ


	    --остаток
		 CREATE VIEW InvolvedView AS 
SELECT Materials.NameMaterials as 'Наименование материала',
	   Expenses.Involved as 'Кол-во',
	   Materials.Price as 'Цена',
	   Expenses.Summ as 'Сумма'
	   from Expenses inner join Materials on Expenses.ID_Materials = Materials.ID_Materials 
	 
	 
	 Select * from InvolvedView









	   CREATE VIEW ProvidersOrders AS 
SELECT Orders.ID_Orders as '№',
Orders.DateOrder as 'Дата заказа',
Providers.NameOrganization as 'Наименование организации',
	   Providers.Phone as 'Телефон',
	   Providers.AddresProviders as 'Адресс'
	   from Orders inner join Providers on Orders.ID_Providers = Providers.ID_Providers

	   Select * from ProvidersOrders

















CREATE VIEW MatTypeView
AS SELECT NameMaterials,CountMaterials
FROM Materials, TypeMaterial
WHERE Materials.ID_TypeMaterial = TypeMaterial.ID_TypeMaterial
GROUP BY  CountMaterials,NameMaterials


CREATE VIEW MaterialsView AS SELECT  NameMaterials  AS Название, CountMaterials,ID_TypeMaterial
FROM Materials 







INSERT INTO MaterialsView(Название,CountMaterials,ID_TypeMaterial)
VALUES('Доска',4, 2),('Столешница',4, 2),('Ношка',4, 2)

INSERT INTO MaterialsTypeMaterials(Название,[ед.изм],[кол-во])
	  VALUES('Фанера',3, 2)



UPDATE MaterialsTypeMaterials SET [кол-во] = 7
	  	  select * from MaterialsTypeMaterials
UPDATE MaterialsView SET Название = 'Гайка'



Delete from  MaterialsTypeMaterials where Название = 'Гайка'
		  select * from MaterialsTypeMaterials
Delete from  MaterialsView where Название = 'Фанера' 


Drop view MaterialsView
Drop view MatTypeView
Drop view MaterialsTypeMaterials

select * from MaterialsView
select * from MaterialsTypeMaterials

select * from Materials
select * from TypeMaterial
	  
