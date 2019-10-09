using golfcard.Interfaces;

namespace golfcard.Models
{
    public class Player : IPlayer
    {


        public string Name { get; set; }
        public int Handicap { get; set; }

        public string GetTemplate()
        {
            throw new System.NotImplementedException();
        }


        public Player(string name, int handicap)
        {
            Name = name;
            Handicap = handicap;
        }
    }
}