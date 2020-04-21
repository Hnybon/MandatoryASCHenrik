namespace MandatoryASCHenrik.World
{
    public class Tile
    {
        //Skal bruges til at holde styr på objektets position

        //TODO How to keep track of Creatures in the world?
        //måske states

        public int row;
        public int column;

        public Tile()
        {
            
        }

        public Tile(int row, int column)
        {
            this.row = row;
            this.column = column;
        }
    }
}