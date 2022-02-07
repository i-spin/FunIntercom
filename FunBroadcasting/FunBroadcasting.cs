using Exiled.API.Enums;
using Exiled.API.Features;

using Server = Exiled.Events.Handlers.Server;
using Player = Exiled.Events.Handlers.Player;

namespace FunBroadcasting
{
    public class FunBroadcasting : Plugin<Config>
    {
        private static readonly Lazy<FunBroadcasting> LazyInstance = new(() => new FunBroadcasting());
        public static FunBroadcasting Instance => LazyInstance.Value;
        public override PluginPriority Priority => PluginPriority.Last;

        private Handlers.Player? _player = new();
        private Handlers.Server? _server = new();

        private FunBroadcasting() { }

        public override void OnEnabled()
        {
            AddEvents();
        }

        public override void OnDisabled()
        {
            RemoveEvents();
        }

        public void AddEvents()
        {
            if (_player != null)
            {
                Player.Joined += _player.OnJoin;
                Player.IntercomSpeaking += _player.OnIntercomSpeaking;
            }
            if (_server != null)
            {   
                Server.WaitingForPlayers += _server.OnWaiting;
            }
        }

        public void RemoveEvents()
        {
            if (_player != null)
            {
                Player.Joined -= _player.OnJoin;
                Player.IntercomSpeaking -= _player.OnIntercomSpeaking;
            }

            if (_server != null)
            {
                Server.WaitingForPlayers -= _server.OnWaiting;
            }

            _player = null;
            _server = null;
        }
    }
}