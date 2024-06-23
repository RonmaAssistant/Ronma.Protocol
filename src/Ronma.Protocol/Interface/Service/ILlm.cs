using Ronma.Protocol.Structure;

namespace Ronma.Protocol.Interface.Service
{
    public interface ILlm : IService
    {
        string Name { get; }
        string Prompt { get; }
        EndpointInfo Endpoint { get; }
    }
}
