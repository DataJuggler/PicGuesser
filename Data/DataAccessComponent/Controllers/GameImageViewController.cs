

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

    #region class GameImageViewController
    /// <summary>
    /// This class controls a(n) 'GameImageView' object.
    /// </summary>
    public class GameImageViewController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'GameImageViewController' object.
        /// </summary>
        public GameImageViewController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateGameImageViewParameter
            /// <summary>
            /// This method creates the parameter for a 'GameImageView' data operation.
            /// </summary>
            /// <param name='gameimageview'>The 'GameImageView' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private static List<PolymorphicObject> CreateGameImageViewParameter(GameImageView gameImageView)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = gameImageView;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region FetchAll(GameImageView tempGameImageView)
            /// <summary>
            /// This method fetches a collection of 'GameImageView' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'GameImageView_FetchAll'.</summary>
            /// <param name='tempGameImageView'>A temporary GameImageView for passing values.</param>
            /// <returns>A collection of 'GameImageView' objects.</returns>
            public List<GameImageView> FetchAll(GameImageView tempGameImageView)
            {
                // Initial value
                List<GameImageView> gameImageViewList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.GameImageViewMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateGameImageViewParameter(tempGameImageView);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<GameImageView> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        gameImageViewList = (List<GameImageView>) returnObject.ObjectValue;
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
                return gameImageViewList;
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
