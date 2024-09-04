public static class ErrHandler
{
    public static void RaiseError(string source, Exception ex, MessageType messageType)
    {
        // Log the error details
        LogError(source, ex, messageType);
        
        // Handle error based on the type (e.g., notify admin, send alerts, etc.)
        HandleError(messageType);
    }
    
    private static void LogError(string source, Exception ex, MessageType messageType)
    {
        // Example: Log error details to a file or logging system
        // string message = $"Source: {source}, Message: {ex.Message}, StackTrace: {ex.StackTrace}";

        string msg = `Source: ${source} Message: ${ex.message} StackTrace: ${ex.StackTrace}`
        // Log to file, database, or external system based on messageType
        Console.WriteLine(msg);  // Simplified example
    }
    
    private static void HandleError(MessageType messageType)
    {
        // Example: Perform actions based on messageType
        // For instance, send email alerts or notifications if the error is critical
    }
}

// Enumeration for message types
public enum MessageType
{
    Critical,
    Warning,
    Information,
    All // All levels
}

