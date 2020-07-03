using System;
using System.Threading.Tasks;
using AmazingChessAPI.Interfaces;
using AmazingChessAPI.Models;
using Firebase.Database;

namespace AmazingChessAPI.Providers
{
    public class FirebaseProvider : IFirebaseProvider
    {
        private readonly FirebaseClient _firebase;

        public FirebaseProvider()
        {
            _firebase = new FirebaseClient(UrlDict.FirebasePath);
        }
        
        public async Task<GameHistory> GetGameRoom(string id)
        {
            var response = await _firebase.Child($"{UrlDict.GameRooms}/{id}").OnceSingleAsync<string>();
            return new GameHistory();
        }

        public async Task<Boolean> DeleteGameRoom(string id)
        {
            return true;
        }
    }
}