using Ronma.Protocol.Structure;

namespace Ronma.Protocol.Interface.Service
{
    public interface IBusService : ICoreService
    {
        void Publish(ServiceInfo info, Packet packet);

        bool Subscribe(ServiceInfo info, Func<Packet, Task<bool>> processor);
    }
}
