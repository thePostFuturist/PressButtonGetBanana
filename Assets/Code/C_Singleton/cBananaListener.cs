using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cBananaListener : MonoBehaviour {

    public static cBananaListener banana_listener;

    void Awake () {
        if (banana_listener == null) {
            banana_listener = this;
        } else if (banana_listener!=this) {
            Destroy (this.gameObject);
        }
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
}
