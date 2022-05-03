using System;

namespace Loops
{
    class Program
    {

        static void Main(string[] args)
        {
            //int x = 0;
            //int y = 3;


            //while (x< y)
            //{
            //    int a=0;

            //    while (a <= x)
            //    {
            //        Console.Write("*");
            //        a++;

            //    }

            //    x++;

            //    Console.WriteLine();

            //}
            //int x = 0;
            //int y = 3;
            //while (x < y)
            //{
            //    int a = 3;

            //    while (a > x)
            //    {
            //        Console.Write("*");

            //        a--;

            //    }

            //    x++;

            //    Console.WriteLine();

            //}

            //int x = 0;
            //int y = 3;


            //while (x < y)

            //{
            //    int a = 0;


            //    while (a <= x)
            //    {
            //        Console.Write("*");
            //        a++;

            //    }

            //    x++;

            //    Console.WriteLine();
            //}



            //int NumberOfHorizLines = 10;
            //int NumberOfVertLines = 10;
            //int x = 1;
            //int y = 1;
            //int z = 1;

            //Console.Write("  |");

            //while (y <= NumberOfVertLines)
            //{

            //    if (y< 10)
            //        Console.Write("  ");
            //    else
            //        Console.Write("  ");

            //    Console.Write(y);

            //    if (y  >= 10)
            //        Console.Write(" ");
            //    else
            //        Console.Write("  ");


            //    y++;

            //}

            //Console.WriteLine();

            //Console.Write("--+");

            //while (z <= NumberOfVertLines)
            //{
            //    if (z < 10)
            //        Console.Write("--");
            //    else
            //        Console.Write("--");

            //    Console.Write("-");

            //    if (z >= 10)
            //        Console.Write("-");
            //    else
            //        Console.Write("--");
            //    z++;

            //}
            //Console.WriteLine();

            //while (x <= NumberOfHorizLines)

            //{
            //    int a = 1;

            //    if (x < 10)
            //        Console.Write(" " + x + "|");
            //    else
            //        Console.Write("" + x + "|");


            //    while (a <= NumberOfVertLines)
            //    {


            //        if (a * x < 10)
            //            Console.Write("  ");
            //        else
            //            Console.Write("  ");

            //        Console.Write(a*x);

            //        if (a * x >= 10)
            //            Console.Write(" ");
            //        else
            //            Console.Write("  ");

            //        a++;

            //    }

            //    x++;

            //    Console.WriteLine();





            int FirstNumberOfHorizontLines = int.Parse(Console.ReadLine());
            int LastNumberOfHorizontLines = int.Parse(Console.ReadLine());
            int FirstNumberOfVerticLines = int.Parse(Console.ReadLine());
            int LastNumberOfVerticLines = int.Parse(Console.ReadLine());
            int a = FirstNumberOfHorizontLines;
            int b = FirstNumberOfHorizontLines;
            int c = FirstNumberOfHorizontLines;

            Console.Write("      |");

            // Cap and --+-------------

            while ( a <= LastNumberOfHorizontLines)
            {

                if (a < 10)
                    Console.Write("      ");
                else if (a < 100)
                    Console.Write("     ");
                else if (a < 1000)
                    Console.Write("    ");

                else
                    Console.Write("   ");

                Console.Write(a);

                a++;

            }

            Console.WriteLine();

            Console.Write("------+");

            while (b <= LastNumberOfHorizontLines)

            {

               Console.Write("-------");

                b++;

            }

            Console.WriteLine();

            while (FirstNumberOfVerticLines <= LastNumberOfVerticLines)

            {
                FirstNumberOfHorizontLines = c;

                if (FirstNumberOfVerticLines < 10)
                    Console.Write("     " + FirstNumberOfVerticLines + "|");
                else if (FirstNumberOfVerticLines < 100)
                    Console.Write("    " + FirstNumberOfVerticLines + "|");
                else if (FirstNumberOfVerticLines < 1000)
                    Console.Write("   " + FirstNumberOfVerticLines + "|");
                else if (FirstNumberOfVerticLines < 10000)
                    Console.Write("  " + FirstNumberOfVerticLines + "|");
                else
                    Console.Write(" " + FirstNumberOfVerticLines + "|");




                while (FirstNumberOfHorizontLines <= LastNumberOfHorizontLines)
                {


                    if (FirstNumberOfHorizontLines * FirstNumberOfVerticLines < 10)
                        Console.Write("      ");
                    else if (FirstNumberOfHorizontLines * FirstNumberOfVerticLines < 100)
                        Console.Write("     ");
                    else if (FirstNumberOfHorizontLines * FirstNumberOfVerticLines < 1000)
                        Console.Write("    ");
                    else if (FirstNumberOfHorizontLines * FirstNumberOfVerticLines < 10000)
                        Console.Write("   ");
                    else if (FirstNumberOfHorizontLines * FirstNumberOfVerticLines < 100000)
                        Console.Write("  ");
                    else
                        Console.Write(" ");


                    Console.Write(FirstNumberOfHorizontLines * FirstNumberOfVerticLines);

                    FirstNumberOfHorizontLines++;

                }

                FirstNumberOfVerticLines++;

                Console.WriteLine();

            }

        }
    }
}