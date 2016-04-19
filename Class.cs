using UnityEngine;
using System.Collections;

public class Class : MonoBehaviour {

	// Use this for initialization
	public class Jane {
		public int Bob;
		public int Billy;

		public Jane ()
		{
			Bob = 1;
			Billy = 1;
		}

		public Jane (int bo, int bil)
		{
			Bob = bo;
			Billy = bil;
		}

	}

	public Jane J = new Jane (5, 15);
	// Update is called once per frame
	void Update () {
	
	}
}
