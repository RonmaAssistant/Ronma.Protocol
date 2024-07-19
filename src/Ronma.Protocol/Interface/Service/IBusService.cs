using Ronma.Protocol.Enums;
using Ronma.Protocol.Structure;

namespace Ronma.Protocol.Interface.Service
{
    public interface IBusService : ICoreService
    {
        void Publish(BusChannel channel, Packet packet);

        bool Subscribe(BusChannel channel, Func<Packet, Task<bool>> processor);
    }
}
