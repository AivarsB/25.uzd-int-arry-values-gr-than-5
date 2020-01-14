using System;

namespace _25.uzd_int_arry_values_gr_than_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 3, 4, 8, 0, 23 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Values greater than 5:");

            foreach (var number in numbers)
            {
                if (number > 5)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}


// Deklarēt int[] - masīvu int[] numbers = { 1, 3, 4, 8, 0, 23 }; 
// Izdrukāt uz ekrāna visas masīva elementu vērtības un pēc tam tikai tās vērtības, kuras lielākas par 5.