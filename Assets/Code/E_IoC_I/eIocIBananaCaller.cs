using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class eIocIBananaCaller : MonoBehaviour {

    BananaImageWorker banana_image_worker;

    [Inject]
    public void Construct(BananaImageWorker _banana_image_worker)
    {
        banana_image_worker = _banana_image_worker;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            banana_image_worker.SummonBanana();
    }
}
   