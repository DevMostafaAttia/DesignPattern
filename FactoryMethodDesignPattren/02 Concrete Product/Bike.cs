using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattren
{
    public class Bike : IFactory
    {
        public void drive(int mile)
        {
            Console.WriteLine("Drive the Bike : " + mile.ToString() + "mile.");
        }
    }
}
