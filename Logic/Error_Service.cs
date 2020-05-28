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
        private Error_DAO error_DAO = new Error_DAO();

        public void LogError(Error error)
        {
            error_DAO.Log(error);
        }
    }
}
