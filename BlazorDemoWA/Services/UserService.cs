using BlazorDemoWA.Shared.Domain;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace BlazorDemoWA.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<User> AddUser(User user)
        {
            var ser = JsonSerializer.Serialize(user);
            var json = new StringContent(ser, Encoding.UTF8, "application/json");

            var resp = await _httpClient.PostAsync("https://jsonplaceholder.typicode.com/users/", json);
            if (resp.IsSuccessStatusCode) {
                var joo = await resp.Content.ReadAsStreamAsync();
                var retValue = await JsonSerializer.DeserializeAsync<User>(joo);
                return retValue;
            }

            return null;
        }

        public async Task DeleteUser(int id)
        {
            var resp = await _httpClient.DeleteAsync($"https://jsonplaceholder.typicode.com/users/{id}");
            resp.EnsureSuccessStatusCode();

            var json = await resp.Content.ReadAsStringAsync();
        }

        public async Task<User> GetUserById(int userId)
        {
            return await JsonSerializer.DeserializeAsync<User>
                (await _httpClient.GetStreamAsync($"https://jsonplaceholder.typicode.com/users/{userId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return await JsonSerializer.DeserializeAsync<IEnumerable<User>>(await _httpClient.GetStreamAsync($"https://jsonplaceholder.typicode.com/users"), options);
        }

        public async Task UpdateUser(User user)
        {
            var json =
                new StringContent(JsonSerializer.Serialize(user), Encoding.UTF8, "application/json");

            await _httpClient.PutAsync($"https://jsonplaceholder.typicode.com/users/{user.Id}", json);
        }
    }
}
