using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class eIocIIBananaListener : MonoBehaviour, IDisposable {

    Signals.BananaToggleSignal banana_toggle_signal;

    [Inject]
    public void Construct(Signals.BananaToggleSignal _banana_toggle_signal)
    {
        banana_toggle_signal = _banana_toggle_signal;
    }

    [Inject]
    public void Subscribe()
    {
		banana_toggle_signal += ToggleImage;
    }

    void Start()
    {
        ToggleImage(false);
    }

    public void TurnOnBanana()
    {
        ToggleImage(true);
    }

    void ToggleImage(bool state)
    {
        GetComponent<Image>().enabled = state;
    }

    public void Dispose()
    {
        banana_toggle_signal -= ToggleImage;
    }
}

