using BlazorAppJSONPlaceholder.Models;

namespace BlazorAppJSONPlaceholder.Services
{
    // PhotoService.cs
    public class PhotoService
    {
        private readonly HttpClient _httpClient;

        public PhotoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Photo>> GetPhotosAsync(int albumId)
        {
            // API'den albümün fotoğraflarını çekmek için HTTP isteği yapın
            var response = await _httpClient.GetFromJsonAsync<List<Photo>>($"https://jsonplaceholder.typicode.com/albums/{albumId}/photos");
            return response;
        }

    }
}
