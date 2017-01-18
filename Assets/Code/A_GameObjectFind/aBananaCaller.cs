using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aBananaCaller : MonoBehaviour {

    aBananaListener a_banana_listener;

    void Start()
    {
        a_banana_listener = GameObject.Find("BananaListener").GetComponent<aBananaListener>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            a_banana_listener.TurnOnBanana();
    }
}
