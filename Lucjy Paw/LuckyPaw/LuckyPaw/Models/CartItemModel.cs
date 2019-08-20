using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LuckyPaw.Models
{
    public class CartItemModel
    {
        [Key]
        public int CartId { get; set; }

        [ForeignKey("PricingPuppyModel")]
        public int PricePuppyID { get; set; }

        public string PricePuppyDesc { get; set; }

        public double PricePuppy { get; set; }

        [ForeignKey("TrainingServicesPriceModel")]
        public int TrainingServicesPriceID { get; set; }

        public string TrainingName { get; set; }

        public double PriceTraining { get; set; }

        public int CartQty { get; set; }

        public string Email { get; set; }

    }
}