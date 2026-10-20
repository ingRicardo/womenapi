using WebWomen.Models;

namespace WebWomen.Services
{
    public class Student
    {
        public int roll_no { get; set; }
        public string name { get; set; }

        public Student(int roll_no, string name)
        {
            this.roll_no = roll_no;
            this.name = name;
        }
    }

    public class ArrayTuto
    {
        public static int[] firstarray()
        {

            // Value type array
            int[] arr = { 10, 20, 30, 40 };

            return arr;
        }

        public static string[] refarray()
        {

            // Reference type array
            string[] names = { "Lakshit", "Rahul", "Pankaj" };

            return names;
        }

        public static int[,] multiarray()
        {

            int[,] arr = { { 10, 20 },
                           { 30, 40 } };
            return arr;
        }

        //Jagged Array

        public static int[][] jaggedArray()
        {

            int[][] arr = new int[3][];
            arr[0] = new int[] { 10, 20 };
            arr[1] = new int[] { 30, 40, 50 };
            arr[2] = new int[] { 60 };

            return arr;
        }

        public static int[] accessvalue()
        {
            int[] arr = { 10, 20, 30, 40 };

            return arr;
        }

        public static int[] modifyvalue()
        {
            int[] arr = { 2, 4, 8, 12, 16 };

            return arr;
        }

        public static Student[] studentarray()
        {
            // Declaring an array of Student objects
            Student[] arr;

            // Allocating memory for five Student references
            arr = new Student[5];

            // Initializing the array elements
            arr[0] = new Student(1, "Rik");
            arr[1] = new Student(2, "Alf");
            arr[2] = new Student(3, "Yola");
            arr[3] = new Student(4, "Borias");
            arr[4] = new Student(5, "Soria");


            return arr;
        }


        // Passing Array to a Method
        public static int Sum(int[] arr)
        {
            // Calculating the sum of array values
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];

            // Console.WriteLine("Sum of array values: " + sum);

            return sum;
        }

        public static int[] ReturnArray()
        {
            // Returning an array
            return new int[] { 1, 2, 3 };
        }


        // Declaration and Initialization
        public static List<object> jaggedAarrDecla()
        {
            List<object> list = new List<object>();

            // Create a jagged array with 4 rows
            int[][] jagged_arr = new int[4][];

            // Initialize rows with different lengths
            jagged_arr[0] = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            jagged_arr[1] = new int[] { 8, 9, 10, 11, 12, 13 };
            jagged_arr[2] = new int[] { 14, 15, 16 };
            jagged_arr[3] = new int[] { 19, 20, 21, 22, 23 };

            list.Add("Jagged array created with 4 rows and different lengths");
            list.Add(jagged_arr);
            // Display the elements
            for (int i = 0; i < jagged_arr.Length; i++)
            {
                list.Add("Row " + i + ": ");

                foreach (int num in jagged_arr[i])
                {
                    list.Add(num);
                }

            }

            return list;
        }

        // Accessing and Modifying Elements
        public static List<object> modifyarray()
        {

            List<object> list = new List<object>();
            list.Add("Declaration of a jagged array with 3 rows");

            int[][] arr = new int[3][];

            // Initializing each row of the jagged array First row
            arr[0] = new int[] { 1, 2, 3, 4 };
            list.Add("Initialized first row with 4 elements: " + string.Join(", ", arr[0]));
            // Second row
            arr[1] = new int[] { 4, 5, 6 };
            list.Add("Initialized second row with 3 elements: " + string.Join(", ", arr[1]));
            // Third row (only two elements)
            arr[2] = new int[] { 7, 8 };
            list.Add("Initialized third row with 2 elements: " + string.Join(", ", arr[2]));


          //  list.Add(arr);

            list.Add("Accessing the third element in second row");
            int value = arr[1][2];
            list.Add(value);

            list.Add("Modifying the second element in the first row (from 2 to 10)");
            arr[0][1] = 10;
            list.Add(arr[0][1]);

            list.Add("Finding the Length of a Jagged Array");

            int[][] arr2 =
            {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5 },
            new int[] { 6, 7, 8, 9 }
            };
            list.Add(arr2);

