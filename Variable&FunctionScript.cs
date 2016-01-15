using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	int Tom = 5;
	void Start () {
		Tom = Jerry (Tom);
		Debug.Log (Tom);
	
	}
	

	int Jerry(int Mouse) {
		int Cat;
		Cat = Mouse - 10;
		return Cat;
	
	}
}
