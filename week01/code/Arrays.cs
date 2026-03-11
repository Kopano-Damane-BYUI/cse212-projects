using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // PLAN:
        // 1. Create a new array of doubles with the given length.
        // 2. Use a loop that runs from 0 to length-1.
        // 3. For each index i, calculate the multiple as (i + 1) * number.
        // 4. Store this multiple in the array at index i.
        // 5. Return the filled array at the end.

        double[] result = new double[length]; // Step 1

        for (int i = 0; i < length; i++) // Step 2
        {
            result[i] = (i + 1) * number; // Step 3 & 4
        }

        return result; // Step 5

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

        // PLAN:
        // 1. Determine the split point: the last 'amount' elements will move to the front.
        // 2. Extract the last 'amount' elements using GetRange.
        // 3. Remove these elements from the end using RemoveRange.
        // 4. Insert the extracted elements at the beginning using InsertRange.

        int count = data.Count; // Total number of elements
        if (amount <= 0 || amount == count)
        {
            // No rotation needed if amount is 0 or equal to the list size
            return;
        }

        // Step 2: Get the last 'amount' elements
        List<int> tail = data.GetRange(count - amount, amount);

        // Step 3: Remove these elements from the end
        data.RemoveRange(count - amount, amount);

        // Step 4: Insert them at the beginning
        data.InsertRange(0, tail);
    }
}
