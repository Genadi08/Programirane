using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prostiChisla
{
    public class PrimeNumbers
    {
        public List<int> FindPrimeNumbers(List<int> inputNumbers)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < inputNumbers.Count; i++)
            {
                if (IsPrime(inputNumbers[i]) == true)
                {
                    result.Add(inputNumbers[i]);


                }
           
            }


            return result;

        }
        public bool IsPrime(int number)
        {
            if (number < 0) number = -number;
            bool flag= false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return flag;
                }
            }
            return true; //the number is prime
        }
    }
}
