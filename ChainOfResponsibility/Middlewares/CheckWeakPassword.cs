﻿using System;

namespace ChainOfResponsibility.Middlewares
{
    class CheckWeakPassword : Middleware
    {
        public override bool Check(string email, string password)
        {
            if (password.Equals("12345"))
            {
                Console.WriteLine("ATENÇÃO: Considere usar uma senha mais segura!");
            }

            return CheckNext(email, password);
        }
    }
}
