namespace eArtAPI.Domain
{
    public class Piece
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public Piece(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}