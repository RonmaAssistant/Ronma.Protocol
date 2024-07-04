namespace Ronma.Protocol.Structure
{
    public class LlmContent
    {
        public string Text { get; set; }

        public List<LlmContentPayload> Payloads { get; set; }        
    }
}
