using UnityEngine;
using System.Collections;

public class SubmarineSound : MonoBehaviour {

	private bool emerged = false;

	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){

		print ("emerge");

		if(!emerged){
		
			emerged = true;

			GetComponent<AudioSource>().Play();
		
		}
	}



}
