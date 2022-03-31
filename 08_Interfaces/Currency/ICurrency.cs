using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Currency
{
    internal interface ICurrency
    {
        string Name { get; }
        decimal Value { get; }

    }
}
