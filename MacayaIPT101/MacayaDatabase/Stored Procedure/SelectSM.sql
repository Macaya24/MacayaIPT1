
CREATE PROCEDURE [dbo].[SelectSM]
	@Id nvarchar (50) = NULL
AS
	BEGIN
		SELECT * FROM [dbo].[SmartPhone] AS a WHERE a.[Id] = @Id;
	END