using Ronma.Protocol.Enums;

namespace Ronma.Protocol.Structure
{
    public record ServiceInfo
    {
        public ServiceInfo()
        {
        }

        public ServiceInfo(BusChannel channel, string service)
            : this(channel, service, service)
        {
        }

        public ServiceInfo(BusChannel channel, string service, string routing)
        {
            Channel = channel;
            Service = service;
            Routing = routing;
            Desc = string.Empty;
        }

        public ServiceInfo(BusChannel channel, string service, ServiceCommand[] commands, string desc)
            : this(channel, service, service, commands, desc)
        {
        }

        public ServiceInfo(BusChannel channel, string service, string routing, ServiceCommand[] commands, string desc)
        { 
            Channel = channel;
            Service = service;
            Routing = routing;
            Commands = [.. commands];
            Desc = desc ?? string.Empty;
        }
        public BusChannel Channel { get; init; }

        public string Service {  get; init; } = string.Empty;

        public string Routing { get; init; } = string.Empty;

        public string Desc { get; init; } = string.Empty;

        public List<ServiceCommand> Commands { get; init; } = new List<ServiceCommand>();

        public override string ToString() => $"{Channel}.{Service}".ToLower();
    }
}
