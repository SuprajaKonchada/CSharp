using System;
class Program
{
    public static void Main(string[] args)
    {
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();
        Validations validations = new Validations();
        OccurancesWithIndexes occurancesWithIndexes = new OccurancesWithIndexes();

        if (validations.IsSubStringPresent(input1, input2) == false)
        {
            Console.WriteLine("SubString not Found");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("\nNo. of Occurances: " + occurancesWithIndexes.FindingPositionsOfSubString(input1, input2));
            Console.ReadLine();
        }

    }
}

