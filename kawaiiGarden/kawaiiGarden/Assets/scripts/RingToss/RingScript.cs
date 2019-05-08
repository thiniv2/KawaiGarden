using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingScript : MonoBehaviour {

    public int ScoreToGive;

    private bool CoroutineRunning;

    private ScoreCounter SC;

    private Swipe Sw;

	// Use this for initialization
	void Start () {
        SC = FindObjectOfType<ScoreCounter>();

        Sw = FindObjectOfType<Swipe>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Sw == null)
            Sw = FindObjectOfType<Swipe>();
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            if(Sw.RB.velocity.y <= 0 && !CoroutineRunning)
            {
                Debug.Log("collider");
                Debug.Log(gameObject.name);
                collision.transform.position = new Vector3(transform.position.x, transform.position.y + 0.25f, transform.position.z);
                SC.AddScore(ScoreToGive);
                StartCoroutine(Animation());
            }

        } 
    }
    IEnumerator Animation()
    {
        CoroutineRunning = true;
        Sw.RB.useGravity = false;
        Sw.RB.velocity = new Vector2(0.5f, -0.5f);
        yield return new WaitForSeconds(0.5f);
        Sw.RB.velocity = new Vector2(-0.5f, -0.5f);
        yield return new WaitForSeconds(0.5f);
        Sw.RB.velocity = new Vector2(-0.25f, 0.25f);
        yield return new WaitForSeconds(0.5f);
        Sw.RB.velocity = new Vector2(0.25f, 0.25f);
        yield return new WaitForSeconds(0.5f);
        Sw.Destoryer = false;
        CoroutineRunning = false;
    }
}
