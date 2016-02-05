using UnityEngine;
using System.Collections;

public class nextScript : MonoBehaviour {

	public Shader nonIllum;
	public Shader Illum;
	private tutorialScript ts;

	// Use this for initialization
	void Start () {
		nonIllum = Shader.Find("Diffuse");
		Illum = Shader.Find("Self-Illumin/Diffuse");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (tutorialScript.go);
		if(tutorialScript.lookingAt == "painting" && !speakerScript.checkPlay){
			tutorialScript.go.GetComponent<Renderer>().material.shader = Illum;
		}

		if(tutorialScript.lookingAt == "book"  && !speakerScript.checkPlay){
			tutorialScript.go.GetComponent<Renderer>().material.shader = Illum;
		}
		

		if(tutorialScript.lookingAt == "cigar"  && !speakerScript.checkPlay){
			tutorialScript.go.GetComponent<Renderer>().material.shader = Illum;
		}

		if(tutorialScript.lookingAt == "Cube"){
			GetComponent<Renderer>().material.shader = nonIllum;
		}

		if(speakerScript.delete == true && tutorialScript.go.GetComponent<BoxCollider>() != null){
			Destroy(tutorialScript.go.GetComponent<BoxCollider>());
			speakerScript.delete = false;

		}
	}
}
