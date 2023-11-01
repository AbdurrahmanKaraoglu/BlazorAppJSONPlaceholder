using BlazorAppJSONPlaceholder.Models;

namespace BlazorAppJSONPlaceholder.Services
{
    // UserService.cs
    public class UserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            // API'den kullanıcı verilerini çekmek için HTTP isteği yapın
            return await _httpClient.GetFromJsonAsync<List<User>>("https://jsonplaceholder.typicode.com/users");
        }
    }
}
