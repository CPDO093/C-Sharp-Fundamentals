using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _11_RestaurantRater.Models
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(0,10)]
        public double FoodScore { get; set; }
        [Required]
        [Range(0, 10)]
        public double EnvironmentScore { get; set; }

        [Required]
        [Range(0, 10)]
        public double CleanlinessScore { get; set; }

        public double AverageRating
        {
            get
            {
                return (FoodScore + EnvironmentScore + CleanlinessScore) / 3; //give back average of all scores
            }
        }
        // Foreign key relationship
        [ForeignKey(nameof(Restaurant))]
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; } 
        // virtual makes it a soft property and entity will fill that info in with lazy loading
    }
}