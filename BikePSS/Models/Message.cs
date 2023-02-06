namespace BikePSS.Models
{
    internal class Message
    {
        public DateTime Created_at { get; private set; }

        public string Contents { get; set; }

        public Guid Id { get; private set; }


        // Constructor
        public Message(string contents)
        {
            this.Created_at = DateTime.Now;
            this.Contents = contents;
            this.Id = new Guid();
        }
    }
}
