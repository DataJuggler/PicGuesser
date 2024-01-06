

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllGameImageViewsStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'GameImageView' objects.
    /// </summary>
    public class FetchAllGameImageViewsStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllGameImageViewsStoredProcedure' object.
        /// </summary>
        public FetchAllGameImageViewsStoredProcedure()
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
                this.ProcedureName = "GameImageView_FetchAll";

                // Set tableName
                this.TableName = "GameImageView";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
