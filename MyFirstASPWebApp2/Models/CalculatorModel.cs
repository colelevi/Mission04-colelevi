using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASPWebApp2.Models
{
    public class CalculatorModel
    {
        [Required]
        [Range(1.00, 100.00, ErrorMessage = "Please enter a Amount between 1.00 and 100.00")]
        public decimal assignment { get; set; }
        ////setter
        //public void setAssignment(decimal input)
        //{
        //    this.assignment = input;
        //}

        ////getter
        //public decimal getAssignment()
        //{
        //    return this.assignment;
        //}
        [Required]
        [Range(1.00, 100.00, ErrorMessage = "Please enter a Amount between 1.00 and 100.00")]
        public decimal gp { get; set; }
        [Required]
        [Range(1.00, 100.00, ErrorMessage = "Please enter a Amount between 1.00 and 100.00")]
        public decimal quiz { get; set; }
        [Required]
        [Range(1.00, 100.00, ErrorMessage = "Please enter a Amount between 1.00 and 100.00")]
        public decimal mid { get; set; }
        [Required]
        [Range(1.00, 100.00, ErrorMessage = "Please enter a Amount between 1.00 and 100.00")]
        public decimal final { get; set; }
        [Required]
        [Range(1.00, 100.00, ErrorMessage = "Please enter a Amount between 1.00 and 100.00")]
        public decimal intex { get; set; }

        public decimal finalGrade;
        public string letterGrade;

    }
}
