namespace BlazorDemoWA.Shared.Domain
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        //public string Suite { get; set; }
        public Geo? Geo { get; set; }
    }
}