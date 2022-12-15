namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Collapsible "if" statements should be merged
            int one = 1;
            int two = 2;

            if (one != 0)
            {
                if (one == 1)
                {
                    Console.WriteLine(one);
                }
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Unused local variables should be removed
        /// </summary>
        /// <param name="hours"></param>
        /// <returns></returns>
        public int LocalVariables(int hours)
        {
            int seconds = 0;   // seconds is never used
            return hours * 60;
        }
    }
}