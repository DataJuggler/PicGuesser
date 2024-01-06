

#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class GameImageView
    public partial class GameImageView
    {

        #region Private Variables
        private bool assigned;
        private bool completed;
        private string fullPath;
        private int gameId;
        private int imageId;
        private string name;
        private bool solved;
        private bool started;
        private DateTime startTime;
        private int totalPixels;
        #endregion

        #region Methods


        #endregion

        #region Properties

            #region bool Assigned
            public bool Assigned
            {
                get
                {
                    return assigned;
                }
                set
                {
                    assigned = value;
                }
            }
            #endregion

            #region bool Completed
            public bool Completed
            {
                get
                {
                    return completed;
                }
                set
                {
                    completed = value;
                }
            }
            #endregion

            #region string FullPath
            public string FullPath
            {
                get
                {
                    return fullPath;
                }
                set
                {
                    fullPath = value;
                }
            }
            #endregion

            #region int GameId
            public int GameId
            {
                get
                {
                    return gameId;
                }
                set
                {
                    gameId = value;
                }
            }
            #endregion

            #region int ImageId
            public int ImageId
            {
                get
                {
                    return imageId;
                }
                set
                {
                    imageId = value;
                }
            }
            #endregion

            #region string Name
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            #endregion

            #region bool Solved
            public bool Solved
            {
                get
                {
                    return solved;
                }
                set
                {
                    solved = value;
                }
            }
            #endregion

            #region bool Started
            public bool Started
            {
                get
                {
                    return started;
                }
                set
                {
                    started = value;
                }
            }
            #endregion

            #region DateTime StartTime
            public DateTime StartTime
            {
                get
                {
                    return startTime;
                }
                set
                {
                    startTime = value;
                }
            }
            #endregion

            #region int TotalPixels
            public int TotalPixels
            {
                get
                {
                    return totalPixels;
                }
                set
                {
                    totalPixels = value;
                }
            }
            #endregion

        #endregion

    }
    #endregion

}
