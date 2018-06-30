using Core;

namespace Game
{
    public class Location : ILocation
    {
        public Location()
        {
            
        }

        public int XLocation { get; set; }
        public int YLocation { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is ILocation))
                return false;

            var otherLocation = (ILocation)obj;

            if (XLocation != otherLocation.XLocation && YLocation != otherLocation.YLocation)
                return false;

            return true;
        }
        
    }
}
