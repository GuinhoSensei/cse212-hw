using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue multiple elements and ensure Dequeue removes the highest priority element first.
    // Expected Result: The highest priority element should be removed first.
    // Defect(s) Found:
    public void TestPriorityQueue_HighestPriorityRemovedFirst()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 2);
        
        var result = priorityQueue.Dequeue();
        Assert.AreEqual("B", result);
    }

    [TestMethod]
    // Scenario: When multiple items have the same highest priority, the first inserted should be dequeued first.
    // Expected Result: FIFO order should be preserved among same-priority items.
    // Defect(s) Found:
    public void TestPriorityQueue_SamePriorityFIFO()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 2);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 3);
        
        var result1 = priorityQueue.Dequeue();
        var result2 = priorityQueue.Dequeue();
        Assert.AreEqual("C", result1);
        Assert.AreEqual("A", result2);
    }

    [TestMethod]
    // Scenario: Attempting to Dequeue from an empty queue should throw an exception.
    // Expected Result: InvalidOperationException should be thrown.
    // Defect(s) Found:
    public void TestPriorityQueue_EmptyQueueException()
    {
        var priorityQueue = new PriorityQueue();
        
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }
}
