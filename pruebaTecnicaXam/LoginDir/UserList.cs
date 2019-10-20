using System;
using System.Collections.Generic;

namespace pruebaTecnicaXam.LoginDir
{
    public static class UserList
    {
        public static List<User> GetUsers()
        {
            List<User> users = new List<User>()
            {
                new User
                {
                    Name = "Pepe",
                    Pass = "Pepe"
                },
                new User
                {
                    Name = "Usuario1",
                    Pass = "Usu"
                },
                new User
                {
                    Name = "Usuario2",
                    Pass = "Usu"
                }
            };
            return users;
        }
    }
}
