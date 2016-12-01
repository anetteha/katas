using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    public class Calculator
    {
        public string Add(string s)
        {

            var numbers = s.Split(',');
            var isNumbers = AreNumbersValid(numbers);

            if (!isNumbers)
                throw new ArgumentException("Invalid input!");

            var numbersList = numbers.Select(int.Parse).ToList();

            var sum = numbersList.Sum(x => x);

            return sum.ToString();
        }

        private static bool AreNumbersValid(IEnumerable<string> numbers)
        {
            foreach (var number in numbers)
            {
                int numberAsInt;
                if (!int.TryParse(number, out numberAsInt))
                    return false;
            }
            return true;
        }

        public string Subtract(string s)
        {
            var numbers = s.Split(',');
            var numbersList = numbers.Select(int.Parse).ToList();

            var sum = numbersList.Sum(x => x*(-1))+numbersList[0]*2;

            return sum.ToString();
        }
    }
}
