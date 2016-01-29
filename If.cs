using UnityEngine;
using System.Collections;

public class If : MonoBehaviour {
	bool Hannah=true;
	// Use this for initialization
	void Start () {
		if (Hannah == false) {
			Debug.Log ("No good!");
		}
		if (Hannah == true) {
			Debug.Log ("Hurray");
		}
	}
		bool Billy()
	{
		return Hannah;
	}
	public int Stuff=5;
	public int Something=10;
	public int Items=30;
	// Update is called once per frame
	void Update () {
	if(Input.GetKeyDown(KeyCode.Space))
		{
			if(Something<Stuff || Something>Items)
			{
				Debug.Log ("Fine");
			}
			else if(Something>Items)
			{
				Debug.Log ("Go Bonkers!!");
			}
			else
			{
				Debug.Log ("All is well");
			}
		}
	}
}
