using System;

namespace Aircompany.Planes
{
    public class PassengerPlane : Plane
    {
        public int PassengersCapacity { get; private set; }

        public PassengerPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, int passengersCapacity)
            :base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            PassengersCapacity = passengersCapacity;
        }

        public override bool Equals(object obj)
        {
            PassengerPlane plane = obj as PassengerPlane;
            return plane != null &&
                   base.Equals(obj) &&
                   PassengersCapacity == plane.PassengersCapacity;
        }

        public override int GetHashCode()
        {
            var hashCode = 0;
            hashCode = hashCode + base.GetHashCode();
            hashCode = hashCode + PassengersCapacity.GetHashCode();
            return hashCode;
        }
       
        public override string ToString()
        {
            return base.ToString().Replace("}",
                    ", passengersCapacity=" + PassengersCapacity +
                    '}');
        }       
        
    }
}
