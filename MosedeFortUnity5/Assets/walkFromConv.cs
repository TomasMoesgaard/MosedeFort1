using UnityEngine;
using System.Collections;

public class walkFromConv : MonoBehaviour {

	public bool hasPlayed = false;

	public GameObject go;

	private Control control;
	// Use this for initialization
	void Start () {
		GetComponent<Animation>()["idle"].wrapMode = WrapMode.Loop;
		GetComponent<Animation>()["walkCycle"].wrapMode = WrapMode.Loop;
		GetComponent<Animation>()["moveFromConv"].wrapMode = WrapMode.Once;
		GetComponent<Animation>()["walkCycle"].layer = 1;
		GetComponent<Animation>()["moveFromConv"].layer = 2;
		GetComponent<Animation>().Play("idle");

		control = go.GetComponent<Control>();
	}
	
	// Update is called once per frame
	void Update () {

		if(control.AudioDone && !hasPlayed){
			GetComponent<Animation>().Stop("idle");
			GetComponent<Animation>().Play ("walkCycle");
			GetComponent<Animation>().Play("moveFromConv");
			hasPlayed = true;
		}
	}
}
