namespace Ronma.Protocol.Structure
{
    public class Packet
    {
        public string Service { get; set; }

        public string Command { get; set; }

        public string Sender { get; set; }

        public List<byte[]> Args { get; set; }

    }
}
