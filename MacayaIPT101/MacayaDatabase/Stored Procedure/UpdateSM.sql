CREATE PROCEDURE [dbo].[UpdateSmartPhone]
	@Id NVARCHAR(50) NULL, 
    @Model NCHAR(50) NULL, 
    @Color NCHAR(10) NULL, 
    @ROM NCHAR(10) NULL, 
    @RAM NCHAR(10) NULL
AS
	BEGIN
    UPDATE SmartPhone
    SET 
    [Color] = @Color,
    [Model] = @Model,
    [ROM] = @ROM,
    [RAM] = @RAM
    WHERE [Id] = @Id;

    END

