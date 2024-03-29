﻿SET NOCOUNT ON;

USE [MsSqlDbExTest];
GO

ALTER DATABASE [MsSqlDbExTest] SET RECOVERY SIMPLE;

DECLARE @SQL as varchar(4000)
DECLARE @SchemaName as varchar(500)
DECLARE @SchemaIndex as int
SET @SchemaIndex = 1

IF OBJECT_ID('tempdb..#Schemas') IS NOT NULL DROP TABLE #Schemas
CREATE TABLE #Schemas([Id] INT, [Name] VARCHAR(20));
INSERT INTO #Schemas([Id], [Name]) values (1, 'dbo');
INSERT INTO #Schemas([Id], [Name]) values (2, 'sec');
INSERT INTO #Schemas([Id], [Name]) values (3, 'unit_test');

IF OBJECT_ID('tempdb..#DropObjects') IS NOT NULL DROP TABLE #DropObjects
CREATE TABLE #DropObjects
(
	[Id] INT IDENTITY(1,1),
	[SQLstatement] VARCHAR(1000)
 )
 
 WHILE (SELECT [Id] FROM #Schemas WHERE [Id] = @SchemaIndex) IS NOT NULL
 BEGIN
	SELECT @SchemaName = [Name] FROM #Schemas WHERE [Id] = @SchemaIndex;

	-- removes all the foreign keys that reference a PK in the target schema
	 SELECT @SQL =
	 'select
		  '' ALTER TABLE ''+SCHEMA_NAME(fk.schema_id)+''.''+OBJECT_NAME(fk.parent_object_id)+'' DROP CONSTRAINT ''+ fk.name
	 FROM sys.foreign_keys fk
	 join sys.tables t on t.object_id = fk.referenced_object_id
	 where t.schema_id = schema_id(''' + @SchemaName+''')
		and fk.schema_id <> t.schema_id
	 order by fk.name desc'
 
	 INSERT INTO #DropObjects
	 EXEC (@SQL)
 
	 -- drop all default constraints, check constraints and Foreign Keys
	 SELECT @SQL =
	 'SELECT
		  '' ALTER TABLE ''+schema_name(t.schema_id)+''.''+OBJECT_NAME(fk.parent_object_id)+'' DROP CONSTRAINT ''+ fk.[Name]
	 FROM sys.objects fk
	 join sys.tables t on t.object_id = fk.parent_object_id
	 where t.schema_id = schema_id(''' + @SchemaName+''')
	  and fk.type IN (''D'', ''C'', ''F'')'
 
	 INSERT INTO #DropObjects
	 EXEC (@SQL)
 
	 -- drop all other objects in order  
	 SELECT @SQL = 
	 'SELECT
		 CASE WHEN SO.type=''PK'' THEN '' ALTER TABLE [''+SCHEMA_NAME(SO.schema_id)+''].[''+OBJECT_NAME(SO.parent_object_id)+''] DROP CONSTRAINT ''+ SO.name
			  WHEN SO.type=''U'' THEN '' DROP TABLE [''+SCHEMA_NAME(SO.schema_id)+''].[''+ SO.[Name] + '']''
			  WHEN SO.type=''V'' THEN '' DROP VIEW [''+SCHEMA_NAME(SO.schema_id)+''].[''+ SO.[Name] + '']''
			  WHEN SO.type=''P'' THEN '' DROP PROCEDURE [''+SCHEMA_NAME(SO.schema_id)+''].[''+ SO.[Name] + '']''     
			  WHEN SO.type=''TR'' THEN '' DROP TRIGGER [''+SCHEMA_NAME(SO.schema_id)+''].[''+ SO.[Name] + '']''
			  WHEN SO.type IN (''FN'', ''TF'',''IF'',''FS'',''FT'') THEN '' DROP FUNCTION [''+SCHEMA_NAME(SO.schema_id)+''].[''+ SO.[Name] + '']''
		  END
	FROM SYS.OBJECTS SO
	WHERE SO.schema_id = schema_id('''+ @SchemaName +''')
	 AND SO.type IN (''PK'', ''FN'', ''TF'', ''TR'', ''V'', ''U'', ''P'')
	ORDER BY CASE WHEN type = ''PK'' THEN 1
				 WHEN type in (''FN'', ''TF'', ''P'',''IF'',''FS'',''FT'') THEN 2
				 WHEN type = ''TR'' THEN 3
				 WHEN type = ''V'' THEN 4
				 WHEN type = ''U'' THEN 5
				ELSE 6
			 END'
 
	INSERT INTO #DropObjects
	EXEC (@SQL)

	IF @SchemaName != 'dbo'
		INSERT INTO #DropObjects SELECT 'DROP SCHEMA [' + @SchemaName + ']';

	SET @SchemaIndex = @SchemaIndex + 1
END

DECLARE @ID int, @statement varchar(1000)
DECLARE statement_cursor CURSOR
FOR SELECT SQLStatement
   FROM #DropObjects
 ORDER BY ID ASC
  
 OPEN statement_cursor
 FETCH statement_cursor INTO @statement
 WHILE (@@FETCH_STATUS = 0)
 BEGIN
 
	PRINT (@statement)
  EXEC(@statement)
 
 
FETCH statement_cursor INTO @statement  
END
 
CLOSE statement_cursor
DEALLOCATE statement_cursor

DROP TABLE #Schemas
DROP TABLE #DropObjects
---------------------------------START THE BUILD ---------------------------------------------------------
USE [MsSqlDbExTest]
GO

CREATE TABLE [dbo].[Address](
	[Id] INT IDENTITY(1,1) NOT NULL,
	[AddressType] INT NULL,
	[Line1] VARCHAR(50) NOT NULL,
	[Line2] VARCHAR(50) NULL,
	[City] VARCHAR(60) NOT NULL,
	[State] CHAR(2) NOT NULL,
	[Zip] VARCHAR(10) NOT NULL,
	[DateCreated] DATETIME NOT NULL CONSTRAINT [DF_Address_DateCreated] DEFAULT (getdate()),
	[DateUpdated] DATETIME NOT NULL CONSTRAINT [DF_Address_DateUpdated] DEFAULT (getdate()),
	CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED ([Id])
)
GO

CREATE TRIGGER [dbo].[TR_Address_DateUpdated]
	ON [dbo].[Address]
	AFTER UPDATE 
	AS 
	IF NOT UPDATE([DateUpdated])
		UPDATE [dbo].[Address] 
		SET [DateUpdated] = GETDATE()
		FROM inserted i
		INNER JOIN [dbo].[Address] a ON a.Id = i.Id
GO

CREATE TABLE [dbo].[Person](
	[Id] INT IDENTITY(1,1) NOT NULL,
	[FirstName] VARCHAR(20) NOT NULL,
	[LastName] VARCHAR(20) NOT NULL,
	[BirthDate] DATE NULL,
	[GenderType] INT NOT NULL,
	[CreditLimit] INT NULL,
	[YearOfLastCreditLimitReview] INT NULL,
	[RegistrationDate] DATETIMEOFFSET NOT NULL CONSTRAINT [DF_Person_RegistrationDate] DEFAULT (sysdatetimeoffset()),
	[LastLoginDate] DATETIMEOFFSET NULL,
	[DateCreated] DATETIME NOT NULL CONSTRAINT [DF_Person_DateCreated] DEFAULT (getdate()),
	[DateUpdated] DATETIME NOT NULL CONSTRAINT [DF_Person_DateUpdated] DEFAULT (getdate()),
	CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([Id]) 
)
GO

CREATE TRIGGER [dbo].[TR_Person_DateUpdated]
	ON [dbo].[Person]
	AFTER UPDATE 
	AS 
	IF NOT UPDATE([DateUpdated])
		UPDATE [dbo].[Person] 
		SET [DateUpdated] = GETDATE()
		FROM inserted i
		INNER JOIN [dbo].[Person] a ON a.Id = i.Id
GO

CREATE TABLE [dbo].[Person_Address](
	[Id] INT IDENTITY(1,1) NOT NULL,
	[PersonId] INT NOT NULL,
	[AddressId] INT NOT NULL,
	[DateCreated] DATETIME NOT NULL CONSTRAINT [DF_Person_Address_DateCreated] DEFAULT (getdate()),
	CONSTRAINT [PK_Person_Address] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_Person_Address_Address] FOREIGN KEY([AddressId]) REFERENCES [dbo].[Address] ([Id]),
	CONSTRAINT [FK_Person_Address_Person] FOREIGN KEY([PersonId]) REFERENCES [dbo].[Person] ([Id])
)
GO

