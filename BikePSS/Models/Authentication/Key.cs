namespace BikePSS.Models.Authentication
{
    enum KeyType
    {
        NONE = 0,
        DEVELOPMENT = 1,
        STANDARD = 2
    }

    internal class Key
    {
        // Key Guid
        public Guid KeyId { get; private set; }

        // Name
        public string Name { get; private set; }

        // Key Type
        public KeyType Type { get; private set; } = KeyType.NONE;

        // Constructor
        public Key(string name)
        {
            this.Name = name;
            this.KeyId = Guid.NewGuid();
        }
    }
}
