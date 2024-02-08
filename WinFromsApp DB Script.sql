CREATE TABLE Colors(
ColorId BIGINT PRIMARY KEY IDENTITY(1,1),
ColorName VARCHAR(25) NOT NULL
)
GO

CREATE TABLE Users(
UserId BIGINT PRIMARY KEY IDENTITY(1,1),
UserName VARCHAR(50) NOT NULL,
Email VARCHAR(50) NOT NULL,
BirthDay DATE NOT NULL,
ColorId BIGINT FOREIGN KEY REFERENCES Colors(ColorId),
Married BIT NOT NULL,
Deleted BIT DEFAULT 0,
SubmitDate DATETIME DEFAULT GETDATE()
)
GO

INSERT INTO Colors(ColorName) VALUES('Yellow'), ('Green'), ('Purple')
GO

--InsertUser 0, 'Siddhant', 'siddhant@yopmail.com', '1993-10-17', 1, 1, 0
CREATE PROCEDURE [dbo].[InsertUser]  
(
@UserId BIGINT,
@UserName VARCHAR(50),
@Email VARCHAR(50),
@BirthDay DATE,
@ColorId BIGINT,
@Married BIT,
@Result BIGINT OUTPUT
)
AS  
BEGIN   
	IF(@UserId = 0)
	BEGIN
		INSERT INTO dbo.Users(UserName, Email, BirthDay, ColorId, Married)
		VALUES(@UserName, @Email, @BirthDay, @ColorId, @Married)
		SET @Result = @@IDENTITY
	END
	ELSE BEGIN
		UPDATE Users SET 
		UserName = @UserName,
		Email = @Email,
		BirthDay = @BirthDay,
		ColorId = @ColorId,
		Married = @Married
		WHERE UserId = @UserId
		SET @Result = @@ROWCOUNT
	END
	SELECT @Result
END  
GO

--DeleteUser 1, 0
CREATE PROCEDURE [dbo].[DeleteUser]  
(
@UserId BIGINT,
@Result BIGINT OUTPUT
)
AS  
BEGIN   
	UPDATE Users SET Deleted = 1 WHERE UserId = @UserId
	SET @Result = @@ROWCOUNT
	SELECT @Result
END  
GO