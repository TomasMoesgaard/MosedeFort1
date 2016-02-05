using UnityEngine;
using System.Collections;

public class CutOff : MonoBehaviour {
	private float newCutoffValue = 3.0f;
	private bool testKeyPressed = false;

	public static bool activated = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(speakerScript.checkPlay == false){
			if (tutorialScript.next){
				testKeyPressed = true;
			}
			if (tutorialScript.repeat){
				testKeyPressed = true;
			}
		}
			
		if (tutorialScript.next == false && tutorialScript.repeat == false){
			testKeyPressed = false;
			newCutoffValue = 3f;
		}

		if(testKeyPressed){

			if(newCutoffValue > 0.055f){
				newCutoffValue -= Time.deltaTime;
			}
			else if(newCutoffValue <= 0.055f){
				activated = true;
				newCutoffValue = 3f;
				testKeyPressed = false;
			}
			else{
				newCutoffValue = 3f;
			}
		}
		else{
			newCutoffValue = 3f;
			activated = false;
		}
		GetComponent<Renderer>().material.SetFloat("_Cutoff", newCutoffValue/3);
		GetComponent<Renderer>().material.color = Color.black;
	}
}
