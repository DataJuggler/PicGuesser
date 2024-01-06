

#region using statements

using DataJuggler.PixelDatabase;
using ObjectLibrary.BusinessObjects;
using DataAccessComponent.Connection;
using DataAccessComponent.DataGateway;
using DataJuggler.UltimateHelper;
using DataJuggler.Win.Controls;
using Image = ObjectLibrary.BusinessObjects.Image;
using DataJuggler.RandomShuffler;

#endregion

namespace PicGuesser
{

    #region class MainForm
    /// <summary>
    /// This class is the Main Form for this app.
    /// </summary>
    public partial class MainForm : Form
    {

        #region Private Variables
        private List<Pixel> pixels;
        private const int PixelsToGrab = 10000;
        private PixelDatabase pixelDatabase;
        private PixelDatabase copyDatabase;
        private int assignedCount;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();
        }
        #endregion

        #region Events

        #region PixelTimer_Tick(object sender, EventArgs e)
        /// <summary>
        /// event is fired when Pixel Timer _ Tick
        /// </summary>
        private void PixelTimer_Tick(object sender, EventArgs e)
        {
            // If the PixelDatabase object exists
            if ((NullHelper.Exists(CopyDatabase)) && (ListHelper.HasOneOrMoreItems(Pixels)))
            {
                List<Pixel> unassignedPixels = Pixels.Where(x => x.Assigned == false).ToList();

                // If the unassignedPixels collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(unassignedPixels))
                {
                    // local
                    int pixelsAssigned = 0;

                    do
                    {
                        // Create a new instance of a 'RandomShuffler' object.
                        LargeNumberShuffler shuffler = new LargeNumberShuffler(unassignedPixels.Count.ToString().Length, 0, unassignedPixels.Count, DataJuggler.RandomShuffler.Enumerations.NumberOutOfRangeOptionEnum.ReturnModulus);

                        // pull the x and y
                        int index = shuffler.PullNumber();

                        if (index < unassignedPixels.Count)
                        {
                            // Set the Pixel
                            Pixel pixel = unassignedPixels[index];

                            // Won't show up next pull
                            pixel.Assigned = true;
                
                            // Find this pixel
                            // PixelInformation pix = PixelDatabase.GetPixel(pixel.X, pixel.Y);

                            // If the pix object exists
                            if (NullHelper.Exists(pixel))
                            {
                                // Set the Color
                                CopyDatabase.SetPixelColor(pixel.X, pixel.Y, Color.FromArgb(pixel.Alpha, pixel.Red, pixel.Green, pixel.Blue), true, 0);

                                // Increment the value for pixelsAssigned
                                pixelsAssigned++;
                            }
                        }
                    } while (pixelsAssigned < PixelsToGrab);

                    // Setup the Graph
                    if (Graph.Maximum < (AssignedCount + pixelsAssigned))
                    {
                        Graph.Maximum = (AssignedCount + pixelsAssigned + 1000);
                    }
                    AssignedCount += pixelsAssigned;
                    Graph.Value = AssignedCount;

                    // Refresh the UI
                    Refresh();
                    Application.DoEvents();
                }
                else
                {
                    // Done
                    StatusLabel.Text = "Done";

                    // Stop the Timer
                    PixelTimer.Stop();
                }

                // Update the image
                Canvas.BackgroundImage = CopyDatabase.DirectBitmap.Bitmap;

                // Update the UI
                Refresh();
                Application.DoEvents();
            }
        }
        #endregion
            
        #region SaveButton_Click(object sender, EventArgs e)
        /// <summary>
        /// event is fired when the 'SaveButton' is clicked.
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            // get the path selected
            string path = ImageBrowser.Text;

