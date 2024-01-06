

#region using statements

using DataAccessComponent.DataBridge;
using DataAccessComponent.DataOperations;
using DataAccessComponent.Logging;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;

#endregion


namespace DataAccessComponent.Controllers
{

    #region class GameController
    /// <summary>
    /// This class controls a(n) 'Game' object.
    /// </summary>
    public class GameController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'GameController' object.
        /// </summary>
        public GameController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateGameParameter
            /// <summary>
            /// This method creates the parameter for a 'Game' data operation.
            /// </summary>
            /// <param name='game'>The 'Game' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private static List<PolymorphicObject> CreateGameParameter(Game game)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = game;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(Game tempGame)
            /// <summary>
            /// Deletes a 'Game' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'Game_Delete'.
            /// </summary>
            /// <param name='game'>The 'Game' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(Game tempGame)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteGame";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify tempgame exists before attemptintg to delete
                    if(tempGame != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteGameMethod = this.AppController.DataBridge.DataOperations.GameMethods.DeleteGame;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateGameParameter(tempGame);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteGameMethod, parameters);

                        // If return object exists
                        if (returnObject != null)
                        {
                            // Test For True
                            if (returnObject.Boolean.Value == NullableBooleanEnum.True)
                            {
                                // Set Deleted To True
                                deleted = true;
                            }
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAll(Game tempGame)
            /// <summary>
            /// This method fetches a collection of 'Game' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'Game_FetchAll'.</summary>
            /// <param name='tempGame'>A temporary Game for passing values.</param>
            /// <returns>A collection of 'Game' objects.</returns>
            public List<Game> FetchAll(Game tempGame)
            {
                // Initial value
                List<Game> gameList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.GameMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateGameParameter(tempGame);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<Game> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        gameList = (List<Game>) returnObject.ObjectValue;
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return gameList;
            }
            #endregion

            #region Find(Game tempGame)
            /// <summary>
            /// Finds a 'Game' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'Game_Find'</param>
            /// </summary>
            /// <param name='tempGame'>A temporary Game for passing values.</param>
            /// <returns>A 'Game' object if found else a null 'Game'.</returns>
            public Game Find(Game tempGame)
            {
                // Initial values
                Game game = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempGame != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.GameMethods.FindGame;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateGameParameter(tempGame);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as Game != null))
                        {
                            // Get ReturnObject
                            game = (Game) returnObject.ObjectValue;
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return game;
            }
            #endregion

            #region Insert(Game game)
            /// <summary>
            /// Insert a 'Game' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'Game_Insert'.</param>
            /// </summary>
            /// <param name='game'>The 'Game' object to insert.</param>
            /// <returns>The id (int) of the new  'Game' object that was inserted.</returns>
            public int Insert(Game game)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If Gameexists
                    if(game != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.GameMethods.InsertGame;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateGameParameter(game);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, insertMethod , parameters);

                        // If return object exists
                        if (returnObject != null)
                        {
                            // Set return value
                            newIdentity = returnObject.IntegerValue;
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region Save(ref Game game)
            /// <summary>
            /// Saves a 'Game' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='game'>The 'Game' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref Game game)
            {
                // Initial value
                bool saved = false;

                // If the game exists.
                if(game != null)
                {
                    // Is this a new Game
                    if(game.IsNew)
                    {
                        // Insert new Game
                        int newIdentity = this.Insert(game);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            game.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update Game
                        saved = this.Update(game);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(Game game)
            /// <summary>
            /// This method Updates a 'Game' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'Game_Update'.</param>
            /// </summary>
            /// <param name='game'>The 'Game' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(Game game)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(game != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.GameMethods.UpdateGame;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateGameParameter(game);
                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, updateMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.Boolean != null) && (returnObject.Boolean.Value == NullableBooleanEnum.True))
                        {
                            // Set saved to true
                            saved = true;
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return saved;
            }
            #endregion

        #endregion

        #region Properties

            #region AppController
            public ApplicationController AppController
            {
                get { return appController; }
                set { appController = value; }
            }
            #endregion

            #region ErrorProcessor
            public ErrorHandler ErrorProcessor
            {
                get { return errorProcessor; }
                set { errorProcessor = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
