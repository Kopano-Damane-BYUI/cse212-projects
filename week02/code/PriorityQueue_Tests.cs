using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add multiple items with different priorities
    // Expected Result: Item with highest priority is returned first
    // Defect(s) Found: 
    // 1. Last element is never checked in the loop.
    // 2. Item is not removed from the queue after dequeue.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 3);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("B", result);
    }

    [TestMethod]
    // Scenario: Multiple items with same highest priority
    // Expected Result: First inserted (FIFO) is returned
    // Defect(s) Found: 
    // 1. FIFO order is broken due to >= comparison.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 5);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 1);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("A", result);
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Ensure item is removed after dequeue
    // Expected Result: Next dequeue returns next highest priority item
    // Defect(s) Found: 
    // Item is not removed after dequeue.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 5);

        priorityQueue.Dequeue();
        var result = priorityQueue.Dequeue();

        Assert.AreEqual("A", result);
    }

    [TestMethod]
    // Scenario: Dequeue on empty queue
    // Expected Result: Exception thrown with correct message
    // Defect(s) Found: 
    // No defect found.
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}