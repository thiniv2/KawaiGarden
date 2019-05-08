using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody rb;

    public GameObject GameOverScreen;

    public float ballSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.AddForce(Random.Range(-6, 6), 0, 0);
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("edge"))
        {
            //Debug.Log("hitted an edge");
            return;
        }

           // rb.AddForce(Random.Range(-6, 6), 9, 0);

          rb.AddRelativeForce(Random.Range(-5, 5), ballSpeed, 0);

        ballSpeed++;

        Debug.Log(ballSpeed);

        
    }

    private void OnBecameInvisible()
    {
        GameOverScreen.SetActive(true);

        Time.timeScale = 0f;
    }

}
