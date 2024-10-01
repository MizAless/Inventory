using UnityEngine;
using Zenject;

public class SampleSceneInstaller : MonoInstaller
{
    [SerializeField] private PlayerStatsConfig _playerStatsConfig;

    public override void InstallBindings()
    {
        BindPlayerFabric();
        BindPlayer();
    }

    private void BindPlayerFabric()
    {
        Container
           .Bind<PlayerFabric>()
           .FromNew()
           .AsSingle()
           .WithArguments(_playerStatsConfig)
           .Lazy();
    }

    private void BindPlayer()
    {
        Container
            .Bind<Player>()
            .FromMethod(CreatePlayer)
            .AsSingle()
            .NonLazy();
    }


    private Player CreatePlayer(InjectContext injectContext)
    {
        return Container
            .Resolve<PlayerFabric>()
            .Create();
    }
}
