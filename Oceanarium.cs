using System.Collections;

namespace HW
{
    class Oceanarium<T> : IEnumerable where T : Animal
    {
        public List<T> _animals;

        public Oceanarium()
        {
            _animals = new List<T>();
        }

        public void Add(T animal)
        {
            _animals?.Add(animal);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < _animals.Count; i++)
            {
                yield return _animals[i];
            }
        }
    }
}