using UnityEngine;
using System.Collections;

public class ZeppelinerSound : MonoBehaviour {


	public bool playNow = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(playNow){
			GetComponent<AudioSource>().volume = 1;
		}else{
			GetComponent<AudioSource>().volume = 0;
		}

	}
}
