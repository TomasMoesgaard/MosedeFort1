using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	private bool isPressed = true;
	public GameObject go;
	private zeppelinAni myZep;

	void Start(){
		GetComponent<Animation>()["wship"].wrapMode = WrapMode.Once;
		//zep = GameObject.Find("zeppelin");
		//zep = zeppelinAni.Instantiate();
		//go.GetComponent<zeppelinAni>();
		myZep = go.GetComponent<zeppelinAni>();
			//new zeppelinAni();

	}
	// Update is called once per frame
	void Update () {

		if(Input.GetButtonUp("Fire1") && isPressed == true){
			isPressed = false;
		}
		if(isPressed == false){
			GetComponent<Animation>().Rewind("wship");
			GetComponent<Animation>().Play("wship");
			myZep.Rewind();
			myZep.Play();
			//animation.Play(go.name);
			//animation.Rewind(go.name);
			isPressed = true;
		}
	}
}
