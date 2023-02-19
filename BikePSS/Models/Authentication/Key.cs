namespace BikePSS.Models.Authentication
{
    internal class Key
    {
        // Key Guid
        internal Guid KeyId { get; private set; }

        // Name
        internal string Name { get; private set; }

        // Constructor
        internal Key(string name)
        {
            this.Name = name;
        }
    }
}
