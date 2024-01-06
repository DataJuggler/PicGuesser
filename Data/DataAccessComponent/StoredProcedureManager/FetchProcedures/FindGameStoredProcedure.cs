

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindGameStoredProcedure
    /// <summary>
    /// This class is used to Find a 'Game' object.
    /// </summary>
    public class FindGameStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindGameStoredProcedure' object.
        /// </summary>
        public FindGameStoredProcedure()
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
                this.ProcedureName = "Game_Find";

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