CREATE TABLE [dbo].[Product](
	[Id] INT IDENTITY(1,1) NOT NULL,
	[ProductCategoryType] INT NULL,
	[Name] VARCHAR(80) NOT NULL,
	[Description] NVARCHAR(2000) NULL,
	[ListPrice] MONEY NOT NULL,
	[Price] MONEY NOT NULL,
	[Quantity] INT NOT NULL,
	[Image] VARBINARY(MAX) NULL,
	[Height] DECIMAL(4, 1) NULL,
	[Width] DECIMAL(4, 1) NULL,
	[Depth] DECIMAL(4, 1) NULL,
	[Weight] DECIMAL(4, 1) NULL,
	[ShippingWeight] DECIMAL(4, 1) NOT NULL,
	[ValidStartTimeOfDayForPurchase] TIME NULL,
	[ValidEndTimeOfDayForPurchase] TIME NULL,
	[DateCreated] DATETIME NOT NULL CONSTRAINT [DF_Product_DateCreated] DEFAULT (getdate()),
	[DateUpdated] DATETIME NOT NULL CONSTRAINT [DF_Product_DateUpdated] DEFAULT (getdate()),
	CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([Id]) 
)
GO

CREATE TRIGGER [dbo].[TR_Product_DateUpdated]
	ON [dbo].[Product]
	AFTER UPDATE 
	AS 
	IF NOT UPDATE([DateUpdated])
		UPDATE [dbo].[Product] 
		SET [DateUpdated] = GETDATE()
		FROM inserted i
		INNER JOIN [dbo].[Product] a ON a.Id = i.Id
