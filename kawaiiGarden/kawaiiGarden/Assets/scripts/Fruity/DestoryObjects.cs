using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryObjects : MonoBehaviour {

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
