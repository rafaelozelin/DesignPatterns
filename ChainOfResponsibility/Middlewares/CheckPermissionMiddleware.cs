using System;

namespace ChainOfResponsibility.Middlewares
{
    internal class CheckPermissionMiddleware : Middleware
    {
        public override bool Check(string email, string password)
        {
            if (email.Equals("master@teste.com.br"))
            {
                Console.WriteLine("Seja bem-vindo administrador");
                return true;
            }

            Console.WriteLine("Seja bem-vindo");

            return CheckNext(email, password);
        }
    }
}
