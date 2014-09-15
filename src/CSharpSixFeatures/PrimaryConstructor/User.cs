using System;

namespace CSharpSixFeatures.PrimaryConstructor
{
    // All instances of the User class must have a name and an email
    public class User(string name, string email) 
    {
        {
            if (name == null) throw new ArgumentException("name was not set");
            if (email == null) throw new ArgumentException("email was not set");
        }
        
        private string _name = name;
        private string _email = email;

        public string Name { get { return _name; } }
        public string Email { get { return _email; } }

        public User(string name, string email, string nickname) : this(name, email) { /** init nickname field **/ }
    }
}