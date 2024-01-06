

namespace DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdatePixelStoredProcedure
    /// <summary>
    /// This class is used to Update a 'Pixel' object.
    /// </summary>
    public class UpdatePixelStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdatePixelStoredProcedure' object.
        /// </summary>
        public UpdatePixelStoredProcedure()
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
                this.ProcedureName = "Pixel_Update";

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
