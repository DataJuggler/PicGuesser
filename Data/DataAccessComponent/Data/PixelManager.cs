

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

    #region class PixelManager
    /// <summary>
    /// This class is used to manage a 'Pixel' object.
    /// </summary>
    public class PixelManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'PixelManager' object.
        /// </summary>
        public PixelManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeletePixel()
            /// <summary>
            /// This method deletes a 'Pixel' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeletePixel(DeletePixelStoredProcedure deletePixelProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deletePixelProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllPixels()
            /// <summary>
            /// This method fetches a  'List<Pixel>' object.
            /// This method uses the 'Pixels_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<Pixel>'</returns>
            /// </summary>
            public List<Pixel> FetchAllPixels(FetchAllPixelsStoredProcedure fetchAllPixelsProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<Pixel> pixelCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allPixelsDataSet = this.DataHelper.LoadDataSet(fetchAllPixelsProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allPixelsDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allPixelsDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            pixelCollection = PixelReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return pixelCollection;
            }
            #endregion

            #region FindPixel()
            /// <summary>
            /// This method finds a  'Pixel' object.
            /// This method uses the 'Pixel_Find' procedure.
            /// </summary>
            /// <returns>A 'Pixel' object.</returns>
            /// </summary>
            public Pixel FindPixel(FindPixelStoredProcedure findPixelProc, DataConnector databaseConnector)
            {
                // Initial Value
                Pixel pixel = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet pixelDataSet = this.DataHelper.LoadDataSet(findPixelProc, databaseConnector);

                    // Verify DataSet Exists
                    if(pixelDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(pixelDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load Pixel
                            pixel = PixelReader.Load(row);
                        }
                    }
                }

                // return value
                return pixel;
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

            #region InsertPixel()
            /// <summary>
            /// This method inserts a 'Pixel' object.
            /// This method uses the 'Pixel_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertPixel(InsertPixelStoredProcedure insertPixelProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertPixelProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdatePixel()
            /// <summary>
            /// This method updates a 'Pixel'.
            /// This method uses the 'Pixel_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdatePixel(UpdatePixelStoredProcedure updatePixelProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updatePixelProc, databaseConnector);
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
