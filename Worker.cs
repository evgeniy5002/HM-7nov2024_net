namespace HW
{
    public class Worker
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Worker(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}, Age: {Age}";
        }
    }
}