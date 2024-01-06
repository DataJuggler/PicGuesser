

#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class Game
    public partial class Game
    {

        #region Private Variables
        private bool completed;
        private int id;
        private int imageId;
        private bool solved;
        private bool started;
        private DateTime startTime;
        #endregion

        #region Methods

            #region UpdateIdentity(int id)
            // <summary>
            // This method provides a 'setter'
            // functionality for the Identity field.
            // </summary>
            public void UpdateIdentity(int id)
            {
                // Update The Identity field
                this.id = id;
            }
            #endregion

        #endregion

        #region Properties

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

            #region int Id
            public int Id
            {
                get
                {
                    return id;
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

            #region bool IsNew
            public bool IsNew
            {
                get
                {
                    // Initial Value
                    bool isNew = (this.Id < 1);

                    // return value
                    return isNew;
                }
            }
            #endregion

        #endregion

    }
    #endregion

}
