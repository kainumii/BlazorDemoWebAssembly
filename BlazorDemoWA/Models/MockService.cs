using BlazorDemoWA.Pages;
using BlazorDemoWA.Shared.Domain;

namespace BlazorDemoWA.Models
{
    public class MockService
    {
        private static List<User>? _users;

        public static List<User> Users
        {
            get
            {
                _users ??= InitializeMockUsers();
                return _users;
            }
        }

        private static List<User>? InitializeMockUsers()
        {
            var list = new List<User>();

            var u1 = new User
            {
                Id = 1,
                Name = "Aku",
                Email = "ewrwer",
                Username = "fdgfdgf",
                WebSite = "ewrewrewrew"
            };

            list.Add(u1);

            return list;
        }
    }
}
