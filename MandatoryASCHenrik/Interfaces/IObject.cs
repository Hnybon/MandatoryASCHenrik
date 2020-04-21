using MandatoryASCHenrik.World;

namespace MandatoryASCHenrik.Interfaces
{
    public interface IObject
    {

        //TODO What happens to the tile value when the object is picked up?
        int Weight { get; set; }
        Tile Tile { get; set; }
    }
}