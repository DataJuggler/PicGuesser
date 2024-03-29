Use [PicGuesser]

/****** Object:  Table [dbo].[Image]    Script Date: 1/5/2024 9:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Image](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[FullPath] [nvarchar](255) NOT NULL,
	[TotalPixels] [int] NOT NULL,
	[Assigned] [bit] NOT NULL,
 CONSTRAINT [PK_Image] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Game]    Script Date: 1/5/2024 9:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Game](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImageId] [int] NOT NULL,
	[StartTime] [datetime] NOT NULL,
	[Started] [bit] NOT NULL,
	[Solved] [bit] NOT NULL,
	[Completed] [bit] NOT NULL,
 CONSTRAINT [PK_Game] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[GameImageView]    Script Date: 1/5/2024 9:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[GameImageView]
AS
SELECT dbo.Game.Id AS GameId, dbo.Game.ImageId, dbo.Game.StartTime, dbo.Game.Started, dbo.Game.Solved, dbo.Game.Completed, dbo.Image.Name, dbo.Image.FullPath, dbo.Image.TotalPixels, dbo.Image.Assigned
FROM  dbo.Game INNER JOIN
        dbo.Image ON dbo.Game.ImageId = dbo.Image.Id
GO
/****** Object:  Table [dbo].[Pixel]    Script Date: 1/5/2024 9:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pixel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImageId] [int] NOT NULL,
	[X] [int] NOT NULL,
	[Y] [int] NOT NULL,
	[Red] [int] NOT NULL,
	[Green] [int] NOT NULL,
	[Blue] [int] NOT NULL,
	[Alpha] [int] NOT NULL,
	[Assigned] [bit] NOT NULL,
 CONSTRAINT [PK_Pixel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Game_Delete]    Script Date: 1/5/2024 9:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Game_Delete]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [Game]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Game_FetchAll]    Script Date: 1/5/2024 9:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Game_FetchAll]

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Completed],[Id],[ImageId],[Solved],[Started],[StartTime]

    -- From tableName
    From [Game]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Game_Find]    Script Date: 1/5/2024 9:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Game_Find]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Completed],[Id],[ImageId],[Solved],[Started],[StartTime]

    -- From tableName
    From [Game]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Game_Insert]    Script Date: 1/5/2024 9:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Game_Insert]

    -- Add the parameters for the stored procedure here
    @Completed bit,
    @ImageId int,
    @Solved bit,
    @Started bit,
    @StartTime datetime

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [Game]
    ([Completed],[ImageId],[Solved],[Started],[StartTime])

    -- Begin Values List
    Values(@Completed, @ImageId, @Solved, @Started, @StartTime)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Game_Update]    Script Date: 1/5/2024 9:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Game_Update]

    -- Add the parameters for the stored procedure here
    @Completed bit,
    @Id int,
    @ImageId int,
    @Solved bit,
    @Started bit,
    @StartTime datetime

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [Game]

    -- Update Each field
    Set [Completed] = @Completed,
    [ImageId] = @ImageId,
    [Solved] = @Solved,
    [Started] = @Started,
    [StartTime] = @StartTime

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[GameImageView_FetchAll]    Script Date: 1/5/2024 9:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[GameImageView_FetchAll]

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Assigned],[Completed],[FullPath],[GameId],[ImageId],[Name],[Solved],[Started],[StartTime],[TotalPixels]

    -- From tableName
    From [GameImageView]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Image_Delete]    Script Date: 1/5/2024 9:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Image_Delete]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [Image]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Image_FetchAll]    Script Date: 1/5/2024 9:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Image_FetchAll]

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Assigned],[FullPath],[Id],[Name],[TotalPixels]

    -- From tableName
    From [Image]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Image_Find]    Script Date: 1/5/2024 9:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Image_Find]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Assigned],[FullPath],[Id],[Name],[TotalPixels]

    -- From tableName
    From [Image]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Image_Insert]    Script Date: 1/5/2024 9:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Image_Insert]

    -- Add the parameters for the stored procedure here
    @Assigned bit,
    @FullPath nvarchar(255),
    @Name nvarchar(50),
    @TotalPixels int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [Image]
    ([Assigned],[FullPath],[Name],[TotalPixels])

    -- Begin Values List
    Values(@Assigned, @FullPath, @Name, @TotalPixels)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Image_Update]    Script Date: 1/5/2024 9:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Image_Update]

    -- Add the parameters for the stored procedure here
    @Assigned bit,
    @FullPath nvarchar(255),
    @Id int,
    @Name nvarchar(50),
    @TotalPixels int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [Image]

    -- Update Each field
    Set [Assigned] = @Assigned,
    [FullPath] = @FullPath,
    [Name] = @Name,
    [TotalPixels] = @TotalPixels

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Pixel_Delete]    Script Date: 1/5/2024 9:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Pixel_Delete]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [Pixel]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Pixel_FetchAll]    Script Date: 1/5/2024 9:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Pixel_FetchAll]

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Alpha],[Assigned],[Blue],[Green],[Id],[ImageId],[Red],[X],[Y]

    -- From tableName
    From [Pixel]

END

-- Thank you for using DataTier.Net.

GO
/****** Object:  StoredProcedure [dbo].[Pixel_FetchAllForImageId]    Script Date: 1/5/2024 9:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[Pixel_FetchAllForImageId]

    -- Create @ImageId Paramater
    @ImageId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Alpha],[Assigned],[Blue],[Green],[Id],[ImageId],[Red],[X],[Y]

    -- From tableName
    From [Pixel]

    -- Load Matching Records
    Where [ImageId] = @ImageId

END
GO
/****** Object:  StoredProcedure [dbo].[Pixel_Find]    Script Date: 1/5/2024 9:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Pixel_Find]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Alpha],[Assigned],[Blue],[Green],[Id],[ImageId],[Red],[X],[Y]

    -- From tableName
    From [Pixel]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Pixel_Insert]    Script Date: 1/5/2024 9:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Pixel_Insert]

    -- Add the parameters for the stored procedure here
    @Alpha int,
    @Assigned bit,
    @Blue int,
    @Green int,
    @ImageId int,
    @Red int,
    @X int,
    @Y int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [Pixel]
    ([Alpha],[Assigned],[Blue],[Green],[ImageId],[Red],[X],[Y])

    -- Begin Values List
    Values(@Alpha, @Assigned, @Blue, @Green, @ImageId, @Red, @X, @Y)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Pixel_Update]    Script Date: 1/5/2024 9:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Pixel_Update]

    -- Add the parameters for the stored procedure here
    @Alpha int,
    @Assigned bit,
    @Blue int,
    @Green int,
    @Id int,
    @ImageId int,
    @Red int,
    @X int,
    @Y int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [Pixel]

    -- Update Each field
    Set [Alpha] = @Alpha,
    [Assigned] = @Assigned,
    [Blue] = @Blue,
    [Green] = @Green,
    [ImageId] = @ImageId,
    [Red] = @Red,
    [X] = @X,
    [Y] = @Y

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
