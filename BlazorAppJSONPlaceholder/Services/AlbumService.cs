using BlazorAppJSONPlaceholder.Models;
using Newtonsoft.Json;

namespace BlazorAppJSONPlaceholder.Services
{

    // AlbumService.cs
    public class AlbumService
    {
        
        public AlbumService()
        {
           
        }



        public async Task<List<Album>> GetAlbumsAsync(int userId)
        {
            List<Album> albums = new List<Album>();
            HttpClient httpClient = new HttpClient();
            var url = $"https://jsonplaceholder.typicode.com/users/{userId}/albums";
            var response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                albums = JsonConvert.DeserializeObject<List<Album>>(json);
            }
            return albums;

        }
    }

}