GO

CREATE TABLE [dbo].[Purchase](
	[Id] INT IDENTITY(1,1) NOT NULL,
	[PersonId] INT NOT NULL,
	[OrderNumber] VARCHAR(20) NOT NULL,
	[TotalPurchaseQuantity] INT NOT NULL,
	[TotalPurchaseAmount] MONEY NOT NULL,
	[PurchaseDate] DATETIME NOT NULL,
	[ShipDate] DATETIME NULL,
	[ExpectedDeliveryDate] DATETIME NULL,
	[TrackingIdentifier] UNIQUEIDENTIFIER NULL,
	[PaymentMethodType] VARCHAR(20) NOT NULL,
	[PaymentSourceType] VARCHAR(20) NULL,
	[DateCreated] DATETIME NOT NULL CONSTRAINT [DF_Purchase_DateCreated] DEFAULT (getdate()),
	[DateUpdated] DATETIME NOT NULL CONSTRAINT [DF_Purchase_DateUpdated] DEFAULT (getdate()),
	CONSTRAINT [PK_Purchase] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_Purchase_Person] FOREIGN KEY([PersonId]) REFERENCES [dbo].[Person] ([Id])
)
GO

CREATE TRIGGER [dbo].[TR_Purchase_DateUpdated]
	ON [dbo].[Purchase]
	AFTER UPDATE 
	AS 
	IF NOT UPDATE([DateUpdated])
		UPDATE [dbo].[Purchase] 
		SET [DateUpdated] = GETDATE()
		FROM inserted i
		INNER JOIN [dbo].[Purchase] a ON a.Id = i.Id
GO

