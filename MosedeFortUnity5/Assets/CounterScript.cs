using UnityEngine;
using System.Collections;
using System.IO;

public class CounterScript : MonoBehaviour {

	public int foundEvents = 0;
	//public StreamWriter writer;
	//private float timeElapsed = 0;

	public bool allDone = false;

	// Use this for initialization
	void Start () {

	//	writer = new StreamWriter("test.txt");
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.R)) {
			Application.LoadLevel (0);
		}

		//timeElapsed += Time.deltaTime;

	/*	if(foundEvents > 7 && !audio.isPlaying && !allDone){
			allDone = true;
			audio.Play();
		}
*/
	}





//void OnDisable(){
//	writer.Close();
//}

//public	void FoundOne (string n) {
//	
//	writer.Write(timeElapsed);
//	writer.Write(", ");
//	writer.Write(n);
//	writer.WriteLine();
//
//}
}
