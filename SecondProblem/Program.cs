using System;

namespace SecondProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] arr = input.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string[] input = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            int fuel = int.Parse(Console.ReadLine());
            int ammunition = int.Parse(Console.ReadLine());


            for (int i = 0; i < input.Length; i++)
            {



                string[] routed = input[i].Split();
                string command = routed[0];
                //int integerNumber = int.Parse(routed[1]);

                if (command == "Travel")
                {
                    int lightYears = int.Parse(routed[1]);
                    if (fuel >= lightYears)
                    {
                        Console.WriteLine($"The spaceship travelled {lightYears} light-years.");
                        fuel -= lightYears;
                    }
                    else
                    {
                        Console.WriteLine($"Mission failed.");
                        break;
                    }
                }
                else if (command == "Enemy")
                {
                    int enemyArmour = int.Parse(routed[1]);
                    if (ammunition > enemyArmour)
                    {
                        Console.WriteLine($"An enemy with {enemyArmour} armour is defeated.");
                        ammunition -= enemyArmour;
                    }
                    else
                    {
                        if (enemyArmour <= 2 * fuel)
                        {
                            Console.WriteLine($"An enemy with {enemyArmour} armour is outmaneuvered.");
                            fuel -= 2 * fuel;
                            
                        }
                        else
                        {
                            Console.WriteLine($"Mission failed.");
                            break;
                        }
                    }

                }
                else if (command == "Repair")
                {
                    int addAmunFuel = int.Parse(routed[1]);
                    Console.WriteLine($"Ammunitions added: {addAmunFuel * 2}.");
                    ammunition += 2 * addAmunFuel;
                    Console.WriteLine($"Fuel added: {addAmunFuel}.");
                    fuel += addAmunFuel;


                }
                else if (command == "Titan")
                {
                    Console.WriteLine($"You have reached Titan, all passengers are safe.");
                    break;
                }



                //if (input [i] == "Enemy")
                //{

                //    Console.WriteLine($"hell");
                //    //int lightYears = int.Parse(input[i+1]);

                //    //if (fuel >= lightYears)
                //    //{
                //    //    Console.WriteLine($"The spaceship travelled {lightYears} light-years.");
                //    //}
                //    //else
                //    //{
                //    //    Console.WriteLine($"Mission failed.");
                //    //    break;
                //    //}

                //}
            }


            //Console.WriteLine(string.Join(" ", input));


        }
    }
}
