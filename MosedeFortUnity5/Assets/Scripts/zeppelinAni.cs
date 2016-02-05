using UnityEngine;
using System.Collections;

public class zeppelinAni : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Animation>()["zeppelin3"].wrapMode = WrapMode.Once;
		GetComponent<Animation>().Play("lastZep");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Play(){
		GetComponent<Animation>().Play("lastZep");
	}
	public void Rewind(){
		GetComponent<Animation>().Rewind("lastZep");
	}
}
