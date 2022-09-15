using System;

namespace MidExam022022
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double pricePackageFlour = double.Parse(Console.ReadLine());
            double priceSingleAgg = double.Parse(Console.ReadLine());
            double priceSingleApron = double.Parse(Console.ReadLine());
            double freePackeges = students;
            double priceAllFlour = 0;
            double priceCurrFlour = 0;
            for (int i = 1; i <= students; i++)
            {
                if (i % 5 == 0)
                {
                    
                }
                else
                {
                    priceAllFlour += pricePackageFlour ;
                }
                //priceAllFlour += priceCurrFlour;

            }

            //Console.WriteLine($"priceALLflour {priceAllFlour}");

            double numApron = 0;
            numApron = students + students * 0.2;
            numApron = Math.Ceiling(numApron);
            double allApron = numApron * priceSingleApron;
            //Console.WriteLine($"allApron{allApron}");
            //Console.WriteLine($"numApron{numApron}");



            double priceAllAgg = priceSingleAgg * 10 * students;
            //Console.WriteLine($"priceAllEgg{priceAllAgg}");

            double sum = 0;
            sum = allApron + priceAllAgg + priceAllFlour;
           // Console.WriteLine($"{sum:f2}");



            if (budget >= sum)
            {
                Console.WriteLine($"Items purchased for {sum:f2}$.");
            }
            else
            {
                Console.WriteLine($"{(sum - budget):f2}$ more needed.");
            }

           


        }
    }
}
