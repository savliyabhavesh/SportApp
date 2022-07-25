Create Table BadlaTrn 
(
id int identity(1,1) PRIMARY KEY,
m_id number,
s_id number,
run number,
amt Currency,
type varchar,
party varchar,
trn_id number,
dt datetime,
[time] datetime
)
GO