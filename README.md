1. Create database called [Fabrikam]
2. Using sql server management studio or any other tool create below table to store customer information

USE [Fabrikam]
GO

/****** Object:  Table [dbo].[Customer]    Script Date: 2022-08-23 11:58:43 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [varchar](255) NULL,
	[UserName] [varchar](255) NULL,
	[Password] [varchar](100) NULL,
	[FirstName] [varchar](100) NULL,
	[LastName] [varchar](100) NULL,
	[Gender] [varchar](50) NULL,
	[MaritalStatus] [varchar](100) NULL,
 CONSTRAINT [PK_EmployeeLogin] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


3. Update Myconnection in appsettings.Development.json to your sql connection string
4. Run the app using visual studio

/*************************************************************************************************************/
Future Enhancements
- Create professional user interface with look,feel,color and logo
- Add duplicate user validation
- Encrypt/hash password
- Add DTO and map using automapper or some mapping library
- Create a rest api and call it from ui
- Add authentication and authorization as per the requirement