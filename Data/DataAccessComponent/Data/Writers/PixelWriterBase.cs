

#region using statements

using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using Microsoft.Data.SqlClient;
using ObjectLibrary.BusinessObjects;
using System;
using System.Data;

#endregion


namespace DataAccessComponent.Data.Writers
{

    #region class PixelWriterBase
    /// <summary>
    /// This class is used for converting a 'Pixel' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class PixelWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(Pixel pixel)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='pixel'>The 'Pixel' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(Pixel pixel)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (pixel != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", pixel.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeletePixelStoredProcedure(Pixel pixel)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeletePixel'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Pixel_Delete'.
            /// </summary>
            /// <param name="pixel">The 'Pixel' to Delete.</param>
            /// <returns>An instance of a 'DeletePixelStoredProcedure' object.</returns>
            public static DeletePixelStoredProcedure CreateDeletePixelStoredProcedure(Pixel pixel)
            {
                // Initial Value
                DeletePixelStoredProcedure deletePixelStoredProcedure = new DeletePixelStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deletePixelStoredProcedure.Parameters = CreatePrimaryKeyParameter(pixel);

                // return value
                return deletePixelStoredProcedure;
            }
            #endregion

            #region CreateFindPixelStoredProcedure(Pixel pixel)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindPixelStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Pixel_Find'.
            /// </summary>
            /// <param name="pixel">The 'Pixel' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindPixelStoredProcedure CreateFindPixelStoredProcedure(Pixel pixel)
            {
                // Initial Value
                FindPixelStoredProcedure findPixelStoredProcedure = null;

                // verify pixel exists
                if(pixel != null)
                {
                    // Instanciate findPixelStoredProcedure
                    findPixelStoredProcedure = new FindPixelStoredProcedure();

                    // Now create parameters for this procedure
                    findPixelStoredProcedure.Parameters = CreatePrimaryKeyParameter(pixel);
                }

                // return value
                return findPixelStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(Pixel pixel)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new pixel.
            /// </summary>
            /// <param name="pixel">The 'Pixel' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(Pixel pixel)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[8];
                SqlParameter param = null;

                // verify pixelexists
                if(pixel != null)
                {
                    // Create [Alpha] parameter
                    param = new SqlParameter("@Alpha", pixel.Alpha);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [Assigned] parameter
                    param = new SqlParameter("@Assigned", pixel.Assigned);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create [Blue] parameter
                    param = new SqlParameter("@Blue", pixel.Blue);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create [Green] parameter
                    param = new SqlParameter("@Green", pixel.Green);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create [ImageId] parameter
                    param = new SqlParameter("@ImageId", pixel.ImageId);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create [Red] parameter
                    param = new SqlParameter("@Red", pixel.Red);

                    // set parameters[5]
                    parameters[5] = param;

                    // Create [X] parameter
                    param = new SqlParameter("@X", pixel.X);

                    // set parameters[6]
                    parameters[6] = param;

                    // Create [Y] parameter
                    param = new SqlParameter("@Y", pixel.Y);

                    // set parameters[7]
                    parameters[7] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertPixelStoredProcedure(Pixel pixel)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertPixelStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Pixel_Insert'.
            /// </summary>
            /// <param name="pixel"The 'Pixel' object to insert</param>
            /// <returns>An instance of a 'InsertPixelStoredProcedure' object.</returns>
            public static InsertPixelStoredProcedure CreateInsertPixelStoredProcedure(Pixel pixel)
            {
                // Initial Value
                InsertPixelStoredProcedure insertPixelStoredProcedure = null;

                // verify pixel exists
                if(pixel != null)
                {
                    // Instanciate insertPixelStoredProcedure
                    insertPixelStoredProcedure = new InsertPixelStoredProcedure();

                    // Now create parameters for this procedure
                    insertPixelStoredProcedure.Parameters = CreateInsertParameters(pixel);
                }

                // return value
                return insertPixelStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(Pixel pixel)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing pixel.
            /// </summary>
            /// <param name="pixel">The 'Pixel' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(Pixel pixel)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[9];
                SqlParameter param = null;

                // verify pixelexists
                if(pixel != null)
                {
                    // Create parameter for [Alpha]
                    param = new SqlParameter("@Alpha", pixel.Alpha);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [Assigned]
                    param = new SqlParameter("@Assigned", pixel.Assigned);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [Blue]
                    param = new SqlParameter("@Blue", pixel.Blue);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create parameter for [Green]
                    param = new SqlParameter("@Green", pixel.Green);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create parameter for [ImageId]
                    param = new SqlParameter("@ImageId", pixel.ImageId);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create parameter for [Red]
                    param = new SqlParameter("@Red", pixel.Red);

                    // set parameters[5]
                    parameters[5] = param;

                    // Create parameter for [X]
                    param = new SqlParameter("@X", pixel.X);

                    // set parameters[6]
                    parameters[6] = param;

                    // Create parameter for [Y]
                    param = new SqlParameter("@Y", pixel.Y);

                    // set parameters[7]
                    parameters[7] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", pixel.Id);
                    parameters[8] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdatePixelStoredProcedure(Pixel pixel)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdatePixelStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Pixel_Update'.
            /// </summary>
            /// <param name="pixel"The 'Pixel' object to update</param>
            /// <returns>An instance of a 'UpdatePixelStoredProcedure</returns>
            public static UpdatePixelStoredProcedure CreateUpdatePixelStoredProcedure(Pixel pixel)
            {
                // Initial Value
                UpdatePixelStoredProcedure updatePixelStoredProcedure = null;

                // verify pixel exists
                if(pixel != null)
                {
                    // Instanciate updatePixelStoredProcedure
                    updatePixelStoredProcedure = new UpdatePixelStoredProcedure();

                    // Now create parameters for this procedure
                    updatePixelStoredProcedure.Parameters = CreateUpdateParameters(pixel);
                }

                // return value
                return updatePixelStoredProcedure;
            }
            #endregion

            #region CreateFetchAllPixelsStoredProcedure(Pixel pixel)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllPixelsStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Pixel_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllPixelsStoredProcedure' object.</returns>
            public static FetchAllPixelsStoredProcedure CreateFetchAllPixelsStoredProcedure(Pixel pixel)
            {
                // Initial value
                FetchAllPixelsStoredProcedure fetchAllPixelsStoredProcedure = new FetchAllPixelsStoredProcedure();

                // return value
                return fetchAllPixelsStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
