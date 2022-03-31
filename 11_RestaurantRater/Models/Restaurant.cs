using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _11_RestaurantRater.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public double AverageFoodScore
        {
            get
            {
                double totalAverageRating = 0;
                foreach (Rating rating in Rating)
                {
                    totalAverageRating += rating.FoodScore;
                }
                return (Rating.Count > 0) ? totalAverageRating / Rating.Count : 0;
            }
        }
        public double AverageClenlinessScore
        {
            get
            {
                double total = 0;
                foreach (Rating rating in Rating)
                {
                    total += rating.CleanlinessScore;
                }
                return (Rating.Count > 0) ? total / Rating.Count : 0;
            }
        }
        public double AverageRating
        {
            get
            {
                double total = Rating.Select(r => r.AverageRating).Sum();
                return (Rating.Count > 0) ? total / Rating.Count : 0;
            }
        }
        public virtual List<Rating> Rating { get; set; } = new List<Rating>();
    }
}