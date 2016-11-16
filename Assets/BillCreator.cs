using UnityEngine;
using System.Collections;

public class BillCreator : MonoBehaviour {

    public GameObject bill;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < 20; i++)
        {
            Instantiate(bill, transform.position, transform.rotation);
        }
        Destroy(this.gameObject);
    } 
    
	
}
