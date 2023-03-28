namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 6, 10, 2, 11, 23, 14 };

            Min(arr);
            Console.WriteLine(Min);



        }
        public static int Min(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    arr[i] = min;
                }


            }

            Console.WriteLine(min);
            return min;

        }
    }
}