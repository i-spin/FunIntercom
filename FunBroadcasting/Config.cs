using Exiled.API.Interfaces;

namespace FunBroadcasting
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        public string JoinedMessage { get; set; } = "%PLAYER% will never be ballin";

    }
}
