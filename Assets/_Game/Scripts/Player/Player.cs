using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    private PlayerInputConnector _playerInputController;

    public Mover Mover { get; private set; }
    public Health Health { get; private set; }
    public PlayerStats PlayerStats { get; private set; }

    //public event Action<Health> HealthChanged;
    //public event Action<PlayerStats> PlayerStatsChanged;

    public void Init(Health health, PlayerStats playerStats, Mover mover)
    {
        Mover = mover;
        PlayerStats = playerStats;
        Health = health;
        _playerInputController = new PlayerInputConnector(Mover);
    }
}
