using System;
namespace LineComputation
{

   namespace LineComputation
{
    class LineComparisionProgram
    {
        public int x1, y1, x2, y2;

        public LineComparisionProgram()
        {
            for (int i = 1; i < 2; i++)
            {
                Console.WriteLine("Enter coordinate=x1:");
                this.x1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter coordinate=y1:");
                this.y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter coordinate=x2:");
                this.x2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter coordinate=y2:");
                this.y2 = Convert.ToInt32(Console.ReadLine());
            }
        }

      
        //creating a comparing line method 
        public void ComparingLines(string line1, string line2)
        {
            if (line1.CompareTo(line2) > 0)
            {
                Console.WriteLine("Line1 is greater than line2");
            }
            else if (line1.CompareTo(line2) < 0)
            {
                Console.WriteLine("Line1 is lesser than line2");
            }
            else
            {
                Console.WriteLine("Both lines are equal");
            }
        }
        static void Main(string[] args)
        {
            //creating objects 
            LineComparisionProgram obj1 = new LineComparisionProgram();
            double line1 = obj1.Length();
            LineComparisionProgram obj2 = new LineComparisionProgram();
            double line2 = obj2.Length();
            obj1.ComparingLines(line1.ToString(), line2.ToString());
            Console.ReadLine();
        }
    }
}
