// See https://aka.ms/new-console-template for more information

internal static class MemoryLeakExample
{
    // Static event (evil!)
    public static event EventHandler? Evil;

    private static void Main()
    {
        while (true)
            // Subscribe to the event with an anonymous method
            Evil += delegate { };

        // To avoid the leak, you'd need to unsubscribe from the event:
        // Evil = null;
    }
}