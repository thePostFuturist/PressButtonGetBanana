using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dBananaCaller : MonoBehaviour {

    public dBananaListener d_banana_listener;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            d_banana_listener.TurnOnBanana();
    }
}
