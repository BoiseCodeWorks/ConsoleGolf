using System.Collections.Generic;
using golfcard.Interfaces;

namespace golfcard.Models
{
    public class Game : IGame
    {

        public ICourse Course { get; set; }
        public Dictionary<IPlayer, int[]> PlayerScores { get; set; }

        public string GetTemplate()
        {
            throw new System.NotImplementedException();
        }
        public Game(ICourse course, string[] playerNames)
        {
            Course = course;
            PlayerScores = new Dictionary<IPlayer, int[]>();
            for (int i = 0; i < playerNames.Length; i++)
            {
                string name = playerNames[i];
                PlayerScores.Add(new Player(name, 0), new int[Course.Holes]);
            }
        }
    }
}