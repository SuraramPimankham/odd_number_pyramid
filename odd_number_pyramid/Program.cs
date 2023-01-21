namespace odd_number_pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int Space, Number;

            for (int i = 1; i <= input; i++)  
            {
                for (Space = 1; Space <= (input - i); Space++)
                { 
                    Console.Write(" ");
                }
                for (Number = 1; Number <= i; Number++)
                {
                    Console.Write("*"); 
                }
                for (Number = (i - 1); Number >= 1; Number--)
                { 
                    Console.Write("*"); 
                }
                Console.WriteLine();
            }
        }
    }
}