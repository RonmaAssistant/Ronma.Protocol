using Ronma.Protocol.Enums;

namespace Ronma.Protocol.Structure
{
    public class LlmContentFile
    {
        public LlmContentFileType FileType { get; set; }

        public byte[] FileContent { get; set; }
    }
}
