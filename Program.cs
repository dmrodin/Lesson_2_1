using System;

namespace Lesson_2_1
{
    internal class Program
    {
        static void Main()
        {
            const int value = 753;

            int cnt = value;
            int sum = 0;

            while (cnt % 10 > 0)
            {
                sum += cnt % 10;
                cnt /= 10;
            }

            Console.WriteLine(sum);
            //Console.ReadKey();
        }
    }
}
