/// <summary>
/// validates the inputs 
/// </summary>
class Validations
{
    /// <summary>
    /// Checks whether substring present in a string or not 
    /// </summary>
    /// <param name="str1"></param>
    /// <param name="str2"></param>
    /// <returns></returns>
    public bool IsSubStringPresent(string str1, string str2)
    {
        int index = str1.IndexOf(str2);

        if ((index == -1) || (str1.Length<str2.Length))
        {
            return false;
        }
        else
        {
            return true;
        }

    }
}
