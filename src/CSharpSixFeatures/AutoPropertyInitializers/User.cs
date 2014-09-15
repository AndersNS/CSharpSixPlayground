namespace CSharpSixFeatures.AutoPropertyInitializers
{
    public class User(string name, string email)
    {
        public string Name { get; } = name;
        public string Email { get; } = email;
    }
}