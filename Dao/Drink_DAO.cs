using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Model;
using System.Configuration;

namespace Dao
{
    public class Drink_DAO : Base
    {
        private readonly SqlConnection dbConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ChapooDatabase"].ConnectionString);

        //Get a list of all the drinks
        public List<Drink> Db_Get_All_Drinks()
        {
            return null;
        }

        //Add a new drink to the database
        public void Db_Add_New_Drink(Drink drink)
        {

        }

        //Remove a drink from the database
        public void Db_Remove_Drink(Drink drink)
        {

        }

        //Modify the properties of a drink in the database
        public void Db_Modify_Beverage(Drink drink)
        {

        }

        //Convert the raw database data into Drink object
        private List<Drink> ReadTables(DataTable dataTable)
        {
            return null;
        }
    }
}
