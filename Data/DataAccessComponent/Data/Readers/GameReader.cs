

#region using statements

using ObjectLibrary.BusinessObjects;
using ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.Data.Readers
{

    #region class GameReader
    /// <summary>
    /// This class loads a single 'Game' object or a list of type <Game>.
    /// </summary>
    public class GameReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'Game' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'Game' DataObject.</returns>
            public static Game Load(DataRow dataRow)
            {
                // Initial Value
                Game game = new Game();

                // Create field Integers
                int completedfield = 0;
                int idfield = 1;
                int imageIdfield = 2;
                int solvedfield = 3;
                int startedfield = 4;
                int startTimefield = 5;

                try
                {
                    // Load Each field
                    game.Completed = DataHelper.ParseBoolean(dataRow.ItemArray[completedfield], false);
                    game.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    game.ImageId = DataHelper.ParseInteger(dataRow.ItemArray[imageIdfield], 0);
                    game.Solved = DataHelper.ParseBoolean(dataRow.ItemArray[solvedfield], false);
                    game.Started = DataHelper.ParseBoolean(dataRow.ItemArray[startedfield], false);
                    game.StartTime = DataHelper.ParseDate(dataRow.ItemArray[startTimefield]);
                }
                catch
                {
                }

                // return value
                return game;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'Game' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A Game Collection.</returns>
            public static List<Game> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<Game> games = new List<Game>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'Game' from rows
                        Game game = Load(row);

                        // Add this object to collection
                        games.Add(game);
                    }
                }
                catch
                {
                }

                // return value
                return games;
            }
            #endregion

        #endregion

    }
    #endregion

}
