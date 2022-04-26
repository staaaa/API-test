using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class User
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        private readonly string _password;

        public User(string id, string name, string password)
        {
            Id = id;
            Name = name;
            _password = password;
        }
    }
}
