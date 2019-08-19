using System;
using System.ComponentModel.DataAnnotations;

namespace LuckyPaw.Models
{
    public class TrainersModel
    {
        [Key]
        public string TrainerId { get; set; }

        public string TrainerName { get; set; }

        public string TrainerArea { get; set; }

        public int DogNumber { get; set; }

        public string DogName { get; set; }
    }
}