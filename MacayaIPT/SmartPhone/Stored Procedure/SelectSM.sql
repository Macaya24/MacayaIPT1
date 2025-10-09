CREATE PROCEDURE [dbo].[SelectSmartPhone]
	@Id nvarchar (50) = NULL
AS
	BEGIN
		SELECT * FROM [dbo].[SmartPhone] AS a WHERE a.[Id] = @Id;
	END