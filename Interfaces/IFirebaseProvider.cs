using System;
using System.Threading.Tasks;
using AmazingChessAPI.Models;

namespace AmazingChessAPI.Interfaces
{
    public interface IFirebaseProvider
    {
        Task<GameHistory> GetGameRoom(string id);
        Task<Boolean> DeleteGameRoom(string id);
    }
}