using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;
using Model;

namespace Dao
{
    public class Reservation_DAO : Base
    {
        // Get a list of all reservations

        public List<Reservation> GetAll()
        {
            string query = "SELECT [id], [name], [date], [from], [to], [numberOfPersons] FROM [dbo].[Reservations]";
            SqlParameter[] parameters = new SqlParameter[0];

            return ReadAll(ExecuteSelectQuery(query, parameters));
        }

        // Add a new reservation to the database
        public void Add(Reservation reservation)
        {
            string query = "INSERT INTO [dbo].[Reservations] ([name], [date], [from], [to], [numberOfPersons]) VALUES (@name, @date, @from, @to, @numberOfPersons)";
            SqlParameter[] parameters = new SqlParameter[5]
            {
                new SqlParameter("@name", reservation.Name),
                new SqlParameter("@date", reservation.Date),
                new SqlParameter("@from", reservation.From),
                new SqlParameter("@to", reservation.To),
                new SqlParameter("@numberOfPersons", reservation.NumberOfPersons)
            };

            ExecuteEditQuery(query, parameters);
        }

        // Remove a reservation from the database
        public void Remove(Reservation reservation)
        {
            string query = "DELETE FROM [dbo].[Reservations] WHERE [id] = @id";
            SqlParameter[] parameters = new SqlParameter[1]
            {
                new SqlParameter("@id", reservation.Id),
            };

            ExecuteEditQuery(query, parameters);
        }

        // Modify the properties of a reservation in the database
        public void Modify(Reservation reservation)
        {
            string query = "UPDATE [dbo].[Reservations] SET " +
                "[name] = @name, [date] = @date, [from] = @from, [to] = @to, [numberOfPersons] = @numberOfPersons" +
                "WHERE [id] = @id";
            SqlParameter[] parameters = new SqlParameter[6]
            {
                new SqlParameter("@name", reservation.Name),
                new SqlParameter("@date", reservation.Date),
                new SqlParameter("@from", reservation.From),
                new SqlParameter("@to", reservation.To),
                new SqlParameter("@numberOfPersons", reservation.NumberOfPersons),
                new SqlParameter("@id", reservation.Id),
            };
            ExecuteEditQuery(query, parameters);
        }

        // Convert the raw database data into a list of Reservation objects
        private List<Reservation> ReadAll(DataTable dataTable)
        {
            List<Reservation> reservations = new List<Reservation>();

            foreach (DataRow dataRow in dataTable.Rows)
                reservations.Add(Read(dataRow));

            return reservations;
        }

        // Convert the raw database data into an Reservation object
        private Reservation Read(DataRow dataRow)
        {
            int id = (int)dataRow["id"];
            string name = (string)dataRow["name"];
            DateTime date = (DateTime)dataRow["date"];
            DateTime from = (DateTime)dataRow["from"];
            DateTime to = (DateTime)dataRow["to"];
            int numberOfPersons = (int)dataRow["numberOfPersons"];

            return new Reservation(id, name, date, from, to, numberOfPersons);
        }
    }
}
