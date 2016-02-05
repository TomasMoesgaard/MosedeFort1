using UnityEngine;
using System.Collections;

public class guyRunning : MonoBehaviour {
	bool check = false;
	// Use this for initialization
	void Start () {
		GetComponent<Animation>()["walkCycle"].wrapMode = WrapMode.Loop;
		GetComponent<Animation>()["moveSol"].wrapMode = WrapMode.Once;
		GetComponent<Animation>()["moveSol2"].wrapMode = WrapMode.Once;
		GetComponent<Animation>()["moveSol"].layer = 1;
		GetComponent<Animation>()["moveSol2"].layer = 2;
		GetComponent<Animation>().Play("moveSol");
	}
	
	// Update is called once per frame
	void Update () {

			GetComponent<Animation>().Play("walkCycle");
			if(GetComponent<Animation>()["moveSol"].enabled == false){
				GetComponent<Animation>().Play("moveSol2");
				check = true;

			}
		if(check == true){
			GetComponent<Animation>().Play("moveSol");
		}
		//else if(animation["moveSol2"].enabled == false){
			//	animation.Play("moveSol");
		//}
			//animation.Play("moveSol");
			/*var temp = transform.position;
			temp.x += 0.1f;
			temp.z += 0.1f;
			transform.position = temp;*/

	}
}
