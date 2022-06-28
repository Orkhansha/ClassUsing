using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAccessModifiers
{
    class Car
    {
        
        public string brand;
        private int _horsePower;

        public readonly int speed;
         
        // public string Color { get; set; }

        public Car()
        {
            speed = 500;
        }

       

        public int HorsePower 
        {
            get
            {
                if(_horsePower < 150)
                {
                    Console.WriteLine("Can't drive");
                    return -1;
                }

                return _horsePower;
            } 
            
            set 
            {
                if (value < 100)
                {
                    Console.WriteLine("Please set correct power");
                    return;
                }
                _horsePower = value;
            }
        }

    }
}
