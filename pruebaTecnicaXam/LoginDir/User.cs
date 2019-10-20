using System;
using System.Collections.Generic;

namespace pruebaTecnicaXam.LoginDir
{
    public class User
    {
        public string Name { get; set; }
        public string Pass { get; set; }

        public User()
        {

        }

        public User(string name, string pass)
        {
            this.Name = name;
            this.Pass = pass;
        }

        public bool CheckUser(User user)
        {
            List<User> users = UserList.GetUsers();
            bool isUser = false;
            for (int i = 0; i < users.Count; i++)
            {
                if (user.Name.ToUpper().Equals(users[i].Name.ToUpper()) && user.Pass.Equals(users[i].Pass)) isUser = true;
            }
            return isUser;
        }
    }
}
