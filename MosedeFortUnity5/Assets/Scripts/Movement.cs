using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public Transform destination;
	public GameObject precursor;
	public bool trigger = false;
	public float animationTime = 100.0f;

	// Use this for initialization
	void Start () {
	
		if(precursor == null)
			trigger = true;

	}
	
	// Update is called once per frame
	void Update () {
		if(trigger){
			transform.position = Vector3.Lerp(transform.position, destination.position, animationTime);
		}
	}
}
