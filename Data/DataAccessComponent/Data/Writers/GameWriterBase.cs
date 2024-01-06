

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

    #region class GameWriterBase
    /// <summary>
    /// This class is used for converting a 'Game' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class GameWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(Game game)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='game'>The 'Game' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(Game game)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (game != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", game.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteGameStoredProcedure(Game game)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteGame'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Game_Delete'.
            /// </summary>
            /// <param name="game">The 'Game' to Delete.</param>
            /// <returns>An instance of a 'DeleteGameStoredProcedure' object.</returns>
            public static DeleteGameStoredProcedure CreateDeleteGameStoredProcedure(Game game)
            {
                // Initial Value
                DeleteGameStoredProcedure deleteGameStoredProcedure = new DeleteGameStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteGameStoredProcedure.Parameters = CreatePrimaryKeyParameter(game);

                // return value
                return deleteGameStoredProcedure;
            }
            #endregion

            #region CreateFindGameStoredProcedure(Game game)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindGameStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Game_Find'.
            /// </summary>
            /// <param name="game">The 'Game' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindGameStoredProcedure CreateFindGameStoredProcedure(Game game)
            {
                // Initial Value
                FindGameStoredProcedure findGameStoredProcedure = null;

                // verify game exists
                if(game != null)
                {
                    // Instanciate findGameStoredProcedure
                    findGameStoredProcedure = new FindGameStoredProcedure();

                    // Now create parameters for this procedure
                    findGameStoredProcedure.Parameters = CreatePrimaryKeyParameter(game);
                }

                // return value
                return findGameStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(Game game)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new game.
            /// </summary>
            /// <param name="game">The 'Game' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(Game game)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[5];
                SqlParameter param = null;

                // verify gameexists
                if(game != null)
                {
                    // Create [Completed] parameter
                    param = new SqlParameter("@Completed", game.Completed);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [ImageId] parameter
                    param = new SqlParameter("@ImageId", game.ImageId);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create [Solved] parameter
                    param = new SqlParameter("@Solved", game.Solved);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create [Started] parameter
                    param = new SqlParameter("@Started", game.Started);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create [StartTime] Parameter
                    param = new SqlParameter("@StartTime", SqlDbType.DateTime);

                    // If game.StartTime does not exist.
                    if (game.StartTime.Year < 1900)
                    {
                        // Set the value to 1/1/1900
                        param.Value = new DateTime(1900, 1, 1);
                    }
                    else
                    {
                        // Set the parameter value
                        param.Value = game.StartTime;
                    }
                    // set parameters[4]
                    parameters[4] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertGameStoredProcedure(Game game)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertGameStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Game_Insert'.
            /// </summary>
            /// <param name="game"The 'Game' object to insert</param>
            /// <returns>An instance of a 'InsertGameStoredProcedure' object.</returns>
            public static InsertGameStoredProcedure CreateInsertGameStoredProcedure(Game game)
            {
                // Initial Value
                InsertGameStoredProcedure insertGameStoredProcedure = null;

                // verify game exists
                if(game != null)
                {
                    // Instanciate insertGameStoredProcedure
                    insertGameStoredProcedure = new InsertGameStoredProcedure();

                    // Now create parameters for this procedure
                    insertGameStoredProcedure.Parameters = CreateInsertParameters(game);
                }

                // return value
                return insertGameStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(Game game)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing game.
            /// </summary>
            /// <param name="game">The 'Game' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(Game game)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[6];
                SqlParameter param = null;

                // verify gameexists
                if(game != null)
                {
                    // Create parameter for [Completed]
                    param = new SqlParameter("@Completed", game.Completed);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [ImageId]
                    param = new SqlParameter("@ImageId", game.ImageId);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [Solved]
                    param = new SqlParameter("@Solved", game.Solved);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create parameter for [Started]
                    param = new SqlParameter("@Started", game.Started);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create parameter for [StartTime]
                    // Create [StartTime] Parameter
                    param = new SqlParameter("@StartTime", SqlDbType.DateTime);

                    // If game.StartTime does not exist.
                    if (game.StartTime.Year < 1900)
                    {
                        // Set the value to 1/1/1900
                        param.Value = new DateTime(1900, 1, 1);
                    }
                    else
                    {
                        // Set the parameter value
                        param.Value = game.StartTime;
                    }

                    // set parameters[4]
                    parameters[4] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", game.Id);
                    parameters[5] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateGameStoredProcedure(Game game)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateGameStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Game_Update'.
            /// </summary>
            /// <param name="game"The 'Game' object to update</param>
            /// <returns>An instance of a 'UpdateGameStoredProcedure</returns>
            public static UpdateGameStoredProcedure CreateUpdateGameStoredProcedure(Game game)
            {
                // Initial Value
                UpdateGameStoredProcedure updateGameStoredProcedure = null;

                // verify game exists
                if(game != null)
                {
                    // Instanciate updateGameStoredProcedure
                    updateGameStoredProcedure = new UpdateGameStoredProcedure();

                    // Now create parameters for this procedure
                    updateGameStoredProcedure.Parameters = CreateUpdateParameters(game);
                }

                // return value
                return updateGameStoredProcedure;
            }
            #endregion

            #region CreateFetchAllGamesStoredProcedure(Game game)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllGamesStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Game_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllGamesStoredProcedure' object.</returns>
            public static FetchAllGamesStoredProcedure CreateFetchAllGamesStoredProcedure(Game game)
            {
                // Initial value
                FetchAllGamesStoredProcedure fetchAllGamesStoredProcedure = new FetchAllGamesStoredProcedure();

                // return value
                return fetchAllGamesStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
