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
        // Step 1: Create a new array to store the multiples.
        // Step 2: Loop through each position in the array.
        // Step 3: Multiply the number by the current position + 1.
        // Step 4: Store the result in the array.
        // Step 5: Return the completed array.
        double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }
        return multiples;
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Find the position where the list should split.
        // Step 2: Save the last "amount" values into a temporary list.
        // Step 3: Save the beginning portion of the list into another temporary list.
        // Step 4: Clear the original list.
        // Step 5: Add the rotated section first.
        // Step 6: Add the remaining section after it.

        int splitIndex = data.Count - amount;

        List<int> rightSide = data.GetRange(splitIndex, amount);
        List<int> leftSide = data.GetRange(0, splitIndex);

        data.Clear();

        data.AddRange(rightSide);
        data.AddRange(leftSide);
    }
}
