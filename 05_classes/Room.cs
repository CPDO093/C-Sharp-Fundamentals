using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_classes
{
    public class Room
    {
        /*
       - Create a Room class that has three properties: one each for the length, width, and height.
        -Create a method that calculates total square footage.
        -We also would like to include some constants that the define a minimum and maximum length, width, and height.
        -When setting the properties, make sure to compare the values to the min/max and only set them if the value is valid.

        Bonus:
        -create a constructor
        Create a method that calculates total lateral surface area.
        -Only allow the properties to be set from inside the class itself
        -Throw an exception if the given value is outside the permitted range.
        -Test the code like we did with the Vehicle tests.
        */

        private const double MaxLength = 30;
        private const double MinLength = 6;
        private const double MaxWidth = 30;
        private const double MinWidth = 6;
        private const double MaxHeight = 20;
        private const double MinHeight = 8;




             private double _Length;
             private double _Width;
             private double _Height;


        //constructor
        // room (){} implicit, but inaccessiable when another constructor exists
        public Room(double l, double w, double h)
        {
            Length = l;
            Width = w;
            Height = h;
        }





        public double Length
        {
            get { return _Length; }
            set
            { // compare to max and min before setting
                //Throw an exception if out side the range
                if (value < MinLength || value > MaxLength)
                {
                   
                    throw new ArgumentException($"outside my ranges of {MinLength} and {MaxLength}.");
                }
                else
                _Length = value;
            }
        }

        public double Width
        {
            get { return _Width; }
            set
            { 
                if (value < MinWidth || value > MaxWidth)
                {
                    //dont store value
                    throw new ArgumentException($"outside my ranges of {MinWidth} and {MaxWidth}.");
                }
                else 
                _Width = value; 
            }

        }   

        public double Height
        {
            get { return _Height; }
            set
            { 
                if (value < MinHeight || value > MaxHeight)
                {
                    //dont store value
                    throw new ArgumentException($"outside my ranges of {MinHeight} and {MaxHeight}.");
                }
                else
                _Height = value;
            }

        }

        //method for square footage

        public double CalculateSQFootage()
        {
            return Length * Width;
        }

        
        //lateral surface area
            public double area()
                {
                return Length * Height * Width;
                }
           public double LsurfaceArea()
            {
                return 2 * Length * Width + 2 * Width * Height + 2 * Length * Height;
            }
        
        public double CalculateTotalLateralSurfaceArea()
        {
            double lenghtLSA = _Length * _Height * 2;
            double widthLSA = _Width * _Height * 2;
            return lenghtLSA + widthLSA;

        }
        public double Calculate2()
        {
            return ((2 * Length) + (2 * Width)) * Height;
        }
    }

}
