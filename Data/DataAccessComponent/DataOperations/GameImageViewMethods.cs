

#region using statements

using DataAccessComponent.Data;
using DataAccessComponent.Data.Writers;
using DataAccessComponent.DataBridge;
using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;

#endregion


namespace DataAccessComponent.DataOperations
{

    #region class GameImageViewMethods
    /// <summary>
    /// This class contains methods for modifying a 'GameImageView' object.
    /// </summary>
    public class GameImageViewMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'GameImageViewMethods' object.
        /// </summary>
        public GameImageViewMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region FetchAll()
            /// <summary>
            /// This method fetches all 'GameImageView' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'GameImageView' to delete.
            /// <returns>A PolymorphicObject object with all  'GameImageViews' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<GameImageView> gameImageViewListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllGameImageViewsStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get GameImageViewParameter
                    // Declare Parameter
                    GameImageView paramGameImageView = null;

                    // verify the first parameters is a(n) 'GameImageView'.
                    if (parameters[0].ObjectValue as GameImageView != null)
                    {
                        // Get GameImageViewParameter
                        paramGameImageView = (GameImageView) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllGameImageViewsProc from GameImageViewWriter
                    fetchAllProc = GameImageViewWriter.CreateFetchAllGameImageViewsStoredProcedure(paramGameImageView);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    gameImageViewListCollection = this.DataManager.GameImageViewManager.FetchAllGameImageViews(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(gameImageViewListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = gameImageViewListCollection;
                    }
                }
                else
                {
                    // Raise Error Data Connection Not Available
                    throw new Exception("The database connection is not available.");
                }

                // return value
                return returnObject;
            }
            #endregion

        #endregion

        #region Properties

            #region DataManager 
            public DataManager DataManager 
            {
                get { return dataManager; }
                set { dataManager = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
