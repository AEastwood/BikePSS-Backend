namespace BikePSS.Models.Message
{
    internal class MessageTypes
    {
        // Get handler for message type
        internal static Dictionary<string, string> messageTypes = new();

        // Add Handler
        internal static void AddMessageType(string type, string typeNamespace) => messageTypes.Add(type, typeNamespace);

        // Returns true if type is allowed
        internal static bool Allowed(string type) => messageTypes.ContainsKey(type);

        // Get Handler for type
        internal static string GetHandler(string type) => messageTypes[type];
    }
}
