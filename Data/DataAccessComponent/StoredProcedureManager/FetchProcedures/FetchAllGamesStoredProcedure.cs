

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllGamesStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'Game' objects.
    /// </summary>
    public class FetchAllGamesStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllGamesStoredProcedure' object.
        /// </summary>
        public FetchAllGamesStoredProcedure()
        {
            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// Set Procedure Properties
            /// </summary>
            private void Init()
            {
                // Set Properties For This Proc

                // Set ProcedureName
                this.ProcedureName = "Game_FetchAll";

                // Set tableName
                this.TableName = "Game";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
