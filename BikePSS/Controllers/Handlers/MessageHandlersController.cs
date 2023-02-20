using BikePSS.Models.Message;
using System.Reflection;
using System.Text.RegularExpressions;

namespace BikePSS.Controllers.Handlers
{
    internal class MessageHandlersController
    {

        // Load Handlers
        internal static void Load()
        {
            foreach (var handler in MessageHandlers())
            {
                var query = from types in Assembly.GetExecutingAssembly().GetTypes() where types.IsClass && types.Namespace == $"BikePSS.Handlers.{handler}" select types;

                query.ToList().ForEach(t =>
                {
                    if (t.Name == "<>o__0") return;

                    MessageTypes.AddMessageType(
                        MessageHandlersRegex().Replace(t.Name, "_").Replace("_Handler", "").ToLower(),
                        t.FullName
                    );
                });
            }
        }

        // Available Message Handlers
        private static string[] MessageHandlers() => new string[] { "Settings" };

        // Message Handlers Regex
        private static Regex MessageHandlersRegex()
        {
            return new Regex("(?<=[A-Z])(?=[A-Z][a-z])|(?<=[^A-Z])(?=[A-Z]) |(?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace);
        }

    }
}
