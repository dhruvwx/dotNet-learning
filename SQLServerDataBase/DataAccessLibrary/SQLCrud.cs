using DataAccessLibrary.Model;
using Microsoft.Data.SqlClient.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class SQLCrud  //we will use SQLDataAccess in this
    {
        /*create constructor and pass connectionString
         * before this create a readonly string variable _connection string and put the passed one into this
         * 
         * Now create Model Class and create instantiated one with contacts table column props.
         * 
         * And using it as a type on list creat another method to get the details as list
         * put SQL Query inside it
         * Now return LOADDATA method that needs 2 arguments(dataTypes)
         *  ==== give it data types inside <>   1. BasicContactModel      2.dynamic(can be anything)
         * 
         * We will be using load and save data methods from SQLDataAccess so instantiate it once and use.
         * 
         * 
         * 
         * 
         */

        private readonly string _connectionString;
        private SQLDataAccess db = new();
        public SQLCrud(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<BasicContactModel> GetAllContacts()
        {
            string sql = "SELECT Id ,[First Name] AS FirstName ,[Last Name] AS LastName FROM dbo.Contacts;";
            return db.LoadData<BasicContactModel , dynamic>(sql, new { }, _connectionString);
        }
    }
}
