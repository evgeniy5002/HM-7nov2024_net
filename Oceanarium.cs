using System.Collections;

namespace HW
{
    public class Oceanarium<T> where T : IEnumerable
    {
        public T _animals;

        public Oceanarium(T collection)
        {
            _animals = collection;
        }

        public void Print()
        {
            foreach (var animal in _animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}