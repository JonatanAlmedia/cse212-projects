public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario:  Enqueue elements and dequeue the one with the highest priority
        // Expected Result: Dequeue should return the element with the highest priority
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("ItemA", 3);
        priorityQueue.Enqueue("ItemB", 5);
        priorityQueue.Enqueue("ItemC", 2);
        Console.WriteLine($"Dequeuing: {priorityQueue.Dequeue()}");
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: None

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Attempt to dequeue from an empty queue
        // Expected Result: Error message should be displayed
        Console.WriteLine("Test 2");
        Console.WriteLine($"Dequeuring: {priorityQueue.Dequeue()}");
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: None

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Enqueue elements with the same priority and dequeue
        // Expected Result: Dequeue should return the element closest to the front
        Console.WriteLine("Test 3");
        priorityQueue.Enqueue("ItemX", 3);
        priorityQueue.Enqueue("ItemY", 3);
        priorityQueue.Enqueue("ItemZ", 3);
        Console.WriteLine($"Dequeuing: {priorityQueue.Dequeue()}");  
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: None

        // Add more Test Cases As Needed Below
    }
}