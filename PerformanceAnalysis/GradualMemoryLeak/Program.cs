// See https://aka.ms/new-console-template for more information

// Set the initial memory to allocate (in megabytes)

var memoryToAllocate = 6000; // 6 GB
// Set the delay between each memory allocation (in milliseconds)
const int delayBetweenIterations = 1000; // 1 second

while (true)
{
    // Allocate memory
    var memoryChunk =
        new byte[memoryToAllocate * 1024 * 1024]; // Convert MB to bytes

    // Wait for the specified delay
    Thread.Sleep(delayBetweenIterations);
}