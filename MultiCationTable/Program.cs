using System;

namespace MultiCationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //progamm küsib kasutajal sisestada numbrit;
            //programm kuvab korrutustabelit 1 kuni 10 sisestadud numbri jaoks
            // userNumber = 5
            //1 * 5 = 5;
            //2 * 5 = 10;
            //jne

            Console.WriteLine("Palun sisesta number");
            int userNumber = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{i} * {userNumber} = {i * userNumber}");

            }
        }
    }
}
