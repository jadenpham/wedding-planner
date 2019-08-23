using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models
{
    public class Wedding
    {
        [Key]
        [Column("wedding_id")]
        public int WeddingId {get; set;}

        [Required]
        [Column("wed_one")]
        [MinLength(2, ErrorMessage="Name should be at least 2 characters")]
        public string WedOne{get; set;}      

        [Required]
        [Column("wed_two")]
        [MinLength(2, ErrorMessage="Name should be at least 2 characters")]
        public string WedTwo{get; set;}
        
        [Required]
        [Column("date")]
        [DateValidator]
        [DisplayFormat(DataFormatString="{yyyyMMdd}")]
        [DataType(DataType.Date)]
        public DateTime Date {get; set;}

        [Required]
        [Column("address")]
        public string Address {get; set;}

        [Column("created_at")]
        public DateTime CreatedAt {get; set;} = DateTime.Now;

        [Column("updated_at")]
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

        [Column("user_id")]
        public int UserId{get; set;}

        public UserReg Creator {get; set;}

        public List<Response> Guests {get; set;}
    }

    public class DateValidatorAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object date, ValidationContext validationContext)
        {
            DateTime today = DateTime.Now;
            DateTime WeddingDate = Convert.ToDateTime(date);
            if(today > WeddingDate)
            {
                return new ValidationResult("Wedding date must be in the future");
            } else{
                return ValidationResult.Success;
            }
        }
    }
}