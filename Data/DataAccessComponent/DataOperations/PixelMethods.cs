

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

    #region class PixelMethods
    /// <summary>
    /// This class contains methods for modifying a 'Pixel' object.
    /// </summary>
    public class PixelMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'PixelMethods' object.
        /// </summary>
        public PixelMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeletePixel(Pixel)
            /// <summary>
            /// This method deletes a 'Pixel' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Pixel' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeletePixel(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeletePixelStoredProcedure deletePixelProc = null;

                    // verify the first parameters is a(n) 'Pixel'.
                    if (parameters[0].ObjectValue as Pixel != null)
                    {
                        // Create Pixel
                        Pixel pixel = (Pixel) parameters[0].ObjectValue;

                        // verify pixel exists
                        if(pixel != null)
                        {
                            // Now create deletePixelProc from PixelWriter
                            // The DataWriter converts the 'Pixel'
                            // to the SqlParameter[] array needed to delete a 'Pixel'.
                            deletePixelProc = PixelWriter.CreateDeletePixelStoredProcedure(pixel);
                        }
                    }

                    // Verify deletePixelProc exists
                    if(deletePixelProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.PixelManager.DeletePixel(deletePixelProc, dataConnector);

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
            /// This method fetches all 'Pixel' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Pixel' to delete.
            /// <returns>A PolymorphicObject object with all  'Pixels' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<Pixel> pixelListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllPixelsStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get PixelParameter
                    // Declare Parameter
                    Pixel paramPixel = null;

                    // verify the first parameters is a(n) 'Pixel'.
                    if (parameters[0].ObjectValue as Pixel != null)
                    {
                        // Get PixelParameter
                        paramPixel = (Pixel) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllPixelsProc from PixelWriter
                    fetchAllProc = PixelWriter.CreateFetchAllPixelsStoredProcedure(paramPixel);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    pixelListCollection = this.DataManager.PixelManager.FetchAllPixels(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(pixelListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = pixelListCollection;
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

            #region FindPixel(Pixel)
            /// <summary>
            /// This method finds a 'Pixel' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Pixel' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindPixel(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Pixel pixel = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindPixelStoredProcedure findPixelProc = null;

                    // verify the first parameters is a 'Pixel'.
                    if (parameters[0].ObjectValue as Pixel != null)
                    {
                        // Get PixelParameter
                        Pixel paramPixel = (Pixel) parameters[0].ObjectValue;

                        // verify paramPixel exists
                        if(paramPixel != null)
                        {
                            // Now create findPixelProc from PixelWriter
                            // The DataWriter converts the 'Pixel'
                            // to the SqlParameter[] array needed to find a 'Pixel'.
                            findPixelProc = PixelWriter.CreateFindPixelStoredProcedure(paramPixel);
                        }

                        // Verify findPixelProc exists
                        if(findPixelProc != null)
                        {
                            // Execute Find Stored Procedure
                            pixel = this.DataManager.PixelManager.FindPixel(findPixelProc, dataConnector);

                            // if dataObject exists
                            if(pixel != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = pixel;
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

            #region InsertPixel (Pixel)
            /// <summary>
            /// This method inserts a 'Pixel' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Pixel' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertPixel(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Pixel pixel = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertPixelStoredProcedure insertPixelProc = null;

                    // verify the first parameters is a(n) 'Pixel'.
                    if (parameters[0].ObjectValue as Pixel != null)
                    {
                        // Create Pixel Parameter
                        pixel = (Pixel) parameters[0].ObjectValue;

                        // verify pixel exists
                        if(pixel != null)
                        {
                            // Now create insertPixelProc from PixelWriter
                            // The DataWriter converts the 'Pixel'
                            // to the SqlParameter[] array needed to insert a 'Pixel'.
                            insertPixelProc = PixelWriter.CreateInsertPixelStoredProcedure(pixel);
                        }

                        // Verify insertPixelProc exists
                        if(insertPixelProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.PixelManager.InsertPixel(insertPixelProc, dataConnector);
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

            #region UpdatePixel (Pixel)
            /// <summary>
            /// This method updates a 'Pixel' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Pixel' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdatePixel(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Pixel pixel = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdatePixelStoredProcedure updatePixelProc = null;

                    // verify the first parameters is a(n) 'Pixel'.
                    if (parameters[0].ObjectValue as Pixel != null)
                    {
                        // Create Pixel Parameter
                        pixel = (Pixel) parameters[0].ObjectValue;

                        // verify pixel exists
                        if(pixel != null)
                        {
                            // Now create updatePixelProc from PixelWriter
                            // The DataWriter converts the 'Pixel'
                            // to the SqlParameter[] array needed to update a 'Pixel'.
                            updatePixelProc = PixelWriter.CreateUpdatePixelStoredProcedure(pixel);
                        }

                        // Verify updatePixelProc exists
                        if(updatePixelProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.PixelManager.UpdatePixel(updatePixelProc, dataConnector);

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
