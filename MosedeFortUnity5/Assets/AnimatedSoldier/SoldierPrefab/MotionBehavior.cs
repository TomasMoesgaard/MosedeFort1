using UnityEngine;
using System.Collections;

public class MotionBehavior : MonoBehaviour {

	public bool Run = false;

	public bool Conversation1 = false;

	public bool Conversation2 = false;

	public bool Looking = false;

	public bool Looking2 = false;

	public bool DisableRenderers = false;

	public bool EnableRenderers = false;

	public float WaitTime = 0;

	public bool ReturnToStartPosition = false;

    public bool WaitForEventEnd = false;

    public GameObject LookTarget;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
