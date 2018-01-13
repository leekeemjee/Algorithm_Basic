using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortedArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[] secondBiggestNumberArray = new int[] { 1, 5, 2, 6, 1, 9, 2 };
            int[] secondBiggestNumberArray = new int[] { 9, 9, 9, 9, 9, 9, 9, 9 };
            int key = 7;

            // Binary search
            int index = BinarySearch(sortedArray, key);

            // Second biggest number
            int secondBiggestNumber = SecondBiggestSearch(secondBiggestNumberArray);

            // Second largest number search

            int secondLargestNumberSeach = SecondLargestNumber(secondBiggestNumberArray);

            Console.WriteLine(secondLargestNumberSeach);
        }

        static int BinarySearch(int [] arraySearch, int key)
        {
            int min = 0;
            int max = arraySearch.Length - 1;
            while(min < max)
            {
                int mid = (max + min) / 2;
                if (key == arraySearch[mid])
                {
                    return ++mid;
                }
                else if (key < arraySearch[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return 0;
        }

        static int SecondBiggestSearch(int[] arraySearch)
        {
            int max = arraySearch[0];
            int secondBiggestNumber = arraySearch[0];
            bool hasSecondBiggestNumber = false;

            // Find the biggest number firstly

            for (int i = 1; i < arraySearch.Length - 1; i++)
            {
                if (max < arraySearch[i])
                {
                    max = arraySearch[i];
                }
            }

            // Find the second biggest number

            for (int j = 1; j < arraySearch.Length - 1; j++)
            {
                if (arraySearch[j] < max)
                {
                    if (secondBiggestNumber == max || arraySearch[j] > secondBiggestNumber)
                    {
                        hasSecondBiggestNumber = true;
                        secondBiggestNumber = arraySearch[j];
                    }
                }
            }

            if (!hasSecondBiggestNumber)
            {
                return 0;
            }
            
            return secondBiggestNumber;
        }

        static int SecondLargestNumber(int [] arraySearch)
        {
            int max1 = arraySearch[0];
            int max2 = arraySearch[1];

            for(int i = 1; i < arraySearch.Length; i++)
            {
                if (arraySearch[i] > max1)
                {
                    max2 = max1;
                    max1 = arraySearch[i];                   
                }
                else if (arraySearch[i] > max2 && arraySearch[i] != max1)
                {
                    max2 = arraySearch[i];
                }
            }

            return max2;
        }
    }
}
