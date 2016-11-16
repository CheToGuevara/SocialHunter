using UnityEngine;
using System.Collections;

public class MenuSound : MonoBehaviour {

	// Use this for initialization
	void Start () {

        InvokeRepeating("PlaySound", 0.2f, 8);
	}
	
	// Update is called once per frame
	void PlaySound () {
        GetComponent<AudioSource>().Play();
	}
}
