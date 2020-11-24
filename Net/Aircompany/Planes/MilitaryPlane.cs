using Aircompany.Models;

namespace Aircompany.Planes
{
    public class MilitaryPlane : Plane
    {
        public MilitaryType Type { get; private set; }

        public MilitaryPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, MilitaryType type)
            : base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            Type = type;
        }

        public override bool Equals(object obj)
        {
            var plane = obj as MilitaryPlane;
            return plane != null &&
                   base.Equals(obj) &&
                   Type == plane.Type;
        }

        public override int GetHashCode()
        {
            var hashCode = 0;
            hashCode = hashCode + base.GetHashCode();
            hashCode = hashCode + Type.GetHashCode();
            return hashCode;
        }


        public override string ToString()
        {
            return base.ToString().Replace("}",
                    ", type=" + Type +
                    '}');
        }        
    }
}
