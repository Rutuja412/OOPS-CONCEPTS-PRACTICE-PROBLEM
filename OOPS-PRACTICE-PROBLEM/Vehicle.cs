using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_PRACTICE_PROBLEM
{
    public class Vehicle
    {
        public string brand = "Ford";
        public void horn()
        {
            Console.WriteLine("Peek Peek");
        }
    }
    class Car : Vehicle
    {
        public string color = "Red";
    }
}
