using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebCalculator.Models;
using WebCalculatorLibrary;



namespace WebCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        public string Add (decimal valueone, decimal valuetwo)
        {
            return $"{MathLib.Add(valueone, valuetwo)}";
        }

        public string Subtract (decimal valueone, decimal valuetwo)
        {
            return $"{MathLib.Subtract(valueone, valuetwo)}";
        }

        public string Multiply (decimal valueone, decimal valuetwo)
        {
            return $"{MathLib.Multiply(valueone, valuetwo)}";
        }

        public string Divide (decimal valueone, decimal valuetwo)
        {
            return $"{MathLib.Divide(valueone, valuetwo)}";
        }

        public string Ceiling (double number)
        {
            return $"{MathLib.Ceiling(number)}";
        }

        public string Floor (double number)
        {
            
            return $"{MathLib.Floor(number)}";
        }

    }
        
}
