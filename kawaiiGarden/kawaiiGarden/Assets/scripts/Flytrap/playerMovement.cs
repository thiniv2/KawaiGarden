using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
	public float speed;
	public float jumpForce;
    public GameObject winScreen;
    public GameObject player;
    public GameObject startPlatform;

	private new Rigidbody2D rigidbody2D;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
		rigidbody2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
		rigidbody2D.velocity = new Vector2(speed, rigidbody2D.velocity.y);

		if(Input.GetMouseButtonDown(0))
		{
			rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpForce);
		}

        if(!startPlatform.activeInHierarchy)
        {
            anim.SetBool("IsStarted", true);
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
          //  Debug.Log("hitted an enemy");

            winScreen.SetActive(true);

            player.SetActive(false);
        }
    }
}
