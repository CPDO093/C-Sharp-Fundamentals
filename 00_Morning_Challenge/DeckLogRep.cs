using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _00_Morning_Challenge
{
    [TestClass]
    public class DeckLogRep
    {
        protected readonly List<DeckLogContent> _deckLogDirectory = new List<DeckLogContent>();
        
        //repository pattern: a typical design pattern for accessing/useing database
        //CRUD functionallity: the standard functions you need
        //create
        public bool AddContentToDirectory(DeckLogContent entery)
        {
            DateTime date = _deckLogDirectory.Date;
            _deckLogDirectory.Add(entery);
            bool wasAdded = (_deckLogDirectory.Date() 
                > date) ? true : false;
            return wasAdded;
        }
        //read
        public List<DeckLogContent> GetContents()
        {
            return _deckLogDirectory;
        }

        //update
        public bool UpdateExistingContent(string origionalEntery, DeckLogContent newEntery)
        {
            DeckLogContent oldEntery = GetContnentByEntery(origionalEntery);
            if (oldEntery != null)
            {
                oldEntery.Date = 
            }
        }
        //delete



    }
}
