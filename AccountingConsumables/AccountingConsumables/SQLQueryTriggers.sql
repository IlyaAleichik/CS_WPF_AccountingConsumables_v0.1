

create trigger diffExp
on  Expenses
for insert
as
begin

declare @a int 
declare @b int 
set @a = (select ID_Materials from inserted)
set @b = (select Involved from inserted)
update Materials set CountMaterials = CountMaterials - @b
 where ID_Materials = @a
 end