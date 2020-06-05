using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao;
using Model;

namespace Logic
{
    public class Drink_Service
    {
        Drink_DAO drink_DAO = new Drink_DAO();

        //Get a list of all the drinks from the DAO
        public List<Drink> GetAllDrinks()
        {
            return drink_DAO.GetAll();
        }

        //Get a list of all the drinks ordered by stock
        public List<Drink> OrderByStock()
        {
            return drink_DAO.OrderByStock();
        }

        //Add a new drink
        public void AddDrink(Drink drink)
        {
            drink_DAO.Add(drink);
        }

        //Remove a drink
        public void RemoveDrink(int id)
        {
            drink_DAO.Remove(id);
        }

        //Modify the properties of a drink
        public void ModifyDrink(Drink drink)
        {
            drink_DAO.Modify(drink);
        }

        public void ModifyStock(int id, int stock)
        {
            drink_DAO.ModifyStock(id, stock);
        }

        //Empty the stock of a drink
        public void EmptyStock(int id)
        {
            drink_DAO.EmptyStock(id);
        }
    }
}
