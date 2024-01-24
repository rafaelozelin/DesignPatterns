﻿using Builder.Components;
using Builder.Products;

namespace Builder.Builders
{
    internal class VehicleBuilder : IBuilder
    {
        private Vehicle vehicle = new Vehicle();

        public Vehicle GetVehicle()
        {
            var result = vehicle;
            Reset();
            return result;
        }

        public void Reset()
        {
            vehicle = new Vehicle();
        }

        public void SetEngine(Engine engine)
        {
           vehicle.Engine = engine;
        }

        public void SetSeats(int seats)
        {
           vehicle.Seats = seats;
        }

        public void SetTransmission(Transmission transmission)
        {
            vehicle.Transmission = transmission;
        }

        public void SetVehicleType(VehicleType vehicleType)
        {
           vehicle.VehicleType = vehicleType;
        }

        public void SetAirbag(bool airbags)
        {
            vehicle.Airbags = airbags;
        }
    }
}
