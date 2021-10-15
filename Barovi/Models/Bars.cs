using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Barovi.Models
{
    public class Bars
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Име")]
        public string Name { get; set; }
        [Display(Name = "Град")]
        public string Grad { get; set; }
        [Display(Name = "Слика")]
        public string Image { get; set; }
        [Display(Name = "Работно време")]
        public string Hours { get; set; }
        [Display(Name = "Ширина")]
        public string Lat { get; set; }
        [Display(Name = "Должина")]
        public string Lon { get; set; }
        [Display(Name = "Телефон")]
        public string Phone { get; set; }
        [Display(Name = "Рејтинг")]
        public float Rating { get; set; }
        [Display(Name="Капацитет")]
        public string Kapacitet { get; set; }


      

    }
}