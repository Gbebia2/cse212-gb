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
        // Declare a new array of doubles called results with length slots to store each multiple
        // Use a for-loop to iterate from 0 up to (length - 1), calculating number × (i + 1) and assigning it to results[i]
        // Return the completed array of calculated multiples

        double[] results = new double[length];
        for (int i = 0; i < length; i++)
        {
            results[i] = number * (i + 1);
        }

        return results;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, ce2w  opi      6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Use GetRange to copy the last amount elements from the original list
        // Insert the last amount elements copied using GetRange at index 0 to move them to the front of the list
        // Remove the original last amount elements from the end of the list to avoid duplication

        List<int> slice = data.GetRange(data.Count - amount, amount);
        data.InsertRange(0, slice);
        data.RemoveRange(data.Count - amount, amount);
    }
}
