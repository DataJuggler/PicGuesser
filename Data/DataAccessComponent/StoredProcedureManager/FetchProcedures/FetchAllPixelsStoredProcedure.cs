

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllPixelsStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'Pixel' objects.
    /// </summary>
    public class FetchAllPixelsStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllPixelsStoredProcedure' object.
        /// </summary>
        public FetchAllPixelsStoredProcedure()
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
                this.ProcedureName = "Pixel_FetchAll";

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
