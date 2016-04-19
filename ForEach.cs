using UnityEngine;
using System.Collections;

public class ForEach : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string[] Dog = new string[3];

		Dog [0] = "Rover";
		Dog [1] = "Spot";
		Dog [2] = "Princess";

		foreach (string Pup in Dog) {
			print (Pup);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
