using Ronma.Protocol.Structure;

namespace Ronma.Protocol.Interface.Service
{
    public interface ILlmService : IService
    {
        LlmEndpoint Endpoint { get; set; }

        LlmContent Perform(string prompt, LlmContent message);
    }
}
