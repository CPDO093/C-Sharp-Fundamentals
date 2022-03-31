using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Inheritence.Animals
{
    public enum DietType { Herbivore = 1, Carnivore, Omnivore}
    public abstract class Animal
    {
        
          public Animal()
          {
                Console.WriteLine("this is the animal constructor");
          }
        //Base empty Constructor still gets 
          public int NumberOfLegs { get; set; }
          public bool IsMammal { get; set; }
          public bool HasFur { get; set; }
          public DietType Diet { get; set; }
            // virtual: can be over written  by a derived type. (A child class can over write it)
          public virtual void Move()
          {
                Console.WriteLine($"this {GetType().Name} moves");
          }



    }
    

}
