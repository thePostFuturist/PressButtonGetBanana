using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class eIocIIIBananaCaller : MonoBehaviour {

    [Inject(Id="Organic")]
    Image banana;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            banana.enabled = true;
    }
}
   