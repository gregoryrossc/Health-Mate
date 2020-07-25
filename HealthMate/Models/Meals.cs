using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthMate.Models
{
    public partial class Meals
    {
        public Meals()
        {
            Flags = new HashSet<Flags>();
            Stats = new HashSet<Stats>();
        }

        [Key]
        [Column("MealID")]
        public int MealId { get; set; }
        [StringLength(50)]
        public string MealName { get; set; }
        public int? Calories { get; set; }
        public int? Protein { get; set; }
        public int? Carbohydrates { get; set; }
        public int? Fat { get; set; }
        public int? Size { get; set; }

        [InverseProperty("FlagMeal")]
        public virtual ICollection<Flags> Flags { get; set; }
        [InverseProperty("Meal")]
        public virtual ICollection<Stats> Stats { get; set; }
    }
}
