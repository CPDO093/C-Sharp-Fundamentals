using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Morning_Challenge
{
    public enum EntreyType { checkIn = 1, notice, incident, majorIncident = 100}

    public class DeckLogContent
    {
        public DeckLogContent () { }
        public DeckLogContent(DateTime date, string description, string watcher, EntreyType type)
        {
            Date = date;
            Description = description;
            DutyPersonel = watcher;
            EntryType = type;
        }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string DutyPersonel { get; set; }
        public EntreyType EntryType { get; set; }

    }
}
