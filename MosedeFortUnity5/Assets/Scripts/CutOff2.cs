using UnityEngine;
using System.Collections;

public class CutOff2 : MonoBehaviour {

	public float CutoffValue = 2.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		GetComponent<Renderer>().material.SetFloat("_Cutoff", (CutoffValue/2) + 0.05f);
	}
}
