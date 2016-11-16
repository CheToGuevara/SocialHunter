using UnityEngine;
using System.Collections;

public class BillBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, 3);

        GetComponent<Rigidbody>().AddForce(Vector3.up * Random.Range(500.0f, 800.0f) + new Vector3(Random.Range(-100.0f, 100.0f),0,0));
        GetComponent<Rigidbody>().AddTorque(Vector3.right * Random.Range(-800.0f, 800.0f));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
