namespace golfcard.Interfaces
{
    public interface IPlayer
    {
        string Name { get; set; }
        int Handicap { get; set; }

        string GetTemplate();
    }
}