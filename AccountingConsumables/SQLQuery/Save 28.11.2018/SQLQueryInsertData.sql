
use AccountingConsumables
go

INSERT INTO TypeMaterial(NameTypeMaterial) Values('Метал'),('Дерево'),('Керамика')
INSERT INTO Materials(NameMaterials,Unit,CountMaterials,ID_TypeMaterial) Values('Седушка','кг',3,1) 

use AccountingConsumables
SELECT * From Materials
SELECT * From TypeMaterial









--удаление
use AccountingConsumables
drop table Materials
drop table TypeMaterial


use master
go
drop database AccountingConsumables

use AccountingConsumables
go
DBCC CHECKIDENT ('Materials',reseed,0)
delete Materials
SELECT * From Materials

DBCC CHECKIDENT ('TypeMaterial',reseed,0)
delete from TypeMaterial

SELECT * From TypeMaterial
 

 delete TypeMaterial where ID_TypeMaterial = 6
 delete from Materials where ID_Materials = 2

 


