using System;

namespace Test1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0, B = 0;
            int BoxesInBucket1 = int.Parse(Console.ReadLine());
            int BoxesInBucket2 = int.Parse(Console.ReadLine());
            int BoxesInBucket3 = int.Parse(Console.ReadLine());

            while (A == 0 && B == 0)
            {
                Console.Write("Player A takes a box from backet number :");
                string bucket_number = Console.ReadLine();
                Console.Write("Amount :");
                int amount_box = int.Parse(Console.ReadLine());

                switch (bucket_number)
                {
                    case "1":
                        BoxesInBucket1 = BoxesInBucket1 - amount_box;
                        break;
                    case "2":
                        BoxesInBucket2 = BoxesInBucket2 - amount_box;
                        break;
                    case "3":
                        BoxesInBucket3 = BoxesInBucket3 - amount_box;
                        break;
                }

                if ((BoxesInBucket1 != 0) || (BoxesInBucket2 != 0) || (BoxesInBucket1 != 0))
                {
                    Console.Write("Player B takes a box from backet number :");
                    bucket_number = Console.ReadLine();
                    Console.Write("Amount :");
                    amount_box = int.Parse(Console.ReadLine());

                    switch (bucket_number)
                    {
                        case "1":
                            BoxesInBucket1 = BoxesInBucket1 - amount_box;
                            break;
                        case "2":
                            BoxesInBucket2 = BoxesInBucket2 - amount_box;
                            break;
                        case "3":
                            BoxesInBucket3 = BoxesInBucket3 - amount_box;
                            break;
                    }
                    if ((BoxesInBucket1 == 0) && (BoxesInBucket2 == 0) && (BoxesInBucket1 == 0))
                        B += 1;
                }
                else
                {
                    A += 1;
                }
            }

            if (A == 1)
            {
                Console.WriteLine("Player B Wins!");
            }
            else
                Console.WriteLine("Player A Wins!");
        }
    }
}