CREATE TABLE [dbo].[PurchaseLine](
	[Id] INT IDENTITY(1,1) NOT NULL,
	[PurchaseId] INT NOT NULL,
	[ProductId] INT NOT NULL,
	[PurchasePrice] DECIMAL(12, 2) NOT NULL,
	[Quantity] INT NOT NULL,
	[DateCreated] DATETIME NOT NULL CONSTRAINT [DF_PurchaseLine_DateCreated] DEFAULT (getdate()),
	[DateUpdated] DATETIME NOT NULL CONSTRAINT [DF_PurchaseLine_DateUpdated] DEFAULT (getdate()),
	CONSTRAINT [PK_PurchaseLine] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_PurchaseLine_Purchase] FOREIGN KEY([PurchaseId]) REFERENCES [dbo].[Purchase] ([Id]),
	CONSTRAINT [FK_PurchaseLine_Product] FOREIGN KEY([ProductId]) REFERENCES [dbo].[Product] ([Id])
)
GO

CREATE TRIGGER [dbo].[TR_PurchaseLine_DateUpdated]
	ON [dbo].[PurchaseLine]
	AFTER UPDATE 
	AS 
	IF NOT UPDATE([DateUpdated])
		UPDATE [dbo].[PurchaseLine] 
		SET [DateUpdated] = GETDATE()
		FROM inserted i
		INNER JOIN [dbo].[PurchaseLine] a ON a.Id = i.Id
GO

CREATE TABLE [dbo].[AccessAuditLog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PersonId] INT NOT NULL,
	[AccessResult] INT NOT NULL,
	[DateCreated] DATETIME NOT NULL CONSTRAINT [DF_AccessAuditLog_DateCreated] DEFAULT (getdate()),
	CONSTRAINT [PK_AccessAuditLog] PRIMARY KEY CLUSTERED ([Id])
)
GO

CREATE SCHEMA [unit_test]
GO

CREATE TABLE [unit_test].[ExpressionElementType](
	[Id] INT NOT NULL,
	[Boolean] BIT NOT NULL,
	[NullableBoolean] BIT NULL,
	[Byte] TINYINT NOT NULL,
	[NullableByte] TINYINT NULL,
	[ByteArray] VARBINARY(MAX) NOT NULL,
	[NullableByteArray] VARBINARY(MAX) NULL,
	[DateTime] DATETIME2 NOT NULL,
	[NullableDateTime] DATETIME2 NULL,
	[DateTimeOffset] DATETIMEOFFSET NOT NULL,
	[NullableDateTimeOffset] DATETIMEOFFSET NULL,
	[Decimal] DECIMAL(5, 4) NOT NULL,
	[NullableDecimal] DECIMAL(5, 4) NULL,
	[Double] MONEY NOT NULL,
	[NullableDouble] MONEY NULL,
	[Guid] UNIQUEIDENTIFIER NOT NULL,
	[NullableGuid] UNIQUEIDENTIFIER NULL,
	[Int16] SMALLINT NOT NULL,
	[NullableInt16] SMALLINT NULL,
	[Int32] INT NOT NULL,
	[NullableInt32] INT NULL,
	[Int64] BIGINT NOT NULL,
	[NullableInt64] BIGINT NULL,
	[Single] REAL NOT NULL,
	[NullableSingle] REAL NULL,	
	[String] VARCHAR(20) NOT NULL,
	[NullableString] VARCHAR(20) NULL,	
	[TimeSpan] TIME NOT NULL,
	[NullableTimeSpan] TIME NULL
)
GO

CREATE TABLE [unit_test].[identifier] (
	[_identifier] VARCHAR(20) NULL,
	[__identifier] VARCHAR(20) NULL,
	[name] VARCHAR(20) NULL,
	[_name] VARCHAR(20) NULL,
	[__name] VARCHAR(20) NULL,
	[schema] VARCHAR(20) NULL,
	[_schema] VARCHAR(20) NULL,
	[__schema] VARCHAR(20) NULL,
	[alias] VARCHAR(20) NULL,
	[_alias] VARCHAR(20) NULL,
	[__alias] VARCHAR(20) NULL,
	[entity] VARCHAR(20) NULL,
	[_entity] VARCHAR(20) NULL,
	[__entity] VARCHAR(20) NULL
)
GO

