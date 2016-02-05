using UnityEngine;
using System.Collections;
using System.IO;

public class counter : MonoBehaviour {
	public int animals = 6;
	public StreamWriter writer;

	
	void OnDisable(){
        writer.Close();
    }
	
	// Use this for initialization
	void Start () {
		transform.position = new Vector3 (2f, 0.5f, 0);
		writer = new StreamWriter("test.txt");
	
	}
	
	// Update is called once per frame
public	void FoundOne (string n) {
		
		animals--;
		
		writer.Write(Time.realtimeSinceStartup);
		writer.Write(": ");
		writer.Write(n);
		writer.WriteLine();
		
		Debug.Log(animals);
		
		if(animals == 0){
			transform.position = new Vector3 (0.5f, 0.5f, 0);
		}
	}
}
