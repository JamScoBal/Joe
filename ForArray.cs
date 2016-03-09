using UnityEngine;
using System.Collections;

public class ForArray : MonoBehaviour {
	string[] Salutations = {"So long", "Fair well", "Hasta La Vista"};
	// Use this for initialization
	void Start () {
		for (int i=0; i < Salutations.Length; i++) {
			Debug.Log(Salutations[i]);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
