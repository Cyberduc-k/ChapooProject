using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace Dao
{
    public class Error_DAO : Base
    {
        // Log an error to the database
        public void Log(Error error)
        {
            //string query = "INSERT INTO [dbo].[Errors] ([type], [time], [message], [trace]) VALUES (@type, @time, @message, @trace)";
            string query = "INSERT INTO [dbo].[Errors] ([type], [time], [message], [trace]) VALUES (@type, @time, @message, @trace)";
            SqlParameter[] parameters = new SqlParameter[4]
            {
                new SqlParameter("@type", error.Type),
                new SqlParameter("@time", error.Time),
                new SqlParameter("@message", error.Message),
                new SqlParameter("@trace", error.Trace),
            };

            ExecuteEditQuery(query, parameters);
        }
    }
}
