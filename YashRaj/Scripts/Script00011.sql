ALTER TABLE Settings ADD NTPosition varchar(10)
GO
UPDATE Settings SET NTPosition = 'BOTTOM'
GO
ALTER TABLE Settings ADD ClientReport varchar(10)
GO
UPDATE Settings SET ClientReport = 'TWO'
GO