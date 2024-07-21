namespace Ronma.Protocol.Structure
{
    public class LlmContent
    {
        public string Message { get; set; }

        public List<LlmContentPayload> Payloads { get; set; }        
    }
}
