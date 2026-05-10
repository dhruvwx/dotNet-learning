using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DataAccessLibrary
{
    public class SQLDataAccess
    {
        /*generic method to load data 
         * Returns generic list
         * using statement used coz no matter what it closes the connection to DB always
         * On connection (of type IDbConection) create new Microsoft.Data.SqlClient.SqlConnection and pass connectionstring
         * Apply Dapper.Query on connection(IDbConection) and save it in rows of type list that takes 1 row from the Database
         * In Query T is ROW from the database
         * 
         * =========================================================================================================
         *    ANOTHER METHOD  TO SAVE THE DATA AFTER LOADING
         *will not return anything
         *    
         *IN THESE METHODS .Query -> READS == loading data method
         *      AND        .Execute -> WRITES == saving data method
         *      
         *they are from dapper  == to use them create new class SQLCrud
         */


        public List<T> LoadData<T , U>(string sqlStatement , U parameters , string connectionString)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(sqlStatement, parameters).ToList();
                return rows;
            }
        }

        public void SaveData<T>(string sqlStatement , T parameters , string connectionString)
        {
            using(IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(sqlStatement, parameters);
            }
        }


    }
}
