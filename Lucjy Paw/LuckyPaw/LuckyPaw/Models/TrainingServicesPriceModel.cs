using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LuckyPaw.Models
{
    public class TrainingServicesPriceModel
    {
        [Key]
        public int TrainingServicesPriceID { get; set; }

        public string TrainingName { get; set; }

        public double PriceTraining { get; set; }

        public string TrainingDesc { get; set; }

        public int TrainingQty { get; set; }

    }
}