CREATE TABLE [unit_test].[entity] (
	[identifier] VARCHAR(20) NULL,
	[_identifier] VARCHAR(20) NULL,
	[__identifier] VARCHAR(20) NULL,
	[name] VARCHAR(20) NULL,
	[_name] VARCHAR(20) NULL,
	[__name] VARCHAR(20) NULL,
	[schema] VARCHAR(20) NULL,
	[_schema] VARCHAR(20) NULL,
	[__schema] VARCHAR(20) NULL,
	[alias] VARCHAR(20) NULL,
	[_alias] VARCHAR(20) NULL,
	[__alias] VARCHAR(20) NULL,
	[_entity] VARCHAR(20) NULL,
	[__entity] VARCHAR(20) NULL
)
GO

CREATE TABLE [unit_test].[name] (
	[identifier] VARCHAR(20) NULL,
	[_identifier] VARCHAR(20) NULL,
	[__identifier] VARCHAR(20) NULL,
	[_name] VARCHAR(20) NULL,
	[__name] VARCHAR(20) NULL,
	[schema] VARCHAR(20) NULL,
	[_schema] VARCHAR(20) NULL,
	[__schema] VARCHAR(20) NULL,
	[alias] VARCHAR(20) NULL,
	[_alias] VARCHAR(20) NULL,
	[__alias] VARCHAR(20) NULL,
	[entity] VARCHAR(20) NULL,
	[_entity] VARCHAR(20) NULL,
	[__entity] VARCHAR(20) NULL
)
GO

CREATE TABLE [unit_test].[schema] (
	[identifier] VARCHAR(20) NULL,
	[_identifier] VARCHAR(20) NULL,
	[__identifier] VARCHAR(20) NULL,
	[name] VARCHAR(20) NULL,
	[_name] VARCHAR(20) NULL,
	[__name] VARCHAR(20) NULL,
	[_schema] VARCHAR(20) NULL,
	[__schema] VARCHAR(20) NULL,
	[alias] VARCHAR(20) NULL,
	[_alias] VARCHAR(20) NULL,
	[__alias] VARCHAR(20) NULL,
	[entity] VARCHAR(20) NULL,
	[_entity] VARCHAR(20) NULL,
	[__entity] VARCHAR(20) NULL
)
GO

CREATE TABLE [unit_test].[alias] (
	[identifier] VARCHAR(20) NULL,
	[_identifier] VARCHAR(20) NULL,
	[__identifier] VARCHAR(20) NULL,
	[name] VARCHAR(20) NULL,
	[_name] VARCHAR(20) NULL,
	[__name] VARCHAR(20) NULL,
	[schema] VARCHAR(20) NULL,
	[_schema] VARCHAR(20) NULL,
	[__schema] VARCHAR(20) NULL,
	[_alias] VARCHAR(20) NULL,
	[__alias] VARCHAR(20) NULL,
	[entity] VARCHAR(20) NULL,
	[_entity] VARCHAR(20) NULL,
	[__entity] VARCHAR(20) NULL
)
GO

CREATE SCHEMA [sec]
GO

CREATE TABLE [sec].[Person](
	[Id] INT NOT NULL,
	[SSN] CHAR(11) NOT NULL,
	[DateCreated] DATETIME NOT NULL CONSTRAINT [DF_Person_DateCreated] DEFAULT (getdate()),
	[DateUpdated] DATETIME NOT NULL CONSTRAINT [DF_Person_DateUpdated] DEFAULT (getdate()),
	CONSTRAINT [PK_secPerson] PRIMARY KEY CLUSTERED ([Id])
)
GO

