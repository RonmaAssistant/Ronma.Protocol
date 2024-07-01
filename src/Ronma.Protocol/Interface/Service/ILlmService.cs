using Ronma.Protocol.Structure;

namespace Ronma.Protocol.Interface.Service
{
    public interface ILlmService : IService
    {
        string Name { get; set; }
        string Prompt { get; set; }
        LlmEndpoint Endpoint { get; set; }

        LlmContent Perform(LlmContent message);
    }
}
