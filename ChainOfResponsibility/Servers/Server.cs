﻿using ChainOfResponsibility.Middlewares;
using System;
using System.Collections.Generic;

namespace ChainOfResponsibility.Servers
{
    class Server
    {
        private Dictionary<string, string> users = new Dictionary<string, string>();

        private Middleware middleware;

        public void SetMiddleware(Middleware middleware)
        {
            this.middleware = middleware;
        }

        public Boolean LogIn(string email, string password)
        {
            if(middleware.Check(email, password))
            {
                Console.WriteLine("Usuário autorizado");
                Console.WriteLine("Seja bem-vindo");
                return true;
            }

            return false;
        }

        public void RegisterUser(string email, string password)
        {
            users[email] = password;
        }

        public Boolean HasEmail(string email)
        {
            return users.ContainsKey(email);
        }

        public Boolean IsValidPassword(string email, string password)
        {
            string value = "";

            users.TryGetValue(email, out value);

            return password == value;
        }

    }
}
