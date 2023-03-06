using BlazorDemoWA.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BlazorDemoWA.Components
{
    public partial class QuickView
    {
        [Parameter]
        public User User { get; set; }

        private User _user;

        // Method invoked when the component has received parameters from
        // its parent in the render tree, and the incoming values have been assigned to properties.
        protected override void OnParametersSet()
        {
            _user = User;
        }

        public void Close()
        {
            _user = null;
        }
    }
}
