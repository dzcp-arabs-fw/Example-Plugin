using YamlDotNet.Serialization;
using DZCP.API;


namespace DZCP.Example
{
    public class DzcpConfig
    {
        [YamlMember(Alias = "debug_mode")]
        public bool DebugMode { get; set; } = false;

        [YamlMember(Alias = "welcome_message")]
        public string WelcomeMessage { get; set; } = "Welcome to our server!";

        [YamlMember(Alias = "max_players")]
        public int MaxPlayers { get; set; } = 20;
    }
}