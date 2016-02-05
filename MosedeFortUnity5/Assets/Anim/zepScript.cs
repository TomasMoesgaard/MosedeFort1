using UnityEngine;
using System.Collections;

public class zepScript : MonoBehaviour {

	//public GameObject o;
	//public int v = 0;
	bool isDone = false;

	public GameObject zep;
	private AudioSource aud;

	private float random = 5.0f;

	// Use this for initialization
	void Start () {
		//var pos = transform.position;
		GetComponent<Animation>()["runSol"].wrapMode = WrapMode.Loop;
		GetComponent<Animation>()["runMove"].wrapMode = WrapMode.Once;
		GetComponent<Animation>()["idleCannon"].wrapMode = WrapMode.Loop;
		GetComponent<Animation>()["idle"].wrapMode = WrapMode.Loop;
		GetComponent<Animation>()["runMove"].layer = 1;
		GetComponent<Animation>()["idleCannon"].layer = 2;
		GetComponent<Animation>()["idle"].layer = 3;
		GetComponent<Animation>().Stop("runSol");

		aud = zep.GetComponent<AudioSource>();
		//animation.Play("idle");
	}

	// Update is called once per frame
	void Update () {

		if(aud.isPlaying)
		random -= Time.deltaTime;

		if(random < 1.0f && !GetComponent<Animation>().isPlaying){
			//animation.Play("runCycle");
			//animation.Stop("idle");
			GetComponent<Animation>().Play("runMove");
			GetComponent<Animation>().Play("runSol");
			isDone = true;
			random = Random.Range(15.0f, 20.0f);
		}
		if(GetComponent<Animation>()["runMove"].enabled == false && isDone == true){
			GetComponent<Animation>().Stop("runSol");
			//animation.Play("idleCannon");
		}


	}
}
