using ChessApp.Location;

namespace ChessApp
{
    public class Thing
    {
        public string PieceType {get;set;}

        public ILocation Location { get; set; }
    }
}