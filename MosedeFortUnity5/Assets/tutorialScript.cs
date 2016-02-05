using UnityEngine;
using System.Collections;

public class tutorialScript : MonoBehaviour {

	public static bool next = false;
	public static bool repeat = false;
	public static string lookingAt;
	public static GameObject go;
	public static string string1 = "book";
	public static string string2 = null;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	if(Input.GetKeyDown(KeyCode.E)){
			Application.LoadLevel("Implicit");
		}




		Ray ray = new Ray(transform.position, transform.forward);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit)){
			lookingAt = hit.transform.name;
			go = hit.collider.gameObject;
			if(hit.transform.name == string1 || hit.transform.name == string2){
					next = true;
				}
				else{
					next = false;
				}
				if(hit.transform.name == "repeat"){
					repeat = true;
				}
				else{
					repeat = false;
				}
			}
		else{
			next = false;
			repeat = false;
		}
		
	}
}
