

namespace DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateGameStoredProcedure
    /// <summary>
    /// This class is used to Update a 'Game' object.
    /// </summary>
    public class UpdateGameStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateGameStoredProcedure' object.
        /// </summary>
        public UpdateGameStoredProcedure()
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
                this.ProcedureName = "Game_Update";

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
