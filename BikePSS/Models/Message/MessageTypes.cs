namespace BikePSS.Models.Message
{
    internal class MessageTypes
    {
        // Get handler for message type
        public static Dictionary<string, string> messageTypes = new();

        // Add Handler
        public static void AddMessageType(string type, string typeNamespace) => messageTypes.Add(type, typeNamespace);

        // Returns true if type is allowed
        public static bool Allowed(string type) => messageTypes.ContainsKey(type);

        // Get Handler for type
        public static string GetHandler(string type) => messageTypes[type];
    }
}
