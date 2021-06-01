using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Services
{
    public class AgeCalculationService
    {
        private readonly DateTimeService _dateTimeService;

        public AgeCalculationService(DateTimeService dateTimeService)
        {
            _dateTimeService = dateTimeService;
        }

        public DateTime CalculateBirthDateFromAge(int age)
        {
            var currentDate = _dateTimeService.GetCurrentDate();

            return currentDate.AddYears(age * (-1));
        }
    }
}
