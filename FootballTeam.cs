using System.Collections;

namespace HW
{
    class FootballTeam<T> : IEnumerable where T : Player
    {
        public List<T> _players;

        public FootballTeam()
        {
            _players = new List<T>();
        }

        public void Add(T player)
        {
            _players.Add(player);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < _players.Count; i++)
            {
                yield return _players[i];
            }
        }
    }
}