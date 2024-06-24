using Ronma.Protocol.Structure;

namespace Ronma.Protocol.Interface.Service
{
    public interface ILlm : IService
    {
        string Name { get; set; }
        string Prompt { get; set; }
        EndpointInfo Endpoint { get; set; }
    }
}
