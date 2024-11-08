using System.Collections;

namespace HW
{
    class FootballTeam<T> where T : IEnumerable
    {
        public T _players;

        public FootballTeam(T collection)
        {
            _players = collection;
        }

        public void Print()
        {
            foreach (var player in _players)
            {
                Console.WriteLine(player.ToString());
            }
        }
    }
}