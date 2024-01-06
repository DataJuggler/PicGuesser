
#region using statements

using DataAccessComponent.Controllers;
using DataAccessComponent.DataOperations;
using DataAccessComponent.Data;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

#endregion

namespace DataAccessComponent.DataGateway
{

    #region class Gateway
    /// <summary>
    /// This class is used to manage DataOperations
    /// between the client and the DataAccessComponent.
    /// Do not change the method name or the parameters for the
    /// code generated methods or they will be recreated the next 
    /// time you code generate with DataTier.Net. If you need additional
    /// parameters passed to a method either create an override or
    /// add or set properties to the temp object that is passed in.
    /// </summary>
    public class Gateway
    {

        #region Private Variables
        private ApplicationController appController;
        private string connectionName;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a Gateway object.
        /// </summary>
        public Gateway(string connectionName = "")
        {
            // store the ConnectionName
            this.ConnectionName = connectionName;

            // Perform Initializations for this object
            Init();
        }
        #endregion

        #region Methods
        
            #region DeleteGame(int id, Game tempGame = null)
            /// <summary>
            /// This method is used to delete Game objects.
            /// </summary>
            /// <param name="id">Delete the Game with this id</param>
            /// <param name="tempGame">Pass in a tempGame to perform a custom delete.</param>
            public bool DeleteGame(int id, Game tempGame = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempGame does not exist
                    if (tempGame == null)
                    {
                        // create a temp Game
                        tempGame = new Game();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempGame.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.GameController.Delete(tempGame);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteImage(int id, Image tempImage = null)
            /// <summary>
            /// This method is used to delete Image objects.
            /// </summary>
            /// <param name="id">Delete the Image with this id</param>
            /// <param name="tempImage">Pass in a tempImage to perform a custom delete.</param>
            public bool DeleteImage(int id, Image tempImage = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempImage does not exist
                    if (tempImage == null)
                    {
                        // create a temp Image
                        tempImage = new Image();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempImage.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.ImageController.Delete(tempImage);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeletePixel(int id, Pixel tempPixel = null)
            /// <summary>
            /// This method is used to delete Pixel objects.
            /// </summary>
            /// <param name="id">Delete the Pixel with this id</param>
            /// <param name="tempPixel">Pass in a tempPixel to perform a custom delete.</param>
            public bool DeletePixel(int id, Pixel tempPixel = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempPixel does not exist
                    if (tempPixel == null)
                    {
                        // create a temp Pixel
                        tempPixel = new Pixel();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempPixel.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.PixelController.Delete(tempPixel);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region ExecuteNonQuery(string procedureName, SqlParameter[] sqlParameters)
            /// <summary>
            /// This method Executes a Non Query StoredProcedure
            /// </summary>
            public PolymorphicObject ExecuteNonQuery(string procedureName, SqlParameter[] sqlParameters)
            {
                // initial value
                PolymorphicObject returnValue = new PolymorphicObject();

                // locals
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // create the parameters
                PolymorphicObject procedureNameParameter = new PolymorphicObject();
                PolymorphicObject sqlParametersParameter = new PolymorphicObject();

                // if the procedureName exists
                if (!String.IsNullOrEmpty(procedureName))
                {
                    // Create an instance of the SystemMethods object
                    SystemMethods systemMethods = new SystemMethods();

                    // setup procedureNameParameter
                    procedureNameParameter.Name = "ProcedureName";
                    procedureNameParameter.Text = procedureName;

                    // setup sqlParametersParameter
                    sqlParametersParameter.Name = "SqlParameters";
                    sqlParametersParameter.ObjectValue = sqlParameters;

                    // Add these parameters to the parameters
                    parameters.Add(procedureNameParameter);
                    parameters.Add(sqlParametersParameter);

                    // get the dataConnector
                    DataAccessComponent.Data.DataConnector dataConnector = GetDataConnector();

                    // Execute the query
                    returnValue = systemMethods.ExecuteNonQuery(parameters, dataConnector);
                }

                // return value
                return returnValue;
            }
            #endregion

            #region FindGame(int id, Game tempGame = null)
            /// <summary>
            /// This method is used to find 'Game' objects.
            /// </summary>
            /// <param name="id">Find the Game with this id</param>
            /// <param name="tempGame">Pass in a tempGame to perform a custom find.</param>
            public Game FindGame(int id, Game tempGame = null)
            {
                // initial value
                Game game = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempGame does not exist
                    if (tempGame == null)
                    {
                        // create a temp Game
                        tempGame = new Game();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempGame.UpdateIdentity(id);
                    }

                    // perform the find
                    game = this.AppController.ControllerManager.GameController.Find(tempGame);
                }

                // return value
                return game;
            }
            #endregion

            #region FindImage(int id, Image tempImage = null)
            /// <summary>
            /// This method is used to find 'Image' objects.
            /// </summary>
            /// <param name="id">Find the Image with this id</param>
            /// <param name="tempImage">Pass in a tempImage to perform a custom find.</param>
            public Image FindImage(int id, Image tempImage = null)
            {
                // initial value
                Image image = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempImage does not exist
                    if (tempImage == null)
                    {
                        // create a temp Image
                        tempImage = new Image();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempImage.UpdateIdentity(id);
                    }

                    // perform the find
                    image = this.AppController.ControllerManager.ImageController.Find(tempImage);
                }

                // return value
                return image;
            }
            #endregion

            #region FindPixel(int id, Pixel tempPixel = null)
            /// <summary>
            /// This method is used to find 'Pixel' objects.
            /// </summary>
            /// <param name="id">Find the Pixel with this id</param>
            /// <param name="tempPixel">Pass in a tempPixel to perform a custom find.</param>
            public Pixel FindPixel(int id, Pixel tempPixel = null)
            {
                // initial value
                Pixel pixel = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempPixel does not exist
                    if (tempPixel == null)
                    {
                        // create a temp Pixel
                        tempPixel = new Pixel();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempPixel.UpdateIdentity(id);
                    }

                    // perform the find
                    pixel = this.AppController.ControllerManager.PixelController.Find(tempPixel);
                }

                // return value
                return pixel;
            }
            #endregion

            #region GetDataConnector()
            /// <summary>
            /// This method (safely) returns the Data Connector from the
            /// AppController.DataBridget.DataManager.DataConnector
            /// </summary>
            private DataConnector GetDataConnector()
            {
                // initial value
                DataConnector dataConnector = null;

                // if the AppController exists
                if (this.AppController != null)
                {
                    // return the DataConnector from the AppController
                    dataConnector = this.AppController.GetDataConnector();
                }

                // return value
                return dataConnector;
            }
            #endregion

            #region GetLastException()
            /// <summary>
            /// This method returns the last Exception from the AppController if one exists.
            /// Always test for null before refeferencing the Exception returned as it will be null 
            /// if no errors were encountered.
            /// </summary>
            /// <returns></returns>
            public Exception GetLastException()
            {
                // initial value
                Exception exception = null;

                // If the AppController object exists
                if (this.HasAppController)
                {
                    // return the Exception from the AppController
                    exception = this.AppController.Exception;

                    // Set to null after the exception is retrieved so it does not return again
                    this.AppController.Exception = null;
                }

                // return value
                return exception;
            }
            #endregion

            #region Init()
            /// <summary>
            /// Perform Initializations for this object.
            /// </summary>
            private void Init()
            {
                // Create Application Controller
                this.AppController = new ApplicationController(ConnectionName);
            }
            #endregion

            #region LoadGameImageViews(GameImageView tempGameImageView = null)
            /// <summary>
            /// This method loads a collection of 'GameImageView' objects.
            /// </summary>
            public List<GameImageView> LoadGameImageViews(GameImageView tempGameImageView = null)
            {
                // initial value
                List<GameImageView> gameImageViews = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    gameImageViews = this.AppController.ControllerManager.GameImageViewController.FetchAll(tempGameImageView);
                }

                // return value
                return gameImageViews;
            }
            #endregion

            #region LoadGames(Game tempGame = null)
            /// <summary>
            /// This method loads a collection of 'Game' objects.
            /// </summary>
            public List<Game> LoadGames(Game tempGame = null)
            {
                // initial value
                List<Game> games = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    games = this.AppController.ControllerManager.GameController.FetchAll(tempGame);
                }

                // return value
                return games;
            }
            #endregion

            #region LoadImages(Image tempImage = null)
            /// <summary>
            /// This method loads a collection of 'Image' objects.
            /// </summary>
            public List<Image> LoadImages(Image tempImage = null)
            {
                // initial value
                List<Image> images = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    images = this.AppController.ControllerManager.ImageController.FetchAll(tempImage);
                }

                // return value
                return images;
            }
            #endregion

