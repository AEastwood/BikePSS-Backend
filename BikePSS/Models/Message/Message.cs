using Newtonsoft.Json.Linq;

namespace BikePSS.Models.Message
{
    internal class Message
    {
        internal DateTime Created_at { get; private set; }

        internal JObject Data { get; set; }

        internal Guid Id { get; private set; }

        internal string Type { get; set; }

        // Constructor
        internal Message(string type, JObject data)
        {
            Created_at = DateTime.Now;
            Data = data;
            Id = new Guid();
            Type = type;

        }

        // Get Value of Path
        internal dynamic? GetValue(string path) => this.Data[path] ?? "";

        // Handle the command
        internal void Handle()
        {
            string typeClass = MessageTypes.GetHandler(this.Type);
            Type messageType = System.Type.GetType(typeClass);
            Activator.CreateInstance(messageType, this);
        }
    }
}
