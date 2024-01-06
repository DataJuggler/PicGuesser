

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

    #region class GameMethods
    /// <summary>
    /// This class contains methods for modifying a 'Game' object.
    /// </summary>
    public class GameMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'GameMethods' object.
        /// </summary>
        public GameMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteGame(Game)
            /// <summary>
            /// This method deletes a 'Game' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Game' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteGame(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteGameStoredProcedure deleteGameProc = null;

                    // verify the first parameters is a(n) 'Game'.
                    if (parameters[0].ObjectValue as Game != null)
                    {
                        // Create Game
                        Game game = (Game) parameters[0].ObjectValue;

                        // verify game exists
                        if(game != null)
                        {
                            // Now create deleteGameProc from GameWriter
                            // The DataWriter converts the 'Game'
                            // to the SqlParameter[] array needed to delete a 'Game'.
                            deleteGameProc = GameWriter.CreateDeleteGameStoredProcedure(game);
                        }
                    }

                    // Verify deleteGameProc exists
                    if(deleteGameProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.GameManager.DeleteGame(deleteGameProc, dataConnector);

                        // Create returnObject.Boolean
                        returnObject.Boolean = new NullableBoolean();

                        // If delete was successful
                        if(deleted)
                        {
                            // Set returnObject.Boolean.Value to true
                            returnObject.Boolean.Value = NullableBooleanEnum.True;
                        }
                        else
                        {
                            // Set returnObject.Boolean.Value to false
                            returnObject.Boolean.Value = NullableBooleanEnum.False;
                        }
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

            #region FetchAll()
            /// <summary>
            /// This method fetches all 'Game' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Game' to delete.
            /// <returns>A PolymorphicObject object with all  'Games' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<Game> gameListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllGamesStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get GameParameter
                    // Declare Parameter
                    Game paramGame = null;

                    // verify the first parameters is a(n) 'Game'.
                    if (parameters[0].ObjectValue as Game != null)
                    {
                        // Get GameParameter
                        paramGame = (Game) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllGamesProc from GameWriter
                    fetchAllProc = GameWriter.CreateFetchAllGamesStoredProcedure(paramGame);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    gameListCollection = this.DataManager.GameManager.FetchAllGames(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(gameListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = gameListCollection;
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

            #region FindGame(Game)
            /// <summary>
            /// This method finds a 'Game' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Game' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindGame(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Game game = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindGameStoredProcedure findGameProc = null;

                    // verify the first parameters is a 'Game'.
                    if (parameters[0].ObjectValue as Game != null)
                    {
                        // Get GameParameter
                        Game paramGame = (Game) parameters[0].ObjectValue;

                        // verify paramGame exists
                        if(paramGame != null)
                        {
                            // Now create findGameProc from GameWriter
                            // The DataWriter converts the 'Game'
                            // to the SqlParameter[] array needed to find a 'Game'.
                            findGameProc = GameWriter.CreateFindGameStoredProcedure(paramGame);
                        }

                        // Verify findGameProc exists
                        if(findGameProc != null)
                        {
                            // Execute Find Stored Procedure
                            game = this.DataManager.GameManager.FindGame(findGameProc, dataConnector);

                            // if dataObject exists
                            if(game != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = game;
                            }
                        }
                    }
                    else
                    {
                        // Raise Error Data Connection Not Available
                        throw new Exception("The database connection is not available.");
                    }
                }

                // return value
                return returnObject;
            }
            #endregion

            #region InsertGame (Game)
            /// <summary>
            /// This method inserts a 'Game' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Game' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertGame(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Game game = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertGameStoredProcedure insertGameProc = null;

                    // verify the first parameters is a(n) 'Game'.
                    if (parameters[0].ObjectValue as Game != null)
                    {
                        // Create Game Parameter
                        game = (Game) parameters[0].ObjectValue;

                        // verify game exists
                        if(game != null)
                        {
                            // Now create insertGameProc from GameWriter
                            // The DataWriter converts the 'Game'
                            // to the SqlParameter[] array needed to insert a 'Game'.
                            insertGameProc = GameWriter.CreateInsertGameStoredProcedure(game);
                        }

                        // Verify insertGameProc exists
                        if(insertGameProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.GameManager.InsertGame(insertGameProc, dataConnector);
                        }

                    }
                    else
                    {
                        // Raise Error Data Connection Not Available
                        throw new Exception("The database connection is not available.");
                    }
                }

                // return value
                return returnObject;
            }
            #endregion

            #region UpdateGame (Game)
            /// <summary>
            /// This method updates a 'Game' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Game' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateGame(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Game game = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateGameStoredProcedure updateGameProc = null;

                    // verify the first parameters is a(n) 'Game'.
                    if (parameters[0].ObjectValue as Game != null)
                    {
                        // Create Game Parameter
                        game = (Game) parameters[0].ObjectValue;

                        // verify game exists
                        if(game != null)
                        {
                            // Now create updateGameProc from GameWriter
                            // The DataWriter converts the 'Game'
                            // to the SqlParameter[] array needed to update a 'Game'.
                            updateGameProc = GameWriter.CreateUpdateGameStoredProcedure(game);
                        }

                        // Verify updateGameProc exists
                        if(updateGameProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.GameManager.UpdateGame(updateGameProc, dataConnector);

                            // Create returnObject.Boolean
                            returnObject.Boolean = new NullableBoolean();

                            // If save was successful
                            if(saved)
                            {
                                // Set returnObject.Boolean.Value to true
                                returnObject.Boolean.Value = NullableBooleanEnum.True;
                            }
                            else
                            {
                                // Set returnObject.Boolean.Value to false
                                returnObject.Boolean.Value = NullableBooleanEnum.False;
                            }
                        }
                        else
                        {
                            // Raise Error Data Connection Not Available
                            throw new Exception("The database connection is not available.");
                        }
                    }
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
