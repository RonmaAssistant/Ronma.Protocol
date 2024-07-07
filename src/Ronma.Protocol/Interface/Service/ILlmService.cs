using Ronma.Protocol.Structure;

namespace Ronma.Protocol.Interface.Service
{
    public interface ILlmService : ICoreService
    {
        LlmEndpoint Endpoint { get; set; }

        LlmContent Perform(string prompt, LlmContent message);
    }
}
