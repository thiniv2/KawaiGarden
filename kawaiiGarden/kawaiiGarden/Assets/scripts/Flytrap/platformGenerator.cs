﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformGenerator : MonoBehaviour
{
	public GameObject thePlatform;
	public Transform generationPoint;
	public float distanceBetween;

	private float platformWidth;

    // Start is called before the first frame update
    void Start()
    {
		//platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;
		
	}

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < generationPoint.position.x)
		{
			transform.position = new Vector3(transform.position.x + distanceBetween, 1, transform.position.z);
			//transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween, transform.position.y, transform.position.z);

			Instantiate(thePlatform, transform.position, transform.rotation);
		}
    }
}
