using System;
using System.Collections.Generic;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputValue = 600851475143;

            Console.WriteLine("The max prime number multiple of 600,851,475,143 is: " + MaxPrime2(inputValue));

        }

        static int MaxPrime(double valueTest)
        {
            int maxPrimeFound = 2;
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(2);

            for(int i = 3; i < valueTest; i = i+2)
            {
                bool primeThis = true;
                foreach(int prime in primeNumbers)
                {
                    if(i%prime == 0)
                    {
                        primeThis = false;
                        break;
                    }
                }
                if (primeThis)
                {
                    primeNumbers.Add(i);
                    maxPrimeFound = i;
                }
            }

            return maxPrimeFound;
        }

        static double MaxPrime2(double valueTest)
        {
            double maxPrimeFound = 2;
            List<double> primeNumbers = new List<double>();
            primeNumbers.Add(2);
            primeNumbers.Add(3);
            double divisor = 2;
            double checkValue;
            bool primeFound = false;

            while (true)
            {
                if(valueTest % divisor == 0)
                {
                    checkValue = valueTest / divisor;
                    for(double i = primeNumbers[primeNumbers.Count-1]+2; i <= checkValue; i = i + 2)
                    {
                        bool primeThis = true;
                        bool outOfLoop = false;
                        foreach (int prime in primeNumbers)
                        {
                            if (i % prime == 0)
                            {
                                primeThis = false;
                                break;
                            }
                            if(checkValue % prime == 0)
                            {
                                outOfLoop = true;
                                break;
                            }
                        }
                        if (primeThis)
                        {
                            primeNumbers.Add(i);
                            if(i == checkValue)
                            {
                                primeFound = true;
                                maxPrimeFound = checkValue;
                                break;
                            }
                        }
                        if (outOfLoop)
                            break;
                    }
                }
                if (primeFound)
                    break;
                divisor++;
            }

            return maxPrimeFound;
        }
    }
}
