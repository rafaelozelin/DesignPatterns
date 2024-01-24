﻿using System;

namespace Bridge.Platforms
{
    class YouTube : IPlatform
    {
        public YouTube()
        {
            ConfigureRMTP();
            Console.WriteLine("YouTube: Transmissão iniciada");
        }
        public void AuthToken()
        {
            Console.WriteLine("YouTube: Autorizando aplicação");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("YouTube: Configurando servidor");
        }
    }
}
