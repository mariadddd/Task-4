namespace list
{
    internal class User
    {
        string result = string.Empty;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }
        public User(string name, string surname, string age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public string Info() 
        {
            result = $"{Name} {Surname}, {Age}.";
            return result;
        }
    }
}
