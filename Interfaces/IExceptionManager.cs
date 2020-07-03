using System;

namespace AmazingChessAPI.Interfaces
{
    public interface IExceptionManager
    {
        bool IsDuplicateEntityCode(Exception e);
    }
}