

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertGameStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'Game' object.
    /// </summary>
    public class InsertGameStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertGameStoredProcedure' object.
        /// </summary>
        public InsertGameStoredProcedure()
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
                this.ProcedureName = "Game_Insert";

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
