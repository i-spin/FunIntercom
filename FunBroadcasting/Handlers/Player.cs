using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace FunBroadcasting.Handlers
{
    class Player
    {
        public void OnJoin(JoinedEventArgs eventArgs)
        {
            Map.Broadcast(5, FunBroadcasting.Instance.Config.JoinedMessage.Replace("%PLAYER%", eventArgs.Player.Nickname));
        }

        public void OnIntercomSpeaking(IntercomSpeakingEventArgs eventArgs)
        {
            ReferenceHub.HostHub.GetComponent<Intercom>().CustomContent = "stfu";
        }

    }
}
