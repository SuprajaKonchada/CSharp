using System;
class FindingAdjacentProduct
{
    /// <summary>
    /// calculates the product of every 4 adjacent digits and returns the maximum product
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public long AdjacentMaxProduct(string num)
    {
        int adjacentDigits = 4;
        long maxProduct = 0;
        for (int i = 0; i <= num.Length - adjacentDigits; i++)
        {
            long product = 1;
            for (int j = 0; j < adjacentDigits; j++)
            {
                int digit = Convert.ToInt32(num[i + j].ToString());
                product = product * digit;
            }

            if (product > maxProduct)
            {
                maxProduct = product;
            }

        }
        return maxProduct;
    }
}

