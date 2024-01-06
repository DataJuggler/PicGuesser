

#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class Pixel
    public partial class Pixel
    {

        #region Private Variables
        private int alpha;
        private bool assigned;
        private int blue;
        private int green;
        private int id;
        private int imageId;
        private int red;
        private int x;
        private int y;
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

            #region int Alpha
            public int Alpha
            {
                get
                {
                    return alpha;
                }
                set
                {
                    alpha = value;
                }
            }
            #endregion

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

            #region int Blue
            public int Blue
            {
                get
                {
                    return blue;
                }
                set
                {
                    blue = value;
                }
            }
            #endregion

            #region int Green
            public int Green
            {
                get
                {
                    return green;
                }
                set
                {
                    green = value;
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

            #region int Red
            public int Red
            {
                get
                {
                    return red;
                }
                set
                {
                    red = value;
                }
            }
            #endregion

            #region int X
            public int X
            {
                get
                {
                    return x;
                }
                set
                {
                    x = value;
                }
            }
            #endregion

            #region int Y
            public int Y
            {
                get
                {
                    return y;
                }
                set
                {
                    y = value;
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
