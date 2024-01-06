

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindPixelStoredProcedure
    /// <summary>
    /// This class is used to Find a 'Pixel' object.
    /// </summary>
    public class FindPixelStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindPixelStoredProcedure' object.
        /// </summary>
        public FindPixelStoredProcedure()
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
                this.ProcedureName = "Pixel_Find";

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
