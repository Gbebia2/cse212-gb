using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add three items with different priorities. My Dequeue will return the one with the highest priority.
    // Expected Result: Dequeue returns "C" (highest priority)
    // Defect(s) Found: The Dequeue method is missing actual removal from the queue. It just returns the value.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 3);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("C", result);
    }


    [TestMethod]
    // Scenario: Enqueue three items. Dequeue one (highest priority). Dequeue again.
    // Expected Result: First Dequeue returns "C", second Dequeue returns "B"
    // Defect(s) Found: Item not being removed from the queue.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 3);

        var first = priorityQueue.Dequeue();
        var second = priorityQueue.Dequeue();

        Assert.AreEqual("C", first);
        Assert.AreEqual("B", second);
    }

    [TestMethod]
    // Scenario: Enqueue A (pri 3), B (pri 3), C (pri 2). All are valid.
    // Expected Result: First Dequeue returns A, second Dequeue returns B
    // Defect(s) Found: None (as long as FIFO order is respected on tie)
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 3);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 2);

        var first = priorityQueue.Dequeue();  // A (first with pri 3)
        var second = priorityQueue.Dequeue(); // B (next with pri 3)

        Assert.AreEqual("A", first);
        Assert.AreEqual("B", second);
    }

}