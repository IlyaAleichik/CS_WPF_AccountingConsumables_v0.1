	   --оборудование

CREATE VIEW EquipmentView AS 
SELECT
	   Equipment.Model as 'Модель',
	   Equipment.CountEquipment as 'Кол-во',
	   Equipment.Life as 'Срок службы',
	   Category.NameCategory as 'Категория'
	   from Equipment inner join Category on Equipment.ID_Category = Category.ID_Category  
	-- drop view EquipmentView


	  -- select * from Equipment
--материалы

CREATE VIEW MaterialsView AS 
SELECT 
	   Materials.NameMaterials as 'Наименование материала',
	   Materials.CountMaterials as 'Кол-во',
	   Materials.DateReceipt as 'Дата прибытия',
	   Materials.Life as 'Срок службы',
	   TypeMaterial.NameTypeMaterial as 'Тип'
	   from Materials inner join TypeMaterial on Materials.ID_TypeMaterial = TypeMaterial.ID_TypeMaterial 	 
--расходы
 --drop view MaterialsView 
 CREATE VIEW ExpensesView
 AS 
SELECT 
      
	   Equipment.Model as 'Модель',
       Materials.NameMaterials as 'Наименование материала',
	   Materials.CountMaterials as 'Кол-во',
	   Materials.DateReceipt as 'Дата поступления',
	   Expenses.DateExpensees as 'Дата расхода',
	   Expenses.Involved as 'Расход/кол-во',
	   Departament.NameDep as 'Подразделение'
	   from Expenses inner join Equipment on Expenses.ID_Equipment = Equipment.ID_Equipment 
		    inner join Materials on Expenses.ID_Materials = Materials.ID_Materials 
		 inner join Departament on Expenses.ID_Departament = Departament.ID_Departament 
	   --заказы
	--   drop view ExpensesView
	 --  select * from ExpensesView

CREATE VIEW OrdersView AS 

SELECT 
Materials.NameMaterials as 'Наименование заказа',
Materials.CountMaterials as 'Кол-во',
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





	   

