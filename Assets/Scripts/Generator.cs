using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {

    public GameObject[] createPrefab;
    public Transform[] waypoints;
   

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn",3f, 0.5f);
    }

    // Update is called once per frame
    void Spawn()
    {
        
            GameObject created = (GameObject)Instantiate(createPrefab[Random.Range(0,(createPrefab.Length))],
                waypoints[Random.Range(0,(waypoints.Length))].position,
                transform.rotation);
            
        
    }
}
