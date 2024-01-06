

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

    #region class ControllerManager
    /// <summary>
    /// This class manages the child controllers for this application.
    /// </summary>
    public class ControllerManager
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        private GameController gameController;
        private GameImageViewController gameimageviewController;
        private ImageController imageController;
        private PixelController pixelController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'ControllerManager' object.
        /// </summary>
        public ControllerManager(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;

            // Create Child Controllers
            Init();
        }
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// Create Child Controllers
            /// </summary>
            private void Init()
            {
                // Create Child Controllers
                this.GameController = new GameController(this.ErrorProcessor, this.AppController);
                this.GameImageViewController = new GameImageViewController(this.ErrorProcessor, this.AppController);
                this.ImageController = new ImageController(this.ErrorProcessor, this.AppController);
                this.PixelController = new PixelController(this.ErrorProcessor, this.AppController);
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

            #region GameController
            public GameController GameController
            {
                get { return gameController; }
                set { gameController = value; }
            }
            #endregion

            #region GameImageViewController
            public GameImageViewController GameImageViewController
            {
                get { return gameimageviewController; }
                set { gameimageviewController = value; }
            }
            #endregion

            #region ImageController
            public ImageController ImageController
            {
                get { return imageController; }
                set { imageController = value; }
            }
            #endregion

            #region PixelController
            public PixelController PixelController
            {
                get { return pixelController; }
                set { pixelController = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
