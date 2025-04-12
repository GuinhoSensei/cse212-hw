public static class Trees
{
    /// <summary>
    /// Given a sorted list, create a balanced BST by inserting the middle value first,
    /// followed by recursively inserting the middle values of each subrange.
    /// </summary>
    public static BinarySearchTree CreateTreeFromSortedList(int[] sortedNumbers)
    {
        var bst = new BinarySearchTree(); // Create an empty BST to start with 
        InsertMiddle(sortedNumbers, 0, sortedNumbers.Length - 1, bst);
        return bst;
    }

    /// <summary>
    /// Recursively inserts the middle element of the specified range into the BST
    /// to form a balanced binary search tree.
    /// </summary>
    private static void InsertMiddle(int[] sortedNumbers, int first, int last, BinarySearchTree bst)
    {
        if (first > last)
            return; // Base case: no elements in the current subrange

        int mid = (first + last) / 2;
        bst.Insert(sortedNumbers[mid]); // Insert middle value

        // Recursively insert left and right subranges
        InsertMiddle(sortedNumbers, first, mid - 1, bst);   // Left half
        InsertMiddle(sortedNumbers, mid + 1, last, bst);    // Right half
    }
}
