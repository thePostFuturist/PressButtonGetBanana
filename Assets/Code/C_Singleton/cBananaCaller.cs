using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cBananaCaller : MonoBehaviour {

    cBananaListener c_banana_listener;

    void Start()
    {
        c_banana_listener = cBananaListener.banana_listener;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            c_banana_listener.GetComponent<Image>().enabled = true;
    }
}
