using Newtonsoft.Json.Linq;

namespace BikePSS.Models.Message
{
    internal class Message
    {
        public DateTime Created_at { get; private set; }

        public JObject Data { get; set; }

        public Guid Id { get; private set; }

        public string Type { get; set; }

        // Constructor
        public Message(string type, JObject data)
        {
            Created_at = DateTime.Now;
            Data = data;
            Id = new Guid();
            Type = type;

        }

        // Get Value of Path
        public dynamic GetValue(string path) => this.Data[path];

        // Handle the command
        public void Handle()
        {
            string typeClass = MessageTypes.GetHandler(this.Type);
            Type messageType = System.Type.GetType(typeClass);
            Activator.CreateInstance(messageType, this);
        }
    }
}
