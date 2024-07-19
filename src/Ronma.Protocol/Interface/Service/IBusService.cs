using Ronma.Protocol.Enums;
using Ronma.Protocol.Structure;

namespace Ronma.Protocol.Interface.Service
{
    public interface IBusService : ICoreService
    {
        void Publish(string name, BusChannel channel, Packet packet);

        bool Subscribe(string name, BusChannel channel, Func<Packet, Task<bool>> processor);
    }
}
