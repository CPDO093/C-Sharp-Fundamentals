using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_classes
{
    public enum VehicleTypes { car, truck, van, motercycle, spaceship, plane, boat }
    //accessor typs:
    //public: available througout the full assembly
    //private: only available in the same class or struct
    //protected: like private but its also accessible by derived class
    // internal: accessible in the assembly only
    // protected internal: accessible in this assembly only and derived classes in other assemblies
    // private protected: only in this class, by code in the same class, and derived


    public class Vehicle // (noun)
    {
        // Constructor
        public Vehicle() // Implicit, goes away when another constructor is added
        {
            LeftIndicator = new Indicator();
            RightIndicator = new Indicator();
        }

        public Vehicle(string make, string model, double mileage, VehicleTypes type)
        {
            make = make;
            model = model;
            mileage = mileage;
            VehicleTypes = type;
            LeftIndicator = new Indicator();
            RightIndicator = new Indicator();
        }

        //feilds, properties(adjective), and methods(verbs)

        //1 access modifier = where can this be seen?
        //2 type = what type of  property is it?
        //3 name= what's it called?
        //4 getters and setters = how do i set it? how do i get it?

        //1      //2   //3      //4  
        public string make { get; set; }
        public string model { get; set; }
        public double mileage { get; set; }
        public VehicleTypes VehicleTypes { get; set; }
        public bool IsRunning { get; private set; }

        public Indicator RightIndicator { get; set; }
        public Indicator LeftIndicator { get; set; }

        public void TurnOn()
        {
            IsRunning = true;
            Console.WriteLine("you turn on the vehicle");

        }
        public void TurnOff()
        {
            IsRunning = false;
            Console.WriteLine("you turned it off");

        }

        public void Drive()
        {
            if (IsRunning)
            {
                Console.WriteLine("you started driving");

            }
            else
            {
                Console.WriteLine("you need to turn on the vehicle first");

            }
        }

        public void IndicateRight()
        {
            RightIndicator.TurnOn();
            LeftIndicator.TurnOff();
        }
        public void IndicateLeft()
        {
            RightIndicator.TurnOff();
            LeftIndicator.TurnOn();
        }
        public void ClearIndicators()
        {
            RightIndicator.TurnOff();
            LeftIndicator.TurnOff();
        }
        public void TurnOnHazards()
        {
            RightIndicator.TurnOn();
            LeftIndicator.TurnOn();
        }


        public class Indicator
        {
             // create a class called indicator that has a property called "is flashing"
             //is flashing should have a private set
            //the indicator class also then needs the meathods required to change the state of isflashing property

             public bool IsFlashing { get; private set; }

    
             public void TurnOn()
             {
             IsFlashing = true;
            Console.WriteLine("your indicator signal is on");

             }
             public void TurnOff()
             {
            IsFlashing = false;
            Console.WriteLine("indicator is off");
             }



        }
    }

}
