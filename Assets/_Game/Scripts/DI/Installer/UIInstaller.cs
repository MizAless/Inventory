using UnityEngine;
using Zenject;

public class UIInstaller : MonoInstaller
{
    [SerializeField] private StatsView _statsView;
    [SerializeField] private HealthView _healthView;

    public override void InstallBindings()
    {
        BindPlayerStatsPresenter();
    }

    private void BindPlayerStatsPresenter()
    {
        //Container
        //    .Bind<PlayerStatsPresenter>()
        //    .FromNew()
        //    .AsCached()
        //    .WithArguments(_statsView, _healthView)
        //    .NonLazy();

        Container
            .BindInterfacesAndSelfTo<PlayerStatsPresenter>()
            .AsSingle()
            .WithArguments(_statsView, _healthView)
            .NonLazy();
    }
}