using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace Dao
{
    public class Table_DAO : Base
    {
        // Get a list of all the tables
        public List<Table> GetAll()
        {
            string query = "SELECT [id], [occupied], [seats] FROM [dbo].[Tables]";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadAll(ExecuteSelectQuery(query, parameters));
        }

        // Add a new table to the database
        public void Add(Table table)
        {
            string query = "INSERT INTO [dbo].[Tables] ([occupied], [seats]) VALUES (@occupied, @seats)";
            SqlParameter[] parameters = new SqlParameter[2]
            {
                new SqlParameter("@occupied", table.Occupied),
                new SqlParameter("@seats", table.Seats),
            };

            ExecuteEditQuery(query, parameters);
        }

        // Remove a drink from the database
        public void Remove(Table table)
        {
            string query = "DELETE FROM [dbo].[Tables] WHERE [id] = @id";
            SqlParameter[] parameters = new SqlParameter[1]
            {
                new SqlParameter("@id", table.Number),
            };

            ExecuteEditQuery(query, parameters);
        }

        // Modify the properties of a drink in the database
        public void Modify(Table table)
        {
            string query = "UPDATE [dbo].[Tables] SET [occupied] = @occupied, [seats] = @seats WHERE [id] = @id";
            SqlParameter[] parameters = new SqlParameter[3]
            {
                new SqlParameter("@occupied", table.Occupied),
                new SqlParameter("@seats", table.Seats),
                new SqlParameter("@id", table.Number),
            };

            ExecuteEditQuery(query, parameters);
        }

        // Convert the raw database data into a list of Table objects
        private List<Table> ReadAll(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow dataRow in dataTable.Rows)
                tables.Add(Read(dataRow));

            return tables;
        }

        // Convert the raw database data into a Table object
        private Table Read(DataRow dataRow)
        {
            int id = (int)dataRow["id"];
            bool occupied = (bool)dataRow["occupied"];
            byte seats = (byte)dataRow["seats"];

            return new Table(id, seats, occupied);
        }
    }
}
