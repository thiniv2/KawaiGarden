using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryObjects : MonoBehaviour {

    public void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
