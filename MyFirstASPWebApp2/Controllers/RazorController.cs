using Microsoft.AspNetCore.Mvc;
using MyFirstASPWebApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASPWebApp2.Controllers
{
    public class RazorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult form(CalculatorModel model)
        {
            model.finalGrade = Decimal.Multiply(model.assignment, (decimal)0.5) + Decimal.Multiply(model.gp, (decimal)0.1) + Decimal.Multiply(model.quiz, (decimal)0.1) +
                        Decimal.Multiply(model.mid, (decimal)0.1) + Decimal.Multiply(model.final, (decimal)0.1) + Decimal.Multiply(model.intex, (decimal)0.1);
            if (model.finalGrade >= 94)
            {
                model.letterGrade = "A";
            }
            else if (model.finalGrade >= 90)
            {
                model.letterGrade = "A-";
            }
            else if (model.finalGrade >= 87)
            {
                model.letterGrade = "B+";
            }
            else if (model.finalGrade >= 84)
            {
                model.letterGrade = "B";
            }
            else if (model.finalGrade >= 80)
            {
                model.letterGrade = "B-";
            }
            else if (model.finalGrade >= 77)
            {
                model.letterGrade = "C+";
            }
            else if (model.finalGrade >= 74)
            {
                model.letterGrade = "C";
            }
            else if (model.finalGrade >= 70)
            {
                model.letterGrade = "C-";
            }
            else if (model.finalGrade >= 67)
            {
                model.letterGrade = "D+";
            }
            else if (model.finalGrade >= 64)
            {
                model.letterGrade = "D";
            }
            else if (model.finalGrade >= 60)
            {
                model.letterGrade = "D-";
            }
            else
            {
                model.letterGrade = "E";
            }

            //ViewData["finalGrade"] = model.finalGrade;
            //ViewData["letterGrade"] = model.letterGrade;
            return View(model);
        }
    }
}
