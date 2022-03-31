using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Morning_Challenge.NewFolder1
{
    public abstract class Product
    {
        public virtual decimal Price => 1m;

    }
    public class Bread : Product
    {
        public override decimal Price => 500.01m;
    }
    public class Cake : Product
    {
        public override decimal Price => 2000m;
    }
    public class Pastry : Product
    {
        public override decimal Price => 200.10m;
    }
    public class Pies : Product
    {
        public override decimal Price => 851.5m;
    }
    public class Donut : Product
    {
        public override decimal Price => 500.01m;
    }

}
