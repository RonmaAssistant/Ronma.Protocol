using Ronma.Protocol.Structure;

namespace Ronma.Protocol.Interface.Service
{
    public interface ILlmService : ICoreService
    {
        LlmEndpoint Endpoint { get; set; }

        Task<LlmContent> Perform(LlmContent content);
    }
}
