using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPojectAPI.Models
{
    public class PersonalInfoModel
    {
        [Required]
        [MaxLength(30)]
        public string BirthPlace { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
        [Required]
        [MaxLength(30)]
        public string Email { get; set; }
        [Required]
        [MaxLength(250)]
        public string AboutHun { get; set; }
        [Required]
        [MaxLength(250)]
        public string AboutEng { get; set; }
    }
}
