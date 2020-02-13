using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattren
{
    public abstract class VehichleFactory
    {
        public abstract IFactory GetVehichel(VehicleType vehicle);
    }
}