            // If the path string exists
            if (TextHelper.Exists(path))
            {
                // Load our image as a PixelDatabase
                PixelDatabase pixelDatabase = PixelDatabaseLoader.LoadPixelDatabase(path, null);

                // If the pixelDatabase object exists
                if (NullHelper.Exists(pixelDatabase))
                {
                    // Create a file info object
                    FileInfo fileInfo = new FileInfo(path);

                    // Create a new instance of a 'Gateway' object.
                    Gateway gateway = new Gateway(Connection.Name);

                    // Create a new instance of an 'Image' object.
                    Image image = new Image();

                    // Set the name
                    image.Name = fileInfo.Name;
                    image.FullPath = path;
                    image.TotalPixels = pixelDatabase.Width * pixelDatabase.Height;
                    image.Assigned = false;

                    // perform the save
                    bool saved = gateway.SaveImage(ref image);

                    // if the value for saved is true
                    if (saved)
                    {
                        ImageIdControl.Text = image.Id.ToString();

                        // Show a status message
                        StatusLabel.Text = "Saving Pixels. Please wait...";
                        Graph.Visible = true;
                        Graph.Value = 0;
                        Graph.Maximum = image.TotalPixels;

                        // Refresh the UI
                        Refresh();
                        Application.DoEvents();

                        // iterate the x and y
                        for (int x = 0; x < pixelDatabase.Width; x++)
                        {
                            for (int y = 0; y < pixelDatabase.Height; y++)
                            {
                                // Find the Pixel at this location
                                PixelInformation pixelInformation = pixelDatabase.GetPixel(x, y);

                                // If the pixelInformation object exists
                                if (NullHelper.Exists(pixelInformation))
                                {
                                    // Create a new instance of a 'Pixel' object.
                                    Pixel pixel = new Pixel();

                                    // Set the properties
                                    pixel.ImageId = image.Id;
                                    pixel.X = pixelInformation.X;
                                    pixel.Y = pixelInformation.Y;
                                    pixel.Red = pixelInformation.Red;
                                    pixel.Green = pixelInformation.Green;
                                    pixel.Blue = pixelInformation.Blue;
                                    pixel.Alpha = pixelInformation.Alpha;
                                    pixel.Assigned = false;

                                    // Perform the Save
                                    saved = gateway.SavePixel(ref pixel);
                                }

                                // Update the Graph
                                Graph.Value++;

                                // update the UI every 100
                                if (Graph.Value % 100 == 0)
                                {
                                    // Refresh the UI
                                    Refresh();
                                    Application.DoEvents();
                                }
                            }
                        }

                        // Done
                        StatusLabel.Text = "Finished";
                    }
                }
            }
        }
        #endregion

        #region StartButton_Click(object sender, EventArgs e)
        /// <summary>
        /// event is fired when the 'StartButton' is clicked.
        /// </summary>
        private void StartButton_Click(object sender, EventArgs e)
        {
            // 
            int imageId = ImageIdControl.IntValue;

            // Load the PixelDatabase
            // PixelDatabase = PixelDatabaseLoader.LoadPixelDatabase(ImageBrowser.Text, null);

            // hard coded path for the black image
            string path = "C:\\Projects\\GitHub\\PicGuesser\\PicGuesser\\Images\\Black.png";

            // load
            CopyDatabase = PixelDatabaseLoader.LoadPixelDatabase(path, null);

            // if exists
            if (NullHelper.Exists(copyDatabase))
            {
                // Update the image
                Canvas.BackgroundImage = copyDatabase.DirectBitmap.Bitmap;
                Canvas.BackgroundImageLayout = ImageLayout.Stretch;

                // Create a new instance of a 'Gateway' object.
                Gateway gateway = new Gateway(Connection.Name);

                // load the pixels for the ImageId
                Pixels = gateway.LoadPixelsForImageId(imageId);

                // If the pixels collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(Pixels))
                {
                    // Show a message
                    StatusLabel.Text = "Randomly Drawing Pixels";

                    // Setup the Graph
                    Graph.Maximum = Pixels.Count;
                    Graph.Value = 0;
                    Graph.Visible = true;

                    // Start the Timer
                    PixelTimer.Start();
                }
            }
        }
        #endregion

        #endregion

        #region Properties

        #region AssignedCount
        /// <summary>
        /// This property gets or sets the value for 'AssignedCount'.
        /// </summary>
        public int AssignedCount
        {
            get { return assignedCount; }
            set { assignedCount = value; }
        }
        #endregion
            
        #region CopyDatabase
        /// <summary>
        /// This property gets or sets the value for 'CopyDatabase'.
        /// </summary>
        public PixelDatabase CopyDatabase
        {
            get { return copyDatabase; }
            set { copyDatabase = value; }
        }
        #endregion
            
        #region HasCopyDatabase
        /// <summary>
        /// This property returns true if this object has a 'CopyDatabase'.
        /// </summary>
        public bool HasCopyDatabase
        {
            get
            {
                // initial value
                bool hasCopyDatabase = (this.CopyDatabase != null);
                    
                // return value
                return hasCopyDatabase;
            }
        }
        #endregion
            
        #region HasPixelDatabase
        /// <summary>
        /// This property returns true if this object has a 'PixelDatabase'.
        /// </summary>
        public bool HasPixelDatabase
        {
            get
            {
                // initial value
                bool hasPixelDatabase = (this.PixelDatabase != null);
                    
                // return value
                return hasPixelDatabase;
            }
        }
        #endregion
            
        #region HasPixels
        /// <summary>
        /// This property returns true if this object has a 'Pixels'.
        /// </summary>
        public bool HasPixels
        {
            get
            {
                // initial value
                bool hasPixels = (this.Pixels != null);

                // return value
                return hasPixels;
            }
        }
        #endregion

        #region PixelDatabase
        /// <summary>
        /// This property gets or sets the value for 'PixelDatabase'.
        /// </summary>
        public PixelDatabase PixelDatabase
        {
            get { return pixelDatabase; }
            set { pixelDatabase = value; }
        }
        #endregion
            
        #region Pixels
        /// <summary>
        /// This property gets or sets the value for 'Pixels'.
        /// </summary>
        public List<Pixel> Pixels
        {
            get { return pixels; }
            set { pixels = value; }
        }
        #endregion

        #endregion

    }
    #endregion

}
