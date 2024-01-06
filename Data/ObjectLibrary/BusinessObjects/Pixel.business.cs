
#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion

namespace ObjectLibrary.BusinessObjects
{

    #region class Pixel
    [Serializable]
    public partial class Pixel
    {

        #region Private Variables
        private bool loadByImageId;
        #endregion

        #region Constructor
        public Pixel()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public Pixel Clone()
            {
                // Create New Object
                Pixel newPixel = (Pixel) this.MemberwiseClone();

                // Return Cloned Object
                return newPixel;
            }
            #endregion

        #endregion

        #region Properties

            #region LoadByImageId
            /// <summary>
            /// This property gets or sets the value for 'LoadByImageId'.
            /// </summary>
            public bool LoadByImageId
            {
                get { return loadByImageId; }
                set { loadByImageId = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
