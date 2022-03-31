﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_StreamingContent_Repository.Content
{
    public class Show : StreamingContent
    {
        public Show(string title, string description, double stars, MaturityRating maturity, GenreType type) : base(title,
            description, stars, maturity, type) { }
        public Show(string title, string description, double stars, MaturityRating maturity, GenreType type, int numberOfSeasons, List<Episode> episodes)
            : this(title, description, stars, maturity, type)
        {
            Episodes = episodes;
            NumberOfSeasnons = numberOfSeasons;
        }
        public List<Episode> Episodes { get; set; }

        public int NumberOfSeasnons { get; set; }
        public double AverageRunTime
        {
            get
            {
                if (Episodes.Count() != 0)
                {
                    double averageTotal = 0;
                    foreach (Episode episode in Episodes) // this list property is accessible and can be worked through
                    {
                        averageTotal += episode.RunTime;
                    }
                    return averageTotal / Episodes.Count();
                }

                else
                {
                    return 20d;
                }
            }
        }

    }
    public class Episode
    {
        public Episode() { }
        public Episode(string title, double runTime, int s, int e)
        {
            Title = title;
            RunTime = runTime;
            SeasonNumber = s;
            EpisodeNumber = e;
        }
        public string Title { get; set; }
        public double RunTime { get; set; }
        public int SeasonNumber { get; set; }
        public int EpisodeNumber { get; set; }

    }
}
