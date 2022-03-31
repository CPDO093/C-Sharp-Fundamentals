using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_StreamingContent_Repository
{
    public enum GenreType { Horror = 1, Drama, Fantasy, Action, Comedy, SciFi, Romance, Bromance = 100 }
    public enum MaturityRating
    {
        G = 0,
        PG,
        PG13,
        R,
        NC_17,
        TV_Y = 10,
        TV_G,
        TV_PG,
        TV_14,
        TV_MA
    }
    public class StreamingContent
    {
        // POCO Plain old C-Sharp objects
        //Class ibject that only conatains data validation and properties
        public StreamingContent() { }
        public StreamingContent(string title, string description, double stars, MaturityRating maturity, GenreType type)
        {
            Title = title;
            Description = description;
            StarRating = stars;
            MaturityRating = maturity;
            GenreType = type;

        }

        public string Title { get; set; }
        public string Description { get; set; }
        public double StarRating { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public bool IsFamilyFriendly
        {
            get
            {
                switch (MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                    case MaturityRating.TV_Y:
                    case MaturityRating.TV_G:
                    case MaturityRating.TV_PG:
                        return true;
                    default:
                        return false;
                }
            }


           

        }   

        public GenreType GenreType { get; set; }



    }
}
