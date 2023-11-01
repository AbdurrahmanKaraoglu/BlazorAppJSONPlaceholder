using BlazorAppJSONPlaceholder.Models;

namespace BlazorAppJSONPlaceholder.Services
{

    // AlbumService.cs
    public class AlbumService
    {
        private readonly HttpClient _httpClient;

        public AlbumService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }



        public async Task<List<Album>> GetAlbumsAsync(int userId)
        {
            // API'den albümün fotoğraflarını çekmek için HTTP isteği yapın
            var response = await _httpClient.GetFromJsonAsync<List<Album>>($"https://jsonplaceholder.typicode.com/users/{userId}/albums");
            return response;
        }
    }

}
