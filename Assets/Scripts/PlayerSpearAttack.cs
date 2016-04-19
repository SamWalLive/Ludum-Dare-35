using UnityEngine;
using System.Collections;

public class PlayerSpearAttack : MonoBehaviour {

    public GameObject spear;
    public Transform spawnPos;
	
	void Update ()
    {
        if (Input.GetButtonDown("Fire"))
        {
            Instantiate(spear, spawnPos.position, transform.rotation);
        }

	}
}
