using UnityEngine;
using Zenject;

public class eIocIInstaller : MonoInstaller
{

    public override void InstallBindings()
    {
        Container.Bind<BananaImageWorker>().AsSingle();
    }
}