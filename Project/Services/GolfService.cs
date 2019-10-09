using System.Collections.Generic;
using golfcard.Interfaces;
using golfcard.Models;

namespace golfcard.Services
{
    public class GolfService
    {
        public List<Message> Messages { get; set; }
        private IGame _game { get; set; }

        public List<ICourse> Courses { get; set; }
        public void AddHoleScores(int[] scores)
        {

        }
        public void NewGame(int course, string[] names)
        {

        }
    }
}