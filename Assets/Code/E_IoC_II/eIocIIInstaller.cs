using UnityEngine;
using Zenject;

public class eIocIIInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.BindSignal<Signals.BananaToggleSignal>();
    }
}