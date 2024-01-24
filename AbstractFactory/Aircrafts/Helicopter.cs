﻿using System;

namespace AbstractFactory.Aircrafts
{
    class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificnado os ventos");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros OK");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando a decolagem");
        }
    }
}
