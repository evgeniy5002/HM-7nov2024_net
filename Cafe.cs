using System.Collections;

namespace HW
{
    public class Cafe<T> : IEnumerable  where T : Worker
    {
        private List<T> _workers;

        public Cafe()
        {
            _workers = new List<T>();
        }

        public void Add(T worker)
        {
            _workers.Add(worker);
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _workers.Count; i++)
            {
                yield return _workers[i];
            }
        }
    }
}