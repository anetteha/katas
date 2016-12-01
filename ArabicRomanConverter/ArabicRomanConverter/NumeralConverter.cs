using System;
using System.Collections.Generic;

namespace ArabicRomanConverter
{
    /// <summary>
    /// The Romans wrote their numbers using letters; specifically the letters 
    /// 'I' meaning '1', 
    /// 'V' meaning '5', 
    /// 'X' meaning '10', 
    /// 'L' meaning '50', 
    /// 'C' meaning '100', 
    /// 'D' meaning '500', and 
    /// 'M' meaning '1000'. 
    /// There were certain rules that the numerals followed which should be observed.
    /// 
    /// The symbols 'I', 'X', 'C', and 'M' can be repeated at most 3 times in a row.
    /// The symbols 'V', 'L', and 'D' can never be repeated. 
    /// The '1' symbols ('I', 'X', and 'C') can only be subtracted from the 2 next highest values('IV' and 'IX', 'XL' and 'XC', 'CD' and 'CM'). 
    /// Only one subtraction can be made per numeral('XC' is allowed, 'XXC' is not). The '5' symbols('V', 'L', and 'D') can never be subtracted.
    /// </summary>
    public class NumeralConverter
    {
        private readonly Dictionary<char, int> _dic = new Dictionary<char, int>
        {
            {'I', 1 },
            {'V', 5 },
            {'X', 10 },
            {'L', 50 },
            {'C', 100 },
            {'D', 500 },
            {'M', 1000 }
        };

        public int ToArabic(string romanNumeral)
        {
            char[] characters = romanNumeral.ToCharArray();

            foreach (char c in characters)
            {
                if (!_dic.ContainsKey(c))
                    throw new ArgumentException($"Invalid character in input {c}");

            }


            if (characters.Length == 3 && characters[0] == 'I' && characters[1] == 'I' && characters[2] != 'I')
            {
                throw new ArgumentException("Illeggal format");
            }

            if (string.IsNullOrEmpty(romanNumeral))
            {
                return 0;
            }

            var sum = _dic[characters[characters.Length - 1]];

            int previousInt = sum;
            for (int i = characters.Length - 2; i >= 0; i--)
            {
                var currentInt = _dic[characters[i]];
                if (previousInt <= currentInt)
                {

                    sum += currentInt;
                }
                else
                {
                    sum -= currentInt;
                }
                previousInt = currentInt;
            }

            return sum;
        }
    }
}
