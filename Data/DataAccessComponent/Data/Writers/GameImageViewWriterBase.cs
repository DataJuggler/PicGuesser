

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

    #region class GameImageViewWriterBase
    /// <summary>
    /// This class is used for converting a 'GameImageView' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class GameImageViewWriterBase
    {

        #region Static Methods

            #region CreateFetchAllGameImageViewsStoredProcedure(GameImageView gameImageView)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllGameImageViewsStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'GameImageView_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllGameImageViewsStoredProcedure' object.</returns>
            public static FetchAllGameImageViewsStoredProcedure CreateFetchAllGameImageViewsStoredProcedure(GameImageView gameImageView)
            {
                // Initial value
                FetchAllGameImageViewsStoredProcedure fetchAllGameImageViewsStoredProcedure = new FetchAllGameImageViewsStoredProcedure();

                // return value
                return fetchAllGameImageViewsStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
