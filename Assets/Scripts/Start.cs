using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour
{

    public Rigidbody rb;

    void Update()
    {

        if (Input.GetKeyDown("s"))

            rb.isKinematic = false;

    }


}
