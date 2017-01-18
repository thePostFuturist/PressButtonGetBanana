using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class eIocIIBananaCaller : MonoBehaviour {

    Signals.BananaToggleSignal banana_toggle_signal;

    [Inject]
    public void Construct(Signals.BananaToggleSignal _banana_toggle_signal)
    {
        banana_toggle_signal = _banana_toggle_signal;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            banana_toggle_signal.Fire(true);
    }
}
   