







--в режиме автофиксации
use AccountingConsumables
INSERT INTO TypeMaterial Values('Золото');
INSERT INTO TypeMaterial Values(NULL);
INSERT INTO TypeMaterial Values('Серебро');
SELECT * From Materials
SELECT * From TypeMaterial


--явные транзакции
USE AccountingConsumables;
go

BEGIN TRANSACTION
 
    UPDATE TypeMaterial
        SET  ID_TypeMaterial  = 4
        WHERE ID_TypeMaterial = 2

    IF (@@error <> 0)
        -- востановление если есть ошибка
        ROLLBACK
    
	 UPDATE Materials
        SET  ID_TypeMaterial  = 4
        WHERE ID_TypeMaterial = 2

    IF (@@error <> 0)
        -- востановление если есть ошибка
        ROLLBACK
    

COMMIT


USE AccountingConsumables;
go
BEGIN TRANSACTION;

	INSERT INTO Materials(NameMaterials,Unit,CountMaterials,ID_TypeMaterial) Values('Шурупы','кг',3,2)
	 
    SAVE TRANSACTION a;

    INSERT INTO Materials(NameMaterials,Unit,CountMaterials,ID_TypeMaterial) Values('Доски','кг',5,2) 
       
    SAVE TRANSACTION b;

    INSERT INTO Materials(NameMaterials,Unit,CountMaterials,ID_TypeMaterial) Values('Столешница','кг',7,2) 
 
    ROLLBACK TRANSACTION b;

    INSERT INTO Materials(NameMaterials,Unit,CountMaterials,ID_TypeMaterial) Values('Ножки','кг',3,1) 
        
    ROLLBACK TRANSACTION a;

COMMIT TRANSACTION;






use AccountingConsumables
SELECT * From Materials
SELECT * From TypeMaterial


use AccountingConsumables
truncate table TypeMaterial

begin tran
INSERT INTO TypeMaterial Values('Золото');
INSERT INTO TypeMaterial Values(NULL);
INSERT INTO TypeMaterial Values('Серебро');
commit tran

SELECT * From TypeMaterial


begin try
begin tran
INSERT INTO TypeMaterial Values('Золото');
INSERT INTO TypeMaterial Values(NULL);
INSERT INTO TypeMaterial Values('Серебро');
commit tran
end try
begin catch
ROLLBACK TRAN
end catch

SELECT * From TypeMaterial



print 'Trancout before transaction' + CAST(@@trancount as char(1))
BEGIN TRAN

print 'After first BEGIN TRAN' + CAST(@@trancount as char(1))
BEGIN TRAN

print 'After second BEGIN TRAN' + CAST(@@trancount as char(1))

COMMIT TRAN

print 'After first CONNIT TRAN' + CAST(@@trancount as char(1))
COMMIT TRAN
print 'After second COMMIT TRAN' + CAST(@@trancount as char(1))



SET IMPLICIT_TRANSACTIONS ON -- вкл неявного режима
SET IMPLICIT_TRANSACTIONS OFF -- откл неявного режима


use AccountingConsumables
SELECT * From TypeMaterial


--неявные транзакции

SET IMPLICIT_TRANSACTIONS ON
GO
INSERT INTO TypeMaterial Values('Серебро');
GO
SELECT @@TRANCOUNT AS [TypeMaterial count]

ROLLBACK TRAN
GO
SELECT @@TRANCOUNT AS [TypeMaterial count]

