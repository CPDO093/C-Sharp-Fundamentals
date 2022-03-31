using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_typesandvariables
{
    [TestClass]
    public class ValueTypes
    {
        // comment ctrl + kc
        /* long comment crtl + shift = / */

        //PascalCaseCapitalization
        // camelCaseCapitalization
    }
    [TestMethod]
    public void Booleans()
    {
        //declaring a variable
        bool declared;

        //assigning a variable
        declared = true;

        //declare and initalize a variable
        bool declarationAndInitilization = false;

        // assigning after declarition
        declarationAndInitilization = true;
    }

    [TestMethod]
    public void Characters()
    {
        char character = 'a';
        char symbol = '!';
        char number = '7';
        char space = ' ';
        char specialCharater = '\n';


    }

    [TestMethod]
    public void WholeNumbers()
    {
        byte byteMin = 0;
        byte byetmax = 255;

        short shortMin = -32768;
        short shortMax = 32767;

        int intMin = -2147483648;
        int intMax = 2147483647;

        long longMin = -9223372036854775808;
        long longMax = 9223372036854775807;

        // ctrl +k +d foxs format issues

        int a = 15;
        int b = -10;
    }

    [TestMethod]
    public void Decimals()
    {

        // 7 digits of precision
        float floatExample = 1.120012f;

        //15-16 digits of precision
        double doubleExample = 12.121092109d;

        // 28-29 digits of precision
        decimal decimalExample = -123.2210188m;

    }

    enum PastryType
    {
        cake, cupcake, eclaire, petitfour, crossant
    };
    enum Names { corey, chung, fast, wildman }

    [TestMethod]
    public void Enums()
    {

        PastryType mypastry = PastryType.cupcake;
        Names myName = 0;

    }

    [TestMethod]
    public void Structs()
    {

        DateTime today = DateTime.Today;
        DateTime birthday = new DateTime(1980, 6, 20);








    }
}
