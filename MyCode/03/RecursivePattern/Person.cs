namespace RecursivePattern
{
    public class Person
    {
        public int Age { get; }
        public string Name { get; }
        public bool RegisteredToVote { get; set; }
        public bool EligibleToVote { get => Age > 18; }

        public Person(string name, int age, bool registered)
        {
            Name = name;
            Age = age;
            RegisteredToVote = registered;
        }
    }
}