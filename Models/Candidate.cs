using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Form.Models
{
    public class Candidate
    {
        [Required(ErrorMessage ="E-mail is required")]//doldurulması zorunlu
        public String? Email { get; set; }= String.Empty;

        [Required(ErrorMessage ="Firstname is required")]//doldurulması zorunlu
        public String? FirstName { get; set; }= String.Empty;

        [Required(ErrorMessage ="Lastname is required")]//doldurulması zorunlu
        public String? LastName { get; set; }= String.Empty;
        public String FullName =>$"{FirstName?.ToLower()}{LastName?.ToLower()}";
        public int? Age { get; set; }
        public String? SelectedCourse { get; set; }= String.Empty;
        public DateTime ApplyAt {get; set;}
        public Candidate()
        {
            ApplyAt=DateTime.Now;
        }

    }
}