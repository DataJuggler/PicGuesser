

#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class GameImageView
    [Serializable]
    public partial class GameImageView
    {

        #region Private Variables
        #endregion

        #region Constructor
        public GameImageView()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public GameImageView Clone()
            {
                // Create New Object
                GameImageView newGameImageView = (GameImageView) this.MemberwiseClone();

                // Return Cloned Object
                return newGameImageView;
            }
            #endregion

        #endregion

        #region Properties
        #endregion

    }
    #endregion

}
