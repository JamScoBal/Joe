using UnityEngine;
using System.Collections;

public class Value : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int Jane = 5;
		int Jack = Jane;
		Jane = 15;

		Debug.Log (Jack);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
