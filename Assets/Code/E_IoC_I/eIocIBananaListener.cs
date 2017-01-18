using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class eIocIBananaListener : MonoBehaviour {

    BananaImageWorker banana_image_worker;

    [Inject]
    public void Construct(BananaImageWorker _banana_image_worker)
    {
        banana_image_worker = _banana_image_worker;
    }

    [Inject]
    public void Subscribe()
    {
        banana_image_worker.onBananaSummon += ToggleImage;
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

