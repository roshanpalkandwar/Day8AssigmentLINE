namespace Day8AssignmentLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welecome line comparision");
            Console.WriteLine("Choose a option\n 1. Length of line\n2.length equal method\n3.compare method\n4.using oops concept");
            Console.WriteLine("Enter the number");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    LengthOfLine.CalculateLengthOfLine();
                    break;
                    case 2:
                        LineComparision.CheckLengthEqualsMetho();
                    break;
                case 3:
                    CompareMethod.CheckLengthCompare();
                    break;
                case 4:
                    UsingOOPs obj=new UsingOOPs();
                    obj.SetLength1(2, 4, 6, 8);
                    obj.GetLength1();
                    obj.SetLength2(2, 4, 6, 8);
                    obj.GetLength2();
                    obj.display1();
                    obj.display2();
                    break;
                default:
                    Console.WriteLine("Choose a rigth number");
                    break;
            }
        }
    }
}