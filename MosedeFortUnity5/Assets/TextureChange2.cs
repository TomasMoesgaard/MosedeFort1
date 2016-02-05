using UnityEngine;
using System.Collections;

public class TextureChange2 : MonoBehaviour {

	public Texture tex1;
	public Texture tex2;
	

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
	
		if(speakerScript.checkPlay)
			GetComponent<Renderer>().material.mainTexture = tex2;
		else
			GetComponent<Renderer>().material.mainTexture = tex1;

	}
}
