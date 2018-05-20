using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlTrigger : MonoBehaviour {

    public bool Catapult = false;

    public float speed = 100f;

	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        while (col.gameObject.name.Contains("Sphere"))
        {
            Catapult = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Catapult == true)
        {
            transform.Rotate(0, speed, 0);
        }
    }
}
