public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
       double[] multiples = new double[length]; // Created a new array
       for (int i = 0; i < length; i++) // starts looping through the array
       {
            multiples[i] = number * (i + 1);
       }

        return multiples; // returns the result 
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        int n = data.Count;
        amount = amount % n; // to verify if the amount is greater or equal than the list size

        if (amount == 0) return; // If the amount is 0, there is no need to rotate the list

        List<int> lastElements = data.GetRange(n - amount, amount); // to get the last amount element
        data.RemoveRange(n - amount, amount); // to remove those elements from the list
        data.InsertRange(0, lastElements); // to insert them at the front of the list
    }
}
