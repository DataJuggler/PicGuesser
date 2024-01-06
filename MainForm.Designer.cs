namespace PicGuesser
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            PixelTimer = new System.Windows.Forms.Timer(components);
            LeftMarginPanel = new DataJuggler.Win.Controls.Objects.PanelExtender();
            RightMarginPanel = new DataJuggler.Win.Controls.Objects.PanelExtender();
            TopPanel = new DataJuggler.Win.Controls.Objects.PanelExtender();
            ImageIdControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            ImageBrowser = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            StartButton = new DataJuggler.Win.Controls.Button();
            SaveButton = new DataJuggler.Win.Controls.Button();
            BottomMarginPanel = new DataJuggler.Win.Controls.Objects.PanelExtender();
            BottomPanel = new DataJuggler.Win.Controls.Objects.PanelExtender();
            Graph = new ProgressBar();
            StatusLabel = new Label();
            Canvas = new PictureBox();
            TopPanel.SuspendLayout();
            BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Canvas).BeginInit();
            SuspendLayout();
            // 
            // PixelTimer
            // 
            PixelTimer.Interval = 1000;
            PixelTimer.Tick += PixelTimer_Tick;
            // 
            // LeftMarginPanel
            // 
            LeftMarginPanel.Dock = DockStyle.Left;
            LeftMarginPanel.Location = new Point(0, 0);
            LeftMarginPanel.Name = "LeftMarginPanel";
            LeftMarginPanel.Size = new Size(16, 772);
            LeftMarginPanel.TabIndex = 8;
            // 
            // RightMarginPanel
            // 
            RightMarginPanel.Dock = DockStyle.Right;
            RightMarginPanel.Location = new Point(1223, 0);
            RightMarginPanel.Name = "RightMarginPanel";
            RightMarginPanel.Size = new Size(16, 772);
            RightMarginPanel.TabIndex = 9;
            // 
            // TopPanel
            // 
            TopPanel.Controls.Add(ImageIdControl);
            TopPanel.Controls.Add(ImageBrowser);
            TopPanel.Controls.Add(StartButton);
            TopPanel.Controls.Add(SaveButton);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(16, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(1207, 76);
            TopPanel.TabIndex = 10;
            // 
            // ImageIdControl
            // 
            ImageIdControl.BackColor = Color.Transparent;
            ImageIdControl.BottomMargin = 0;
            ImageIdControl.Editable = true;
            ImageIdControl.Encrypted = false;
            ImageIdControl.Font = new Font("Verdana", 12F, FontStyle.Bold);
            ImageIdControl.Inititialized = true;
            ImageIdControl.LabelBottomMargin = 0;
            ImageIdControl.LabelColor = Color.LemonChiffon;
            ImageIdControl.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
            ImageIdControl.LabelText = "Image Id:";
            ImageIdControl.LabelTopMargin = 0;
            ImageIdControl.LabelWidth = 120;
            ImageIdControl.Location = new Point(626, 28);
            ImageIdControl.MultiLine = false;
            ImageIdControl.Name = "ImageIdControl";
            ImageIdControl.OnTextChangedListener = null;
            ImageIdControl.PasswordMode = false;
            ImageIdControl.ScrollBars = ScrollBars.None;
            ImageIdControl.Size = new Size(249, 32);
            ImageIdControl.TabIndex = 10;
            ImageIdControl.TextBoxBottomMargin = 0;
            ImageIdControl.TextBoxDisabledColor = Color.LightGray;
            ImageIdControl.TextBoxEditableColor = Color.White;
            ImageIdControl.TextBoxFont = new Font("Verdana", 12F);
            ImageIdControl.TextBoxTopMargin = 0;
            ImageIdControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // ImageBrowser
            // 
            ImageBrowser.BackColor = Color.Transparent;
            ImageBrowser.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            ImageBrowser.ButtonColor = Color.LemonChiffon;
            ImageBrowser.ButtonImage = (Image)resources.GetObject("ImageBrowser.ButtonImage");
            ImageBrowser.ButtonWidth = 48;
            ImageBrowser.DarkMode = false;
            ImageBrowser.DisabledLabelColor = Color.Empty;
            ImageBrowser.Editable = true;
            ImageBrowser.EnabledLabelColor = Color.Empty;
            ImageBrowser.Filter = null;
            ImageBrowser.Font = new Font("Verdana", 12F);
            ImageBrowser.HideBrowseButton = false;
            ImageBrowser.LabelBottomMargin = 0;
            ImageBrowser.LabelColor = Color.LemonChiffon;
            ImageBrowser.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
            ImageBrowser.LabelText = "Image:";
            ImageBrowser.LabelTopMargin = 0;
            ImageBrowser.LabelWidth = 120;
            ImageBrowser.Location = new Point(38, 28);
            ImageBrowser.Name = "ImageBrowser";
            ImageBrowser.OnTextChangedListener = null;
            ImageBrowser.OpenCallback = null;
            ImageBrowser.ScrollBars = ScrollBars.None;
            ImageBrowser.SelectedPath = null;
            ImageBrowser.Size = new Size(525, 32);
            ImageBrowser.StartPath = null;
            ImageBrowser.TabIndex = 9;
            ImageBrowser.TextBoxBottomMargin = 0;
            ImageBrowser.TextBoxDisabledColor = Color.Empty;
            ImageBrowser.TextBoxEditableColor = Color.Empty;
            ImageBrowser.TextBoxFont = new Font("Verdana", 12F);
            ImageBrowser.TextBoxTopMargin = 0;
            ImageBrowser.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // StartButton
            // 
            StartButton.BackColor = Color.Transparent;
            StartButton.ButtonText = "Start";
            StartButton.FlatStyle = FlatStyle.Flat;
            StartButton.ForeColor = Color.LemonChiffon;
            StartButton.Location = new Point(1080, 16);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(120, 44);
            StartButton.TabIndex = 8;
            StartButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            StartButton.Click += StartButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.Transparent;
            SaveButton.ButtonText = "Save";
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.ForeColor = Color.LemonChiffon;
            SaveButton.Location = new Point(933, 16);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(120, 44);
            SaveButton.TabIndex = 7;
            SaveButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            SaveButton.Click += SaveButton_Click;
            // 
            // BottomMarginPanel
            // 
            BottomMarginPanel.Dock = DockStyle.Bottom;
            BottomMarginPanel.Location = new Point(16, 756);
            BottomMarginPanel.Name = "BottomMarginPanel";
            BottomMarginPanel.Size = new Size(1207, 16);
            BottomMarginPanel.TabIndex = 12;
            // 
            // BottomPanel
            // 
            BottomPanel.Controls.Add(Graph);
            BottomPanel.Controls.Add(StatusLabel);
            BottomPanel.Dock = DockStyle.Bottom;
            BottomPanel.Location = new Point(16, 708);
            BottomPanel.Name = "BottomPanel";
            BottomPanel.Size = new Size(1207, 48);
            BottomPanel.TabIndex = 13;
            // 
            // Graph
            // 
            Graph.Dock = DockStyle.Fill;
            Graph.Location = new Point(0, 24);
            Graph.Name = "Graph";
            Graph.Size = new Size(1207, 24);
            Graph.TabIndex = 6;
            Graph.Visible = false;
            // 
            // StatusLabel
            // 
            StatusLabel.Dock = DockStyle.Top;
            StatusLabel.ForeColor = Color.LemonChiffon;
            StatusLabel.Location = new Point(0, 0);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(1207, 24);
            StatusLabel.TabIndex = 5;
            // 
            // Canvas
            // 
            Canvas.Dock = DockStyle.Fill;
            Canvas.Location = new Point(16, 76);
            Canvas.Name = "Canvas";
            Canvas.Size = new Size(1207, 632);
            Canvas.TabIndex = 14;
            Canvas.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            ClientSize = new Size(1239, 772);
            Controls.Add(Canvas);
            Controls.Add(BottomPanel);
            Controls.Add(BottomMarginPanel);
            Controls.Add(TopPanel);
            Controls.Add(RightMarginPanel);
            Controls.Add(LeftMarginPanel);
            Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pic Guesser";
            WindowState = FormWindowState.Maximized;
            TopPanel.ResumeLayout(false);
            BottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Canvas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer PixelTimer;
        private DataJuggler.Win.Controls.Objects.PanelExtender LeftMarginPanel;
        private DataJuggler.Win.Controls.Objects.PanelExtender RightMarginPanel;
        private DataJuggler.Win.Controls.Objects.PanelExtender TopPanel;
        private DataJuggler.Win.Controls.LabelTextBoxControl ImageIdControl;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl ImageBrowser;
        private DataJuggler.Win.Controls.Button StartButton;
        private DataJuggler.Win.Controls.Button SaveButton;
        private DataJuggler.Win.Controls.Objects.PanelExtender BottomMarginPanel;
        private DataJuggler.Win.Controls.Objects.PanelExtender BottomPanel;
        private ProgressBar Graph;
        private Label StatusLabel;
        private PictureBox Canvas;
    }
}
