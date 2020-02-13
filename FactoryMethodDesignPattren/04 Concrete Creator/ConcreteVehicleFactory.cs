using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattren
{
    public class ConcreteVehicleFactory : VehichleFactory
    {
        public override IFactory GetVehichel(VehicleType vehicle)
        {
            switch (vehicle)
            {
                case VehicleType.Scooter:
                    return new Scooter();
                case VehicleType.Bike:
                    return new Bike();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", vehicle));
            }
        }
    }
}
