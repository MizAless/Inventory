public class PlayerStats
{
    public PlayerStats(PlayerStatsConfig playerStatsConfig)
    {
        Power = new Stat<int>(playerStatsConfig.Power);
        Endurance = new Stat<int>(playerStatsConfig.Endurance);
        Wisdom = new Stat<int>(playerStatsConfig.Wisdom);
    }

    public Stat<int> Power { get; private set; }
    public Stat<int> Endurance { get; private set; }
    public Stat<int> Wisdom { get; private set; }
}
