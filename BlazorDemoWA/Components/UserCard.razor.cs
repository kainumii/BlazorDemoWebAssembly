using BlazorDemoWA.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BlazorDemoWA.Components
{
    public partial class UserCard
    {
        [Parameter]
        public  User User { get; set; }

        [Parameter]
        public EventCallback<User> UserQuickViewClicked { get; set; }

        [Inject]
        public NavigationManager? NavigationManager { get; set; } = default;

        //public void NavigateToDetails(User selected) 
        //{
        //    NavigationManager.NavigateTo($"/userdetails/{selected.Id}");
        //}

    }
}
