using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class Person
    {

        public enum GenderEnum
        {
            Male, Female
        }

        [Key]
        public int PersonId { get; set; }

        public string Image { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "FirstName cannot be longer than 40 characters and less than 3 characters")]
        [RegularExpression(@"^[a-zA-Z_ ]*$", ErrorMessage = "FirstName cannot contain numbers ")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "LastName cannot be longer than 40 characters and less than 3 characters")]
        [RegularExpression(@"^[a-zA-Z_ ]*$", ErrorMessage = "LastName cannot contain numbers ")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? DateofBirth { get; set; }
                
        [Required]
        [EnumDataType(typeof(GenderEnum))]
        public GenderEnum Gender { get; set; }

        [Required]
        public string city { get; set; }

        public int Age { get; set; }

    }
}   
    
