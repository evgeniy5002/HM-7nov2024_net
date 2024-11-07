namespace HW
{
    public class Animal
    {
        public string? Name { get; set; }
        public bool IsCarnivore { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        public Animal(string name, bool isCarnivore, double weight, int age)
        {
            Name = name;
            IsCarnivore = isCarnivore;
            Weight = weight;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}, IsCarnivore: {IsCarnivore}, Weight: {Weight}, Age: {Age}";
        }
    }

    public class Fish : Animal
    {
        public Fish(string name, bool isCarnivore, double weight, int age)
        : base(name, isCarnivore, weight, age)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    public class Dolphin : Animal
    {
        public Dolphin(string name, bool isCarnivore, double weight, int age)
        : base(name, isCarnivore, weight, age)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    public class Octopus : Animal
    {
        public Octopus(string name, bool isCarnivore, double weight, int age)
        : base(name, isCarnivore, weight, age)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}