CREATE TRIGGER [sec].[TR_Person_DateUpdated]
	ON [sec].[Person]
	AFTER UPDATE 
	AS 
	IF NOT UPDATE([DateUpdated])
		UPDATE [sec].[Person] 
		SET [DateUpdated] = GETDATE()
		FROM inserted i
		INNER JOIN [sec].[Person] a ON a.Id = i.Id
GO

CREATE VIEW [dbo].[PersonTotalPurchasesView]
AS
SELECT    
	[dbo].[Person].[Id], 
	SUM([dbo].[Purchase].[TotalPurchaseAmount]) AS [TotalAmount],
	COUNT([dbo].[Purchase].[Id]) AS [TotalCount]
FROM      
	[dbo].[Person] 
	INNER JOIN [dbo].[Purchase] ON [dbo].[Purchase].[PersonId] = [dbo].[Person].[Id]
GROUP BY 
	[dbo].[Person].[Id]

GO

CREATE PROCEDURE [dbo].[SelectPersonId_As_ScalarValue_With_Input_And_Default_Value]
	@P1 INT NULL = 3
AS
	SELECT 
		[dbo].[Person].[Id]
	FROM 
		[dbo].[Person]
	WHERE 
		[dbo].[Person].[Id] = @P1;
GO

CREATE PROCEDURE [dbo].[SelectPerson_As_Dynamic_With_Input]
	@P1 INT NULL
AS
	SELECT 
		[dbo].[Person].[Id]
		,[dbo].[Person].[FirstName]
		,[dbo].[Person].[LastName]
		,[dbo].[Person].[BirthDate]
		,[dbo].[Person].[GenderType]
		,[dbo].[Person].[CreditLimit]
		,[dbo].[Person].[YearOfLastCreditLimitReview]
		,[dbo].[Person].[RegistrationDate]
		,[dbo].[Person].[LastLoginDate]
		,[dbo].[Person].[DateCreated]
		,[dbo].[Person].[DateUpdated]
	FROM 
		[dbo].[Person]
	WHERE 
		[dbo].[Person].[Id] = @P1;
GO

CREATE PROCEDURE [dbo].[SelectPerson_As_DynamicList_With_Input]
	@P1 INT NULL 
AS
	SELECT 
		[dbo].[Person].[Id]
		,[dbo].[Person].[FirstName]
		,[dbo].[Person].[LastName]
		,[dbo].[Person].[BirthDate]
		,[dbo].[Person].[GenderType]
		,[dbo].[Person].[CreditLimit]
		,[dbo].[Person].[YearOfLastCreditLimitReview]
		,[dbo].[Person].[RegistrationDate]
		,[dbo].[Person].[LastLoginDate]
		,[dbo].[Person].[DateCreated]
		,[dbo].[Person].[DateUpdated]
	FROM 
		[dbo].[Person]
	WHERE 
		[dbo].[Person].[Id] > @P1;
GO

CREATE PROCEDURE [dbo].[SelectPersonId_As_ScalarValue_With_Input]
	@P1 INT NULL
AS
	SELECT 
		[dbo].[Person].[Id]
	FROM 
		[dbo].[Person]
	WHERE 
		[dbo].[Person].[Id] = @P1;
GO

CREATE PROCEDURE [dbo].[SelectPersonId_As_ScalarValueList_With_Input]
	@P1 INT NULL
AS
	SELECT 
		[dbo].[Person].[Id]
	FROM 
		[dbo].[Person]
	WHERE 
		[dbo].[Person].[Id] > @P1;
GO

CREATE PROCEDURE [dbo].[SelectPerson_As_Dynamic_With_Input_And_Output]
	@P1 INT,
	@Count INT OUTPUT
