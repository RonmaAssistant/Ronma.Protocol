using Ronma.Protocol.Enums;
using Ronma.Protocol.Structure;

namespace Ronma.Protocol.Interface.Service
{
    public interface IBusService : IService
    {
        void Publish(Packet packet);

        bool Subscribe(ServiceQueue queue, Func<Packet, bool> processor);
    }
}
