using UnityEngine;
using System.Collections;

public class repeatScript: MonoBehaviour {
	
	public Shader nonIllum;
	public Shader Illum;
	GameObject go;
	
	// Use this for initialization
	void Start () {

		go = gameObject;
		nonIllum = Shader.Find("Diffuse");
		Illum = Shader.Find("Self-Illumin/Diffuse");
	}
	
	// Update is called once per frame
	void Update () {
		if(tutorialScript.repeat){
			go.GetComponent<Renderer>().material.shader = Illum;
		}
		else{
			go.GetComponent<Renderer>().material.shader = nonIllum;
		}
	}
}
