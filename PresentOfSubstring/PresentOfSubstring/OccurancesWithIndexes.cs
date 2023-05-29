using System;
/// <summary>
/// Finds the Indexes and total number of occurances of a substring in a string
/// </summary>
class OccurancesWithIndexes
{
    /// <summary>
    /// Finding the Positions of Substring in a string and returning No.of occurances 
    /// </summary>
    /// <param name="str1"></param>
    /// <param name="str2"></param>
    /// <returns></returns>
    public int FindingPositionsOfSubString(string str1, string str2)
    {
        int occurance = 0;
        int index = str1.IndexOf(str2);
        Console.Write("Index Positons: ");

        while (index >= 0)
        {
            Console.Write(index + " ");
            occurance++;
            index = str1.IndexOf(str2, index + 1);
        }
        return occurance;
    }
}