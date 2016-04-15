using UnityEngine;
using System.Collections;

public class SwitchStatement : MonoBehaviour {
	public int Conversations = 3;

	// Use this for initialization
	void Start () {
		Speech ();
	}
	
	// Update is called once per frame
	void Speech () {
	switch (Conversations) {
		case 1:
			print ("Hello, it's me!");
				break;
		case 2:
			print ("So long");
			break;
		case 3:
			print ("Through the cheese!");
			break;
		default:
			print ("Put something here");
			break;
		}
	}
}
