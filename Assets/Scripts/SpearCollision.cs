using UnityEngine;
using System.Collections;

public class SpearCollision : MonoBehaviour {

    public float killTime;

    private Rigidbody2D rb;
    private PolygonCollider2D coll;

	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<PolygonCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "World")
        {
            rb.velocity = Vector2.zero;
            rb.gravityScale = 0f;
            coll.enabled = false;
            Destroy(this.gameObject, killTime);
        }

        if (collision.gameObject.tag == "Enemy")
        {
            transform.parent = collision.transform;
            rb.velocity = Vector2.zero;
            rb.gravityScale = 0f;
            coll.enabled = false;
            Destroy(this.gameObject.transform.parent.gameObject, killTime);
        }
        
    }

}
