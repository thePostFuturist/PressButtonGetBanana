using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bBananaCaller : MonoBehaviour {

    bBananaListener b_banana_listener;

    void Start()
    {
        b_banana_listener = Object.FindObjectOfType<bBananaListener>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            b_banana_listener.GetComponent<Image>().enabled = true;
    }
}
