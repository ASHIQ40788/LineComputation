using System;
namespace LineComputation
{

    class CheckEquality
    {

     
        static void Main(String[] args)
        {
            int x = 1;
            int y = 2;
            double equ1 = "3 * x - 2 * y - 2";
            double equ2 = "7 * x + 3 * y - 43";
            

            if (equ1 > equ2)
            {
                Console.WriteLine("equ1 is greater");
                //Console.WriteLine(equ1);
            }

            else
                if (equ2 > equ1)
            {
                Console.WriteLine("equ2 is greater");
                //Console.WriteLine(equ2);
            }
            else
                if (equ1 == equ2)
            {
                Console.WriteLine("both lines are equal");
            }
            Console.ReadKey();
        }
    }
   
}