AS
	SELECT 
		[dbo].[Person].[Id]
		,[dbo].[Person].[FirstName]
		,[dbo].[Person].[LastName]
		,[dbo].[Person].[BirthDate]
		,[dbo].[Person].[GenderType]
		,[dbo].[Person].[CreditLimit]
		,[dbo].[Person].[YearOfLastCreditLimitReview]
		,[dbo].[Person].[RegistrationDate]
		,[dbo].[Person].[LastLoginDate]
		,[dbo].[Person].[DateCreated]
		,[dbo].[Person].[DateUpdated]
	FROM 
		[dbo].[Person]
	WHERE 
		[dbo].[Person].[Id] = @P1;

	SELECT @Count = 1;
GO

CREATE PROCEDURE [dbo].[SelectPerson_As_DynamicList_With_Input_And_Output]
	@P1 INT,
	@Count INT OUTPUT
AS
	SELECT 
		[dbo].[Person].[Id]
		,[dbo].[Person].[FirstName]
		,[dbo].[Person].[LastName]
		,[dbo].[Person].[BirthDate]
		,[dbo].[Person].[GenderType]
		,[dbo].[Person].[CreditLimit]
		,[dbo].[Person].[YearOfLastCreditLimitReview]
		,[dbo].[Person].[RegistrationDate]
		,[dbo].[Person].[LastLoginDate]
		,[dbo].[Person].[DateCreated]
		,[dbo].[Person].[DateUpdated]
	FROM 
		[dbo].[Person]
	WHERE 
		[dbo].[Person].[Id] > @P1;

	SELECT 
		@Count = COUNT(*) 
	FROM 
		[dbo].[Person]
	WHERE 
		[dbo].[Person].[Id] > @P1;
GO

CREATE PROCEDURE [dbo].[SelectPersonId_As_ScalarValue_With_Input_And_Output]
	@P1 INT NULL,
	@Count INT OUTPUT
AS
	SELECT 
		[Id]
	FROM 
		[dbo].[Person]
	WHERE 
		[dbo].[Person].[Id] = @P1;

	SELECT 
		@Count = COUNT(*) 
	FROM 
		[dbo].[Person]
	WHERE 
		[dbo].[Person].[Id] = @P1;
GO

CREATE PROCEDURE [dbo].[SelectPersonId_As_ScalarValueList_With_Input_And_Output]
	@P1 INT NULL,
	@Count INT OUTPUT
AS
	SELECT 
		[Id]
	FROM 
		[dbo].[Person]
	WHERE 
		[dbo].[Person].[Id] > @P1;

	SELECT 
		@Count = COUNT(*) 
	FROM 
		[dbo].[Person]
	WHERE 
		[dbo].[Person].[Id] > @P1;
GO

CREATE PROCEDURE [dbo].[SelectPerson_As_Dynamic_With_Input_And_InputOutput]
	@P1 INT,
	@CreditLimit INT OUTPUT
AS
	SELECT 
		[dbo].[Person].[Id]
		,[dbo].[Person].[FirstName]
		,[dbo].[Person].[LastName]
		,[dbo].[Person].[BirthDate]
		,[dbo].[Person].[GenderType]
		,[dbo].[Person].[CreditLimit]
		,[dbo].[Person].[YearOfLastCreditLimitReview]
		,[dbo].[Person].[RegistrationDate]
		,[dbo].[Person].[LastLoginDate]
		,[dbo].[Person].[DateCreated]
		,[dbo].[Person].[DateUpdated]
	FROM 
		[dbo].[Person]
	WHERE 
		[dbo].[Person].[Id] = @P1
		AND
		[dbo].[Person].[CreditLimit] = @CreditLimit;

	SELECT 
		@CreditLimit = [dbo].[Person].[CreditLimit] * 2
	FROM 
		[dbo].[Person]
	WHERE 
		[dbo].[Person].[Id] = @P1
		AND
		[dbo].[Person].[CreditLimit] = @CreditLimit;
GO

CREATE PROCEDURE [dbo].[SelectPerson_As_DynamicList_With_Input_And_InputOutput]
	@P1 INT,
	@CreditLimit INT OUTPUT
