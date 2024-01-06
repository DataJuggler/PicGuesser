

namespace DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeletePixelStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'Pixel' object.
    /// </summary>
    public class DeletePixelStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeletePixelStoredProcedure' object.
        /// </summary>
        public DeletePixelStoredProcedure()
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
                this.ProcedureName = "Pixel_Delete";

                // Set tableName
                this.TableName = "Pixel";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
