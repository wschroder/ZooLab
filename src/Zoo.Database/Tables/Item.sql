﻿CREATE TABLE dbo.Item
(
	Id INT NOT NULL IDENTITY(1000, 1),
	EntityId UNIQUEIDENTIFIER NOT NULL,
	RecordedDate UNIQUEIDENTIFIER NOT NULL,
	ItemName NVARCHAR(500) NOT NULL,
	UnitPrice dbo.UnitPriceType NULL,
	OnHand INT NULL,
	CONSTRAINT PK_Item PRIMARY KEY (Id)
)

GO

CREATE UNIQUE NONCLUSTERED INDEX [IX_Item_EntityId] ON [dbo].[Item] ([EntityId])
GO