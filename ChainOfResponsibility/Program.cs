using ChainOfResponsibility.Middlewares;
using ChainOfResponsibility.Servers;
using System;

namespace ChainOfResponsibility
{
    internal class Program
    {
        private static Server server;

        static void Init()
        {
            server = new Server();

            server.RegisterUser("master@teste.com.br", "12345");
            server.RegisterUser("user@teste.com.br", "12345");

            Middleware middleware = new CheckUserMiddleware(server);

            middleware.LinkWith(new CheckPermissionMiddleware());
            middleware.LinkWith(new CheckWeakPassword());

            server.SetMiddleware(middleware);
        }
        static void Main(string[] args)
        {
            Init();

            Boolean done = false;

            do
            {
                Console.WriteLine("Digite o seu e-mail");
                string email =  Console.ReadLine();

                Console.WriteLine("Digite a sua senha");
                string password = Console.ReadLine();

                done = server.LogIn(email, password);

            } while (!done);

            Console.ReadLine();
        }
    }
}
