using System;
using AmazingChessAPI.Interfaces;
using Microsoft.Data.SqlClient;

namespace AmazingChessAPI.Providers
{
    public class ExceptionManager : IExceptionManager
    {
        public bool IsDuplicateEntityCode(Exception e)
        {
            if (e.InnerException is SqlException sqlException && (sqlException.Number == 2601 || sqlException.Number == 2627))
            {
                return true;
            }

            return false;
        }
    }
}