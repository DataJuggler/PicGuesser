

#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class Image
    public partial class Image
    {

        #region Private Variables
        private bool assigned;
        private string fullPath;
        private int id;
        private string name;
        private int totalPixels;
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

            #region int Id
            public int Id
            {
                get
                {
                    return id;
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
