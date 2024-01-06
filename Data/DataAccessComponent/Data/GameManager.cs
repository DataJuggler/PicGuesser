

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

    #region class GameManager
    /// <summary>
    /// This class is used to manage a 'Game' object.
    /// </summary>
    public class GameManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'GameManager' object.
        /// </summary>
        public GameManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteGame()
            /// <summary>
            /// This method deletes a 'Game' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteGame(DeleteGameStoredProcedure deleteGameProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteGameProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllGames()
            /// <summary>
            /// This method fetches a  'List<Game>' object.
            /// This method uses the 'Games_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<Game>'</returns>
            /// </summary>
            public List<Game> FetchAllGames(FetchAllGamesStoredProcedure fetchAllGamesProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<Game> gameCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allGamesDataSet = this.DataHelper.LoadDataSet(fetchAllGamesProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allGamesDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allGamesDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            gameCollection = GameReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return gameCollection;
            }
            #endregion

            #region FindGame()
            /// <summary>
            /// This method finds a  'Game' object.
            /// This method uses the 'Game_Find' procedure.
            /// </summary>
            /// <returns>A 'Game' object.</returns>
            /// </summary>
            public Game FindGame(FindGameStoredProcedure findGameProc, DataConnector databaseConnector)
            {
                // Initial Value
                Game game = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet gameDataSet = this.DataHelper.LoadDataSet(findGameProc, databaseConnector);

                    // Verify DataSet Exists
                    if(gameDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(gameDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load Game
                            game = GameReader.Load(row);
                        }
                    }
                }

                // return value
                return game;
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

            #region InsertGame()
            /// <summary>
            /// This method inserts a 'Game' object.
            /// This method uses the 'Game_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertGame(InsertGameStoredProcedure insertGameProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertGameProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateGame()
            /// <summary>
            /// This method updates a 'Game'.
            /// This method uses the 'Game_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateGame(UpdateGameStoredProcedure updateGameProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateGameProc, databaseConnector);
                }

                // return value
                return saved;
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
