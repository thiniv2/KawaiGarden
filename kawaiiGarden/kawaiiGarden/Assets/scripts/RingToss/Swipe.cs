using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Swipe : MonoBehaviour {

    Vector2 firstPressPos;
    Vector2 secondPressPos;
    Vector3 currentSwipe;
    [HideInInspector]
    public Rigidbody RB;

    public Transform RingReturn;

    public enum SwipeM {None, Up, Down, Left, Right};
    [HideInInspector]
    public bool Destoryer;

    public float minSwipeLenght = 200f;

    public static SwipeM swipeDir;

    public void Swipeh()
    {
        if (Input.touches.Length > 0)
        {
            Touch t = Input.GetTouch(0);
            if (t.phase == TouchPhase.Began)
                firstPressPos = new Vector2(t.position.x, t.position.y);
            if (t.phase == TouchPhase.Ended)
            {
                secondPressPos = new Vector2(t.position.x, t.position.y);
                currentSwipe = new Vector3(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y, transform.position.z);

                if (currentSwipe.magnitude < minSwipeLenght)
                {
                    swipeDir = SwipeM.None;
                    return;
                }

                currentSwipe.Normalize();

                if (currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
                {
                    transform.position += currentSwipe;
                    RB.velocity += currentSwipe * 10f;
                    RB.useGravity = true;
                    swipeDir = SwipeM.Up;
                }
                if (currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
                {
                    Debug.Log("Swipe Down");
                    swipeDir = SwipeM.Down;
                }
                if (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
                {
                    Debug.Log("Swipe Left");
                    swipeDir = SwipeM.Left;
                }
                if (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
                {
                    Debug.Log("Swipe Right");
                    swipeDir = SwipeM.Right;
                }
            }
        }
        else
            swipeDir = SwipeM.None;
            
        if (Input.GetMouseButtonDown(0))
            firstPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        if (Input.GetMouseButtonUp(0))
        {
            secondPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            currentSwipe = new Vector2(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

            if (currentSwipe.magnitude < minSwipeLenght)
            {
                swipeDir = SwipeM.None;
                return;
            }

            currentSwipe.Normalize();

            if (currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
            {
                RB.velocity += currentSwipe * 10f;
                RB.useGravity = true;
                swipeDir = SwipeM.Up;
            }
            if (currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
            {
                Debug.Log("Swipe Down");
                swipeDir = SwipeM.Down;
            }
            if (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
            {
                Debug.Log("Swipe Left");
                swipeDir = SwipeM.Left;
            }
            if (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
            {
                Debug.Log("Swipe Right");
                swipeDir = SwipeM.Right;
            }
            /*
            if(swipeDir == SwipeM.Up)
                transform.position += new Vector3(0, 1, 0);
            if (swipeDir == SwipeM.Down)
                transform.position += new Vector3(0, -1, 0);
            if(swipeDir == SwipeM.Right)
                transform.position += new Vector3(-1, 0, 0);
            if (swipeDir == SwipeM.Left)
                transform.position += new Vector3(1, 0, 0);
             */
        }
    }

	// Use this for initialization
	void Start () {

        RB = GetComponent<Rigidbody>();

        Destoryer = true;

	}
	
	// Update is called once per frame
	void Update () {
        Swipeh();
        if (Destoryer == false)
        {
            var clone = Instantiate(this, RingReturn.position, Quaternion.Euler(Vector3.zero));
            clone.name = "Ring";
            clone.gameObject.SetActive(true);
            clone.gameObject.GetComponent<Swipe>().enabled = true;
            Destoryer = true;
            Destroy(gameObject);
        }

    }
    void OnBecameInvisible()
    {

        RB.useGravity = false;

        Destoryer = false;
    }

}
