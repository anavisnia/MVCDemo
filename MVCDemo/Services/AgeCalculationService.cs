using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Services
{
    public class AgeCalculationService
    {

        public DateTime CalculateBirthDateFromAge(int age)
        {
            var currentDate = DateTime.Now;

            return currentDate.AddYears(age * (-1));
        }
    }
}
