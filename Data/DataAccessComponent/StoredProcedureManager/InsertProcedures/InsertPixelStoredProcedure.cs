

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertPixelStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'Pixel' object.
    /// </summary>
    public class InsertPixelStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertPixelStoredProcedure' object.
        /// </summary>
        public InsertPixelStoredProcedure()
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
                this.ProcedureName = "Pixel_Insert";

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
