using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattren
{
    public class Scooter : IFactory
    {
        public void drive(int mile)
        {
            Console.WriteLine("Drive  the Scooter : " + mile.ToString() + "mile.");
        }
    }
}
