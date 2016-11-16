using UnityEngine;
using System.Collections;

public class MouseAcction : MonoBehaviour {

    public GameObject billetes;
    public GUIText text;
    public int points=0;

	// Use this for initialization
	void Start () {
        this.text.pixelOffset = new Vector2(Screen.width * 0.42f, -Screen.height * 0.87f);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit info;
            if (Physics.Raycast(ray,out info,100))
            {
                //Instantiate(particle, transform.position, transform.rotation) as GameObject;
                if (info.collider.tag == "Fruit")
                {
                    Instantiate(billetes, info.point, info.collider.gameObject.transform.rotation);
                    Destroy(info.collider.gameObject);
                    GetComponent<AudioSource>().Play();
                    points += 5;
                }
            }
        }
        text.text = string.Format(" Score: {0}", points);
	}
}
