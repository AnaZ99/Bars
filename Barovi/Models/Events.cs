using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Barovi.Models
{
    public class Events
    {
        [Key]
        [Display(Name = "Име")]
        public string Name { get; set; }
        [Display(Name = "Слика")]
        public string Image { get; set; }
        [Display(Name = "Локација на настан")]
        public string Location { get; set; }
        [Display(Name = "Цена на карта")]
        public int Price { get; set; }
        [Display(Name = "Дозволена возраст")]
        public string Age { get; set; }
        
    }
}