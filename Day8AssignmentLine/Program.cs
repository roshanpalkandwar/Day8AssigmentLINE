namespace Day8AssignmentLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welecome line comparision");
            Console.WriteLine("Choose a option\n 1. Length of line\n2.length equal method\n3.compare method");
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
                default:
                    Console.WriteLine("Choose a rigth number");
                    break;
            }
        }
    }
}