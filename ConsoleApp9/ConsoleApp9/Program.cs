namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int S = 0;
            Area(3);
            Area(4, 9);
            Area(5, 8, 6);
            Area(4, 5, 6, 7);
        }
        public static void Area(int r)
        {

            decimal pi = 3.14m;
            Console.WriteLine("cevrenin SAhEsi= ");
            Console.WriteLine(pi * r * r);
        }
        public static void Area(int a, int b)
        {

            Console.WriteLine("ducbucaqlinin sahesi= ");
            Console.WriteLine(a * b);
        }
        public static void Area(int a, int b, int c)
        {
            Console.WriteLine("duzbucaqli paralepidin sahesi= ");
            Console.WriteLine(2 * (a * b + a * c + b * c));
        }
        public static void Area( int a, int b, int c, int r)
        {
            
            int p =  (a + b + c) / 2;
            Console.WriteLine("3bucagin daxiline cekilen cevrenin sahesi= ");
            Console.WriteLine(p * r);
        }
    }
}