using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float speed;

    private Rigidbody2D playerRB;
    private Animator anim;
    private bool isPerson = true;

	void Start ()
    {
        playerRB = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	void FixedUpdate ()
    {
        float moveHoriz = Input.GetAxis("Horizontal") * speed;
        playerRB.transform.Translate(new Vector3(moveHoriz, 0f, 0f) * Time.deltaTime);
        if (Input.GetButtonDown("Animal"))
        {
            anim.SetBool("IsPerson", false);
            isPerson = false;
        }
        if (Input.GetButtonDown("Person"))
        {
            anim.SetBool("IsPerson", true);
            isPerson = true;
        }
	}
}
