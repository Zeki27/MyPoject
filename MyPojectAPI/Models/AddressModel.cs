using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPojectAPI.Models
{
    public class AddressModel
    {
        [Required]
        public int PostalCode { get; set; }
        [Required]
        [MaxLength(30)]
        public string CountryNameHun { get; set; }
        [Required]
        [MaxLength(30)]
        public string CountryNameEng { get; set; }
        [Required]
        [MaxLength(30)]
        public string StreetHun { get; set; }
        [Required]
        [MaxLength(30)]
        public string StreetEng { get; set; }
        [Required]
        public int HouseNumber { get; set; }
        [Required]
        public int PersonalInfoId { get; set; }
    }
}
