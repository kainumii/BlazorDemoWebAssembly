using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDemoWA.Shared.Model
{
    public class Marker
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string? Description { get; set; }
        public bool ShowPopup { get; set; }
    }
}
