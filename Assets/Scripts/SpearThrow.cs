using UnityEngine;
using System.Collections;

public class SpearThrow : MonoBehaviour {

    public Vector2 force;

	void Start () {
        GetComponent<Rigidbody2D>().AddForce(force, ForceMode2D.Force);
	}

}
