

namespace DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteGameStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'Game' object.
    /// </summary>
    public class DeleteGameStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteGameStoredProcedure' object.
        /// </summary>
        public DeleteGameStoredProcedure()
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
                this.ProcedureName = "Game_Delete";

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
