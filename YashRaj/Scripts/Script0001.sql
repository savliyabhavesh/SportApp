ALTER TABLE Settings ADD s_Api_Url Text
GO
UPDATE Settings SET s_Api_Url = 'http://65.1.135.123:4881/api'
GO