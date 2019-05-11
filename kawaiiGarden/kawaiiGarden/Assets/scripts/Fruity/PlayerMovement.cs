using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 3f;

    Touch touch;

    bool isMoving = false;

    public int[] ScoreToGive;

    Vector3 touchpos, wheretomove;

    Vector3 pos;

    public GameObject GameOverPanel;

    ScoreScript score;

    float previousDistanceToTouchPos, currentDistanceToTouchPos;

    [HideInInspector]
    public Rigidbody RB;

    // Use this for initialization
    void Start () {

        GameOverPanel.SetActive(false);

        score = FindObjectOfType<ScoreScript>();

        pos = transform.position;
        
        RB = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        if (isMoving)
            currentDistanceToTouchPos = (touchpos - transform.position).magnitude;

        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began)
            {
                previousDistanceToTouchPos = 0;
                currentDistanceToTouchPos = 0;
                isMoving = true;
                touchpos = Camera.main.ScreenToWorldPoint(touch.position);
                touchpos.z = 0;
                wheretomove = (touchpos - transform.position).normalized;
                RB.velocity = new Vector2(wheretomove.x * speed, RB.velocity.y);

            }
        }

        if(currentDistanceToTouchPos > previousDistanceToTouchPos)
        {
            isMoving = false;
            RB.velocity = Vector2.zero;
        }

        if (isMoving)
            previousDistanceToTouchPos = (touchpos - transform.position).magnitude;
        pos = new Vector3(Input.mousePosition.x, 400, 10);
        pos = Camera.main.ScreenToWorldPoint(pos);
        transform.position = Vector3.Lerp(transform.position, pos, speed * Time.deltaTime);

    }

    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag.Equals("Goodnes"))
    //    {
    //        score.AddScore(ScoreToGive[0]);
    //        Destroy(collision.gameObject);
    //    }

    //    if (collision.gameObject.tag.Equals("Badness"))
    //    {
    //        score.AddScore(ScoreToGive[1]);
    //        GameOverPanel.SetActive(true);
    //        Destroy(collision.gameObject);
    //    }
    //}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Goodnes"))
        {
            score.AddScore(ScoreToGive[0]);
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag.Equals("Badness"))
        {
            score.AddScore(ScoreToGive[1]);
            GameOverPanel.SetActive(true);
            Destroy(other.gameObject);
        }
    }

}
