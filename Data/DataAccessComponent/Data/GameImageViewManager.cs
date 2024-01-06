

#region using statements

using DataAccessComponent.Data.Readers;
using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.Data
{

    #region class GameImageViewManager
    /// <summary>
    /// This class is used to manage a 'GameImageView' object.
    /// </summary>
    public class GameImageViewManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'GameImageViewManager' object.
        /// </summary>
        public GameImageViewManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region FetchAllGameImageViews()
            /// <summary>
            /// This method fetches a  'List<GameImageView>' object.
            /// This method uses the 'GameImageViews_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<GameImageView>'</returns>
            /// </summary>
            public List<GameImageView> FetchAllGameImageViews(FetchAllGameImageViewsStoredProcedure fetchAllGameImageViewsProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<GameImageView> gameImageViewCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allGameImageViewsDataSet = this.DataHelper.LoadDataSet(fetchAllGameImageViewsProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allGameImageViewsDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allGameImageViewsDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            gameImageViewCollection = GameImageViewReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return gameImageViewCollection;
            }
            #endregion

            #region Init()
            /// <summary>
            /// Perorm Initialization For This Object
            /// </summary>
            private void Init()
            {
                // Create DataHelper object
                this.DataHelper = new DataHelper();
            }
            #endregion

        #endregion

        #region Properties

            #region DataHelper
            /// <summary>
            /// This object uses the Microsoft Data
            /// Application Block to execute stored
            /// procedures.
            /// </summary>
            internal DataHelper DataHelper
            {
                get { return dataHelper; }
                set { dataHelper = value; }
            }
            #endregion

            #region DataManager
            /// <summary>
            /// A reference to this objects parent.
            /// </summary>
            internal DataManager DataManager
            {
                get { return dataManager; }
                set { dataManager = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
