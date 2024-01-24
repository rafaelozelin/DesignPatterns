using Builder.Builders;
using Builder.Directors;
using System;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder builder = new VehicleBuilder();
            Director director = new Director(builder);

            director.ConstructSedan();

            var sedan = builder.GetVehicle();

            Console.WriteLine($"criando um tipo: {sedan.VehicleType}");

            director.ConstructTruck();

            var truck = builder.GetVehicle();

            Console.WriteLine($"criando um tipo: {truck.VehicleType}");

            director.ConstructSUV();

            var suv = builder.GetVehicle();

            Console.WriteLine($"criando um tipo: {suv.VehicleType}");

            Console.ReadLine();
        }
    }
}
