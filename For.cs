using UnityEngine;
using System.Collections;

public class For : MonoBehaviour {
	int Dog = 12;
	// Use this for initialization
	void Start () {
		for (int Pound = 100; Pound > Dog; Pound--) {
			Debug.Log ("freedom" + Pound);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
