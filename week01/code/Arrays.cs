public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    // Plan:
    // 1. Create a new double[] with lenght as count
    // 2. For i from 0 to count-1:
    // the i multiple is number times i + 1
    // store it in the array
    // 3. return the array
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        double[] r = new double[length];

        for (int i = 0; i < length; i++)
        {
            r[i] = number * (i + 1);
        }

        return r; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    // 1. rotating right by amount items move to the front
    // 2. Compute index as the count minus the amount rotated
    // 3. slice the list into two parts
    // left = data[0 to Index split]
    // right = data[index split to end]
    // 4. Clear original list and add right and left back in
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        int n = data.Count;

        amount = amount % n;

        int indexSplit = n - amount;

        List<int> left = data.GetRange(0, indexSplit);
        List<int> right = data.GetRange(indexSplit, n- indexSplit);

        data.Clear();
        data.AddRange(right);
        data.AddRange(left);
    }
}