AS
	SELECT 
		[dbo].[Person].[Id]
		,[dbo].[Person].[FirstName]
		,[dbo].[Person].[LastName]
		,[dbo].[Person].[BirthDate]
		,[dbo].[Person].[GenderType]
		,[dbo].[Person].[CreditLimit]
		,[dbo].[Person].[YearOfLastCreditLimitReview]
		,[dbo].[Person].[RegistrationDate]
		,[dbo].[Person].[LastLoginDate]
		,[dbo].[Person].[DateCreated]
		,[dbo].[Person].[DateUpdated]
	FROM 
		[dbo].[Person]
	WHERE 
		[dbo].[Person].[Id] >= @P1
		AND
		[dbo].[Person].[CreditLimit] = @CreditLimit;

	SELECT 
		@CreditLimit = [dbo].[Person].[CreditLimit] * 2
	FROM 
		[dbo].[Person]
	WHERE 
		[dbo].[Person].[Id] = @P1
		AND
		[dbo].[Person].[CreditLimit] = @CreditLimit;
GO

CREATE PROCEDURE [dbo].[SelectPersonId_As_ScalarValue_With_Input_And_InputOutput]
	@P1 INT,
	@CreditLimit INT OUTPUT
AS
	SELECT 
		[Id]
	FROM 
		[dbo].[Person]
	WHERE 
		[dbo].[Person].[Id] = @P1
		AND
		[dbo].[Person].[CreditLimit] = @CreditLimit;

	SELECT 
		@CreditLimit = [dbo].[Person].[CreditLimit] * 2
	FROM 
		[dbo].[Person]
	WHERE 
		[dbo].[Person].[Id] = @P1
		AND
		[dbo].[Person].[CreditLimit] = @CreditLimit;
GO

CREATE PROCEDURE [dbo].[SelectPersonId_As_ScalarValueList_With_Input_And_InputOutput]
	@P1 INT,
	@CreditLimit INT OUTPUT
AS
	SELECT 
		[Id]
	FROM 
		[dbo].[Person]
	WHERE 
		[dbo].[Person].[Id] >= @P1
		AND
		[dbo].[Person].[CreditLimit] = @CreditLimit;

	SELECT 
		@CreditLimit = [dbo].[Person].[CreditLimit] * 2
	FROM 
		[dbo].[Person]
	WHERE 
		[dbo].[Person].[Id] = @P1;
GO

CREATE PROCEDURE [dbo].[UpdatePersonCreditLimit_With_Inputs]
	@P1 INT,
	@CreditLimit INT
AS
	UPDATE 
		[dbo].[Person]
	SET
		[dbo].[Person].[CreditLimit] = @CreditLimit
	WHERE 
		[dbo].[Person].[Id] = @P1;
GO

CREATE PROCEDURE [dbo].[GetMaxCreditLimitLessThan]
    @CreditLimit INT
AS
    SELECT
        MAX([dbo].[Person].[CreditLimit])
    FROM
        [dbo].[Person]
    WHERE
        [dbo].[Person].[CreditLimit] < @CreditLimit
GO

CREATE PROCEDURE [dbo].[GetPersonsWithCreditLimitLessThan]
    @CreditLimit INT
AS
    SELECT
        [dbo].[Person].[Id],
        [dbo].[Person].[FirstName],
        [dbo].[Person].[LastName]
    FROM
        [dbo].[Person]
    WHERE
        [dbo].[Person].[CreditLimit] < @CreditLimit
GO

CREATE PROCEDURE [dbo].[GetPersonById]
    @Id INT
AS
    SELECT
        [dbo].[Person].[Id],
        [dbo].[Person].[FirstName],
        [dbo].[Person].[LastName]
    FROM
        [dbo].[Person]
    WHERE
        [dbo].[Person].[Id] = @Id
GO

CREATE PROCEDURE [dbo].[SetCreditLimitForPerson]
    @Id INT,
    @CreditLimit INT
AS
    UPDATE
        [dbo].[Person]
    SET
        [dbo].[Person].[CreditLimit] = @CreditLimit
    WHERE
        [dbo].[Person].[Id] = @Id
GO
