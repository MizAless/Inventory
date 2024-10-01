using System;
using UnityEngine;

public class PlayerFabric
{
    private PlayerStatsConfig _playerStatsConfig;

    public PlayerFabric(PlayerStatsConfig playerStatsConfig)
    {
        _playerStatsConfig = playerStatsConfig;
    }

    public Player Create()
    {
        var prefab = Resources.Load<Player>("Prefabs/Player");

        var instance = UnityEngine.Object.Instantiate(prefab, Vector3.zero, Quaternion.identity);

        var health = CreateHealth();
        var mover = CreateMover(instance);
        var playerStats = CreatePlayerStats();

        instance.Init(health, playerStats, mover);

        return instance;
    }

    private Health CreateHealth()
    {
        return new Health(_playerStatsConfig.Health);
    }

    private Mover CreateMover(Player player)
    {
        if (player.TryGetComponent(out Rigidbody rigidbody) == false)
            throw new ArgumentException("Player must have Rigidbody, but he is not!");

        return new Mover(rigidbody, _playerStatsConfig.Speed);
    }

    private PlayerStats CreatePlayerStats()
    {
        return new PlayerStats(_playerStatsConfig);
    }
}
