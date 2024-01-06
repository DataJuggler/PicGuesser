

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

    #region class DataManager
    /// <summary>
    /// This class manages data operations for this project.
    /// </summary>
    public class DataManager
    {

        #region Private Variables
        private DataConnector dataConnector;
        private string connectionName;
        private GameManager gameManager;
        private GameImageViewManager gameimageviewManager;
        private ImageManager imageManager;
        private PixelManager pixelManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new instance of a(n) 'DataManager' object.
        /// </summary>
        public DataManager(string connectionName = "")
        {
            // Store the ConnectionName arg
            this.ConnectionName = connectionName;

            // Perform Initializations For This Object.
            Init();
        }
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// Perform Initializations For This Object.
            /// Create the DataConnector and the Child Object Managers.
            /// </summary>
            private void Init()
            {
                // Create New DataConnector
                this.DataConnector = new DataConnector();

                // Create Child Object Managers
                this.GameManager = new GameManager(this);
                this.GameImageViewManager = new GameImageViewManager(this);
                this.ImageManager = new ImageManager(this);
                this.PixelManager = new PixelManager(this);
            }
            #endregion

        #endregion

        #region Properties

            #region DataConnector
            public DataConnector DataConnector
            {
                get { return dataConnector; }
                set { dataConnector = value; }
            }
            #endregion

            #region ConnectionName
            public string ConnectionName
            {
                get { return connectionName; }
                set { connectionName = value; }
            }
            #endregion

            #region GameManager
            public GameManager GameManager
            {
                get { return gameManager; }
                set { gameManager = value; }
            }
            #endregion

            #region GameImageViewManager
            public GameImageViewManager GameImageViewManager
            {
                get { return gameimageviewManager; }
                set { gameimageviewManager = value; }
            }
            #endregion

            #region ImageManager
            public ImageManager ImageManager
            {
                get { return imageManager; }
                set { imageManager = value; }
            }
            #endregion

            #region PixelManager
            public PixelManager PixelManager
            {
                get { return pixelManager; }
                set { pixelManager = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
