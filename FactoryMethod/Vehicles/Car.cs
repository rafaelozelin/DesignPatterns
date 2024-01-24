using System;

namespace FactoryMethod.Vehicles
{
    internal class Car : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos os passageiros"); 
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciamos o trajet");
        }
    }
}
