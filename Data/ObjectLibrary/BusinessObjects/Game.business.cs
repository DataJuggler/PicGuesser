

#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class Game
    [Serializable]
    public partial class Game
    {

        #region Private Variables
        #endregion

        #region Constructor
        public Game()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public Game Clone()
            {
                // Create New Object
                Game newGame = (Game) this.MemberwiseClone();

                // Return Cloned Object
                return newGame;
            }
            #endregion

        #endregion

        #region Properties
        #endregion

    }
    #endregion

}
