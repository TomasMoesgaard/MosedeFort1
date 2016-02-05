using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ImageScript : MonoBehaviour {
	
	private bool startImage = false;
	private Color transparent;
	private Color nontransparent;
	float time;

	public GameObject camera;

	private ScreenClick sc;

	public List<Texture2D> tex = new List<Texture2D>();

	// Use this for initialization
	void Start () {

		sc = camera.GetComponent<ScreenClick>();

		time = 0f;
		transparent = new Color(0f,0f,0f,0f);
		nontransparent = new Color(1f,1f,1f,1f);
		//renderer.material.shader = Shader.Find("Transparent/Diffuse");
		//renderer.material.SetColor ("_Color", transparent);
	}
	
	// Update is called once per frame
	void Update () {


		if(time == 0){
			switch(sc.objectName){
			case "Calender":
				GetComponent<Renderer>().material.SetTexture ("_MainTex", tex[0]);
				break;
			case "Cannons":
				GetComponent<Renderer>().material.SetTexture ("_MainTex", tex[1]);
				break;
			case "Hat":
				GetComponent<Renderer>().material.SetTexture ("_MainTex", tex[2]);
				break;
			case "Picture":
				GetComponent<Renderer>().material.SetTexture ("_MainTex", tex[3]);
				break;
			case "Soldiers":
				GetComponent<Renderer>().material.SetTexture ("_MainTex", tex[4]);
				break;
			case "submarine":
				GetComponent<Renderer>().material.SetTexture ("_MainTex", tex[5]);
				break;
			case "warship":
				GetComponent<Renderer>().material.SetTexture ("_MainTex", tex[6]);
				break;
			case "zeppelin":
				GetComponent<Renderer>().material.SetTexture ("_MainTex", tex[7]);
				break;
			}
		}



		
	
		if(sc.Playing){
			time += Time.deltaTime;
			GetComponent<Renderer>().material.color = Color.Lerp(transparent,nontransparent,time);
		}else{
			time -= Time.deltaTime;
			GetComponent<Renderer>().material.color = Color.Lerp(transparent,nontransparent,time);
		}

		if(time < 0f){
			time = 0f;}

		if(time > 1f){
			time = 1f;}

	}
}