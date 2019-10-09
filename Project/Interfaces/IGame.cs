using System.Collections.Generic;

namespace golfcard.Interfaces
{
    public interface IGame
    {
        ICourse Course { get; set; }
        Dictionary<IPlayer, int[]> PlayerScores { get; set; }

        string GetTemplate();
    }
}