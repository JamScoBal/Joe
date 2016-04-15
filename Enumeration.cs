using UnityEngine;
using System.Collections;

public class Enumeration : MonoBehaviour {
	enum Pirates {Hook, BlackBeard, LongJohnSilver};
	// Use this for initialization
	void Start () {
		Pirates Pan;
		Pan = Pirates.BlackBeard;
		Pan = Enemy (Pan); 
		Debug.Log (Pan);
	}
	
	Pirates Enemy (Pirates Dumb)
		{
		if (Dumb == Pirates.Hook)
			Dumb = Pirates.BlackBeard;
		else if (Dumb == Pirates.BlackBeard)
			Dumb = Pirates.LongJohnSilver;
		else if (Dumb == Pirates.LongJohnSilver)
			Dumb = Pirates.Hook;

		return Dumb;
		}
	
	}

