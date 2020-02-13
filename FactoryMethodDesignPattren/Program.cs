using System;

namespace FactoryMethodDesignPattren
{
    class Program
    {
        static void Main(string[] args)
        {
            VehichleFactory factory = new ConcreteVehicleFactory();

            IFactory scooter = factory.GetVehichel(VehicleType.Scooter);
            scooter.drive(10);

            IFactory bike = factory.GetVehichel(VehicleType.Bike);
            bike.drive(20);

            Console.ReadKey();
        }
    }
}
