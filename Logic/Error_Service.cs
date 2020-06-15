using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao;
using Model;

namespace Logic
{
    public class Error_Service
    {
        //Reference to the error DAO for database operatoins
        private Error_DAO error_DAO = new Error_DAO();

        //Log the error
        public void LogError(Error error)
        {
            error_DAO.Log(error);
        }
    }
}
