using UnityEngine;
using System.Collections;

public class ScreenClick : MonoBehaviour {
	/*
	public bool Playing = false;

	private Control control;

	private GameObject go = null;

	private GameObject loader;
	
	private CutOff2 ls;

	public string objectName;

	// Use this for initialization
	void Start () {
		Screen.lockCursor = true;
		go = gameObject;

		loader = GameObject.Find("LoadingBar");
		ls = loader.GetComponent<CutOff2>();
	
	}
	    void Update() {
		Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

		
	//	if(Input.GetButtonDown("Fire1")){

		if(!Playing){


	        if (Physics.Raycast(ray, out hit)){

				objectName = hit.transform.name;

				if(hit.transform.name != go.transform.name){

				if(go.GetComponent<Control>() != null){
					control.LookedAt = false;
					control.activationTimer = 0.0f;
					ls.CutoffValue = 2;
					}
				
						go = hit.collider.gameObject;
				

			        //print("I'm looking at " + hit.transform.name);
					


					if(go.GetComponent<Control>() != null){
						control = go.GetComponent<Control>();
					}
				}
			if(go.GetComponent<Control>() != null){
				control.activationTimer += Time.deltaTime;
				ls.CutoffValue = 2 - control.activationTimer;
				

					if(ls.CutoffValue <= 0.05f){
						ls.CutoffValue = 0.05f;
					}

				control.LookedAt = true;
			}

			}

		}
		else{
			ls.CutoffValue = 2;
		}

		if(go.GetComponent<Control>() != null){
	
				Playing = control.isplaying;
			}
		}
        */
	}


