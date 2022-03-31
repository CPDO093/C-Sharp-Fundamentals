using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Inheritence.Animals
{
    public class Bear : Animal
    {

        public Bear()
        {
            Console.WriteLine("creating Bear");
            IsMammal = true;
            Diet = DietType.Carnivore;
            HasFur = true;
            NumberOfLegs = 4;

        }
        public bool IsAngry { get; set; }
        public bool IsHibernating { get; set; }
        public string FurColor { get; set; }
        public virtual void Roar()
        {
            Console.WriteLine("the bear roars!");
        }

    }
    public class PolarBear : Bear
    {
        public PolarBear()
        {
            Console.WriteLine("adding ice");
            FurColor = "White";
        }
        public override void Roar()
        {
            base.Roar();
            Console.WriteLine("The polar bear roars and you see its breath mist in the cold aid!");
        }
        public void Run()
        {
            Move();
            Move();
            Move();
            Move();
            Move();

        }

    }
}
