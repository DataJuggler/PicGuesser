

#region using statements

using ObjectLibrary.BusinessObjects;
using ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.Data.Readers
{

    #region class PixelReader
    /// <summary>
    /// This class loads a single 'Pixel' object or a list of type <Pixel>.
    /// </summary>
    public class PixelReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'Pixel' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'Pixel' DataObject.</returns>
            public static Pixel Load(DataRow dataRow)
            {
                // Initial Value
                Pixel pixel = new Pixel();

                // Create field Integers
                int alphafield = 0;
                int assignedfield = 1;
                int bluefield = 2;
                int greenfield = 3;
                int idfield = 4;
                int imageIdfield = 5;
                int redfield = 6;
                int xfield = 7;
                int yfield = 8;

                try
                {
                    // Load Each field
                    pixel.Alpha = DataHelper.ParseInteger(dataRow.ItemArray[alphafield], 0);
                    pixel.Assigned = DataHelper.ParseBoolean(dataRow.ItemArray[assignedfield], false);
                    pixel.Blue = DataHelper.ParseInteger(dataRow.ItemArray[bluefield], 0);
                    pixel.Green = DataHelper.ParseInteger(dataRow.ItemArray[greenfield], 0);
                    pixel.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    pixel.ImageId = DataHelper.ParseInteger(dataRow.ItemArray[imageIdfield], 0);
                    pixel.Red = DataHelper.ParseInteger(dataRow.ItemArray[redfield], 0);
                    pixel.X = DataHelper.ParseInteger(dataRow.ItemArray[xfield], 0);
                    pixel.Y = DataHelper.ParseInteger(dataRow.ItemArray[yfield], 0);
                }
                catch
                {
                }

                // return value
                return pixel;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'Pixel' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A Pixel Collection.</returns>
            public static List<Pixel> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<Pixel> pixels = new List<Pixel>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'Pixel' from rows
                        Pixel pixel = Load(row);

                        // Add this object to collection
                        pixels.Add(pixel);
                    }
                }
                catch
                {
                }

                // return value
                return pixels;
            }
            #endregion

        #endregion

    }
    #endregion

}
