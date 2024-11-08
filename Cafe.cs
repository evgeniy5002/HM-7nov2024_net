using System.Collections;

namespace HW
{
    class Cafe<T> where T : IEnumerable
    {
        public T _workers;

        public Cafe(T collection)
        {
            _workers = collection;
        }

        public void Print()
        {
            foreach (var worker in _workers)
            {
                Console.WriteLine(worker.ToString());
            }
        }
    }
}