            #region LoadPixels(Pixel tempPixel = null)
            /// <summary>
            /// This method loads a collection of 'Pixel' objects.
            /// </summary>
            public List<Pixel> LoadPixels(Pixel tempPixel = null)
            {
                // initial value
                List<Pixel> pixels = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    pixels = this.AppController.ControllerManager.PixelController.FetchAll(tempPixel);
                }

                // return value
                return pixels;
            }
            #endregion

                #region LoadPixelsForImageId(int imageId)
                /// <summary>
                /// This method is used to load 'Pixel' objects for the ImageId given.
                /// </summary>
                public List<Pixel> LoadPixelsForImageId(int imageId)
                {
                    // initial value
                    List<Pixel> pixels = null;
                    
                    // Create a temp Pixel object
                    Pixel tempPixel = new Pixel();
                    
                    // Set the value for LoadByImageId to true
                    tempPixel.LoadByImageId = true;
                    
                    // Set the value for ImageId
                    tempPixel.ImageId = imageId;
                    
                    // Perform the load
                    pixels = LoadPixels(tempPixel);
                    
                    // return value
                    return pixels;
                }
                #endregion
                
            #region SaveGame(ref Game game)
            /// <summary>
            /// This method is used to save 'Game' objects.
            /// </summary>
            /// <param name="game">The Game to save.</param>
            public bool SaveGame(ref Game game)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.GameController.Save(ref game);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveImage(ref Image image)
            /// <summary>
            /// This method is used to save 'Image' objects.
            /// </summary>
            /// <param name="image">The Image to save.</param>
            public bool SaveImage(ref Image image)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.ImageController.Save(ref image);
                }

                // return value
                return saved;
            }
            #endregion

            #region SavePixel(ref Pixel pixel)
            /// <summary>
            /// This method is used to save 'Pixel' objects.
            /// </summary>
            /// <param name="pixel">The Pixel to save.</param>
            public bool SavePixel(ref Pixel pixel)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.PixelController.Save(ref pixel);
                }

                // return value
                return saved;
            }
            #endregion

        #endregion

        #region Properties

            #region AppController
            /// <summary>
            /// This property gets or sets the value for 'AppController'.
            /// </summary>
            public ApplicationController AppController
            {
                get { return appController; }
                set { appController = value; }
            }
            #endregion

            #region ConnectionName
            /// <summary>
            /// This property gets or sets the value for 'ConnectionName'.
            /// </summary>
            public string ConnectionName
            {
                get { return connectionName; }
                set { connectionName = value; }
            }
            #endregion
            
            #region HasAppController
            /// <summary>
            /// This property returns true if this object has an 'AppController'.
            /// </summary>
            public bool HasAppController
            {
                get
                {
                    // initial value
                    bool hasAppController = (this.AppController != null);

                    // return value
                    return hasAppController;
                }
            }
            #endregion

            #region HasConnectionName
            /// <summary>
            /// This property returns true if the 'ConnectionName' exists.
            /// </summary>
            public bool HasConnectionName
            {
                get
                {
                    // initial value
                    bool hasConnectionName = (!String.IsNullOrEmpty(this.ConnectionName));
                    
                    // return value
                    return hasConnectionName;
                }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
