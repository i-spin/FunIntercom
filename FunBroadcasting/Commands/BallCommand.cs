using CommandSystem;
using RemoteAdmin;

namespace FunBroadcasting.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class BallCommand : ICommand
    {
        public string Command => "ball";

        public string[] Aliases { get; } = {"moreballs"};

        public string Description => "Gives you a ball";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender player)
            {
                response = $"No ball for you, ${player.Nickname}";
                return false;
            }
            response = "Yes mom";
            return true;
        }
    }
}
