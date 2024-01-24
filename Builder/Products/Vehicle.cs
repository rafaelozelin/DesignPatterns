using Builder.Components;

namespace Builder.Products
{
    class Vehicle
    {
        public VehicleType VehicleType { get; set; }
        public int Seats { get; set; }
        public Engine Engine { get; set; }
        public Transmission Transmission { get; set; }
        public bool Airbags { get; set; }
    }
}
