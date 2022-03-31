using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_typesandvariables
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void Strings()
        {

            // string is a collection of char

            //declare
            string thisIsDeclared;

            //initalize by assigning
            string declared;
            declared = "this is initialized";

            //declared and initalized
            string declaredAndInitalized = "this is both declaring and initializing";

            string number = "7788";

            string nullString;
            string emptyString = "";

            string firstName = "corey";
            string lastName = "Pfleiger";

            //Concatenation
            string concateenatedFullName = firstName + " " + lastName;
            Console.WriteLine(concateenatedFullName);

            //compositing
            string compositeFullname = string.Format("{0} {1}", firstName, lastName);
            Console.WriteLine(compositeFullname);

            // interpolation
            string interpolatedFullName = $"{firstName} {lastName}";
            Console.WriteLine(interpolatedFullName);
        }

        [TestMethod]
        public void Collections()
        {

            string stringExample = "this is a collection of char";

            //arrays use[] and can not be edited after creation
            string[] stringArray = { "hello", "world", "why" };

            Console.WriteLine(stringArray[2]);

            // updating a value by it's index
            stringArray[0] = "who";

            stringArray[2] = "changed";

            List<string> listOfStrings = new List<string>();
            List<int> listOfIntergers = new List<int>();

            listOfStrings.Add("A string");
            listOfIntergers.Add(12900);

            // first in first out, like getting in line
            Queue<string> firstInFirstOut = new Queue<string>();

            firstInFirstOut.Enqueue("i'm first");
            firstInFirstOut.Enqueue("i'm next");

            // a collection of key value pairs
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();

            //have to give it a key, 7, and value "agent"
            keyAndValue.Add(7, "agent");

            Dictionary<string, string> realDictionary = new Dictionary<string, string>();

            realDictionary.Add("know, be aware of through observation, inquiry, or information");

            Console.WriteLine(realDictionary["know"]);

            // extra collection types, not as usful but good to know they exist
            // dictionary that is sorted so the value can be accessed by the key and the index
            SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();
            HashSet<int> uniqueList = new HashSet<int>();

            //like stacking objects, last object added is first off the stack
            Stack<string> lastInFirstOut = new Stack<string>();

        }

        [TestMethod]
        public void Classes()
        {
            // use new to make a 'new' instance of a class
            Random rng = new Random();

            int randomNumber = rng.Next();
            Console.WriteLine(randomNumber);
        }
    }
}
