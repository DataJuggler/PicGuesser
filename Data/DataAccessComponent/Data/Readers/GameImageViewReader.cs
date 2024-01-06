

#region using statements

using ObjectLibrary.BusinessObjects;
using ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.Data.Readers
{

    #region class GameImageViewReader
    /// <summary>
    /// This class loads a single 'GameImageView' object or a list of type <GameImageView>.
    /// </summary>
    public class GameImageViewReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'GameImageView' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'GameImageView' DataObject.</returns>
            public static GameImageView Load(DataRow dataRow)
            {
                // Initial Value
                GameImageView gameImageView = new GameImageView();

                // Create field Integers
                int assignedfield = 0;
                int completedfield = 1;
                int fullPathfield = 2;
                int gameIdfield = 3;
                int imageIdfield = 4;
                int namefield = 5;
                int solvedfield = 6;
                int startedfield = 7;
                int startTimefield = 8;
                int totalPixelsfield = 9;

                try
                {
                    // Load Each field
                    gameImageView.Assigned = DataHelper.ParseBoolean(dataRow.ItemArray[assignedfield], false);
                    gameImageView.Completed = DataHelper.ParseBoolean(dataRow.ItemArray[completedfield], false);
                    gameImageView.FullPath = DataHelper.ParseString(dataRow.ItemArray[fullPathfield]);
                    gameImageView.GameId = DataHelper.ParseInteger(dataRow.ItemArray[gameIdfield], 0);
                    gameImageView.ImageId = DataHelper.ParseInteger(dataRow.ItemArray[imageIdfield], 0);
                    gameImageView.Name = DataHelper.ParseString(dataRow.ItemArray[namefield]);
                    gameImageView.Solved = DataHelper.ParseBoolean(dataRow.ItemArray[solvedfield], false);
                    gameImageView.Started = DataHelper.ParseBoolean(dataRow.ItemArray[startedfield], false);
                    gameImageView.StartTime = DataHelper.ParseDate(dataRow.ItemArray[startTimefield]);
                    gameImageView.TotalPixels = DataHelper.ParseInteger(dataRow.ItemArray[totalPixelsfield], 0);
                }
                catch
                {
                }

                // return value
                return gameImageView;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'GameImageView' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A GameImageView Collection.</returns>
            public static List<GameImageView> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<GameImageView> gameImageViews = new List<GameImageView>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'GameImageView' from rows
                        GameImageView gameImageView = Load(row);

                        // Add this object to collection
                        gameImageViews.Add(gameImageView);
                    }
                }
                catch
                {
                }

                // return value
                return gameImageViews;
            }
            #endregion

        #endregion

    }
    #endregion

}