            list.Add("Number of rows: " + arr2.Length);
            list.Add("Elements in first row: " + arr2[0].Length);
            list.Add("Elements in second row: " + arr2[1].Length);

            list.Add("Iterating Through a Jagged Array");

            int[][] arr3 = { new int[] { 1, 2 },
                             new int[] { 3, 4, 5 },
                             new int[] { 6, 7, 8, 9 } };

            list.Add(arr3);
            for (int i = 0; i < arr3.Length; i++)
            {
                list.Add("Row " + i + ": ");
                for (int j = 0; j < arr3[i].Length; j++)
                {
                    list.Add(arr3[i][j]);
                }
            }

            return list;
        }
        //It supports common operations such as sorting, searching, copying, reversing, and retrieving information about array elements

        public static List<object> classArray()
        {
            List<object> lt = new List<object>();

            Array numbers = new int[] { 10, 20, 30, 40, 50 };
            lt.Add("Array elements:");
            lt.Add(numbers);
            lt.Add("Length of the array: " + numbers.Length);

            int[] numbers2 = { 10, 20, 30, 40, 50, 60 };
            lt.Add("Array elements:");
            lt.Add(numbers2);
            lt.Add("Length of the array: " +numbers2.Length);

            //Rank Property
            // The Rank property returns the number of dimensions of an array.

            lt.Add("Rank of the array: " + numbers2.Rank);

            // Examples of Array Class Methods
            //Array.Reverse()
            int[] numbers3 = { 10, 20, 30, 40, 50, 60 };
            int[] numbersOriginal = (int[])numbers3.Clone(); // Create a copy of the original array
            lt.Add("Array before reversing:");
           // lt.Add(numbersOriginal);
            foreach (int number in numbersOriginal)
            {
                lt.Add(number);
            }

           Array.Reverse(numbers3);
            lt.Add("Array after reversing:");
            //lt.Add(numbers3);
            foreach (int number in numbers3)
            {
                lt.Add(number);
            }
            //Array.Sort()

            int[] numbers4 = { 50, 20, 40, 10, 60, 30 };

            lt.Add("Array before sorting:");
            foreach (int number in numbers4)
            {
                lt.Add(number);
            }

            Array.Sort(numbers4);

            lt.Add("Array after sorting:");
            foreach (int number in numbers4)
            {
                lt.Add(number);
            }

            return lt;
        }


         //Sorting an Array
        public static List<object> sortArray()
        {
            List<object> lt = new List<object>();

            //Sort Integer and Character Arrays in Ascending Order

            // Array of integer type
            int[] arr1 = { 2, -1, 3, 4 };

            // Character array
            char[] arr2 = { 'b', 'a', 'c', 'b' };

            // Sorting arrays in ascending order
            Array.Sort(arr1);
            Array.Sort(arr2);

            // Print sorted arrays
            lt.Add(string.Join(", ", arr1));
            lt.Add(string.Join(", ", arr2));


            // To Sort a Subarray
            int[] arr = { 2, -1, 4, 3 };

            // Sort elements from index 1, for 3 elements
            Array.Sort(arr, 1, 3);

            // Print array after sorting
            lt.Add(string.Join(", ", arr));

            // Descending Order Sorting

            // Integer array
            int[] arrD = { 2, -1, 3, 4 };

            Array.Sort(arrD);
            Array.Reverse(arrD);

            lt.Add(string.Join(", ", arrD));

            // String array
            string[] str = { "SorIa", "Zoyla", "Mario" };

            Array.Sort(str, StringComparer.Ordinal);
            Array.Reverse(str);

            lt.Add(string.Join(", ", str));

            //Custom Sorting with Comparer

            StudentI[] students =
            {
                new(1, "Ram", "UP"),
                new(2, "Shyam", "MP"),
                new(3, "Hari", "Bihar")
            };

            // Sort students by name
            Array.Sort(students);

            // Print sorted students
            foreach (StudentI student in students)
                lt.Add(student.ToString());

            return lt;
        }

     }
}
