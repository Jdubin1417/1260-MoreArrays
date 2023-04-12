///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InClass-MoreArrays
//	File Name:         Driver.cs
//	Description:       Provides examples about various array topics discussed in class.
//	Course:            CSCI-1260
//	Author:            Katie Wilson, wilsonkl4@etsu.edu, East Tennessee State University
//	Created:           09/19/2022
//	Copyright:         Katie Wilson, 2022
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_MoreArrays
{
    /// <summary>
    /// Provides examples about various array topics discussed in class.
    /// </summary>
    public class Driver
    {
        /// <summary>
        /// Provides examples about various array topics discussed in class.
        /// </summary>
        public static void Main()
        {
            #region Creating and displaying an array
            /////Creating and displaying an array/////
            Console.WriteLine("-----CREATING AND DISPLAYING AN ARRAY-----");

            //Create an array
            int[] myNums = new int[10]; 

            //Fill the array with multiples of 3
            for(int i = 0; i < myNums.Length; i++)
            {
                myNums[i] = i * 3; //0, 3, 6, 9, 12, 15, 18, 21, 24, 27
            }

            //Display the array
            Console.WriteLine("myNums array (wrong way):");
            Console.WriteLine(myNums); //doesn't give you what you want - don't do this!

            Console.WriteLine("\nmyNums array:");
            for (int i = 0; i < myNums.Length; i++) //use a loop when displaying values from an array
            {
                Console.WriteLine(myNums[i]);
            }

            ////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n--------------------------------------------------\n");
            ////////////////////////////////////////////////////////////////////////////
            #endregion

            #region Shallow vs. Deep Copy
            /////Shallow vs. Deep Copy/////
            Console.WriteLine("-----SHALLOW VS. DEEP COPY-----");

            //Shallow copy - don't do this!
            int[] nums = { 3, 7, 5, 1 };
            int[] nums2;

            Console.WriteLine("Shallow copy:");
            nums2 = nums; //shallow copy - both nums and nums2 point to the same array

            Console.WriteLine("nums:");
            for(int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " "); //3, 7, 5, 1
            }

            Console.WriteLine("\nnums2:");
            for (int i = 0; i < nums2.Length; i++)
            {
                Console.Write(nums2[i] + " "); //3, 7, 5, 1
            }

            Console.WriteLine("\n\nChanging nums2[0] = 1000...\n");
            nums2[0] = 1000;


            Console.WriteLine("nums:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " "); //1000, 7, 5, 1 - not ideal, we just wanted nums2 to change!
            }

            Console.WriteLine("\nnums2:");
            for (int i = 0; i < nums2.Length; i++)
            {
                Console.Write(nums2[i] + " "); //1000, 7, 5, 1
            }

            //Deep copy values from nums into nums3
            Console.WriteLine("\n\nDeep copy:");
            int[] nums3 = new int[nums.Length]; //needs to be the same size or larger
            for(int i = 0; i < nums.Length; i++)
            {
                nums3[i] = nums[i]; //copy over each value
            }

            Console.WriteLine("nums:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " "); //1000, 7, 5, 1
            }

            Console.WriteLine("\nnums3:");
            for (int i = 0; i < nums3.Length; i++)
            {
                Console.Write(nums3[i] + " "); //1000, 7, 5, 1
            }

            Console.WriteLine("\n\nChanging nums3[0] = 1...\n");
            nums3[0] = 1;


            Console.WriteLine("nums:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " "); //1000, 7, 5, 1 - good, it didn't change
            }

            Console.WriteLine("\nnums3:");
            for (int i = 0; i < nums3.Length; i++)
            {
                Console.Write(nums3[i] + " "); //1, 7, 5, 1 - good, changed as we expected
            }

            Console.WriteLine();

            ////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n--------------------------------------------------\n");
            ////////////////////////////////////////////////////////////////////////////
            #endregion

            #region Calling methods w Arrays
            /////Calling methods with arrays/////
            Console.WriteLine("-----CALLING METHODS WITH ARRAY VALUES OR ARRAYS AS PARAMETERS-----");

            ShowValue(3);

            int x = 5;
            ShowValue(x);

            ShowValue(myNums[2]);

            ShowArray(myNums);

            ////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n--------------------------------------------------\n");
            ////////////////////////////////////////////////////////////////////////////
            #endregion

            #region String Arrays
            /////String arrays/////
            Console.WriteLine("-----STRING ARRAYS-----");

            //Overall, work the same as other arrays
            string[] names = new string[3]; //create an array of size 3
            names[0] = "Bob"; //put values in the array
            names[1] = "Bill";
            names[2] = "Joe";

            Console.WriteLine("All values in the string array, names:");
            foreach(string n in names) //display all items in the array
            {
                Console.WriteLine(n);
            }

            //string methods can be called from strings, e.g., ToUpper()
            string name = "Bob";
            string nameCap = name.ToUpper();
            Console.WriteLine($"name: {name}");
            Console.WriteLine($"name capitalized: {nameCap}");

            //similarly, each element in a string array is just a string - you can call string methods!
            Console.WriteLine("Capitalizing all values in the array, names:");
            foreach (string n in names)
            {
                Console.WriteLine(n.ToUpper());
            }

            //Another array of names
            string[] names2 = { "Bob", "Bill", "Joe", "Larry", "Kane" };

            //names2 is the name of the array, so its length is the number of elements in the array
            Console.WriteLine($"Length of the array (number of elements in the array): {names2.Length}"); //5

            //names2[0] is "Bob", so the length is the number of characters in "Bob"
            Console.WriteLine($"Length of element 0 of the array (number of characters): {names2[0].Length}"); //3

            ////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n--------------------------------------------------\n");
            ////////////////////////////////////////////////////////////////////////////
            #endregion

            #region Default Values for Arrays of Different Types
            /////Default values for arrays of different types/////
            Console.WriteLine("-----DEFAULT VALUES FOR ARRAYS OF DIFFERENT TYPES-----");

            Console.WriteLine("ints:");
            int[] myInts = new int[5];
            for (int i = 0; i < myInts.Length; i++)
            {
                Console.WriteLine(myInts[i]);
            }

            Console.WriteLine("doubles:");
            double[] myDoubles = new double[5];
            for(int i = 0; i < myDoubles.Length; i++)
            {
                Console.WriteLine(myDoubles[i]);
            }

            Console.WriteLine("bools:");
            bool[] myBools = new bool[5];
            for (int i = 0; i < myBools.Length; i++)
            {
                Console.WriteLine(myBools[i]);
            }

            Console.WriteLine("chars:");
            char[] myChars = new char[5];
            for (int i = 0; i < myChars.Length; i++)
            {
                Console.WriteLine(myChars[i]);
            }

            Console.WriteLine("strings:");
            string[] myStrings = new string[5];
            for (int i = 0; i < myStrings.Length; i++)
            {
                Console.WriteLine(myStrings[i]);
            }

            ////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n--------------------------------------------------\n");
            ////////////////////////////////////////////////////////////////////////////
            #endregion

            #region Object Arrays
            /////Object arrays/////
            Console.WriteLine("-----OBJECT ARRAYS-----");

            Person[] people = new Person[5];
            people[0] = new Person("Bob", 46);
            people[1] = new Person("Joe", 33);
            people[2] = new Person("Katie", 26);
            people[3] = new Person("Bill", 10);
            people[4] = new Person("Steve", 58);

            Console.WriteLine("All people in the array:");
            for(int i = 0; i < people.Length; i++)
            {
                Console.WriteLine(people[i]);
            }

            //people[3] is "Bill", 10, so this will retrieve the age, 10
            Console.WriteLine($"Bill's age: {people[3].Age}"); //10

            people[3].HaveBirthday(); //make "Bill" age from 10 to 11
            Console.WriteLine($"Bill's age after his birthday: {people[3].Age}"); //11

            Console.WriteLine("All people in the array after Bill's birthday:");
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine(people[i]);
            }

            ////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n--------------------------------------------------\n");
            ////////////////////////////////////////////////////////////////////////////
            #endregion

            #region Objects with an Array as an Attribute
            /////Objects with an Array as an Attribute/////
            Console.WriteLine("-----OBJECTS WITH AN ARRAY AS AN ATTRIBUTE-----");

            Classroom defaultClassroom = new Classroom();
            Console.WriteLine(defaultClassroom);

            Classroom param1Classroom = new Classroom("MC 220", new Person("Bob", 33), 5);
            Console.WriteLine(param1Classroom);

            Person[] students = { new Person("A", 33), new Person("B", 24), new Person("C", 45) };
            Classroom param2Classroom = new Classroom("MC 137B", new Person("Joe", 25), students);
            Console.WriteLine(param2Classroom);

            string[] studentNames = { "Bob", "Joe", "Steve" };
            int[] studentAges = { 22, 18, 34 };
            Person instructor = new Person("Katie", 23);
            Classroom param3Classroom = new Classroom("MC 137B", instructor, studentNames, studentAges);
            Console.WriteLine(param3Classroom);

            ////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n--------------------------------------------------\n");
            ////////////////////////////////////////////////////////////////////////////
            #endregion

            #region Array Algorithms
            /////Array algorithms/////
            Console.WriteLine("-----ARRAY ALGORITHMS-----");

            int[] myArray = { 3, 5, 2, 6 };
            Console.WriteLine("myArray:");
            foreach(int i in myArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            int largestPos = FindLargestPos(myArray);
            Console.WriteLine($"The largest value in myArray is {myArray[largestPos]} and is found at position {largestPos}.");

            int sum = SumArray(myArray);
            Console.WriteLine($"The sum of the values in myArray is {sum}.");
            #endregion
        }

        /// <summary>
        /// Displays the passed in number to the screen
        /// </summary>
        /// <param name="n">the number to display</param>
        private static void ShowValue(int n)
        {
            Console.WriteLine($"ShowValue was called with value {n}");
        }

        /// <summary>
        /// Displays each of the values from the passed in array
        /// </summary>
        /// <param name="myArray">the array of which to display its elements</param>
        private static void ShowArray(int[] myArray)
        {
            Console.WriteLine("ShowArray was called with an array containing the following values:");
            foreach(int value in myArray)
            {
                Console.WriteLine(value);
            }

            /* Equivalent to above
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            */
        }

        /// <summary>
        /// Return the index of the largest value
        /// </summary>
        /// <param name="myArray">the array to search</param>
        /// <returns>the position of the largest value</returns>
        private static int FindLargestPos(int[] myArray)
        {
            //Assume the first value is the largest, since its the only
            //one we have looked at
            int largestPos = 0;

            for(int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] > myArray[largestPos])
                {
                    largestPos = i;
                }
            }

            return largestPos;
        }

        /// <summary>
        /// Sums the values in the passed in array and returns the total.
        /// </summary>
        /// <param name="myArray">the array to sum</param>
        /// <returns>the result after summing all values in myArray</returns>
        private static int SumArray(int[] myArray)
        {
            //e.g., myArray: 3, 5, 2, 6
            // total = 0
            // total += 3; //total = 3
            // total += 5; //total = 8
            // total += 2; //total = 10
            // total += 6; //total = 16

            int total = 0;

            for(int i = 0; i < myArray.Length; i++)
            {
                total += myArray[i];
            }

            return total;
        }
    }
}
