using BlazorAppJSONPlaceholder.Models;
using Newtonsoft.Json;

namespace BlazorAppJSONPlaceholder.Services
{
    // UserService.cs
    public class UserService
    {
         

        public UserService()
        {
            
        }

        public async Task<List<User>> GetUsersAsync()
        {
            List<User> users = new List<User>();
            HttpClient httpClient = new HttpClient();
            var url = "https://jsonplaceholder.typicode.com/users";
            var response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                users = JsonConvert.DeserializeObject<List<User>>(json);
            }
            return users;

           
        }
    }
}
