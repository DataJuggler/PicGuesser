

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

    #region class PixelController
    /// <summary>
    /// This class controls a(n) 'Pixel' object.
    /// </summary>
    public class PixelController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'PixelController' object.
        /// </summary>
        public PixelController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreatePixelParameter
            /// <summary>
            /// This method creates the parameter for a 'Pixel' data operation.
            /// </summary>
            /// <param name='pixel'>The 'Pixel' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private static List<PolymorphicObject> CreatePixelParameter(Pixel pixel)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = pixel;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(Pixel tempPixel)
            /// <summary>
            /// Deletes a 'Pixel' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'Pixel_Delete'.
            /// </summary>
            /// <param name='pixel'>The 'Pixel' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(Pixel tempPixel)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeletePixel";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify temppixel exists before attemptintg to delete
                    if(tempPixel != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deletePixelMethod = this.AppController.DataBridge.DataOperations.PixelMethods.DeletePixel;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreatePixelParameter(tempPixel);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deletePixelMethod, parameters);

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

            #region FetchAll(Pixel tempPixel)
            /// <summary>
            /// This method fetches a collection of 'Pixel' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'Pixel_FetchAll'.</summary>
            /// <param name='tempPixel'>A temporary Pixel for passing values.</param>
            /// <returns>A collection of 'Pixel' objects.</returns>
            public List<Pixel> FetchAll(Pixel tempPixel)
            {
                // Initial value
                List<Pixel> pixelList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.PixelMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreatePixelParameter(tempPixel);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<Pixel> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        pixelList = (List<Pixel>) returnObject.ObjectValue;
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
                return pixelList;
            }
            #endregion

            #region Find(Pixel tempPixel)
            /// <summary>
            /// Finds a 'Pixel' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'Pixel_Find'</param>
            /// </summary>
            /// <param name='tempPixel'>A temporary Pixel for passing values.</param>
            /// <returns>A 'Pixel' object if found else a null 'Pixel'.</returns>
            public Pixel Find(Pixel tempPixel)
            {
                // Initial values
                Pixel pixel = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempPixel != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.PixelMethods.FindPixel;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreatePixelParameter(tempPixel);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as Pixel != null))
                        {
                            // Get ReturnObject
                            pixel = (Pixel) returnObject.ObjectValue;
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
                return pixel;
            }
            #endregion

            #region Insert(Pixel pixel)
            /// <summary>
            /// Insert a 'Pixel' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'Pixel_Insert'.</param>
            /// </summary>
            /// <param name='pixel'>The 'Pixel' object to insert.</param>
            /// <returns>The id (int) of the new  'Pixel' object that was inserted.</returns>
            public int Insert(Pixel pixel)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If Pixelexists
                    if(pixel != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.PixelMethods.InsertPixel;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreatePixelParameter(pixel);

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

            #region Save(ref Pixel pixel)
            /// <summary>
            /// Saves a 'Pixel' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='pixel'>The 'Pixel' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref Pixel pixel)
            {
                // Initial value
                bool saved = false;

                // If the pixel exists.
                if(pixel != null)
                {
                    // Is this a new Pixel
                    if(pixel.IsNew)
                    {
                        // Insert new Pixel
                        int newIdentity = this.Insert(pixel);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            pixel.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update Pixel
                        saved = this.Update(pixel);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(Pixel pixel)
            /// <summary>
            /// This method Updates a 'Pixel' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'Pixel_Update'.</param>
            /// </summary>
            /// <param name='pixel'>The 'Pixel' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(Pixel pixel)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(pixel != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.PixelMethods.UpdatePixel;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreatePixelParameter(pixel);
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
