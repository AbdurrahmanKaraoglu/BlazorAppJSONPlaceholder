using BlazorAppJSONPlaceholder.Models;
using Newtonsoft.Json;

namespace BlazorAppJSONPlaceholder.Services
{
    // PhotoService.cs
    public class PhotoService
    {


        public PhotoService()
        {

        }

        public async Task<List<Photo>> GetPhotosAsync(int albumId)
        {
            // API'den albümün fotoğraflarını çekmek için HTTP isteği yapın

            List<Photo> photos = new List<Photo>();
            HttpClient httpClient = new HttpClient();
            var url = $"https://jsonplaceholder.typicode.com/albums/{albumId}/photos";
            var response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                photos = JsonConvert.DeserializeObject<List<Photo>>(json);
            }
            return photos;
        }

    }
}
