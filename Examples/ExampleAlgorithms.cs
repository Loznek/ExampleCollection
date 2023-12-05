using ExampleCollection.Data.Entities;
using ExampleCollection.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ExampleCollection.Examples
{
    internal class ExampleAlgorithms
    {

        public void SortAlgorithm(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }


        public int SumFirstNNumbers(int n)
        {
            int totalSum = 0;
            for (int i = 1; i <= n; i++)
            {
                totalSum += i;
            }
            return totalSum;
        }



        public void DropNumbersCanBeDividedByN(List<int> arr, int n)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] % 3 == 0)
                {
                    arr.RemoveAt(i);
                }
            }
        }


        public Customer? getCostumerByName(string name)
        {
            using var context = new AdatvezDbContext();
            return context.Customers.FromSqlRaw($"SELECT * FROM dbo.Customers WHERE Name = {name}").FirstOrDefault();
        }
  



        public int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return Math.Abs(a);
        }

        public bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }


        public int findSecndLargest(int[] nums)
        {
            if (nums.Length < 2)
            {
                throw new ArgumentException("Invalid input");
            }
            int Largest = int.MinValue;
            int secondlargest = int.MinValue;
            foreach (int num in nums)
            {
                if (num > Largest)
                {
                    secondlargest = Largest;
                    Largest = num;
                }
                else if (num > secondlargest && num != Largest)
                {
                    secondlargest = num;
                }
            }
            return secondlargest != int.MinValue ? secondlargest : secondlargest;
        }



        public void queryExamples()
        {


            using (var dbContext = new AdatvezDbContext())
            {

                //Products with more than 30 units in stock:

                //Customer pairs with sites in the same city:


                //Products ordered at least twice:


                //Orders with a total value over $30,000


                //How old is the captain?


                //Details of the most expensive product:



            }

        }

    }
}
