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
        public override string ToString() 
        {  
            return $"{Name} {Surname}, {Age}."; 
        }       
    }
}
