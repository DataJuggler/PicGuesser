
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

    #region class PixelWriter
    /// <summary>
    /// This class is used for converting a 'Pixel' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class PixelWriter : PixelWriterBase
    {

        #region Static Methods

            #region CreateFetchAllPixelsStoredProcedure(Pixel pixel)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllPixelsStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Pixel_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllPixelsStoredProcedure' object.</returns>
            public static new FetchAllPixelsStoredProcedure CreateFetchAllPixelsStoredProcedure(Pixel pixel)
            {
                // Initial value
                FetchAllPixelsStoredProcedure fetchAllPixelsStoredProcedure = new FetchAllPixelsStoredProcedure();

                // if the pixel object exists
                if (pixel != null)
                {
                    // if LoadByImageId is true
                    if (pixel.LoadByImageId)
                    {
                        // Change the procedure name
                        fetchAllPixelsStoredProcedure.ProcedureName = "Pixel_FetchAllForImageId";
                        
                        // Create the @ImageId parameter
                        fetchAllPixelsStoredProcedure.Parameters = SqlParameterHelper.CreateSqlParameters("@ImageId", pixel.ImageId);
                    }
                }
                
                // return value
                return fetchAllPixelsStoredProcedure;
            }
            #endregion
            
        #endregion

    }
    #endregion

}
