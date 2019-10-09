namespace golfcard.Interfaces
{
    public interface ICourse
    {
        string Name { get; set; }
        int Holes { get; set; }
        int[] Par { get; set; }

        string GetTemplate();
    }
}