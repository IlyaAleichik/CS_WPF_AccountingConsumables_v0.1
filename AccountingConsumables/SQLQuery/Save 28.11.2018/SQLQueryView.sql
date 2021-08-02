use AccountingConsumables
go

CREATE VIEW MaterialsTypeMaterials AS 
SELECT Materials.NameMaterials as Название,
      Materials.Unit as 'ед.изм',
	  Materials.CountMaterials as 'кол-во',
	  TypeMaterial.NameTypeMaterial as Тип
	  from Materials inner join TypeMaterial on Materials.ID_TypeMaterial = TypeMaterial.ID_TypeMaterial



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
	  
