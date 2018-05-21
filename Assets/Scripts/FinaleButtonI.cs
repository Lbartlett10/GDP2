using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinaleButtonI : MonoBehaviour {

    public bool I;
    public GameObject box;
    public AudioClip ding;

    // Use this for initialization
    void Start ()
    {
        box.SetActive(true);
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = ding;
    }

    private void OnTriggerEnter(Collider other)
    {
        box.SetActive(false);
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
