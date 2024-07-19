using Ronma.Protocol.Enums;
using Ronma.Protocol.Structure;

namespace Ronma.Protocol.Interface.Service
{
    public interface IBusService : ICoreService
    {
        void Publish(BusChannel channel, string name, Packet packet);

        bool Subscribe(BusChannel channel, string name, Func<Packet, Task<bool>> processor);
    }
}
