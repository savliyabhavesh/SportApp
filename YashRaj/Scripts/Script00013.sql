ALTER TABLE PartyMaster ADD BalanceLimit Currency
GO
UPDATE PartyMaster SET BalanceLimit = '0.00'
GO

ALTER TABLE Trans ADD tns_IsAuto Number
GO