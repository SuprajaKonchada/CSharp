using System;
class Program
{
    public static void Main(string[] args)
    {
        string number = Console.ReadLine();
        Validations validations = new Validations();
        FindingAdjacentProduct findingAdjacentProduct = new FindingAdjacentProduct();
        if(validations.IsStringValid(number) == false)
        {
            Console.WriteLine("Length of number entered is less than 4");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Max Product: " + findingAdjacentProduct.AdjacentMaxProduct(number));
            Console.ReadLine();
        }

    }
}
