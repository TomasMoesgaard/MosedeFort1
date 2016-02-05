using UnityEngine;
using System.Collections;

public class ShaderChange : MonoBehaviour {

	public Shader shader1 = Shader.Find("Diffuse");
	public Shader shader2 = Shader.Find("Bumped Specular");

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		// Toggle between Diffuse and Transparent/Diffuse shaders
		// when space key is pressed


			if (Input.GetButtonDown("Jump")) {
				if( GetComponent<Renderer>().material.shader == shader1 )
					GetComponent<Renderer>().material.shader = shader2;
				else
					GetComponent<Renderer>().material.shader = shader1;
			}



	}
}
