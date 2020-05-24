using System;
using System.Text;
using Model;
using Dao;
using System.Collections.Generic;

namespace Logic
{
    public class Menu_Service
    {
        Menu_DAO menu_DAO = new Menu_DAO();

        //Get a list of all the menu's from the DAO
        public List<Menu> GetAllMenus()
        {
            return null;
        }

        //Add a new menu
        public void AddMenu(Menu menu)
        {

        }

        //Remove a menu
        public void DeleteMenu(Menu menu)
        {

        }

        //Modify the properties of the menu
        public void ModifyMenu(Menu menu)
        {

        }
    }
}
