using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LuckyPaw.Models
{
    public class TrainingDogModel
    {
        [Key]
        public int TrainingId { get; set; }

        public string DogName { get; set; }

        [ForeignKey("TrainersModel")]
        public string TrainerId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Graduation Date")]
        public DateTime GraduationDate { get; set; }

        public string TrainingType { get; set; }

    }
}