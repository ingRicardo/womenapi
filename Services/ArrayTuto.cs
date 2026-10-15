namespace WebWomen.Services
{
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
    }
}
