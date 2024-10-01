using System;
using UnityEngine;
using Zenject;


public class PlayerStatsPresenter : IInitializable, IDisposable
{
    private readonly StatsView _statsView;
    private readonly HealthView _healthView;

    private readonly Player _player;

    public PlayerStatsPresenter(Player player, StatsView statsView, HealthView healthView)
    {
        _player = player;
        _statsView = statsView;
        _healthView = healthView;
    }

    public void Initialize()
    {
        _healthView.ChangeHealth(_player.Health.StatProperty.Value.ToString());
        _statsView.ChangePower(_player.PlayerStats.Power.Value.ToString());
        _statsView.ChangeEndurance(_player.PlayerStats.Endurance.Value.ToString());
        _statsView.ChangeWisdom(_player.PlayerStats.Wisdom.Value.ToString());

        _player.Health.StatProperty.Changed += OnHealthChange;
        _player.PlayerStats.Power.Changed += OnPowerChange;
        _player.PlayerStats.Endurance.Changed += OnEnduranceChange;
        _player.PlayerStats.Wisdom.Changed += OnWisdomChange;
    }

    public void Dispose()
    {
        _player.Health.StatProperty.Changed -= OnHealthChange;
        _player.PlayerStats.Power.Changed -= OnPowerChange;
        _player.PlayerStats.Endurance.Changed -= OnEnduranceChange;
        _player.PlayerStats.Wisdom.Changed -= OnWisdomChange;
    }

    private void OnHealthChange(float health)
    {
        _healthView.ChangeHealth(health.ToString());
    }

    private void OnPowerChange(int power)
    {
        _statsView.ChangePower(power.ToString());
    }

    private void OnEnduranceChange(int endurance)
    {
        _statsView.ChangeEndurance(endurance.ToString());
    }

    private void OnWisdomChange(int wisdom)
    {
        _statsView.ChangeWisdom(wisdom.ToString());
    }
}
