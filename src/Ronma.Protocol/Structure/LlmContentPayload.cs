using Ronma.Protocol.Enums;

namespace Ronma.Protocol.Structure
{
    public class LlmContentPayload
    {
        public LlmContentPayloadType Type { get; set; }

        public byte[] Content { get; set; }

    }
}
