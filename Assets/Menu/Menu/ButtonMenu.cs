using UnityEngine;
using System.Collections;

public class ButtonMenu : MonoBehaviour {

	public Color mainColor 	= 	new Color(0, 0, 0, 255);
	public bool isQuit		=	false;
	public bool isPlay		=	false;

	// Use this for initialization
	void Start () {
		GetComponent<Renderer>().material.color = mainColor;
	}
	
	// Update is called once per frame
	void Update () {

		#if UNITY_ANDROID
		BoxCollider2D coll = GetComponent<BoxCollider2D>();

		if ( coll.OverlapPoint(Input.GetTouch(0).position)){
			if (isPlay)
				Application.LoadLevel ("Game");
		}
		Debug.Log("Iphone");
		
		
		#endif
	
	}
	

	void OnMouseEnter () {
		GetComponent<Renderer>().material.color = Color.red;
	}



	void OnMouseExit () {
		GetComponent<Renderer>().material.color = mainColor;
	}
	
	void OnMouseUp () {
		//Go to assigned level
		if (isPlay)
			Application.LoadLevel ("Game");

		if(isQuit)
			Application.Quit();
	}
	

	#if UNITY_IPHONE
	BoxCollider2D coll = GetComponent<BoxCollider2D>();
	
	if ( coll.OverlapPoint(Input.GetTouch(0).position)){
		if (isPlay)
			Application.LoadLevel ("Game");
	}
	Debug.Log("Iphone");
	#endif

	


}
