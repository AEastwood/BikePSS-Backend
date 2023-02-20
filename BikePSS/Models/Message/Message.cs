using BikePSS.Controllers.Backend;
using BikePSS.Core;
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
        public Message(string type, JObject data)
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
            
            Activator.CreateInstance(
                System.Type.GetType(typeClass), 
                this
            );

            BackendController.SaveState(Loader.Backend);
        }
    }
}
