﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Dao;

namespace Logic
{
    public class Dish_Service
    {
        Dish_DAO dish_DAO = new Dish_DAO();

        //Get a list of all the dishes from the DAO
        public List<Dish> GetAllDishes()
        {
            return dish_DAO.GetAll();
        }

        public List<Dish> GetAllDiner()
        {
            return dish_DAO.GetAllDiner();
        }

        //Add a new dish
        public void AddDish(Dish dish)
        {
            dish_DAO.Add(dish);
        }

        //Remove a dish
        public void RemoveDish(Dish dish)
        {
            dish_DAO.Remove(dish);
        }

        //Modify the properties of a dish
        public void ModifyDish(Dish dish)
        {
            dish_DAO.Modify(dish);
        }
    }
}
