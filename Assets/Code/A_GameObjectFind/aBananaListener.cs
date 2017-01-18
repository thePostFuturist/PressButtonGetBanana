using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aBananaListener : MonoBehaviour {

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
