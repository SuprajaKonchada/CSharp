/// <summary>
/// Validates the input given
/// </summary>
class Validations
{
    /// <summary>
    /// method to check the length of input and checks whether the input is valid or not
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public bool IsStringValid(string input)
    {
        if(input.Length < 4)
        {
            return false;
        }
        else
        {
            return true;
        }
        
    }
}
