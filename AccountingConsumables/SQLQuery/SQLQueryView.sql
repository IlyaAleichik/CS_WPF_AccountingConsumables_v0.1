
	   --оборудование
go
CREATE VIEW EquipmentView AS 
SELECT
       Equipment.ID_Equipment,
	   Equipment.Model as 'Модель',
	   Equipment.CountEquipment as 'Кол-во',
	   Equipment.Life as 'Срок службы',
	   Category.NameCategory as 'Категория'
	   from Equipment inner join Category on Equipment.ID_Category = Category.ID_Category  
	-- drop view EquipmentView



	  -- select * from Equipment
--материалы
go
CREATE VIEW MaterialsView AS 
SELECT Materials.ID_Materials,
	   Materials.NameMaterials as 'Наименование материала',
	   Materials.CountMaterials as 'Кол-во',
	   Materials.DateReceipt as 'Дата прибытия',
	   Materials.Life as 'Срок службы',
	   TypeMaterial.NameTypeMaterial as 'Тип'
	   from Materials inner join TypeMaterial on Materials.ID_TypeMaterial = TypeMaterial.ID_TypeMaterial 	 
--расходы
 --drop view MaterialsView 
 go
 CREATE VIEW ExpensesView
 AS 
SELECT 
       Expenses.ID_Expenses,
	   Expenses.DateExpensees as 'Дата расхода',
	   Expenses.Involved as 'Расход',
	   Equipment.Model as 'Модель',
       Materials.NameMaterials as 'Наименование материала',
	   Materials.CountMaterials as 'Кол-во',
	   Materials.DateReceipt as 'Дата поступления',
	   Departament.NameDep as 'Подразделение'
	   from Expenses inner join Equipment on Expenses.ID_Equipment = Equipment.ID_Equipment 
		    inner join Materials on Expenses.ID_Materials = Materials.ID_Materials 
		 inner join Departament on Expenses.ID_Departament = Departament.ID_Departament 
	   --заказы
	--   drop view ExpensesView
	 --  select * from ExpensesView
	 go
CREATE VIEW OrdersView AS 
SELECT  Orders.ID_Orders,
Materials.NameMaterials as 'Наименование заказа',
Orders.CountOrderMat as 'Кол-во',
Orders.DateOrder as 'Дата заказа',
Providers.NameOrganization as 'Наименование организации',
	   Providers.Phone as 'Телефон',
	   Providers.AddresProviders as 'Адрес'
	   from Orders inner join Providers on Orders.ID_Providers = Providers.ID_Providers 
	   inner join  Materials on Orders.ID_Materials = Materials.ID_Materials
	--    drop view OrdersView 
	   







--оборудование
CREATE VIEW EquipmentViewReport AS 
SELECT Equipment.ID_Equipment,
	   Equipment.Model,
	   Equipment.CountEquipment ,
	   Equipment.Life,
	   Category.NameCategory
	   from Equipment inner join Category on Equipment.ID_Category = Category.ID_Category

	  -- select * from ExpensesView
	  --  select * from ExpensesViewReport

--материалы
CREATE VIEW MaterialsViewReport AS 
SELECT Materials.ID_Materials,
	   Materials.NameMaterials,
	   Materials.CountMaterials,
	   Materials.DateReceipt,
	   Materials.Life ,
	   TypeMaterial.NameTypeMaterial
	   from Materials inner join TypeMaterial on Materials.ID_TypeMaterial = TypeMaterial.ID_TypeMaterial  	 
--расходы
CREATE VIEW ExpensesViewReport AS 
SELECT Expenses.ID_Expenses ,
	   Equipment.Model ,	   
       Materials.NameMaterials,
	   Materials.CountMaterials,
	   Materials.DateReceipt ,
	   Expenses.DateExpensees,
	   Expenses.Involved,
	   Departament.NameDep 
	   from Expenses inner join Equipment on Expenses.ID_Equipment = Equipment.ID_Equipment 
		    inner join Materials on Expenses.ID_Materials = Materials.ID_Materials 
		 inner join Departament on Expenses.ID_Departament = Departament.ID_Departament 
	
	   --заказы
CREATE VIEW OrdersViewReport  AS 
SELECT Orders.ID_Orders,
Materials.NameMaterials,
Materials.CountMaterials,
Orders.DateOrder ,
Providers.NameOrganization ,
	   Providers.Phone ,
	   Providers.AddresProviders 
	   from Orders inner join Providers on Orders.ID_Providers = Providers.ID_Providers 
	   inner join  Materials on Orders.ID_Materials = Materials.ID_Materials





	   






	 --  select * 





	   
	  -- Select * from OrdersView
	
	   --Select * from ExpensesView
	 -	   --  Select * from EquipmentView
	  -- Select * from MaterialsView





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
	  
