using UnityEngine;
using System.Collections;

public class EControl : MonoBehaviour {

	public bool ExplicitOn = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetButtonDown("Fire1")){
			ExplicitOn = true;
		}

	}
}
