CREATE PROCEDURE [dbo].[CreateSmartPhone]
	@Id NVARCHAR(50) NULL, 
    @Model NCHAR(50) NULL, 
    @Color NCHAR(10) NULL, 
    @ROM NCHAR(10) NULL, 
    @RAM NCHAR(10) NULL
AS
	BEGIN
        INSERT INTO [dbo].[SmartPhone] ([Id], [Model], [Color], [ROM], [RAM])
        VALUES (@Id,@Model,@Color,@ROM,@RAM);
	END