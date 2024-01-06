Use [PicGuesser]

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Game_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   1/5/2024
-- Description:    Insert a new Game
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Game_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Game_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Game_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Game_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Game_Insert >>>'

    End

GO

Create PROCEDURE Game_Insert

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
Go
-- =========================================================
-- Procure Name: Game_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   1/5/2024
-- Description:    Update an existing Game
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Game_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Game_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Game_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Game_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Game_Update >>>'

    End

GO

Create PROCEDURE Game_Update

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
Go
-- =========================================================
-- Procure Name: Game_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   1/5/2024
-- Description:    Find an existing Game
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Game_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Game_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Game_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Game_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Game_Find >>>'

    End

GO

Create PROCEDURE Game_Find

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
Go
-- =========================================================
-- Procure Name: Game_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   1/5/2024
-- Description:    Delete an existing Game
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Game_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Game_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Game_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Game_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Game_Delete >>>'

    End

GO

Create PROCEDURE Game_Delete

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
Go
-- =========================================================
-- Procure Name: Game_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   1/5/2024
-- Description:    Returns all Game objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Game_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Game_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Game_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Game_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Game_FetchAll >>>'

    End

GO

Create PROCEDURE Game_FetchAll

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
Go
-- =========================================================
-- Procure Name: GameImageView_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   1/5/2024
-- Description:    Returns all GameImageView objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('GameImageView_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure GameImageView_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.GameImageView_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure GameImageView_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure GameImageView_FetchAll >>>'

    End

GO

Create PROCEDURE GameImageView_FetchAll

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
Go
-- =========================================================
-- Procure Name: Image_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   1/5/2024
-- Description:    Insert a new Image
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Image_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Image_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Image_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Image_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Image_Insert >>>'

    End

GO

Create PROCEDURE Image_Insert

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
Go
-- =========================================================
-- Procure Name: Image_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   1/5/2024
-- Description:    Update an existing Image
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Image_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Image_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Image_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Image_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Image_Update >>>'

    End

GO

Create PROCEDURE Image_Update

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
Go
-- =========================================================
-- Procure Name: Image_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   1/5/2024
-- Description:    Find an existing Image
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Image_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Image_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Image_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Image_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Image_Find >>>'

    End

GO

Create PROCEDURE Image_Find

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
Go
-- =========================================================
-- Procure Name: Image_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   1/5/2024
-- Description:    Delete an existing Image
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Image_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Image_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Image_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Image_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Image_Delete >>>'

    End

GO

Create PROCEDURE Image_Delete

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
Go
-- =========================================================
-- Procure Name: Image_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   1/5/2024
-- Description:    Returns all Image objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Image_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Image_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Image_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Image_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Image_FetchAll >>>'

    End

GO

Create PROCEDURE Image_FetchAll

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
Go
-- =========================================================
-- Procure Name: Pixel_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   1/5/2024
-- Description:    Insert a new Pixel
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Pixel_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Pixel_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Pixel_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Pixel_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Pixel_Insert >>>'

    End

GO

Create PROCEDURE Pixel_Insert

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
Go
-- =========================================================
-- Procure Name: Pixel_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   1/5/2024
-- Description:    Update an existing Pixel
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Pixel_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Pixel_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Pixel_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Pixel_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Pixel_Update >>>'

    End

GO

Create PROCEDURE Pixel_Update

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
Go
-- =========================================================
-- Procure Name: Pixel_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   1/5/2024
-- Description:    Find an existing Pixel
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Pixel_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Pixel_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Pixel_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Pixel_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Pixel_Find >>>'

    End

GO

Create PROCEDURE Pixel_Find

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
Go
-- =========================================================
-- Procure Name: Pixel_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   1/5/2024
-- Description:    Delete an existing Pixel
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Pixel_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Pixel_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Pixel_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Pixel_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Pixel_Delete >>>'

    End

GO

Create PROCEDURE Pixel_Delete

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
Go
-- =========================================================
-- Procure Name: Pixel_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   1/5/2024
-- Description:    Returns all Pixel objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Pixel_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Pixel_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Pixel_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Pixel_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Pixel_FetchAll >>>'

    End

GO

Create PROCEDURE Pixel_FetchAll

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

