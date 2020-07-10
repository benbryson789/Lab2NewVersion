using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Y";



            while (input != "N")

            {
                Console.WriteLine("Enter the width: ");
                decimal width = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter the length: ");
                decimal length = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter the height:  ");
                decimal height = Convert.ToDecimal(Console.ReadLine());


                decimal area = width * length;
                decimal perimeter = (width + length) * 2;
                decimal volume = width * length * height;


                Console.WriteLine("The Perimeter is " + " " + perimeter);
                Console.WriteLine("The Area is " + " " + area);
                Console.WriteLine("The Volume is " + " " + volume);





                Console.WriteLine("Do you want to continue? Y/N");
                input = Console.ReadLine();

            }

        }
    }
}
