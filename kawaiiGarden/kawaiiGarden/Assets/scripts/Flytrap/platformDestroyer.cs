﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformDestroyer : MonoBehaviour
{
	public GameObject platformDestroyPoint;

    // Start is called before the first frame update
    void Start()
    {
		platformDestroyPoint = GameObject.Find("platformDestroyPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < platformDestroyPoint.transform.position.x)
		{
			Destroy(gameObject);
		}
    }
}
