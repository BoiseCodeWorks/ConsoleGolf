using golfcard.Interfaces;

namespace golfcard.Models
{
    public class Course : ICourse
    {


        public string Name { get; set; }
        public int Holes { get; set; }
        public int[] Par { get; set; }

        public string GetTemplate()
        {
            throw new System.NotImplementedException();
        }

        public Course(string name, int holes, int[] par)
        {
            Name = name;
            Holes = holes;
            Par = par;
        }
    }
}