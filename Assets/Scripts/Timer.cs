using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
    public GUIText text;
    public int time=60;
    int points = 0;
    bool end = true;
    float timepass;
	// Use this for initialization
	void Start () {
        text.pixelOffset = new Vector2(Screen.width * 0.68f, -Screen.height * 0.87f);
        DontDestroyOnLoad(transform.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
        if (end)
        {
            timepass += Time.deltaTime;
            time = Mathf.RoundToInt(20 - timepass);
            text.text = string.Format("Time: {0}", time);
            if (time == 0)
            {
                ///fin
                GameObject aux = GameObject.Find("Manager");
                points= aux.GetComponent<MouseAcction>().points;
                Application.LoadLevel("fin");
                Invoke("Final", 0.2f);
                end = false;
            }
            if (time == 6)
            {
                ///fin
                GetComponent<AudioSource>().Play();
            }
        }
        else
        {

            if (Input.GetMouseButtonDown(0))
            {
                Application.LoadLevel("Menu");
                Destroy(this.gameObject);
            }
        }
	}


    void Final()
    {
        text.pixelOffset = new Vector2(Screen.width * 0.4f, -Screen.height * 0.5f);
        text.fontSize = 80;
        text.text = string.Format( "Total points = {0}",points);
        

    }

}
