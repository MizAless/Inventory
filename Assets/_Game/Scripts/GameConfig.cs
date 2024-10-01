public class GameConfig
{
    public static PlayerStatsConfig PlayerStatsConfig { get; private set; }

    public GameConfig(PlayerStatsConfig playerStatsConfig)
    {
        PlayerStatsConfig = playerStatsConfig;
    }
}
