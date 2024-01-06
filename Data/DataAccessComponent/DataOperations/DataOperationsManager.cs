

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

    #region class DataOperationsManager
    /// <summary>
    /// This class manages DataOperations for this project.
    /// </summary>
    public class DataOperationsManager
    {

        #region Private Variables
        private DataManager dataManager;
        private SystemMethods systemMethods;
        private GameMethods gameMethods;
        private GameImageViewMethods gameimageviewMethods;
        private ImageMethods imageMethods;
        private PixelMethods pixelMethods;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'DataOperationsManager' object.
        /// </summary>
        public DataOperationsManager(DataManager dataManagerArg)
        {
            // Save Arguments
            this.DataManager = dataManagerArg;

            // Create Child DataOperationMethods
            Init();
        }
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// Create Child DataOperationMethods
            /// </summary>
            private void Init()
            {
                // Create Child DataOperatonMethods
                this.SystemMethods = new SystemMethods();
                this.GameMethods = new GameMethods(this.DataManager);
                this.GameImageViewMethods = new GameImageViewMethods(this.DataManager);
                this.ImageMethods = new ImageMethods(this.DataManager);
                this.PixelMethods = new PixelMethods(this.DataManager);
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

            #region SystemMethods
            public SystemMethods SystemMethods
            {
                get { return systemMethods; }
                set { systemMethods = value; }
            }
            #endregion

            #region GameMethods
            public GameMethods GameMethods
            {
                get { return gameMethods; }
                set { gameMethods = value; }
            }
            #endregion

            #region GameImageViewMethods
            public GameImageViewMethods GameImageViewMethods
            {
                get { return gameimageviewMethods; }
                set { gameimageviewMethods = value; }
            }
            #endregion

            #region ImageMethods
            public ImageMethods ImageMethods
            {
                get { return imageMethods; }
                set { imageMethods = value; }
            }
            #endregion

            #region PixelMethods
            public PixelMethods PixelMethods
            {
                get { return pixelMethods; }
                set { pixelMethods = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
