ALTER TABLE Settings ADD s_Entry_Order text
GO

UPDATE Settings SET s_Entry_Order = 'FIRST AMOUNT'
GO
