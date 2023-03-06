using BlazorDemoWA.Models;
using BlazorDemoWA.Services;
using BlazorDemoWA.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BlazorDemoWA.Pages
{
    public partial class UserOverview
    {
        [Inject]
       IUserService UserService { get; set; }

        private User? _selectedUser;

        public List<User>? Users { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var list = await UserService.GetUsers();
            Users = list.ToList();         
        }

        public void ShowQuickView(User selected)        
        {
            _selectedUser = selected;
        }

        public void EditUserView(User selected)
        {
            _selectedUser = selected;
        }
    }
}
