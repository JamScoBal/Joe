using UnityEngine;
using System.Collections;

public class While : MonoBehaviour {
	int Pup = 10;
	// Use this for initialization
	void Start () {
		while (Pup >= 5) 
		{
			Debug.Log ("Dog");
			Pup--;
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
