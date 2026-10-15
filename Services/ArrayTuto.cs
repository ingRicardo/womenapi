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
    }
}
